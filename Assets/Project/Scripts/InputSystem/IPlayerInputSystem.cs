using System;
using UnityEngine;

namespace MyLife.InputSystem
{
    public interface IPlayerInputSystem
    {
        event Action<Vector2> OnMoveStarted;
        
        event Action OnMoveEnded;
    }
}