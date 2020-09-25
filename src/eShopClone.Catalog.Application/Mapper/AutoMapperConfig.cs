using AutoMapper;
using eShopClone.Catalog.Application.Mapper.Configurations;

namespace eShopClone.Catalog.Application.Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMapCatalogItem();
            }).CreateMapper();
    }
}