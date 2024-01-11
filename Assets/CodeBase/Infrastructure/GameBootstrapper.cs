using CodeBase.Infrastructure.ServiceLocator;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            AllServices.SrvContainer.RegisterSingle<IInputServices>(new InputServices());  
        }
    }
}