using CodeBase.Infrastructure.ServiceLocator;
using UnityEngine;

namespace CodeBase.Infrastructure.AssetManagement
{
    public interface IAssetProvider : IService
    {
        T GetPrefab<T>(string prefabPath) where T : Object;
        T Instatiate<T>(string prefabPath) where T : Object;
    }
}