// GENERATED AUTOMATICALLY FROM 'Assets/_PROJECT/Scripts/Input/GenericXRController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GenericXRController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GenericXRController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GenericXRController"",
    ""maps"": [
        {
            ""name"": ""RightController"",
            ""id"": ""b2ee4ce0-7cbf-490b-9a8f-21739f022c84"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""61eac9c9-d97e-4fc7-905e-61a0ddbc0bd7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1685c2cb-41f5-4045-ac74-9c06eb467a84"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c1ab1b7d-2698-42b0-8e6e-4cc3788bceb8"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa96e396-5171-497a-a2ee-5a827df69ca6"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftController"",
            ""id"": ""912baaff-9340-441e-84ba-d6dbdc562250"",
            ""actions"": [
                {
                    ""name"": ""Grip"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b63e6f03-b1ec-439e-b85e-030723199abc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1d450595-d37d-4be2-850b-d2165ce7b73d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fab151f0-4b41-4426-af9f-4cecce10e616"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0db3559e-d5ad-47a3-a140-979f274de5a6"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightController
        m_RightController = asset.FindActionMap("RightController", throwIfNotFound: true);
        m_RightController_Grip = m_RightController.FindAction("Grip", throwIfNotFound: true);
        m_RightController_Trigger = m_RightController.FindAction("Trigger", throwIfNotFound: true);
        // LeftController
        m_LeftController = asset.FindActionMap("LeftController", throwIfNotFound: true);
        m_LeftController_Grip = m_LeftController.FindAction("Grip", throwIfNotFound: true);
        m_LeftController_Trigger = m_LeftController.FindAction("Trigger", throwIfNotFound: true);
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

    // RightController
    private readonly InputActionMap m_RightController;
    private IRightControllerActions m_RightControllerActionsCallbackInterface;
    private readonly InputAction m_RightController_Grip;
    private readonly InputAction m_RightController_Trigger;
    public struct RightControllerActions
    {
        private @GenericXRController m_Wrapper;
        public RightControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_RightController_Grip;
        public InputAction @Trigger => m_Wrapper.m_RightController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_RightController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightControllerActions set) { return set.Get(); }
        public void SetCallbacks(IRightControllerActions instance)
        {
            if (m_Wrapper.m_RightControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_RightControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public RightControllerActions @RightController => new RightControllerActions(this);

    // LeftController
    private readonly InputActionMap m_LeftController;
    private ILeftControllerActions m_LeftControllerActionsCallbackInterface;
    private readonly InputAction m_LeftController_Grip;
    private readonly InputAction m_LeftController_Trigger;
    public struct LeftControllerActions
    {
        private @GenericXRController m_Wrapper;
        public LeftControllerActions(@GenericXRController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grip => m_Wrapper.m_LeftController_Grip;
        public InputAction @Trigger => m_Wrapper.m_LeftController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_LeftController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftControllerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftControllerActions instance)
        {
            if (m_Wrapper.m_LeftControllerActionsCallbackInterface != null)
            {
                @Grip.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_LeftControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public LeftControllerActions @LeftController => new LeftControllerActions(this);
    public interface IRightControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
    public interface ILeftControllerActions
    {
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
}
