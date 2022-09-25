using MyLife.Additional;
using UnityEngine;

namespace MyLife.Communication
{
    public class DialogueFinder : TriggerFinder<IDialogueStarter>
    {
        
        protected override void OnTriggerEnter2D(Collider2D collider)
        {
            base.OnTriggerEnter2D(collider);
            
        }
    }
}