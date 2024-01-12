using CodeBase.Infrastructure.EntyPoint;
using CodeBase.Infrastructure.Service.GameStates;
using CodeBase.Infrastructure.ServiceLocator;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBootstrapper
    {
        public override void Bootstrap()
        {
            IGameStateSwither gameStateSwither = AllServices.SrvContainer.Single<IGameStateSwither>();
            gameStateSwither.AddState(new GameBootstrapState(gameStateSwither));
            gameStateSwither.AddState(new LoadNextLevelState(AllServices.SrvContainer.Single<ISceneLoader>()));

            gameStateSwither.EnterState<GameBootstrapState>();
        }
    }
}