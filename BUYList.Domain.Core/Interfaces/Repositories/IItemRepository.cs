using BUYList.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BUYList.Domain.Core.Interfaces.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll(Guid userId);
        Item GetById(Guid id, Guid userId);
        void Add(Item item);
        void Update(Item item);
        void Remove(Guid id);
    }
}
