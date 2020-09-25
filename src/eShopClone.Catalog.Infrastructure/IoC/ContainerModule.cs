
using Autofac;
using AutoMapper.Configuration;
using eShopClone.Catalog.Infrastructure.IoC.Modules;

namespace eShopClone.Catalog.Infrastructure.IoC
{
    public class ContainerModule : Autofac.Module
    {
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;
        public ContainerModule(Microsoft.Extensions.Configuration.IConfiguration  configuration)
            => _configuration = configuration;

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<MapperModule>();
        }
    }
}