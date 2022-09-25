using System;
using UnityEngine;

namespace MyLife.Movement
{
    public class VelocityMovement : IMovement
    {
        private readonly Rigidbody2D _rigidbody;
        private readonly float _speed;
        
        public VelocityMovement(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            _speed = speed;
        }

        public void Move(Vector2 direction) =>
            _rigidbody.velocity = direction * _speed;

        public void Stop() =>
            _rigidbody.velocity = Vector2.zero;
    }
}