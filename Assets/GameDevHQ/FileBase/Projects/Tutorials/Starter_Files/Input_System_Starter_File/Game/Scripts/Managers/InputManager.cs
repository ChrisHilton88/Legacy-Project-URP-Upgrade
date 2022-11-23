using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class InputManager : MonoBehaviour
    {
        PlayerInputActions _playerInputActions;


        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
            _playerInputActions.Forklift.Disable();
            _playerInputActions.Drone.Disable();
        }

        // Don't use Update() for input in NIS
        // Don't use wasPressedThisFrame etc as that is designed for prototyping.


        void EnablePlayerActionMap()
        {
            _playerInputActions.Player.Enable();
            _playerInputActions.Drone.Disable();
            _playerInputActions.Forklift.Disable();
        }

        void EnableForkliftActionMap()
        {
            _playerInputActions.Player.Disable();
            _playerInputActions.Forklift.Enable();
            _playerInputActions.Drone.Disable();
        }

        void EnableDroneActionMap()
        {
            _playerInputActions.Player.Disable();
            _playerInputActions.Forklift.Disable();
            _playerInputActions.Drone.Enable();
        }

        void OnDisable()
        {
            _playerInputActions.Player.Disable();
            _playerInputActions.Forklift.Disable();
            _playerInputActions.Drone.Disable();
        }
    }
}
