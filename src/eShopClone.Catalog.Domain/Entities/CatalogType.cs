using System;
using eShopClone.Catalog.Domain.Common;

namespace eShopClone.Catalog.Domain.Entities
{
    public class CatalogType : Entity
    {
        public string Type {get; protected set;}

        protected CatalogType() {}
        public CatalogType(Guid id, string type)
            : base(id)
            => SetType(type);

        public void SetType(string type)
        {
            if(string.IsNullOrWhiteSpace(type))
            {
                //Chage to DomainException
                throw new Exception("Type cannot be null or white space.");
            }
            if(Type == type) return;

            Type = type;
        }
    }
}