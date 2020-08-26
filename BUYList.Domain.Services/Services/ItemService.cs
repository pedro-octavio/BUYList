using BUYList.Domain.Core.Interfaces.Repositories;
using BUYList.Domain.Core.Interfaces.Services;
using BUYList.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace BUYList.Domain.Services.Services
{
    public class ItemService :
    IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IValidator<Item> _validator;

        public ItemService
        (IItemRepository itemRepository, IValidator<Item> validator)
        {
            _itemRepository = itemRepository;
            _validator = validator;
        }

        public IEnumerable<Item> GetAll
        ()
        {
            try
            {
                return _itemRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetById
        (Guid id)
        {
            try
            {
                var item = _itemRepository.GetById(id);

                if (item != null) return item;
                else throw new Exception("The item dont exists.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add
        (Item item)
        {
            try
            {
                var validateResult = _validator.Validate(item);

                if (validateResult.IsValid) _itemRepository.Add(item);
                else throw new Exception(validateResult.Errors[0].ErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update
        (Item item)
        {
            try
            {
                var validateResult = _validator.Validate(item);

                if (validateResult.IsValid) _itemRepository.Update(item);
                else throw new Exception(validateResult.Errors[0].ErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove
        (Guid id)
        {
            try
            {
                _itemRepository.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
