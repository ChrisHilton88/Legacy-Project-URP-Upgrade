using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

namespace Game.Scripts.LiveObjects
{
    public class Crate : MonoBehaviour
    {
        [SerializeField] private float _punchDelay;

        private int _onePiece = 1;
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
                if (context.interaction is TapInteraction && _brakeOff.Count > 0)
                {
                    BreakSinglePart();
                    StartCoroutine(PunchDelay());
                }
                else if (context.interaction is HoldInteraction && _brakeOff.Count > 0)
                {
                    BreakMultipleParts();
                    StartCoroutine(PunchDelay());
                }
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
            else if (_isReadyToBreak && _brakeOff.Count == 0)
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

        // Working correctly
        public void BreakSinglePart()
        {
            if(_brakeOff.Count < 1)
                _brakeOff.Clear();
            else
            {
                _brakeOff[_onePiece].constraints = RigidbodyConstraints.None;
                _brakeOff[_onePiece].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                _brakeOff.Remove(_brakeOff[_onePiece]);
                Debug.Log("Total pieces remaining: " + _brakeOff.Count);
            }
        }

        public void BreakMultipleParts()
        {
            _multiplePiecesRNG = Random.Range(_minRangePieces, _maxRangePieces);
            Debug.Log("Hold RNG: " + _multiplePiecesRNG);

            if(_multiplePiecesRNG > _brakeOff.Count)
            {
                _multiplePiecesRNG = _brakeOff.Count;
                Debug.Log("MultiplePiecesRNG: " + _multiplePiecesRNG);
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
                if (_brakeOff.Count < 1)
                {
                    _brakeOff.Clear();
                    return;
                }
                else
                {
                    _brakeOff[i].constraints = RigidbodyConstraints.None;
                    _brakeOff[i].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
                    _brakeOff.Remove(_brakeOff[i]);
                    Debug.Log("Total pieces remaining: " + _brakeOff.Count);
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
