using System.Reflection;
using Autofac;
using eShopClone.Catalog.Application.Services;

namespace eShopClone.Catalog.Infrastructure.IoC.Modules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(IService)
                .GetTypeInfo()
                .Assembly;
            
            builder.RegisterAssemblyTypes(assembly).Where(x => x.IsAssignableTo<IService>())
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();
            
        }
    }
}