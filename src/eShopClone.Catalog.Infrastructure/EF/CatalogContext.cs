using eShopClone.Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace eShopClone.Catalog.Infrastructure.EF
{
    public class CatalogContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems {get; set;}
        public DbSet<CatalogBrand> CatalogBrands {get; set;}
        public DbSet<CatalogType> CatalogTypes {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
            => builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}