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
        ()
        {
            try
            {
                return _dataContext.Items.ToList().OrderBy(x => x.Name).Where(x => x.IsDeleted == false);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetById
        (Guid id)
        {
            try
            {
                return _dataContext.Items.Where(x => x.IsDeleted == false).FirstOrDefault();
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
                var item = GetById(id);

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
