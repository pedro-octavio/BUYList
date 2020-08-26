using BUYList.Application.DTOs;
using System;
using System.Collections.Generic;

namespace BUYList.Application.Interfaces
{
    public interface IItemApplicationService
    {
        IEnumerable<ItemDTO> GetAll();
        ItemDTO GetById(Guid id);
        void Add(ItemDTO itemDTO);
        void Update(ItemDTO itemDTO);
        void Remove(Guid id);
    }
}
