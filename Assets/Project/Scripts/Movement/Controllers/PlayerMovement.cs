using System;
using MyLife.InputSystem;
using UnityEngine;
using Zenject;

namespace MyLife.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] [Min(0)] private float _speed;

        private IMovement _movement;
        private IPlayerInputSystem _inputSystem;
        private Vector2 _direction = Vector2.zero;
        
        [Inject]
        private void Construct(IPlayerInputSystem inputSystem) =>
            _inputSystem = inputSystem;

        private void OnEnable()
        {
            _movement = new VelocityMovement(_rigidbody, _speed);
            
            _inputSystem.OnMove += SetDirection;
            _inputSystem.OnStopped += _movement.Stop;
        }

        private void OnDisable()
        { 
            _inputSystem.OnMove -= SetDirection;
            _inputSystem.OnStopped -= Stop;
        }
        
        private void FixedUpdate()
        {
            if (_direction == Vector2.zero)
                return;
            
            _movement.Move(_direction);
        }

        private void Stop()
        {
            _direction = Vector2.zero;
            _movement.Stop();
        }
        
        private void SetDirection(Vector2 direction) =>
            _direction = direction;
    }
}