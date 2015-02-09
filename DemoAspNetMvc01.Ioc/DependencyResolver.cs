using DemoAspNetMvc01.Data;
using DemoAspNetMvc01.Data.Repository;
using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Service.Service;
using DemoAspNetMvc01.Service.Service.Interface;
using Microsoft.Practices.Unity;

namespace DemoAspNetMvc01.Ioc
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DataContext,DataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IPostRepository, PostRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPostService, PostService>(new HierarchicalLifetimeManager());
        }
    }
}
