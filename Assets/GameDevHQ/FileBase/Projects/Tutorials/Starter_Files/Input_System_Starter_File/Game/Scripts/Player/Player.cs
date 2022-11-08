using UnityEngine;
using Game.Scripts.LiveObjects;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 5.0f;
        [SerializeField] private float _rotSpeed = 20f;

        private bool _playerGrounded;
        private bool _canMove = true;

        private PlayerInputActions _playerInputActions;
        private CharacterController _controller;
        private Animator _anim;

        [SerializeField] private Detonator _detonator;
        [SerializeField] private CinemachineVirtualCamera _followCam;
        [SerializeField] private GameObject _model;



        void OnEnable()
        {
            // 1. Get a reference to Input Action Asset
            _playerInputActions = new PlayerInputActions();

            // 2. Enable Action Map
            _playerInputActions.Player.Enable();

            // Subscribing to delegate events
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete += ReleasePlayerControl;
            Laptop.onHackEnded += ReturnPlayerControl;
            Forklift.onDriveModeEntered += ReleasePlayerControl;
            Forklift.onDriveModeEntered += HidePlayer;
            Forklift.onDriveModeExited += ReturnPlayerControl;
            Drone.OnEnterFlightMode += ReleasePlayerControl;
            Drone.onExitFlightmode += ReturnPlayerControl;
        } 

        void Start()
        {
            _controller = GetComponent<CharacterController>();
            _playerInputActions.Player.Movement.performed += MovementPerformed;

            if (_controller == null)
                Debug.LogError("No Character Controller Present");

            _anim = GetComponentInChildren<Animator>();

            if (_anim == null)
                Debug.Log("Failed to connect the Animator");
        }

        void Update()
        {
            if (_canMove == true)
                CalculateMovement();
        }

        void CalculateMovement()
        {
            _playerGrounded = _controller.isGrounded;
            //float h = Input.GetAxisRaw("Horizontal");
            //float v = Input.GetAxisRaw("Vertical");

            // Storing the Vector ReadValues into a new variable
            Vector2 _playerInput = _playerInputActions.Player.Movement.ReadValue<Vector2>();
            // Moving player using Vector2 above on the X and Z-axis's. Using the Vector2 Y as the Z-axis
            // Allows for movement forward, backwards, left and right
            transform.Translate(new Vector3(_playerInput.x, 0, _playerInput.y) * Time.deltaTime * _moveSpeed);
            // Rotate the character using the Y-axis. 
            transform.Rotate(transform.up, _playerInput.x);

            Vector3 direction = transform.forward * _playerInput.y;
            Vector3 velocity = direction * _moveSpeed;

            _anim.SetFloat("Speed", Mathf.Abs(velocity.magnitude));

            // Jump
            if (_playerGrounded)
                velocity.y = 0f;

            if (!_playerGrounded)
            {
                velocity.y += -20f * Time.deltaTime;
            }
            
            _controller.Move(velocity * Time.deltaTime);                      
        }

        void MovementPerformed(InputAction.CallbackContext context)
        {
            Debug.Log("Moving: " + context.ReadValue<Vector2>());
        }

        void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            switch(zone.GetZoneID())
            {
                case 1: //place c4
                    _detonator.Show();
                    break;
                case 2: //Trigger Explosion
                    TriggerExplosive();
                    break;
            }
        }

        void ReleasePlayerControl()
        {
            _canMove = false;
            _followCam.Priority = 9;
        }

        void ReturnPlayerControl()
        {
            _model.SetActive(true);
            _canMove = true;
            _followCam.Priority = 10;
        }

        void HidePlayer()
        {
            _model.SetActive(false);
        }
               
        void TriggerExplosive()
        {
            _detonator.TriggerExplosion();
        }

        void OnDisable()
        {
            // Unsubscribing to delegate events
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
            Laptop.onHackComplete -= ReleasePlayerControl;
            Laptop.onHackEnded -= ReturnPlayerControl;
            Forklift.onDriveModeEntered -= ReleasePlayerControl;
            Forklift.onDriveModeEntered -= HidePlayer;
            Forklift.onDriveModeExited -= ReturnPlayerControl;
            Drone.OnEnterFlightMode -= ReleasePlayerControl;
            Drone.onExitFlightmode -= ReturnPlayerControl;
        }
    }
}

