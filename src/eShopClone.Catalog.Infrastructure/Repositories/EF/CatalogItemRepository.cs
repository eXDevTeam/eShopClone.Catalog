using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopClone.Catalog.Domain.Entities;
using eShopClone.Catalog.Domain.Repositories;
using eShopClone.Catalog.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;

namespace eShopClone.Catalog.Infrastructure.Repositories.EF
{
    public class CatalogItemRepository : ICatalogItemRepository
    {
        private readonly CatalogContext _context;
        private readonly DbSet<CatalogItem> _catalogItems;
        public CatalogItemRepository(CatalogContext context)
        {
            _context = context;
            _catalogItems = context.Set<CatalogItem>();
        }
        public async Task<CatalogItem> GetAsync(Guid id)
            => await _catalogItems.AsNoTracking().Where(x => x.Id ==id).SingleOrDefaultAsync();

        public async Task<IEnumerable<CatalogItem>> BrowsAsync()
            => await _catalogItems.AsNoTracking().ToListAsync();
        public async Task AddAsync(CatalogItem catalogItem)
        {
            await _catalogItems.AddAsync(catalogItem);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CatalogItem catalogItem)
        {
            _catalogItems.Update(catalogItem);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(CatalogItem catalogItem)
        {
            _catalogItems.Remove(catalogItem);
            await _context.SaveChangesAsync();
        }


    }
}