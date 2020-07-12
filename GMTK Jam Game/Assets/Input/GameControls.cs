// GENERATED AUTOMATICALLY FROM 'Assets/Input/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""ZG_Main"",
            ""id"": ""968db6bd-ed6c-41d7-813a-91a5cf2f3e9b"",
            ""actions"": [
                {
                    ""name"": ""LeftHand"",
                    ""type"": ""Value"",
                    ""id"": ""9a100091-c682-4bd1-9908-c555a5b17717"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHand"",
                    ""type"": ""Value"",
                    ""id"": ""d75af4c9-17f4-4c5b-8f20-11bd4d36a9b8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftGrab"",
                    ""type"": ""Button"",
                    ""id"": ""e627cf05-d17a-433d-bf00-b1b2b960325c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightGrab"",
                    ""type"": ""Button"",
                    ""id"": ""f8f710e3-ddb3-41c4-a6c3-1d2c00d8a90c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DisableLook"",
                    ""type"": ""Button"",
                    ""id"": ""ab5dde3e-b7e7-4aa6-aaf6-0908c35584fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""a8c200fe-1eff-4b11-b376-1165a372e854"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""29c16d23-016f-4c25-8ac7-4fbb32da609e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""22d648d1-bf1c-4f07-a1ee-c23f85e29fdb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7fababdd-b08d-47bb-872d-c188460f820c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6de55c6d-be98-403a-9a27-ac20595ffd4a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3166ba5a-c109-49b2-9786-ea78a8ec9a50"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29951aa1-68cc-4b3c-aad1-476094d0a39c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""9cc98ebb-7abb-49ac-b281-6c4a19cd1d1e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""999fd8f9-b4ee-4ec6-915a-299c80604120"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7dccf3ff-a2c7-401a-b4b0-226015870bc9"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3745de86-0700-4d7e-b646-b5d2da11deec"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95bf5069-72ee-466f-bf60-036f689ffa17"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0358d9ba-121a-47f0-b354-acfdbd55f93c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d5c6dfb-dd61-4644-8f2f-8795649ca6a4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""349f5bd3-1aae-4aec-83ee-c921151240f4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b19fcaa-ccc1-4147-8949-0cb0387f1125"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94369064-4983-4da1-943e-b4fbf9ac10d7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DisableLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90cd672c-9870-41d6-b96e-22ef4e200cb5"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DisableLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""EscapeToQuit"",
            ""id"": ""1a407ab8-5a40-4971-b7f3-59694afdd6c6"",
            ""actions"": [
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""cd742cda-0afe-41e6-b1e2-b0c6cc219519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b2eb44bf-581e-4dce-b075-72494bb93fef"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ZG_Main
        m_ZG_Main = asset.FindActionMap("ZG_Main", throwIfNotFound: true);
        m_ZG_Main_LeftHand = m_ZG_Main.FindAction("LeftHand", throwIfNotFound: true);
        m_ZG_Main_RightHand = m_ZG_Main.FindAction("RightHand", throwIfNotFound: true);
        m_ZG_Main_LeftGrab = m_ZG_Main.FindAction("LeftGrab", throwIfNotFound: true);
        m_ZG_Main_RightGrab = m_ZG_Main.FindAction("RightGrab", throwIfNotFound: true);
        m_ZG_Main_DisableLook = m_ZG_Main.FindAction("DisableLook", throwIfNotFound: true);
        // EscapeToQuit
        m_EscapeToQuit = asset.FindActionMap("EscapeToQuit", throwIfNotFound: true);
        m_EscapeToQuit_Quit = m_EscapeToQuit.FindAction("Quit", throwIfNotFound: true);
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

    // ZG_Main
    private readonly InputActionMap m_ZG_Main;
    private IZG_MainActions m_ZG_MainActionsCallbackInterface;
    private readonly InputAction m_ZG_Main_LeftHand;
    private readonly InputAction m_ZG_Main_RightHand;
    private readonly InputAction m_ZG_Main_LeftGrab;
    private readonly InputAction m_ZG_Main_RightGrab;
    private readonly InputAction m_ZG_Main_DisableLook;
    public struct ZG_MainActions
    {
        private @GameControls m_Wrapper;
        public ZG_MainActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftHand => m_Wrapper.m_ZG_Main_LeftHand;
        public InputAction @RightHand => m_Wrapper.m_ZG_Main_RightHand;
        public InputAction @LeftGrab => m_Wrapper.m_ZG_Main_LeftGrab;
        public InputAction @RightGrab => m_Wrapper.m_ZG_Main_RightGrab;
        public InputAction @DisableLook => m_Wrapper.m_ZG_Main_DisableLook;
        public InputActionMap Get() { return m_Wrapper.m_ZG_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZG_MainActions set) { return set.Get(); }
        public void SetCallbacks(IZG_MainActions instance)
        {
            if (m_Wrapper.m_ZG_MainActionsCallbackInterface != null)
            {
                @LeftHand.started -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftHand;
                @LeftHand.performed -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftHand;
                @LeftHand.canceled -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftHand;
                @RightHand.started -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightHand;
                @RightHand.performed -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightHand;
                @RightHand.canceled -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightHand;
                @LeftGrab.started -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftGrab;
                @LeftGrab.performed -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftGrab;
                @LeftGrab.canceled -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnLeftGrab;
                @RightGrab.started -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightGrab;
                @RightGrab.performed -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightGrab;
                @RightGrab.canceled -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnRightGrab;
                @DisableLook.started -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnDisableLook;
                @DisableLook.performed -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnDisableLook;
                @DisableLook.canceled -= m_Wrapper.m_ZG_MainActionsCallbackInterface.OnDisableLook;
            }
            m_Wrapper.m_ZG_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftHand.started += instance.OnLeftHand;
                @LeftHand.performed += instance.OnLeftHand;
                @LeftHand.canceled += instance.OnLeftHand;
                @RightHand.started += instance.OnRightHand;
                @RightHand.performed += instance.OnRightHand;
                @RightHand.canceled += instance.OnRightHand;
                @LeftGrab.started += instance.OnLeftGrab;
                @LeftGrab.performed += instance.OnLeftGrab;
                @LeftGrab.canceled += instance.OnLeftGrab;
                @RightGrab.started += instance.OnRightGrab;
                @RightGrab.performed += instance.OnRightGrab;
                @RightGrab.canceled += instance.OnRightGrab;
                @DisableLook.started += instance.OnDisableLook;
                @DisableLook.performed += instance.OnDisableLook;
                @DisableLook.canceled += instance.OnDisableLook;
            }
        }
    }
    public ZG_MainActions @ZG_Main => new ZG_MainActions(this);

    // EscapeToQuit
    private readonly InputActionMap m_EscapeToQuit;
    private IEscapeToQuitActions m_EscapeToQuitActionsCallbackInterface;
    private readonly InputAction m_EscapeToQuit_Quit;
    public struct EscapeToQuitActions
    {
        private @GameControls m_Wrapper;
        public EscapeToQuitActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Quit => m_Wrapper.m_EscapeToQuit_Quit;
        public InputActionMap Get() { return m_Wrapper.m_EscapeToQuit; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EscapeToQuitActions set) { return set.Get(); }
        public void SetCallbacks(IEscapeToQuitActions instance)
        {
            if (m_Wrapper.m_EscapeToQuitActionsCallbackInterface != null)
            {
                @Quit.started -= m_Wrapper.m_EscapeToQuitActionsCallbackInterface.OnQuit;
                @Quit.performed -= m_Wrapper.m_EscapeToQuitActionsCallbackInterface.OnQuit;
                @Quit.canceled -= m_Wrapper.m_EscapeToQuitActionsCallbackInterface.OnQuit;
            }
            m_Wrapper.m_EscapeToQuitActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Quit.started += instance.OnQuit;
                @Quit.performed += instance.OnQuit;
                @Quit.canceled += instance.OnQuit;
            }
        }
    }
    public EscapeToQuitActions @EscapeToQuit => new EscapeToQuitActions(this);
    public interface IZG_MainActions
    {
        void OnLeftHand(InputAction.CallbackContext context);
        void OnRightHand(InputAction.CallbackContext context);
        void OnLeftGrab(InputAction.CallbackContext context);
        void OnRightGrab(InputAction.CallbackContext context);
        void OnDisableLook(InputAction.CallbackContext context);
    }
    public interface IEscapeToQuitActions
    {
        void OnQuit(InputAction.CallbackContext context);
    }
}
