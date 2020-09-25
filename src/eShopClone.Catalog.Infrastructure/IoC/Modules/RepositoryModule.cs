using System.Reflection;
using Autofac;
using eShopClone.Catalog.Domain.Repositories;

namespace eShopClone.Catalog.Infrastructure.IoC.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(RepositoryModule)
                .GetTypeInfo()
                .Assembly;
            
            builder.RegisterAssemblyTypes(assembly).Where(x => x.IsAssignableTo<IRepository>())
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();
        }
    }
}