using System;
using eShopClone.Catalog.Domain.Common;

namespace eShopClone.Catalog.Domain.Entities
{
    public class CatalogBrand : Entity
    {
        public string Brand {get; protected set;}

        protected CatalogBrand() {}

        public CatalogBrand(Guid id, string brand)
            : base(id)
            => SetBrand(brand);

        public void SetBrand(string brand)
        {
            if(string.IsNullOrWhiteSpace(brand))
            {
                //Chage to DomainException
                throw new Exception("Type cannot be null or white space.");
            }
            if(Brand == brand) return;

            Brand = brand;
        }

    }
}