using System.Web.Http;
using Unity;
using Unity.WebApi;
using APIService.Models;
using APIService.DataAccessRepository;

namespace APIService
{
    // public static class UnityConfig
    // {
    //     public static void RegisterComponents()
    //     {
    //var container = new UnityContainer();

    //         // register all your components with the container here
    //         // it is NOT necessary to register your controllers

    //         // e.g. container.RegisterType<ITestService, TestService>();

    //         GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
    //     }
    // }

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IDataAccessRepository<EmployeeInfo, int>, clsDataAccessRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}