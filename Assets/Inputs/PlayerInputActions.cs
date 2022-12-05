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
                    ""name"": ""InteractTap"",
                    ""type"": ""Button"",
                    ""id"": ""93b8cebd-c403-4eeb-9fe0-6055bed92199"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InteractHold"",
                    ""type"": ""Button"",
                    ""id"": ""30f051a0-1ac8-47b9-9973-4f35164a4ffe"",
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
                    ""name"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
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
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""5361e211-c9f0-4172-9b3b-2744f428501d"",
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
                    ""id"": ""5b7e3a03-997d-46c4-b9d6-604cfddd3eed"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5de634f-8648-4a39-be86-32dfb6e753f8"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5522e1cb-2120-4fc6-9431-266310513a4c"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fa97efe6-8f9d-4831-bb01-f35151ab9297"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Keyboard"",
                    ""action"": ""InteractHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6446ed7b-533f-434a-9481-73003e31c55f"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""InteractHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a9a2564-67d7-4fc9-9915-8ad03af7930f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit Cameras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc309eda-5da9-4304-b8d9-5f26a5690c4f"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit Cameras"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83d3c774-e1c9-4223-8c05-6ab8fe0b5abf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""InteractTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ee4959c-d919-4aed-827c-8d69646a0aa4"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""InteractTap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""8d4478bc-1d43-4ed7-bb19-6e4c7ee40bbc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""8363b5ec-da13-422e-a7b2-3169533c6b99"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Thrusters"",
                    ""type"": ""Button"",
                    ""id"": ""7146c86a-cbfc-4d3c-a9a1-c67ac66f70ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit Flight Mode"",
                    ""type"": ""Button"",
                    ""id"": ""ec07b6cf-a187-40e4-a62b-79f060f25449"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11211551-26d3-4b30-a587-273876a2555a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit Flight Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaee7859-29ff-4752-b0bf-ea59f7a6db89"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit Flight Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""bdde3060-4fac-4c81-902c-6534ccb56066"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrusters"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c0c860d8-40a1-4272-b0a0-105f095df6f1"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Thrusters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dee9fe2f-7a68-47b4-8c7c-32c84361df61"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Thrusters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""0d1f9dc6-fc1e-4cc9-8a0f-1628487a4f63"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrusters"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d1ce7522-ce18-4be6-87f2-8e7250ab7244"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Thrusters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4e912caa-dcea-49da-9779-408a98041aed"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Thrusters"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""a26d7414-a9dc-4200-90f9-a7f99a664755"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""777565a2-3233-4148-88bf-bd3583a60611"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7097e1b-862c-41b3-bba0-4eda4b438e00"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5fb69509-bdf4-427e-9bed-b403cddce706"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3d2e1748-b335-4154-992c-40a6e4a3a6f8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""ae708876-d955-4c4b-a246-93690efa9e79"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""548f9732-de49-4261-8804-ca55247c759b"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cd473980-2e43-4649-b2fa-48548f797a53"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""97986251-ebac-4d27-b14b-19890c118fb1"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f89380a3-964f-4acc-982b-234d8678c726"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Forklift"",
            ""id"": ""05600a73-686e-4caf-98af-8ecbcad83d4e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1d2c2831-acf0-4840-bd95-f18be88b8dcc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fork Movement"",
                    ""type"": ""Button"",
                    ""id"": ""92e19a24-5526-4b14-a4c2-138fb97ed3d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit Forklift Mode"",
                    ""type"": ""Button"",
                    ""id"": ""17a5c1fb-5eba-4c3f-ae1f-1fd448032c7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""3458f73e-f484-4209-bb6f-df8b0edbdc81"",
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
                    ""id"": ""a000e1b5-bd62-42a9-a75f-9b3dce4dc50b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8aa5f2d0-3ed9-4874-b299-89fa66b5c19c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""902c32ea-8c36-4416-ab3b-ba20679a5570"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51448c4c-33a8-4ecb-b21c-aa662da519f3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""f705abee-4fd9-4c3f-9dad-a227029d3d99"",
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
                    ""id"": ""d50228d2-a585-441a-bce2-e4c85df4d44c"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f2e6e8b0-eb79-4761-8aa1-da9139430918"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""005150a3-3884-41e0-bf45-093927843594"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4e5b7b2d-09c5-4990-9938-83f486a782bc"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a0ba0318-8bc2-400b-804e-33c5099a2bc2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Exit Forklift Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39c2a1f1-da75-4207-a886-673edffe75e1"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit Forklift Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""fa469646-d2db-4f33-ad61-c022aa7e407a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cc4c58a3-62ff-4b0e-b32d-789a4cf84a90"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8eb43eea-6e36-432b-9644-74f44e5e7866"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""93027bda-f875-4aee-8347-c0567f5eb1d8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""397a1c8f-e7cd-4cd5-acff-e920e7073e6f"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f2934803-8e7b-402a-984a-6effb3a294b3"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fork Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_InteractTap = m_Player.FindAction("InteractTap", throwIfNotFound: true);
        m_Player_InteractHold = m_Player.FindAction("InteractHold", throwIfNotFound: true);
        m_Player_ExitCameras = m_Player.FindAction("Exit Cameras", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Movement = m_Drone.FindAction("Movement", throwIfNotFound: true);
        m_Drone_Thrusters = m_Drone.FindAction("Thrusters", throwIfNotFound: true);
        m_Drone_ExitFlightMode = m_Drone.FindAction("Exit Flight Mode", throwIfNotFound: true);
        // Forklift
        m_Forklift = asset.FindActionMap("Forklift", throwIfNotFound: true);
        m_Forklift_Movement = m_Forklift.FindAction("Movement", throwIfNotFound: true);
        m_Forklift_ForkMovement = m_Forklift.FindAction("Fork Movement", throwIfNotFound: true);
        m_Forklift_ExitForkliftMode = m_Forklift.FindAction("Exit Forklift Mode", throwIfNotFound: true);
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
    private readonly InputAction m_Player_InteractTap;
    private readonly InputAction m_Player_InteractHold;
    private readonly InputAction m_Player_ExitCameras;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @InteractTap => m_Wrapper.m_Player_InteractTap;
        public InputAction @InteractHold => m_Wrapper.m_Player_InteractHold;
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
                @InteractTap.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractTap;
                @InteractTap.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractTap;
                @InteractTap.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractTap;
                @InteractHold.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractHold;
                @InteractHold.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractHold;
                @InteractHold.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractHold;
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
                @InteractTap.started += instance.OnInteractTap;
                @InteractTap.performed += instance.OnInteractTap;
                @InteractTap.canceled += instance.OnInteractTap;
                @InteractHold.started += instance.OnInteractHold;
                @InteractHold.performed += instance.OnInteractHold;
                @InteractHold.canceled += instance.OnInteractHold;
                @ExitCameras.started += instance.OnExitCameras;
                @ExitCameras.performed += instance.OnExitCameras;
                @ExitCameras.canceled += instance.OnExitCameras;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_Movement;
    private readonly InputAction m_Drone_Thrusters;
    private readonly InputAction m_Drone_ExitFlightMode;
    public struct DroneActions
    {
        private @PlayerInputActions m_Wrapper;
        public DroneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drone_Movement;
        public InputAction @Thrusters => m_Wrapper.m_Drone_Thrusters;
        public InputAction @ExitFlightMode => m_Wrapper.m_Drone_ExitFlightMode;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnMovement;
                @Thrusters.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrusters;
                @Thrusters.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrusters;
                @Thrusters.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrusters;
                @ExitFlightMode.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
                @ExitFlightMode.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
                @ExitFlightMode.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnExitFlightMode;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Thrusters.started += instance.OnThrusters;
                @Thrusters.performed += instance.OnThrusters;
                @Thrusters.canceled += instance.OnThrusters;
                @ExitFlightMode.started += instance.OnExitFlightMode;
                @ExitFlightMode.performed += instance.OnExitFlightMode;
                @ExitFlightMode.canceled += instance.OnExitFlightMode;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // Forklift
    private readonly InputActionMap m_Forklift;
    private IForkliftActions m_ForkliftActionsCallbackInterface;
    private readonly InputAction m_Forklift_Movement;
    private readonly InputAction m_Forklift_ForkMovement;
    private readonly InputAction m_Forklift_ExitForkliftMode;
    public struct ForkliftActions
    {
        private @PlayerInputActions m_Wrapper;
        public ForkliftActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Forklift_Movement;
        public InputAction @ForkMovement => m_Wrapper.m_Forklift_ForkMovement;
        public InputAction @ExitForkliftMode => m_Wrapper.m_Forklift_ExitForkliftMode;
        public InputActionMap Get() { return m_Wrapper.m_Forklift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkliftActions set) { return set.Get(); }
        public void SetCallbacks(IForkliftActions instance)
        {
            if (m_Wrapper.m_ForkliftActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnMovement;
                @ForkMovement.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnForkMovement;
                @ForkMovement.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnForkMovement;
                @ForkMovement.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnForkMovement;
                @ExitForkliftMode.started -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnExitForkliftMode;
                @ExitForkliftMode.performed -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnExitForkliftMode;
                @ExitForkliftMode.canceled -= m_Wrapper.m_ForkliftActionsCallbackInterface.OnExitForkliftMode;
            }
            m_Wrapper.m_ForkliftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ForkMovement.started += instance.OnForkMovement;
                @ForkMovement.performed += instance.OnForkMovement;
                @ForkMovement.canceled += instance.OnForkMovement;
                @ExitForkliftMode.started += instance.OnExitForkliftMode;
                @ExitForkliftMode.performed += instance.OnExitForkliftMode;
                @ExitForkliftMode.canceled += instance.OnExitForkliftMode;
            }
        }
    }
    public ForkliftActions @Forklift => new ForkliftActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteractTap(InputAction.CallbackContext context);
        void OnInteractHold(InputAction.CallbackContext context);
        void OnExitCameras(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnThrusters(InputAction.CallbackContext context);
        void OnExitFlightMode(InputAction.CallbackContext context);
    }
    public interface IForkliftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnForkMovement(InputAction.CallbackContext context);
        void OnExitForkliftMode(InputAction.CallbackContext context);
    }
}
