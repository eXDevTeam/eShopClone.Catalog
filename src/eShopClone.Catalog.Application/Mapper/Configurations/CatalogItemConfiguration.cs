using AutoMapper;
using eShopClone.Catalog.Application.DTOs.CatalogItem;
using eShopClone.Catalog.Domain.Entities;

namespace eShopClone.Catalog.Application.Mapper.Configurations
{
    public static class CatalogItemConfiguration
    {
        public static void CreateMapCatalogItem(this IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CatalogItem, CatalogItemDto>();
            cfg.CreateMap<CatalogItem, CatalogItemDetailsDto>();
        }
    }
}