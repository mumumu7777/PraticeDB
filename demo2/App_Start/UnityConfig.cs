using demo2.Models.EFModel;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace demo2
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
           container.RegisterType<PraticeDbEntities1>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}