// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""ea470c08-6c9c-4cc1-a49e-b8464e62bda1"",
            ""actions"": [
                {
                    ""name"": ""FlipRight"",
                    ""type"": ""Button"",
                    ""id"": ""6e1d89d1-602b-418d-a1b6-c0132e15e53d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipLeft"",
                    ""type"": ""Button"",
                    ""id"": ""660366c1-e66d-433b-a16f-48b58ce47b93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""63b43e49-a4c8-45b2-9b05-7c2ae10c2227"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26bd7181-6f6e-49e9-966c-a7db1c408568"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_FlipRight = m_Game.FindAction("FlipRight", throwIfNotFound: true);
        m_Game_FlipLeft = m_Game.FindAction("FlipLeft", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_FlipRight;
    private readonly InputAction m_Game_FlipLeft;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FlipRight => m_Wrapper.m_Game_FlipRight;
        public InputAction @FlipLeft => m_Wrapper.m_Game_FlipLeft;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @FlipRight.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipRight;
                @FlipRight.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipRight;
                @FlipRight.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipRight;
                @FlipLeft.started -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipLeft;
                @FlipLeft.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipLeft;
                @FlipLeft.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnFlipLeft;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FlipRight.started += instance.OnFlipRight;
                @FlipRight.performed += instance.OnFlipRight;
                @FlipRight.canceled += instance.OnFlipRight;
                @FlipLeft.started += instance.OnFlipLeft;
                @FlipLeft.performed += instance.OnFlipLeft;
                @FlipLeft.canceled += instance.OnFlipLeft;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameActions
    {
        void OnFlipRight(InputAction.CallbackContext context);
        void OnFlipLeft(InputAction.CallbackContext context);
    }
}
