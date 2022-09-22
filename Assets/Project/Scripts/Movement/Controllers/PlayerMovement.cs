using System;
using MyLife.InputSystem;
using UnityEngine;
using Zenject;

namespace MyLife.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private VelocityMovement _movement;

        private IPlayerInputSystem _inputSystem;
        private Vector2 _direction = Vector2.zero;
        
        [Inject]
        private void Construct(IPlayerInputSystem inputSystem) =>
            _inputSystem = inputSystem;

        private void OnEnable()
        {
            _inputSystem.OnMove += SetDirection;
            _inputSystem.OnStopped += _movement.Stop;
        }

        private void OnDisable()
        { 
            _inputSystem.OnMove -= SetDirection;
            _inputSystem.OnStopped -= _movement.Stop;
        }

        private void FixedUpdate()
        {
            if (_direction == Vector2.zero)
                return;
            
            _movement.Move(_direction);
        }

        private void SetDirection(Vector2 direction) =>
            _direction = direction;
    }
}