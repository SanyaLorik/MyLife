using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MyLife.InputSystem
{
    public class PlayerInputSystem : MonoBehaviour, IPlayerInputSystem
    {
        public event Action<Vector2> OnMoveStarted = delegate { };
        public event Action OnMoveEnded = delegate { };

        private MyLifeInputSystem _inputSystem;

        private void Awake() =>
            _inputSystem = new MyLifeInputSystem();

        private void OnEnable()
        {
            _inputSystem.Player.Move.performed += MoveStarted;
            _inputSystem.Player.Move.canceled += MoveEnded;
            
            _inputSystem.Enable();
        }

        private void OnDisable()
        {
            _inputSystem.Player.Move.performed -= MoveStarted;
            _inputSystem.Player.Move.canceled -= MoveEnded;
            
            _inputSystem.Disable();
        }

        private void MoveStarted(InputAction.CallbackContext context) =>
            OnMoveStarted.Invoke(context.ReadValue<Vector2>());

        private void MoveEnded(InputAction.CallbackContext _) =>
            OnMoveEnded.Invoke();
    }
}