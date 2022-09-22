using UnityEngine;

namespace MyLife.Moving
{
    public interface IMovement
    {
        void Move(Vector2 direction);

        void Stop();
    }
}