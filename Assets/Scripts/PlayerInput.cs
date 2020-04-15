// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""input"",
            ""id"": ""c4cd8065-9889-46de-aedc-3b38aa8d55da"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""002457b0-1ce1-48f3-b648-19b4892a3211"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f340813a-e9ed-4334-a96b-9f7022eca413"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1d82b2aa-6953-492e-8c54-bed0566c156b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Hide"",
                    ""type"": ""Button"",
                    ""id"": ""b390714e-4978-41b1-a1b5-f547309e76dc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action2"",
                    ""type"": ""Button"",
                    ""id"": ""380cd0cc-2a8a-4dab-9d3d-81ac4c9b9aa6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""6ae43751-a8c8-4fd0-94c2-55741a20ab01"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""ff7f640d-49ef-481d-a632-6160a862fe7d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d087255-e701-4daa-b1b0-fee0ba56717f"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b726c602-26c3-4147-a7d3-db58b397bbe3"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01032644-1fdd-40a7-9479-4694766b8167"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fedf2c88-8bbb-454f-b053-92c9080e6a6b"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9504f1c-5bb2-4d63-8a26-e6d72076ceef"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d943070e-347c-45ad-9298-3b0f7fc99ab7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96f9c9d0-9693-4fcf-b529-68e49d46b336"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // input
        m_input = asset.FindActionMap("input", throwIfNotFound: true);
        m_input_Move = m_input.FindAction("Move", throwIfNotFound: true);
        m_input_Look = m_input.FindAction("Look", throwIfNotFound: true);
        m_input_Attack = m_input.FindAction("Attack", throwIfNotFound: true);
        m_input_Hide = m_input.FindAction("Hide", throwIfNotFound: true);
        m_input_Newaction2 = m_input.FindAction("New action2", throwIfNotFound: true);
        m_input_Interact = m_input.FindAction("Interact", throwIfNotFound: true);
        m_input_Throw = m_input.FindAction("Throw", throwIfNotFound: true);
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

    // input
    private readonly InputActionMap m_input;
    private IInputActions m_InputActionsCallbackInterface;
    private readonly InputAction m_input_Move;
    private readonly InputAction m_input_Look;
    private readonly InputAction m_input_Attack;
    private readonly InputAction m_input_Hide;
    private readonly InputAction m_input_Newaction2;
    private readonly InputAction m_input_Interact;
    private readonly InputAction m_input_Throw;
    public struct InputActions
    {
        private @PlayerInput m_Wrapper;
        public InputActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_input_Move;
        public InputAction @Look => m_Wrapper.m_input_Look;
        public InputAction @Attack => m_Wrapper.m_input_Attack;
        public InputAction @Hide => m_Wrapper.m_input_Hide;
        public InputAction @Newaction2 => m_Wrapper.m_input_Newaction2;
        public InputAction @Interact => m_Wrapper.m_input_Interact;
        public InputAction @Throw => m_Wrapper.m_input_Throw;
        public InputActionMap Get() { return m_Wrapper.m_input; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputActions set) { return set.Get(); }
        public void SetCallbacks(IInputActions instance)
        {
            if (m_Wrapper.m_InputActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_InputActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnAttack;
                @Hide.started -= m_Wrapper.m_InputActionsCallbackInterface.OnHide;
                @Hide.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnHide;
                @Hide.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnHide;
                @Newaction2.started -= m_Wrapper.m_InputActionsCallbackInterface.OnNewaction2;
                @Newaction2.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnNewaction2;
                @Newaction2.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnNewaction2;
                @Interact.started -= m_Wrapper.m_InputActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnInteract;
                @Throw.started -= m_Wrapper.m_InputActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_InputActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_InputActionsCallbackInterface.OnThrow;
            }
            m_Wrapper.m_InputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Hide.started += instance.OnHide;
                @Hide.performed += instance.OnHide;
                @Hide.canceled += instance.OnHide;
                @Newaction2.started += instance.OnNewaction2;
                @Newaction2.performed += instance.OnNewaction2;
                @Newaction2.canceled += instance.OnNewaction2;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
            }
        }
    }
    public InputActions @input => new InputActions(this);
    public interface IInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnHide(InputAction.CallbackContext context);
        void OnNewaction2(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
    }
}
