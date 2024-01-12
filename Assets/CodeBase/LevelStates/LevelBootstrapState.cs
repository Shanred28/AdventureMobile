using CodeBase.GamePlay.Hero;
using CodeBase.Infrastructure.AssetManagement;
using CodeBase.Infrastructure.ServiceLocator;
using CodeBase.Infrastructure.StateMachines;
using UnityEngine;

namespace CodeBase.Infrastructure.Service.LevelStates
{
    public class LevelBootstrapState : IEnterableState, IService
    {
        private IAssetProvider _assetProvider;
        private HeroSpawnPoint _heroSpawnPoint;

        public LevelBootstrapState(IAssetProvider assetProvider, HeroSpawnPoint heroSpawnPoint)
        {
            _assetProvider = assetProvider;
            _heroSpawnPoint = heroSpawnPoint;
        }

        public void Enter()
        {
            Debug.Log("LEVEL: Init");

            GameObject hero = _assetProvider.Instatiate<GameObject>(AsseetPath.HeroPath);
            hero.transform.position = _heroSpawnPoint.transform.position;
            hero.transform.rotation = _heroSpawnPoint.transform.rotation;

            FollowCamera followCamera = _assetProvider.Instatiate<FollowCamera>(AsseetPath.FollowCameraPath);
            followCamera.SetTarget(hero.transform);

            _assetProvider.Instatiate<GameObject>(AsseetPath.VirtualJoystickPath);
        }
    }
}