using System;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        private float _speed = 5f, _liftSpeed = 1f;

        private bool _inDriveMode = false;

        [SerializeField] private Vector3 _liftLowerLimit, _liftUpperLimit;

        [SerializeField] private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField] private CinemachineVirtualCamera _forkliftCam;
        [SerializeField] private GameObject _driverModel;
        [SerializeField] private InteractableZone _interactableZone;

        PlayerInputActions _playerInputActions;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;



        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
            _playerInputActions.Forklift.Enable();
            _playerInputActions.Forklift.ExitForkliftMode.started += ExitForkliftModeStarted;
        }

        void ExitForkliftModeStarted(InputAction.CallbackContext context)
        {
            if (_inDriveMode)
                ExitDriveMode();
        }

        void Update()
        {
            if (_inDriveMode)
            {
                LiftControls();
                CalcutateMovement();
            }
        }

        void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode != true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _interactableZone.CompleteTask(5);
            }
        }

        void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
        }

        void CalcutateMovement()
        {
            Vector2 _playerInput = _playerInputActions.Forklift.Movement.ReadValue<Vector2>();

            //float h = Input.GetAxisRaw("Horizontal");
            //float v = Input.GetAxisRaw("Vertical");
            var direction = new Vector3(0, 0, _playerInput.y);
            var velocity = direction * _speed;

            transform.Translate(velocity * Time.deltaTime);

            if (Mathf.Abs(_playerInput.y) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
                tempRot.y += _playerInput.x * _speed / 2;
                transform.rotation = Quaternion.Euler(tempRot);
            }
        }

        // Update to NIS
        void LiftControls()
        {
            float _moveYAxis = _playerInputActions.Forklift.ForkMovement.ReadValue<float>();
            if (_moveYAxis > 0)
                LiftUpRoutine();
            else if (_moveYAxis < 0)
                LiftDownRoutine();

            //Debug.Log("Lift Controls");
            //if (Input.GetKey(KeyCode.R))
            //    LiftUpRoutine();
            //else if (Input.GetKey(KeyCode.T))
            //    LiftDownRoutine();
        }

        void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
            _playerInputActions.Forklift.ExitForkliftMode.started -= ExitForkliftModeStarted;
            _playerInputActions.Forklift.Disable();
        }
    }
}