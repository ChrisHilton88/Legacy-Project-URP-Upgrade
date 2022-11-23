using System;
using UnityEngine;
using Cinemachine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Drone : MonoBehaviour
    {
        private enum Tilt
        {
            NoTilt, Forward, Back, Left, Right
        }

        private float _speed = 5f;

        private bool _inFlightMode = false;

        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Animator _propAnim;
        [SerializeField] private CinemachineVirtualCamera _droneCam;
        [SerializeField] private InteractableZone _interactableZone;

        InputManager _inputManager;
        PlayerInputActions _playerInputActions;

        public static event Action OnEnterFlightMode;
        public static event Action onExitFlightmode;

        // I need a greater understanding of creating different instances of the PlayerInputActions class. 
        // Or should we try to be using 1 instance from the InputManager.
        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            InteractableZone.onZoneInteractionComplete += EnterFlightMode;
            _playerInputActions.Drone.Enable();
            _playerInputActions.Drone.Thrusters.performed += ThrustersPerformed;
            _playerInputActions.Drone.ExitFlightMode.started += ExitFlightModeStarted;
        }

        void ThrustersPerformed(InputAction.CallbackContext context)
        {
            if (_inFlightMode)
            {
                float value = context.ReadValue<float>();

                if (value < 0)
                {
                    Debug.Log("Test");
                    _rigidbody.AddForce(-transform.up * _speed, ForceMode.Acceleration);
                }
                else if (value > 0)
                {
                    _rigidbody.AddForce(transform.up * _speed, ForceMode.Acceleration);
                }
                else
                    return;
            }

        }

        void ExitFlightModeStarted(InputAction.CallbackContext context)
        {
            if (_inFlightMode)
            {
                Debug.Log("Exited Flight Mode");
                _inFlightMode = false;
                onExitFlightmode?.Invoke();
                ExitFlightMode();
            }
        }

        void EnterFlightMode(InteractableZone zone)
        {
            if (_inFlightMode != true && zone.GetZoneID() == 4) // drone Scene
            {
                Debug.Log("Enabled Drone Action Map");
                _propAnim.SetTrigger("StartProps");
                _droneCam.Priority = 11;
                _inFlightMode = true;
                OnEnterFlightMode?.Invoke();
                UIManager.Instance.DroneView(true);
                _interactableZone.CompleteTask(4);
            }
        }

        void ExitFlightMode()
        {            
            _droneCam.Priority = 9;
            _inFlightMode = false;
            UIManager.Instance.DroneView(false);            
        }

        void Update()
        {
            if (_inFlightMode)
            {
                CalculateTilt();
                //CalculateMovementUpdate();

                // Exit Flight Mode
                //if (Input.GetKeyDown(KeyCode.Escape))
                //{
                //    _inFlightMode = false;
                //    onExitFlightmode?.Invoke();
                //    ExitFlightMode();
                //}
            }
        }

        void FixedUpdate()
        {
            // Running at the start of the game and constantly keeping the drone on the ground
            _rigidbody.AddForce(transform.up * (9.81f), ForceMode.Acceleration);
            if (_inFlightMode)
                CalculateMovementFixedUpdate();
        }

        // Move Left and Right
        //void CalculateMovementUpdate()
        //{
            //if (Input.GetKey(KeyCode.LeftArrow))
            //{
            //    var tempRot = transform.localRotation.eulerAngles;
            //    tempRot.y -= _speed / 3;
            //    transform.localRotation = Quaternion.Euler(tempRot);
            //}
            //if (Input.GetKey(KeyCode.RightArrow))
            //{
            //    var tempRot = transform.localRotation.eulerAngles;
            //    tempRot.y += _speed / 3;
            //    transform.localRotation = Quaternion.Euler(tempRot);
            //}
        //}

        // Move Up and Down
        void CalculateMovementFixedUpdate()
        {
            Debug.Log("1D Axis value: " + _playerInputActions.Drone.Thrusters.ReadValue<float>());
            float _moveYAxis = _playerInputActions.Drone.Thrusters.ReadValue<float>();
            _rigidbody.AddForce(new Vector3(0, _moveYAxis, 0) * _speed, ForceMode.Acceleration);
        }

        // Tilt the drone
        void CalculateTilt()
        {
            Vector2 _tiltDirection = _playerInputActions.Drone.Movement.ReadValue<Vector2>();
            transform.rotation = Quaternion.Euler(_tiltDirection.y * 30f, transform.localRotation.eulerAngles.y, _tiltDirection.x * 30f);


            //if (Input.GetKey(KeyCode.A)) 
            //    transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 30);
            //else if (Input.GetKey(KeyCode.D))
            //    transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, -30);
            //else if (Input.GetKey(KeyCode.W))
            //    transform.rotation = Quaternion.Euler(30, transform.localRotation.eulerAngles.y, 0);
            //else if (Input.GetKey(KeyCode.S))
            //    transform.rotation = Quaternion.Euler(-30, transform.localRotation.eulerAngles.y, 0);
            //else 
            //    transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0);
        }

        void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterFlightMode;
        }
    }
}
