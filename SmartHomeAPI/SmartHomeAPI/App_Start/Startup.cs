using System.Collections.Generic;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using SmartHomeBusinessLayer.Define;
using SmartHomeBusinessLayer.Implement;
using SmartHomeDataAccessLayer.Database;
using SmartHomeDataAccessLayer.Repository.Define;
using SmartHomeDataAccessLayer.Repository.Implement;

[assembly: OwinStartup(typeof(SmartHomeAPI.App_Start.Startup))]

namespace SmartHomeAPI.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            WebApiConfig.Register(configuration);

            app.UseCors(CorsOptions.AllowAll);

            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(configuration);
        }
        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(new List<NinjectModule>
            {
                new InfrastructureDependency()
            });
            return kernel;
        }
    }
    public class InfrastructureDependency : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IEntityContext>().To<SmartHomeAPIContext>();
            Bind<IUserService>().To<UserService>();
            Bind<IHouseService>().To<HouseService>();
            Bind<IDeviceService>().To<DeviceService>();
            Bind<ICategoryService>().To<CategoryService>();
        }
    }
}
