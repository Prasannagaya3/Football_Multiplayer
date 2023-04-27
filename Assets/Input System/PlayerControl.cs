//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Input System/PlayerControl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""5f420ff5-8c21-4d64-ae1a-7dad04af36dc"",
            ""actions"": [
                {
                    ""name"": ""PlayerUp"",
                    ""type"": ""Value"",
                    ""id"": ""5e247ca5-7ca6-4835-a038-9d1bea4d2a38"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerDown"",
                    ""type"": ""Value"",
                    ""id"": ""a6cb2d0d-c017-40f2-9d40-b17806186d92"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8d70a9b3-f055-4358-80cb-fb9ef42a2d25"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb1bbc3e-07c2-44f3-b699-4d966c3ed7ff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwo"",
            ""id"": ""3e588711-1a6a-431f-b131-d3fb4a076e94"",
            ""actions"": [
                {
                    ""name"": ""PlayerUp"",
                    ""type"": ""Value"",
                    ""id"": ""c79465e7-6a6b-489c-912f-9c234a22f0ee"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerDown"",
                    ""type"": ""Value"",
                    ""id"": ""6745cf25-ec3c-4eb4-a3e1-86bfc87aeab0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""455c740b-0b90-47d4-b6bb-b1459b51bcb2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3770c9f-ca74-4e6d-9395-cff1282837ea"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_PlayerUp = m_PlayerOne.FindAction("PlayerUp", throwIfNotFound: true);
        m_PlayerOne_PlayerDown = m_PlayerOne.FindAction("PlayerDown", throwIfNotFound: true);
        // PlayerTwo
        m_PlayerTwo = asset.FindActionMap("PlayerTwo", throwIfNotFound: true);
        m_PlayerTwo_PlayerUp = m_PlayerTwo.FindAction("PlayerUp", throwIfNotFound: true);
        m_PlayerTwo_PlayerDown = m_PlayerTwo.FindAction("PlayerDown", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_PlayerUp;
    private readonly InputAction m_PlayerOne_PlayerDown;
    public struct PlayerOneActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerOneActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerUp => m_Wrapper.m_PlayerOne_PlayerUp;
        public InputAction @PlayerDown => m_Wrapper.m_PlayerOne_PlayerDown;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @PlayerUp.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerUp;
                @PlayerUp.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerUp;
                @PlayerUp.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerUp;
                @PlayerDown.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerDown;
                @PlayerDown.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerDown;
                @PlayerDown.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPlayerDown;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerUp.started += instance.OnPlayerUp;
                @PlayerUp.performed += instance.OnPlayerUp;
                @PlayerUp.canceled += instance.OnPlayerUp;
                @PlayerDown.started += instance.OnPlayerDown;
                @PlayerDown.performed += instance.OnPlayerDown;
                @PlayerDown.canceled += instance.OnPlayerDown;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);

    // PlayerTwo
    private readonly InputActionMap m_PlayerTwo;
    private IPlayerTwoActions m_PlayerTwoActionsCallbackInterface;
    private readonly InputAction m_PlayerTwo_PlayerUp;
    private readonly InputAction m_PlayerTwo_PlayerDown;
    public struct PlayerTwoActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerTwoActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerUp => m_Wrapper.m_PlayerTwo_PlayerUp;
        public InputAction @PlayerDown => m_Wrapper.m_PlayerTwo_PlayerDown;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoActions instance)
        {
            if (m_Wrapper.m_PlayerTwoActionsCallbackInterface != null)
            {
                @PlayerUp.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerUp;
                @PlayerUp.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerUp;
                @PlayerUp.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerUp;
                @PlayerDown.started -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerDown;
                @PlayerDown.performed -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerDown;
                @PlayerDown.canceled -= m_Wrapper.m_PlayerTwoActionsCallbackInterface.OnPlayerDown;
            }
            m_Wrapper.m_PlayerTwoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerUp.started += instance.OnPlayerUp;
                @PlayerUp.performed += instance.OnPlayerUp;
                @PlayerUp.canceled += instance.OnPlayerUp;
                @PlayerDown.started += instance.OnPlayerDown;
                @PlayerDown.performed += instance.OnPlayerDown;
                @PlayerDown.canceled += instance.OnPlayerDown;
            }
        }
    }
    public PlayerTwoActions @PlayerTwo => new PlayerTwoActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerOneActions
    {
        void OnPlayerUp(InputAction.CallbackContext context);
        void OnPlayerDown(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoActions
    {
        void OnPlayerUp(InputAction.CallbackContext context);
        void OnPlayerDown(InputAction.CallbackContext context);
    }
}
