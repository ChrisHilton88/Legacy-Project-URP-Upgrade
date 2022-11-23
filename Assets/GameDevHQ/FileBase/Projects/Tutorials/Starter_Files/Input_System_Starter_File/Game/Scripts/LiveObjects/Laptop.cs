using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;
using UnityEngine.InputSystem;

namespace Game.Scripts.LiveObjects
{
    public class Laptop : MonoBehaviour
    {
        private int _activeCamera = 0;
        [SerializeField] private int _hackTime = 5;

        [SerializeField] private bool _hacked = false;

        [SerializeField] private Slider _progressBar;
        [SerializeField] private CinemachineVirtualCamera[] _cameras;
        [SerializeField] private InteractableZone _interactableZone;

        PlayerInputActions _playerInputActions;

        public static event Action onHackComplete;
        public static event Action onHackEnded;


        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
            InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;
            _playerInputActions.Player.SwitchCameras.started += SwitchCameras_started;
            _playerInputActions.Player.ExitCameras.started += ExitCameras_started;
        }

        void SwitchCameras_started(InputAction.CallbackContext context)
        {
            if(_hacked == true)
            {
                var previous = _activeCamera;
                _activeCamera++;

                if (_activeCamera >= _cameras.Length)
                    _activeCamera = 0;

                _cameras[_activeCamera].Priority = 11;
                _cameras[previous].Priority = 9;
            }
        }

        void ExitCameras_started(InputAction.CallbackContext context)
        {
            _hacked = false;
            onHackEnded?.Invoke();
            ResetCameras();
        }

        void ResetCameras()
        {
            foreach (var cam in _cameras)
            {
                cam.Priority = 9;
            }
        }

        void InteractableZone_onHoldStarted(int zoneID)
        {
            if (zoneID == 3 && _hacked == false) //Hacking terminal
            {
                _progressBar.gameObject.SetActive(true);
                StartCoroutine(HackingRoutine());
                onHackComplete?.Invoke();
            }
        }

        void InteractableZone_onHoldEnded(int zoneID)
        {
            if (zoneID == 3) //Hacking terminal
            {
                if (_hacked == true)
                    return;

                StopAllCoroutines();
                _progressBar.gameObject.SetActive(false);
                _progressBar.value = 0;
                onHackEnded?.Invoke();
            }
        }

        IEnumerator HackingRoutine()
        {
            while (_progressBar.value < 1)
            {
                _progressBar.value += Time.deltaTime / _hackTime;
                yield return new WaitForEndOfFrame();
            }

            //successfully hacked
            _hacked = true;
            _interactableZone.CompleteTask(3);

            //hide progress bar
            _progressBar.gameObject.SetActive(false);

            //enable Vcam1
            _cameras[0].Priority = 11;
        }
        
        void OnDisable()
        {
            InteractableZone.onHoldStarted -= InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded -= InteractableZone_onHoldEnded;
            _playerInputActions.Player.SwitchCameras.started -= SwitchCameras_started;
            _playerInputActions.Player.ExitCameras.started -= ExitCameras_started;
            _playerInputActions.Player.Disable();
        }
    }
}

