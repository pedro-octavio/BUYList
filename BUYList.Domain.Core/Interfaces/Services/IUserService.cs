using BUYList.Domain.Entities;
using System;

namespace BUYList.Domain.Core.Interfaces.Services
{
    public interface IUserService
    {
        User GetByEmail(string email);
        void Add(User user);
        void Update(User user);
        void Remove(string email);
    }
}
