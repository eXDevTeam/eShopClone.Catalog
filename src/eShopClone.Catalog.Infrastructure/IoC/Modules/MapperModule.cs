using Autofac;
using eShopClone.Catalog.Application.Mapper;

namespace eShopClone.Catalog.Infrastructure.IoC.Modules
{
    public class MapperModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(AutoMapperConfig.Initialize())
                .SingleInstance();
        }
    }
}