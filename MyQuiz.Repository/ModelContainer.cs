using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuiz.Repository
{
    public static class ModelContainer
    {
        private static IUnityContainer _Instance;

        static ModelContainer()
        {
            _Instance = new UnityContainer();
        }

        public static IUnityContainer Instance
        {
            get
            {
                _Instance.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<Logger.ILogger, Logger.Logger>(new HierarchicalLifetimeManager());
                //_Instance.RegisterType<ISecurityRepository, SecurityRepository>(new HierarchicalLifetimeManager());
                //_Instance.RegisterType<IMarketsAndNewsRepository, MarketsAndNewsRepository>(new HierarchicalLifetimeManager());
                return _Instance;
            }
        }

        public static object Resolve(Type type)
        {
            return Instance.Resolve(type);
        }

        public static TContract Resolve<TContract>()
        {
            return Resolve<TContract>(null);
        }

        public static TContract Resolve<TContract>(string key)
        {
            return Instance.Resolve<TContract>(key);
        }
    }
}
