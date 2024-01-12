using CodeBase.GamePlay.Hero;
using CodeBase.Infrastructure.AssetManagement;
using CodeBase.Infrastructure.EntyPoint;
using CodeBase.Infrastructure.Service.LevelStates;
using CodeBase.Infrastructure.ServiceLocator;

namespace CodeBase.Infrastructure
{
    public class LevelBootstrapper : MonoBootstrapper
    {
        public override void Bootstrap()
        {
            ILevelStateSwitcher levelStateSwitcher = AllServices.SrvContainer.Single<ILevelStateSwitcher>();

            levelStateSwitcher.AddState(new LevelBootstrapState(
                  AllServices.SrvContainer.Single<IAssetProvider>(),
                  AllServices.SrvContainer.Single<HeroSpawnPoint>()
                ));

            levelStateSwitcher.EnterState<LevelBootstrapState>();
        }
    }
}