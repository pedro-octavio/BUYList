using BUYList.Application.DTOs;
using System;

namespace BUYList.Application.Interfaces
{
    public interface IUserApplicationService
    {
        UserDTO GetByEmail(string email);
        void Add(UserDTO userDTO);
        void Update(UserDTO userDTO);
        void Remove(string email);
    }
}
