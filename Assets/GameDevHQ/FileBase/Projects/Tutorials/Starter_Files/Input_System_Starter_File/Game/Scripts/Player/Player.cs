using UnityEngine;
using Game.Scripts.LiveObjects;
using Cinemachine;

namespace Game.Scripts.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 5.0f;

        private bool _playerGrounded;
        [SerializeField] private bool _canMove = true;

        private PlayerInputActions _playerInputActions;
        private CharacterController _controller;
        private Animator _anim;

        [SerializeField] private Detonator _detonator;
        [SerializeField] private CinemachineVirtualCamera _followCam;
        [SerializeField] private GameObject _model;



        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
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

            // Check Player is enabled
            Vector2 _playerInput = _playerInputActions.Player.Movement.ReadValue<Vector2>();

            transform.Rotate(transform.up, _playerInput.x);

            Vector3 direction = transform.forward * _playerInput.y;
            Vector3 velocity = direction * _moveSpeed;

            _anim.SetFloat("Speed", Mathf.Abs(velocity.magnitude));

            // Stays on the ground
            if (_playerGrounded)
                velocity.y = 0f;

            if (!_playerGrounded)
            {
                velocity.y += -20f * Time.deltaTime;
            }

            _controller.Move(velocity * Time.deltaTime);
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

