using UnityEngine;

namespace MyLife.Movement
{
    public interface IMovement
    {
        void Move(Vector2 direction);

        void Stop();
    }
}