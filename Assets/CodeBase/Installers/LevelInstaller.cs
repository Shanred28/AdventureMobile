using CodeBase.GamePlay.Hero;
using CodeBase.Infrastructure.EntyPoint;
using CodeBase.Infrastructure.Service.LevelStates;
using CodeBase.Infrastructure.ServiceLocator;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class LevelInstaller : MonoInstaller
    {
        [SerializeField] private HeroSpawnPoint _spawnPoint;
        protected override void InstallBindings()
        {
            Debug.Log("LEVEL: Install");

            AllServices.SrvContainer.RegisterSingle<ILevelStateSwitcher>(new LevelStateMachine());
            AllServices.SrvContainer.RegisterSingle(_spawnPoint);
        }

        void OnDestroy() 
        {
            AllServices.SrvContainer.Unregister<HeroSpawnPoint>();
            AllServices.SrvContainer.Unregister<ILevelStateSwitcher>();
        }
    }
}

