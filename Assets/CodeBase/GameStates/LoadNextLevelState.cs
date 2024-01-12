using CodeBase.Infrastructure.ServiceLocator;
using CodeBase.Infrastructure.StateMachines;

namespace CodeBase.Infrastructure.Service.GameStates
{
    public class LoadNextLevelState : IEnterableState, IService
    {
        private ISceneLoader _sceneLoader;

        public LoadNextLevelState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load("Level_01");
        }
    }
}