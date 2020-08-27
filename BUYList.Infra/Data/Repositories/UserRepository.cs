using BUYList.Domain.Core.Interfaces.Repositories;
using BUYList.Domain.Entities;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BUYList.Infra.Data.Repositories
{
    public class UserRepository :
    IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository
        (DataContext dataContext) => _dataContext = dataContext;

        public User GetByEmail(string email)
        {
            try
            {
                var user = _dataContext.Users.Where(x => !x.IsDeleted && x.Email == email).FirstOrDefault();

                if (user == null) throw new Exception("The user dont exists.");

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Add(User user)
        {
            try
            {
                _dataContext.Add(user);

                _dataContext.SaveChanges();
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(User user)
        {
            try
            {
                _dataContext.Update(user);

                _dataContext.SaveChanges();
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(string email)
        {
            try
            {
                var user = GetByEmail(email);

                user.IsDeleted = true;

                var items = _dataContext.Items.Where(x => x.UserId == user.Id && x.IsDeleted == false).ToList();

                items.ForEach(x => x.IsDeleted = true);

                _dataContext.Users.Update(user);

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
