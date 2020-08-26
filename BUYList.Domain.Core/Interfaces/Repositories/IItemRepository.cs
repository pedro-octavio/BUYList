using BUYList.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BUYList.Domain.Core.Interfaces.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        Item GetById(Guid id);
        void Add(Item item);
        void Update(Item item);
        void Remove(Guid id);
    }
}
