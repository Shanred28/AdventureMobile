using CodeBase.GamePlay.Hero;
using CodeBase.Infrastructure.AssetManagement;
using CodeBase.Infrastructure.EntyPoint;
using CodeBase.Infrastructure.ServiceLocator;
using System;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class LevelBootstrapper : MonoBootstrapper
    {

        private IAssetProvider _assetProvider;
        private HeroSpawnPoint _heroSpawnPoint;

        public override void Bootstrap()
        {
            Debug.Log("LEVEL: Init");

            GetServices();

            GameObject hero = _assetProvider.Instatiate<GameObject>(AsseetPath.HeroPath);
            hero.transform.position = _heroSpawnPoint.transform.position;
            hero.transform.rotation = _heroSpawnPoint.transform.rotation;

            FollowCamera followCamera = _assetProvider.Instatiate<FollowCamera>(AsseetPath.FollowCameraPath);
            followCamera.SetTarget(hero.transform);

            _assetProvider.Instatiate<GameObject>(AsseetPath.VirtualJoystickPath);     
        }

        private void GetServices()
        {
            _assetProvider = AllServices.SrvContainer.Single<IAssetProvider>();
            _heroSpawnPoint = AllServices.SrvContainer.Single<HeroSpawnPoint>();
        }
    }
}