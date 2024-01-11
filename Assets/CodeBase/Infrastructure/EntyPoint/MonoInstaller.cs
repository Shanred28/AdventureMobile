using UnityEngine;

namespace CodeBase.Infrastructure.EntyPoint
{
    public class MonoInstaller : MonoBehaviour
    {
        [SerializeField] private MonoBootstrapper _monoBootstrapper;

        private void Awake()
        {
            InstallBindings();

            _monoBootstrapper?.Bootstrap();
        }

        protected virtual void InstallBindings() { }
    }
}