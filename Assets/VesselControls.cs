//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/VesselControls.inputactions
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

public partial class @VesselControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @VesselControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VesselControls"",
    ""maps"": [
        {
            ""name"": ""VesselActions"",
            ""id"": ""ccb69df1-3716-46a7-a4ff-f06ea50b51dc"",
            ""actions"": [
                {
                    ""name"": ""MovementVector"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6993ddf6-284e-403b-86d3-9205eda9bd8d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertY=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseXY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f88d21be-e22e-4299-a476-70b61b97e241"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.1,y=0.1),InvertVector2(invertX=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovementUpDownVector"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7c73b710-af48-4747-b8c4-2a686daad75e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""deb96809-1a26-4464-b539-6555e29e2ab4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2bc8a338-dd81-43dc-ac03-521d7aebaec8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""34d003f7-3997-4c2a-a871-85e55e9bc171"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d60e8b82-459f-4243-9fbc-da8b3ae8f5fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a51275d1-cb76-45b1-9d95-bde90fd59b40"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5f4c4af3-6328-4f50-8a99-af68cf00f27a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f283d210-2efa-4c22-ba1c-ca1e9e014e0b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseXY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d19ddc2-bed2-413d-96e5-72ce29585e82"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardScheme"",
                    ""action"": ""MouseXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a1a2fdda-2a1c-4b1f-a543-c94e481acd60"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardScheme"",
                    ""action"": ""MouseXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9f781f21-b247-451e-a90a-d133a17703a2"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardScheme"",
                    ""action"": ""MouseXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f1cf96f2-7947-414c-adbe-675f48dae786"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardScheme"",
                    ""action"": ""MouseXY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e3a93beb-ccd6-47cb-9086-584b60b15d77"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUpDownVector"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""12922e23-f913-4554-bb2d-c67059d43b9e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUpDownVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5a3f935f-1428-4431-acd7-85f815097c72"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUpDownVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01626294-57c5-4a34-baa5-5bf74a40fe57"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardScheme"",
            ""bindingGroup"": ""KeyboardScheme"",
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
        }
    ]
}");
        // VesselActions
        m_VesselActions = asset.FindActionMap("VesselActions", throwIfNotFound: true);
        m_VesselActions_MovementVector = m_VesselActions.FindAction("MovementVector", throwIfNotFound: true);
        m_VesselActions_MouseXY = m_VesselActions.FindAction("MouseXY", throwIfNotFound: true);
        m_VesselActions_MovementUpDownVector = m_VesselActions.FindAction("MovementUpDownVector", throwIfNotFound: true);
        m_VesselActions_Fire = m_VesselActions.FindAction("Fire", throwIfNotFound: true);
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

    // VesselActions
    private readonly InputActionMap m_VesselActions;
    private IVesselActionsActions m_VesselActionsActionsCallbackInterface;
    private readonly InputAction m_VesselActions_MovementVector;
    private readonly InputAction m_VesselActions_MouseXY;
    private readonly InputAction m_VesselActions_MovementUpDownVector;
    private readonly InputAction m_VesselActions_Fire;
    public struct VesselActionsActions
    {
        private @VesselControls m_Wrapper;
        public VesselActionsActions(@VesselControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementVector => m_Wrapper.m_VesselActions_MovementVector;
        public InputAction @MouseXY => m_Wrapper.m_VesselActions_MouseXY;
        public InputAction @MovementUpDownVector => m_Wrapper.m_VesselActions_MovementUpDownVector;
        public InputAction @Fire => m_Wrapper.m_VesselActions_Fire;
        public InputActionMap Get() { return m_Wrapper.m_VesselActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VesselActionsActions set) { return set.Get(); }
        public void SetCallbacks(IVesselActionsActions instance)
        {
            if (m_Wrapper.m_VesselActionsActionsCallbackInterface != null)
            {
                @MovementVector.started -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementVector;
                @MovementVector.performed -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementVector;
                @MovementVector.canceled -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementVector;
                @MouseXY.started -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMouseXY;
                @MouseXY.performed -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMouseXY;
                @MouseXY.canceled -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMouseXY;
                @MovementUpDownVector.started -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementUpDownVector;
                @MovementUpDownVector.performed -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementUpDownVector;
                @MovementUpDownVector.canceled -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnMovementUpDownVector;
                @Fire.started -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_VesselActionsActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_VesselActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementVector.started += instance.OnMovementVector;
                @MovementVector.performed += instance.OnMovementVector;
                @MovementVector.canceled += instance.OnMovementVector;
                @MouseXY.started += instance.OnMouseXY;
                @MouseXY.performed += instance.OnMouseXY;
                @MouseXY.canceled += instance.OnMouseXY;
                @MovementUpDownVector.started += instance.OnMovementUpDownVector;
                @MovementUpDownVector.performed += instance.OnMovementUpDownVector;
                @MovementUpDownVector.canceled += instance.OnMovementUpDownVector;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public VesselActionsActions @VesselActions => new VesselActionsActions(this);
    private int m_KeyboardSchemeSchemeIndex = -1;
    public InputControlScheme KeyboardSchemeScheme
    {
        get
        {
            if (m_KeyboardSchemeSchemeIndex == -1) m_KeyboardSchemeSchemeIndex = asset.FindControlSchemeIndex("KeyboardScheme");
            return asset.controlSchemes[m_KeyboardSchemeSchemeIndex];
        }
    }
    public interface IVesselActionsActions
    {
        void OnMovementVector(InputAction.CallbackContext context);
        void OnMouseXY(InputAction.CallbackContext context);
        void OnMovementUpDownVector(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
