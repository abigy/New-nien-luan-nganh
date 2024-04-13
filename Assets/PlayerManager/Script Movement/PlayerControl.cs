//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/PlayerManager/Script Movement/PlayerControl.inputactions
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

public partial class @PlayerControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""7ad28888-b73f-4358-b7be-d246cb547497"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c376a3c3-f974-4dd3-8c90-67565884cc07"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f4d61bf8-b405-4656-a061-35710508b792"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Ctrl"",
                    ""type"": ""Button"",
                    ""id"": ""0334277d-1844-47eb-a532-f75226d9034b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Input Player"",
                    ""id"": ""c27fe37f-8553-412b-95d5-eb3354752585"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6efd64c0-5ddf-47c4-90f7-82dfc61433e0"",
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
                    ""id"": ""af15961b-2e0b-4358-a744-4fe38650df63"",
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
                    ""id"": ""1679ae4d-f961-46e0-829b-2b45be0f7f68"",
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
                    ""id"": ""1ce42066-b0ca-4fb2-bb52-06318462bf3f"",
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
                    ""id"": ""7d6cd793-7564-45e9-ba47-b105e6d8041b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right stick"",
                    ""id"": ""e8e33381-c3de-4cec-9454-a13268ceea62"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8e04966c-544f-4ec9-9062-557d49e9d3e4"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""28836803-87c1-429e-831b-9c1b67e3db75"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e936fff6-4c1b-45a7-a2da-338723a0b205"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""be569b63-b538-4602-8d72-26cfc9c69cc8"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e9b7be43-3229-4549-9646-07b5fd522ae0"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ctrl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player action"",
            ""id"": ""362f1aa8-992d-4a95-b479-486854a0d3b7"",
            ""actions"": [
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""c0dad393-f4c4-4da3-9d0d-7c33d148f336"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c7408ec1-2668-4680-97bf-128536ccf51c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack_left"",
                    ""type"": ""Button"",
                    ""id"": ""a9d2d589-8801-4b88-8bc5-5eb8f2b921d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack_right"",
                    ""type"": ""Button"",
                    ""id"": ""302c3a93-1969-4ce6-a8b8-c1a2898a30ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill"",
                    ""type"": ""Button"",
                    ""id"": ""b2df83ae-c8b8-4d97-8825-4ec5d41a5415"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Storm_skill"",
                    ""type"": ""Button"",
                    ""id"": ""f6c5e310-5ed7-4141-8bae-d1b51618ff7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""flash"",
                    ""type"": ""Button"",
                    ""id"": ""69ef8876-046e-449b-9bc0-ddd5f2bcc71a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""068b9b87-331f-44f4-a0f8-3a7643ed67b7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""400fbd0a-fc2e-4b0d-b29f-e6acf9737edd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e53a675-f3d8-4c06-aedf-89becc19aa52"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72366d8d-0178-4c57-8130-2249bceb689d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack_right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7962b917-9773-450e-a061-2234587c2022"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a92eb1c-0b73-4ff1-860f-5de3d2daa030"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Storm_skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28b9b91d-ae17-43ac-b7db-6ce726397416"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""flash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        m_PlayerMovement_Ctrl = m_PlayerMovement.FindAction("Ctrl", throwIfNotFound: true);
        // Player action
        m_Playeraction = asset.FindActionMap("Player action", throwIfNotFound: true);
        m_Playeraction_B = m_Playeraction.FindAction("B", throwIfNotFound: true);
        m_Playeraction_Jump = m_Playeraction.FindAction("Jump", throwIfNotFound: true);
        m_Playeraction_Attack_left = m_Playeraction.FindAction("Attack_left", throwIfNotFound: true);
        m_Playeraction_Attack_right = m_Playeraction.FindAction("Attack_right", throwIfNotFound: true);
        m_Playeraction_Skill = m_Playeraction.FindAction("Skill", throwIfNotFound: true);
        m_Playeraction_Storm_skill = m_Playeraction.FindAction("Storm_skill", throwIfNotFound: true);
        m_Playeraction_flash = m_Playeraction.FindAction("flash", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private List<IPlayerMovementActions> m_PlayerMovementActionsCallbackInterfaces = new List<IPlayerMovementActions>();
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    private readonly InputAction m_PlayerMovement_Ctrl;
    public struct PlayerMovementActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerMovementActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputAction @Ctrl => m_Wrapper.m_PlayerMovement_Ctrl;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Ctrl.started += instance.OnCtrl;
            @Ctrl.performed += instance.OnCtrl;
            @Ctrl.canceled += instance.OnCtrl;
        }

        private void UnregisterCallbacks(IPlayerMovementActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Ctrl.started -= instance.OnCtrl;
            @Ctrl.performed -= instance.OnCtrl;
            @Ctrl.canceled -= instance.OnCtrl;
        }

        public void RemoveCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player action
    private readonly InputActionMap m_Playeraction;
    private List<IPlayeractionActions> m_PlayeractionActionsCallbackInterfaces = new List<IPlayeractionActions>();
    private readonly InputAction m_Playeraction_B;
    private readonly InputAction m_Playeraction_Jump;
    private readonly InputAction m_Playeraction_Attack_left;
    private readonly InputAction m_Playeraction_Attack_right;
    private readonly InputAction m_Playeraction_Skill;
    private readonly InputAction m_Playeraction_Storm_skill;
    private readonly InputAction m_Playeraction_flash;
    public struct PlayeractionActions
    {
        private @PlayerControl m_Wrapper;
        public PlayeractionActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @B => m_Wrapper.m_Playeraction_B;
        public InputAction @Jump => m_Wrapper.m_Playeraction_Jump;
        public InputAction @Attack_left => m_Wrapper.m_Playeraction_Attack_left;
        public InputAction @Attack_right => m_Wrapper.m_Playeraction_Attack_right;
        public InputAction @Skill => m_Wrapper.m_Playeraction_Skill;
        public InputAction @Storm_skill => m_Wrapper.m_Playeraction_Storm_skill;
        public InputAction @flash => m_Wrapper.m_Playeraction_flash;
        public InputActionMap Get() { return m_Wrapper.m_Playeraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayeractionActions set) { return set.Get(); }
        public void AddCallbacks(IPlayeractionActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayeractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayeractionActionsCallbackInterfaces.Add(instance);
            @B.started += instance.OnB;
            @B.performed += instance.OnB;
            @B.canceled += instance.OnB;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Attack_left.started += instance.OnAttack_left;
            @Attack_left.performed += instance.OnAttack_left;
            @Attack_left.canceled += instance.OnAttack_left;
            @Attack_right.started += instance.OnAttack_right;
            @Attack_right.performed += instance.OnAttack_right;
            @Attack_right.canceled += instance.OnAttack_right;
            @Skill.started += instance.OnSkill;
            @Skill.performed += instance.OnSkill;
            @Skill.canceled += instance.OnSkill;
            @Storm_skill.started += instance.OnStorm_skill;
            @Storm_skill.performed += instance.OnStorm_skill;
            @Storm_skill.canceled += instance.OnStorm_skill;
            @flash.started += instance.OnFlash;
            @flash.performed += instance.OnFlash;
            @flash.canceled += instance.OnFlash;
        }

        private void UnregisterCallbacks(IPlayeractionActions instance)
        {
            @B.started -= instance.OnB;
            @B.performed -= instance.OnB;
            @B.canceled -= instance.OnB;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Attack_left.started -= instance.OnAttack_left;
            @Attack_left.performed -= instance.OnAttack_left;
            @Attack_left.canceled -= instance.OnAttack_left;
            @Attack_right.started -= instance.OnAttack_right;
            @Attack_right.performed -= instance.OnAttack_right;
            @Attack_right.canceled -= instance.OnAttack_right;
            @Skill.started -= instance.OnSkill;
            @Skill.performed -= instance.OnSkill;
            @Skill.canceled -= instance.OnSkill;
            @Storm_skill.started -= instance.OnStorm_skill;
            @Storm_skill.performed -= instance.OnStorm_skill;
            @Storm_skill.canceled -= instance.OnStorm_skill;
            @flash.started -= instance.OnFlash;
            @flash.performed -= instance.OnFlash;
            @flash.canceled -= instance.OnFlash;
        }

        public void RemoveCallbacks(IPlayeractionActions instance)
        {
            if (m_Wrapper.m_PlayeractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayeractionActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayeractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayeractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayeractionActions @Playeraction => new PlayeractionActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnCtrl(InputAction.CallbackContext context);
    }
    public interface IPlayeractionActions
    {
        void OnB(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack_left(InputAction.CallbackContext context);
        void OnAttack_right(InputAction.CallbackContext context);
        void OnSkill(InputAction.CallbackContext context);
        void OnStorm_skill(InputAction.CallbackContext context);
        void OnFlash(InputAction.CallbackContext context);
    }
}
