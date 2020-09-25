using System;

namespace eShopClone.Catalog.Application.DTOs.CatalogItem
{
    public class CatalogItemDetailsDto
    {
        public Guid Id {get; set;}
        public string Description {get; set;}
        public decimal Price {get; set;}
        public string PictureFileName {get; set;}
        public string PictureUri {get; set;}
        public string CatalogType {get; set;}
        public string CatalogBrand {get; set;}
        public int AvailableStock {get; set;}
    }
}