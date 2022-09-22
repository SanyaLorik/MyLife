using System;
using UnityEngine;

namespace MyLife.Movement
{
    [Serializable]
    public class VelocityMovement : IMovement
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] [Min(0)] private float _speed;

        public void Move(Vector2 direction) =>
            _rigidbody.velocity = direction * _speed;

        public void Stop() =>
            _rigidbody.velocity = Vector2.zero;
    }
}