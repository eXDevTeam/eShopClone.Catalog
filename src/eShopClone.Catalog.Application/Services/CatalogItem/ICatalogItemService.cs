using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopClone.Catalog.Application.DTOs.CatalogItem;

namespace eShopClone.Catalog.Application.Services.CatalogItem
{
    public interface ICatalogItemService : IService
    {
        Task<CatalogItemDetailsDto> GetAsync(Guid id);
        Task<IEnumerable<CatalogItemDto>> BrowsAsync();
        Task CreateAsync(Guid id, string name, string description,
                decimal price, string pictureFileName, string pictureUri,
                string catalogType, string catalogBrand, bool onReorder);
        Task UpdateAsync(Guid id, string name, string description,
                decimal price, string pictureFileName, string pictureUri,
                string catalogType, string catalogBrand, bool onReorder);
        Task RemoveAsync(Guid id);
    }
}