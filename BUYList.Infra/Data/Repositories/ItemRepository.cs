using BUYList.Domain.Core.Interfaces.Repositories;
using BUYList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUYList.Infra.Data.Repositories
{
    public class ItemRepository :
    IItemRepository
    {
        private readonly DataContext _dataContext;

        public ItemRepository
        (DataContext dataContext) => _dataContext = dataContext;

        public IEnumerable<Item> GetAll
        (Guid userId)
        {
            try
            {
                return _dataContext.Items.ToList().Where(x => x.IsDeleted == false && x.UserId == userId).OrderBy(x => x.Name);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetById
        (Guid id, Guid userId)
        {
            try
            {
                return _dataContext.Items.Where(x => x.IsDeleted == false && x.Id == id && x.UserId == userId).FirstOrDefault();
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Add
        (Item item)
        {
            try
            {
                _dataContext.Items.Add(item);

                _dataContext.SaveChanges();
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Update
        (Item item)
        {
            try
            {
                _dataContext.Items.Update(item);

                _dataContext.SaveChanges();
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
                var item = _dataContext.Items.Where(x => x.IsDeleted == false && x.Id == id).FirstOrDefault();

                if (item == null) throw new Exception("The item dont exists.");

                item.IsDeleted = true;

                _dataContext.Items.Update(item);

                _dataContext.SaveChanges();
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }
    }
}
