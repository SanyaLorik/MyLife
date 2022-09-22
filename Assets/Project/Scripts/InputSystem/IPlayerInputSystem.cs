using System;
using UnityEngine;

namespace MyLife.InputSystem
{
    public interface IPlayerInputSystem
    {
        event Action<Vector2> OnMove;
        
        event Action OnStopped;
    }
}