using BUYList.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BUYList.Domain.Core.Interfaces.Services
{
    public interface IItemService
    {
        IEnumerable<Item> GetAll();
        Item GetById(Guid id);
        void Add(Item item);
        void Update(Item item);
        void Remove(Guid id);
    }
}
