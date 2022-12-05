using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using Game.Scripts.UI;

namespace Game.Scripts.LiveObjects
{
    public class Crate : MonoBehaviour
    {
        [SerializeField] private float _punchDelay;

        private int elementZero = 0;
        private int _minRangePieces = 2, _maxRangePieces = 5;
        private int _multiplePiecesRNG;

        private bool _isReadyToBreak = false;

        private List<Rigidbody> _brakeOff = new List<Rigidbody>();

        [SerializeField] private GameObject _wholeCrate, _brokenCrate;
        [SerializeField] private Rigidbody[] _pieces;
        [SerializeField] private BoxCollider _crateCollider;
        [SerializeField] private InteractableZone _interactableZone;

        PlayerInputActions _playerInputActions;
        


        void OnEnable()
        {
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
            _playerInputActions.Player.Interact.performed += BreakCratePerformed;
        }

        void BreakCratePerformed(InputAction.CallbackContext context)
        {
            if (_interactableZone.InZone && _isReadyToBreak && _interactableZone.GetZoneID() == 6)
            {
                // When this is on 1, it will become 0 and call BreakSinglePart()
                if (context.interaction is TapInteraction && _brakeOff.Count > 0)
                {
                    Debug.Log("Tappity Tap");
                    // Break one piece
                    BreakSinglePart();
                    StartCoroutine(PunchDelay());
                }
                else if (context.interaction is HoldInteraction && _brakeOff.Count > 0)
                {
                    Debug.Log("Hooooolding");
                    // Break multiple pieces
                    BreakMultipleParts();
                    StartCoroutine(PunchDelay());
                }
                else
                    return;
            }
        }

        void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            if (_isReadyToBreak == false && _brakeOff.Count > 0)
            {
                _wholeCrate.SetActive(false);
                _brokenCrate.SetActive(true);
                _isReadyToBreak = true;
            }
            // This isn't getting called for multiple break parts, when the final piece is broken.
            // The crate is being busted and the marker moves forward, but the text to destroy the creat with E still stays.
            else if (_isReadyToBreak && _brakeOff.Count <= 0)
            {
                _isReadyToBreak = false;
                _crateCollider.enabled = false;
                _interactableZone.CompleteTask(6);
                Debug.Log("Completely Busted");
            }
        }

        void Start()
        {
            _brakeOff.AddRange(_pieces);
        }

        public void BreakSinglePart()
        {
            if(_brakeOff.Count > 0)
            {
                _brakeOff[elementZero].constraints = RigidbodyConstraints.None;
                _brakeOff[elementZero].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                _brakeOff.Remove(_brakeOff[elementZero]);
                Debug.Log("Total pieces remaining: " + _brakeOff.Count);
            }
            else
            {
                _brakeOff.Clear();
                Debug.Log("Zero: " + _brakeOff.Count);
            }
        }

        public void BreakMultipleParts()
        {
            _multiplePiecesRNG = Random.Range(_minRangePieces, _maxRangePieces);
            Debug.Log("Hold RNG: " + _multiplePiecesRNG);

            if(_multiplePiecesRNG > _brakeOff.Count)
            {
                _multiplePiecesRNG = _brakeOff.Count;
                Debug.Log("RNG set to breakoff count: " + _multiplePiecesRNG);
                CalculateBreakMultiplePieces(_multiplePiecesRNG);
            }
            else
            {
                CalculateBreakMultiplePieces(_multiplePiecesRNG);
            }
        }

        void CalculateBreakMultiplePieces(int pieces)
        {
            for(int i = 0; i < pieces; i++)
            {
                if (_brakeOff.Count > 0)
                {
                    _brakeOff[elementZero].constraints = RigidbodyConstraints.None;
                    _brakeOff[elementZero].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                    _brakeOff.Remove(_brakeOff[elementZero]);
                    Debug.Log("CalculateBreakMultiplePieces IF statement: " + _brakeOff.Count);

                    if (_brakeOff.Count <= 0)
                    {
                        _isReadyToBreak = false;
                        _crateCollider.enabled = false;
                        _interactableZone.CompleteTask(6);
                        _brakeOff.Clear();
                        Debug.Log("CurrentZone: " + InteractableZone.CurrentZoneID);
                        Debug.Log("Completely Busted");

                        // Add here something to turn off the display message
                        UIManager.Instance.DisplayInteractableZoneMessage(false);

                        // Display message still showing when stepping out of marker and in again, even though marker has moved forward.

                    }
                }
            }
        }

        IEnumerator PunchDelay()
        {
            float delayTimer = 0;
            while (delayTimer < _punchDelay)
            {
                yield return new WaitForEndOfFrame();
                delayTimer += Time.deltaTime;
            }

            _interactableZone.ResetAction(6);
        }

        void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
        }
    }
}
