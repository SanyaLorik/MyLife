using UnityEngine;

namespace MyLife.Moving
{
    public class VelocityMovement : MonoBehaviour, IMovement
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] [Min(0)] private float _speed;

        public void Move(Vector2 direction) =>
            _rigidbody.velocity = direction * _speed;

        public void Stop() =>
            _rigidbody.velocity = Vector2.zero;
    }
}