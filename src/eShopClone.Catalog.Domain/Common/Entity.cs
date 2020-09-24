using System;

namespace eShopClone.Catalog.Domain.Common
{
    public abstract class Entity
    {
        public Guid Id {get; protected set;}

        protected Entity () {}

        public Entity(Guid id)
            => SetId(id);

        private void SetId(Guid id)  //Chage to DomainException
            => _= id == Guid.Empty ? throw new Exception("Id cannot be empty.") : Id = id;
    }
}