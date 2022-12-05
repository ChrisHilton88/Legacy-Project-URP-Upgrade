using System;
using UnityEngine;
using Game.Scripts.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

namespace Game.Scripts.LiveObjects
{
    public class InteractableZone : MonoBehaviour
    {
        private enum ZoneType
        {
            Collectable,
            Action,
            HoldAction
        }

        //private enum KeyState
        //{
        //    Press,
        //    PressHold
        //}

        [SerializeField] private int _zoneID;
        [SerializeField] private int _requiredID;

        public bool InZone { get; private set; }
        private bool _itemsCollected = false;
        private bool _actionPerformed = false;
        private bool _inHoldState = false;

        [SerializeField] private ZoneType _zoneType;
        //[SerializeField] private KeyCode _zoneKeyInput;
        //[SerializeField] private KeyState _keyState;

        [SerializeField] private GameObject[] _zoneItems;
        [SerializeField] private Sprite _inventoryIcon;
        [SerializeField] private GameObject _marker;
        [SerializeField] [Tooltip("Press the (---) Key to .....")] private string _displayMessage;

        private PlayerInputActions _playerInputActions;

        private static int _currentZoneID = 0;
        public static int CurrentZoneID
        {
            get
            {
                return _currentZoneID;
            }
            set
            {
                _currentZoneID = value;

            }
        }

        public static event Action<InteractableZone> onZoneInteractionComplete;
        public static event Action<int> onHoldStarted;
        public static event Action<int> onHoldEnded;

        
        void OnEnable()
        {
            onZoneInteractionComplete += SetMarker;
            _playerInputActions = new PlayerInputActions();
            _playerInputActions.Player.Enable();
        }

        void Start()
        {
            _playerInputActions.Player.InteractTap.performed += InteractTapPerformed;
            _playerInputActions.Player.InteractHold.performed += InteractHoldPerformed;
            _playerInputActions.Player.InteractHold.canceled += InteractHoldCanceled;
        }

        // Gets called when the button is released BEFORE the max tap duration
        void InteractTapPerformed(InputAction.CallbackContext context)
        {
            if (InZone)
            {
                if (_zoneType == ZoneType.Collectable)
                {
                    if (_itemsCollected == false)
                    {
                        CollectItems();
                        _itemsCollected = true;
                        UIManager.Instance.DisplayInteractableZoneMessage(false);
                    }
                }
                else if (_zoneType == ZoneType.Action)
                {
                    if (_actionPerformed == false)
                    {
                        PerformAction();
                        _actionPerformed = true;
                        UIManager.Instance.DisplayInteractableZoneMessage(false);
                    }
                }
                else
                    Debug.Log("Not an appropriate ZoneType");
            }
        }

        void InteractHoldPerformed(InputAction.CallbackContext context)
        {
            if (InZone)
            {
                if (_zoneType == ZoneType.HoldAction)
                {
                    Debug.Log("Hold performed: " + context.time);
                    _inHoldState = true;
                    PerformHoldAction();
                }
            }
        }

        void InteractHoldCanceled(InputAction.CallbackContext context)
        {
            if (InZone && _zoneType == ZoneType.HoldAction)
            {
                Debug.Log("Hold canceled: " + context.time);
                _inHoldState = false;
                onHoldEnded?.Invoke(_zoneID);
            }
        }

        // Old Input System - Input Code
        //void Update()
        //{
        //    if (_inZone == true)
        //    {
        //        if (Input.GetKeyDown(_zoneKeyInput) && _keyState != KeyState.PressHold)
        //        {
        //            switch (_zoneType)
        //            {
        //                case ZoneType.Collectable:
        //                    if (_itemsCollected == false)
        //                    {
        //                        CollectItems();
        //                        _itemsCollected = true;
        //                        UIManager.Instance.DisplayInteractableZoneMessage(false);
        //                    }
        //                    break;

        //                case ZoneType.Action:
        //                    if (_actionPerformed == false)
        //                    {
        //                        PerformAction();
        //                        _actionPerformed = true;
        //                        UIManager.Instance.DisplayInteractableZoneMessage(false);
        //                    }
        //                    break;
        //            }
        //        }
        //        else if (Input.GetKey(_zoneKeyInput) && _keyState == KeyState.PressHold && _inHoldState == false)
        //        {
        //            _inHoldState = true;

        //            switch (_zoneType)
        //            {
        //                case ZoneType.HoldAction:
        //                    PerformHoldAction();
        //                    break;
        //            }
        //        }

        //        if (Input.GetKeyUp(_zoneKeyInput) && _keyState == KeyState.PressHold)
        //        {
        //            _inHoldState = false;
        //            onHoldEnded?.Invoke(_zoneID);
        //        }


        //    }
        //}

        public void CollectItems()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(false);
            }
            UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);
            CompleteTask(_zoneID);
            onZoneInteractionComplete?.Invoke(this);
        }

        void PerformAction()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(true);
            }

            if (_inventoryIcon != null)
                UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            onZoneInteractionComplete?.Invoke(this);
        }

        void PerformHoldAction()
        {
            UIManager.Instance.DisplayInteractableZoneMessage(false);
            onHoldStarted?.Invoke(_zoneID);
        }

        public GameObject[] GetItems()
        {
            return _zoneItems;
        }

        public int GetZoneID()
        {
            return _zoneID;
        }

        public void CompleteTask(int zoneID)
        {
            if (zoneID == _zoneID)
            {
                CurrentZoneID++;
                onZoneInteractionComplete?.Invoke(this);
            }
        }

        public void ResetAction(int zoneID)
        {
            if (zoneID == _zoneID)
                _actionPerformed = false;
        }

        public void SetMarker(InteractableZone zone)
        {
            if (_zoneID == CurrentZoneID)
            {
                _marker.SetActive(true);
            }
            else
                _marker.SetActive(false);
        }

        void OnTriggerEnter(Collider other)
        {
            // 7 > 5 == true. 
            if (other.CompareTag("Player") && CurrentZoneID > _requiredID)
            {
                switch (_zoneType)
                {
                    case ZoneType.Collectable:
                        if (_itemsCollected == false)
                        {
                            InZone = true;
                            NewMethod();
                        }
                        break;

                    case ZoneType.Action:
                        if (_actionPerformed == false)
                        {
                            InZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the E key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the E key to perform action");
                        }
                        break;

                    case ZoneType.HoldAction:
                        InZone = true;
                        if (_displayMessage != null)
                        {
                            string message = $"Hold the E key to {_displayMessage}.";
                            UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                        }
                        else
                            UIManager.Instance.DisplayInteractableZoneMessage(true, $"Hold the E key to perform action");
                        break;
                }
            }
        }

        private void NewMethod()
        {
            if (_displayMessage != null)
            {
                string message = $"Press the E key to {_displayMessage}.";
                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
            }
            else
            {
                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the E key to collect");
            }
        }

        void OnTriggerExit(Collider other)
        {
            // When Player steps out of the InZone, turn off display message
            if (other.CompareTag("Player"))
            {
                InZone = false;
                UIManager.Instance.DisplayInteractableZoneMessage(false);
            }
        }

        void OnDisable()
        {
            onZoneInteractionComplete -= SetMarker;
            _playerInputActions.Player.InteractTap.performed -= InteractTapPerformed;
            _playerInputActions.Player.InteractHold.performed -= InteractHoldPerformed;
            _playerInputActions.Player.InteractHold.canceled -= InteractHoldCanceled;
            _playerInputActions.Player.Disable();
        }       
    }
}


