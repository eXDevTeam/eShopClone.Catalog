using System;
using eShopClone.Catalog.Domain.Common;

namespace eShopClone.Catalog.Domain.Entities
{
    public class CatalogItem : Entity
    {
        public string Name {get; protected set;}
        public string Description {get; protected set;}
        public decimal Price {get; protected set;}

        public string PictureFileName {get; protected set;}

        public string PictureUri {get; protected set;}

        public Guid CatalogTypeId {get; protected set;}

        public CatalogType CatalogType {get; protected set;}

        public Guid CatalogBrandId {get; protected set;}

        public CatalogBrand CatalogBrand {get; protected set;}
        public int AvailableStock {get; protected set;}

        public int RestockThreshold {get; protected set;}

        public int MaxStockThreshold {get; protected set;}

        public bool OnReorder {get; protected set;}

        protected CatalogItem() {}

        public CatalogItem(Guid id, string name, string description,
                decimal price, string pictureFileName, string pictureUri,
                CatalogType catalogType, CatalogBrand catalogBrand, bool onReorder)
            : base(id)
        {
            SetName(name);
            SetDescription(description);
            SetPrice(price);
            SetPictureFileName(pictureFileName);
            SetPictureUri(pictureUri);
            SetCatalogType(catalogType);
            SetCatalogBrand(catalogBrand);
            SetOnReorder(onReorder);
        }

        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new Exception($"Name for {this.GetType().Name} cannot be null or white space.");
            }

            if(Name == name) return;

            Name = name;
        }

        public void SetDescription(string description)
        {
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new Exception($"Description for {this.GetType().Name} cannot be null or white space.");
            }
            if(Description == description) return;

            Description = description;
        }

        public void SetPrice(decimal price)
        {
            if(price < 0)
            {
                throw new Exception($"Price for {this.GetType().Name} cannot be lower than zero.");
            }
            if(Price == price) return;

            Price = price;
        }

        public void SetPictureFileName(string pictureFileName)
        {
            if(string.IsNullOrWhiteSpace(pictureFileName))
            {
                throw new Exception($"Picture file name for {this.GetType().Name} cannot be null or white space.");
            }
            if(PictureFileName == pictureFileName) return;

            PictureFileName = pictureFileName;
        }

        public void SetPictureUri(string pictureUri)
        {
            if(!Uri.IsWellFormedUriString(pictureUri, UriKind.RelativeOrAbsolute))
            {
                throw new Exception($"Picture URI for {this.GetType().Name} is incorect.");
            }
            if(PictureUri == pictureUri) return;

            PictureUri = pictureUri;
        }
        private void SetCatalogType(CatalogType catalogType)
        {
            if(catalogType == null)
            {
                throw new Exception("Catalog type cannot be null.");
            }

            if(CatalogTypeId == catalogType.Id) return;

            CatalogTypeId = catalogType.Id;
            CatalogType = catalogType;
        }

        private void SetCatalogBrand(CatalogBrand  catalogBrand)
        {
            if(catalogBrand == null)
            {
                throw new Exception("catalog brand cannot be null.");
            }

            if(CatalogBrandId == catalogBrand.Id) return;

            CatalogBrandId = catalogBrand.Id;
            CatalogBrand = catalogBrand;
        }

        public void SetOnReorder(bool onReorder)
        {
            if(OnReorder == onReorder) return;
            OnReorder = onReorder;
        }

        public void AddStock(int quantity, bool whenQuantityIsTooHighAddMaxStock = false)
        {
            var stockAfterAdd = AvailableStock + quantity;
            if(stockAfterAdd <= MaxStockThreshold)
            {
                AvailableStock = stockAfterAdd;
            }
            else if((stockAfterAdd > MaxStockThreshold) && !whenQuantityIsTooHighAddMaxStock)
            {
                throw new Exception("You are trying to add too much.");
            }
            else 
            {
                AvailableStock = MaxStockThreshold;
            }
        }

        public void AddMaxStock()
        {
            if(AvailableStock == MaxStockThreshold) return;
            AvailableStock = MaxStockThreshold;
        }

        public void RemoveStock(int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllStock()
        {
            if(AvailableStock == 0) return;
            AvailableStock = 0;
        }

    }
}