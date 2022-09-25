using System;
using UnityEngine;

namespace MyLife.Additional
{
    public class TriggerFinder<T> : MonoBehaviour
        where T : class
    {
        protected virtual void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out T t) == false)
                return;
        }
    }
}