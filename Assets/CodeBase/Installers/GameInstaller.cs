using CodeBase.Infrastructure.AssetManagement;
using CodeBase.Infrastructure.EntyPoint;
using CodeBase.Infrastructure.Service.GameStates;
using CodeBase.Infrastructure.ServiceLocator;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GamesInstaller : MonoInstaller
    {
        protected override void InstallBindings()
        {
            Debug.Log("GLOBAL: Install");
            RegisterInputServices();
        }

        private void RegisterInputServices()
        {
            AllServices.SrvContainer.RegisterSingle<IGameStateSwither>(new GameStateMachine());
            AllServices.SrvContainer.RegisterSingle<IAssetProvider>(new AssetProvider());
            AllServices.SrvContainer.RegisterSingle<IInputServices>(new InputServices());
        }
    }
}