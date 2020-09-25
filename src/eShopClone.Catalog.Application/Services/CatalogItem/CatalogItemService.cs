using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using eShopClone.Catalog.Application.DTOs.CatalogItem;
using eShopClone.Catalog.Domain.Repositories;

namespace eShopClone.Catalog.Application.Services.CatalogItem
{
    public class CatalogItemService : ICatalogItemService
    {
        private readonly ICatalogItemRepository _catalogItemRepository;
        private readonly IMapper _mapper;
        public CatalogItemService(ICatalogItemRepository catalogItemRepository, IMapper mapper)
        {
            _catalogItemRepository = catalogItemRepository;
            _mapper = mapper;
        }
        public async Task<CatalogItemDetailsDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<CatalogItemDto>> BrowsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Guid id, string name, string description, decimal price, string pictureFileName, string pictureUri, string catalogType, string catalogBrand, bool onReorder)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Guid id, string name, string description, decimal price, string pictureFileName, string pictureUri, string catalogType, string catalogBrand, bool onReorder)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}