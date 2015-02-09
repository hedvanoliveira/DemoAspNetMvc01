using DemoAspNetMvc01.Data;
using DemoAspNetMvc01.Data.Repository;
using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Service.Service;
using DemoAspNetMvc01.Service.Service.Interface;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace DemoAspNetMvc01.Web
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();
			
			// register all your components with the container here
			// it is NOT necessary to register your controllers
			
			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<DataContext, DataContext>();

			container.RegisterType<IPostRepository, PostRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IPostService, PostService>(new HierarchicalLifetimeManager());

			container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

			container.RegisterType<ICategoryRepository, CategoryRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<ICategoryService, CategoryService>(new HierarchicalLifetimeManager());
			
			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}