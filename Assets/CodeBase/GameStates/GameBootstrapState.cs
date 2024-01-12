using CodeBase.Infrastructure.ServiceLocator;
using CodeBase.Infrastructure.StateMachines;
using UnityEngine;

namespace CodeBase.Infrastructure.Service.GameStates
{
    public class GameBootstrapState : IEnterableState, IService
    {
        private IGameStateSwither _gameStateSwither;

        public GameBootstrapState(IGameStateSwither gameStateSwither)
        {
            _gameStateSwither = gameStateSwither;
        }

        public void Enter()
        {
            Debug.Log("GLOBAL: Init");
            Application.targetFrameRate = 60;
            _gameStateSwither.Enter<LoadNextLevelState>();
        }
    }
}