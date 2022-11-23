using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    // This is more like an Action Map Manager
    public class InputManager : MonoBehaviour
    {
        private PlayerInputActions _playerInputActions;


        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
            _playerInputActions.Forklift.Disable();
            _playerInputActions.Drone.Disable();

        }


        public void EnablePlayerActionMap()
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

        public void EnableDroneActionMap()
        {
            if (_playerInputActions.Player.enabled)
            {
                Debug.Log("Enabled Drone Action Map from InputManager");
                _playerInputActions.Player.Disable();
                _playerInputActions.Forklift.Disable();
                _playerInputActions.Drone.Enable();
            }
        }

        void OnDisable()
        {
            _playerInputActions.Player.Disable();
            _playerInputActions.Forklift.Disable();
            _playerInputActions.Drone.Disable();
        }
    }
}
