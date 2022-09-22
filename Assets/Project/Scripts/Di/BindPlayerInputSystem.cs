using MyLife.InputSystem;
using UnityEngine;
using Zenject;

namespace MyLife.Di
{
    public class BindPlayerInputSystem : MonoInstaller
    {
        [SerializeField] private PlayerInputSystem _inputSystem;
        
        public override void InstallBindings() =>
            Bind();

        private void Bind()
        {
            Container
                .Bind<IPlayerInputSystem>()
                .To<PlayerInputSystem>()
                .FromInstance(_inputSystem)
                .AsSingle()
                .NonLazy();
            
            /*
            Container
                .BindInterfacesTo<IPlayerInputSystem>()
                .FromInstance(_inputSystem)
                .AsSingle()
                .NonLazy();
            */
        }
    }
}