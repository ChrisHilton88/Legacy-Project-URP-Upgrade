// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""93125291-ee5b-442b-a5e6-1b6a5b5274f9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""8d104da8-4e4c-4978-b712-d41e0089ba6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Collectable"",
                    ""type"": ""Button"",
                    ""id"": ""30f051a0-1ac8-47b9-9973-4f35164a4ffe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""ffae0723-7e8f-442a-bb7f-de99bea33c1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HoldAction"",
                    ""type"": ""Button"",
                    ""id"": ""ca340f1a-8d61-4e4f-9972-e4f129c3eb04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Switch Cameras"",
                    ""type"": ""Button"",
                    ""id"": ""04a69d41-1b8d-4acc-9614-92a3d8988cb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit Cameras"",
                    ""type"": ""Button"",
                    ""id"": ""300312b2-4adf-4811-b27d-44b75c692545"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""d33722df-7d20-4a59-8017-c57ff5b589cf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b07f529e-d8ba-4f99-bbbf-dd5e6b2bcc40"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""804dc2d8-edec-4072-9da9-ba6e717a7c03"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""db1695e9-0043-43e2-94ac-6ded1886328b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8464be6e-656d-4943-8abc-db5781d1fabf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6b1bdab2-1181-42c7-a3c2-c860a10ac913"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Collectable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7ac4247-b0ef-4951-9e41-f50f3ee46428"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""736af092-367a-4776-93d4-30747d69b6a0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoldAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""242bdb1b-01fc-454c-8081-7781bb14eb30"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Cameras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a9a2564-67d7-4fc9-9915-8ad03af7930f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit Cameras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Forklift"",
            ""id"": ""05600a73-686e-4caf-98af-8ecbcad83d4e"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""Drone"",
            ""id"": ""8d4478bc-1d43-4ed7-bb19-6e4c7ee40bbc"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Collectable = m_Player.FindAction("Collectable", throwIfNotFound: true);
        m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
        m_Player_HoldAction = m_Player.FindAction("HoldAction", throwIfNotFound: true);
        m_Player_SwitchCameras = m_Player.FindAction("Switch Cameras", throwIfNotFound: true);
        m_Player_ExitCameras = m_Player.FindAction("Exit Cameras", throwIfNotFound: true);
        // Forklift
        m_Forklift = asset.FindActionMap("Forklift", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Collectable;
    private readonly InputAction m_Player_Action;
    private readonly InputAction m_Player_HoldAction;
    private readonly InputAction m_Player_SwitchCameras;
    private readonly InputAction m_Player_ExitCameras;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Collectable => m_Wrapper.m_Player_Collectable;
        public InputAction @Action => m_Wrapper.m_Player_Action;
        public InputAction @HoldAction => m_Wrapper.m_Player_HoldAction;
        public InputAction @SwitchCameras => m_Wrapper.m_Player_SwitchCameras;
        public InputAction @ExitCameras => m_Wrapper.m_Player_ExitCameras;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Collectable.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollectable;
                @Collectable.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollectable;
                @Collectable.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollectable;
                @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                @HoldAction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldAction;
                @HoldAction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldAction;
                @HoldAction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHoldAction;
                @SwitchCameras.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCameras;
                @SwitchCameras.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCameras;
                @SwitchCameras.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchCameras;
                @ExitCameras.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitCameras;
                @ExitCameras.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitCameras;
                @ExitCameras.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitCameras;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Collectable.started += instance.OnCollectable;
                @Collectable.performed += instance.OnCollectable;
                @Collectable.canceled += instance.OnCollectable;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @HoldAction.started += instance.OnHoldAction;
                @HoldAction.performed += instance.OnHoldAction;
                @HoldAction.canceled += instance.OnHoldAction;
                @SwitchCameras.started += instance.OnSwitchCameras;
                @SwitchCameras.performed += instance.OnSwitchCameras;
                @SwitchCameras.canceled += instance.OnSwitchCameras;
                @ExitCameras.started += instance.OnExitCameras;
                @ExitCameras.performed += instance.OnExitCameras;
                @ExitCameras.canceled += instance.OnExitCameras;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Forklift
    private readonly InputActionMap m_Forklift;
    private IForkliftActions m_ForkliftActionsCallbackInterface;
    public struct ForkliftActions
    {
        private @PlayerInputActions m_Wrapper;
        public ForkliftActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Forklift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkliftActions set) { return set.Get(); }
        public void SetCallbacks(IForkliftActions instance)
        {
            if (m_Wrapper.m_ForkliftActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_ForkliftActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public ForkliftActions @Forklift => new ForkliftActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    public struct DroneActions
    {
        private @PlayerInputActions m_Wrapper;
        public DroneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCollectable(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnHoldAction(InputAction.CallbackContext context);
        void OnSwitchCameras(InputAction.CallbackContext context);
        void OnExitCameras(InputAction.CallbackContext context);
    }
    public interface IForkliftActions
    {
    }
    public interface IDroneActions
    {
    }
}
