using System;
using System.Collections.Generic;

namespace CodeBase.Infrastructure.ServiceLocator
{
    public class AllServices
    {
        private static AllServices _instance;
        public static AllServices SrvContainer => _instance ?? (_instance = new AllServices());

        private readonly Dictionary<Type, IService> _services = new Dictionary<Type, IService>();

        public void RegisterSingle<TypeService>(TypeService implementation) where TypeService : class, IService
        {
            _services.Add(typeof(TypeService), implementation);
        }

        public void Unregister<TypeService>() where TypeService : class, IService
        {
            _services.Remove(typeof(TypeService));
        }

        public TypeService Single<TypeService>() where TypeService : class, IService
        { 
             if(_services.ContainsKey(typeof(TypeService)) == true)
                return _services[typeof(TypeService)] as TypeService;

             return null;
        }
    }
}