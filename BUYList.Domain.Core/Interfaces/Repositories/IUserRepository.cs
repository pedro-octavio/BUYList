using BUYList.Domain.Entities;
using System;

namespace BUYList.Domain.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User GetByEmail(string email);
        void Add(User user);
        void Update(User user);
        void Remove(string email);
    }
}
