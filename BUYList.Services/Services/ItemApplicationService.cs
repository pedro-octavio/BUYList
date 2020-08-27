using AutoMapper;
using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using BUYList.Domain.Core.Interfaces.Services;
using BUYList.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BUYList.Application.Services
{
    public class ItemApplicationService :
    IItemApplicationService
    {
        private readonly IItemService _itemService;
        private readonly IMapper _mapper;

        public ItemApplicationService
        (IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        public IEnumerable<ItemDTO> GetAll
        (Guid userId)
        {
            try
            {
                var items = _itemService.GetAll(userId);

                return _mapper.Map<IEnumerable<ItemDTO>>(items);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public ItemDTO GetById
        (Guid id, Guid userId)
        {
            try
            {
                var item = _itemService.GetById(id, userId);

                return _mapper.Map<ItemDTO>(item);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Add
        (ItemDTO itemDTO)
        {
            try
            {
                var item = _mapper.Map<Item>(itemDTO);

                _itemService.Add(item);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Update
        (ItemDTO itemDTO)
        {
            try
            {
                var item = _mapper.Map<Item>(itemDTO);

                _itemService.Update(item);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove
        (Guid id)
        {
            try
            {
                _itemService.Remove(id);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }
    }
}
