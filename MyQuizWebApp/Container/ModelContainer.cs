using Microsoft.Practices.Unity;
using MyQuiz.Services;
using System;

namespace MyQuiz.Repository
{
    public static partial class ModelContainer
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
                GetInstances();
                _Instance.RegisterType<Logger.ILogger, Logger.Logger>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<IQuizWrapper, QuizRepository>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<IQuizService, QuizService>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<ILoginService, LoginService>(new HierarchicalLifetimeManager());
                //_Instance.RegisterType<ISecurityRepository, SecurityRepository>(new HierarchicalLifetimeManager());
                //_Instance.RegisterType<IMarketsAndNewsRepository, MarketsAndNewsRepository>(new HierarchicalLifetimeManager());
                return _Instance;
            }
        }

        private static void GetInstances()
        {

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
