using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eShopClone.Catalog.Domain.Entities;

namespace eShopClone.Catalog.Domain.Repositories
{
    public interface ICatalogItemRepository : IRepository
    {
        Task<CatalogItem> GetAsync(Guid id);
        Task<IEnumerable<CatalogItem>> BrowsAsync();
        Task AddAsync(CatalogItem catalogItem);
        Task UpdateAsync(CatalogItem catalogItem);
        Task RemoveAsync(CatalogItem catalogItem);
    }
}