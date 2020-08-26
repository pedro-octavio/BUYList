using AutoMapper;
using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using BUYList.Domain.Core.Interfaces.Services;
using BUYList.Domain.Entities;
using System;

namespace BUYList.Application.Services
{
    public class UserApplicationService :
    IUserApplicationService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserApplicationService
        (IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public UserDTO GetByEmail
        (string email)
        {
            try
            {
                var user = _userService.GetByEmail(email);

                return _mapper.Map<UserDTO>(user);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(UserDTO userDTO)
        {
            try
            {
                var user = _mapper.Map<User>(userDTO);

                _userService.Add(user);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(UserDTO userDTO)
        {
            try
            {
                var user = _mapper.Map<User>(userDTO);

                _userService.Update(user);
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
                _userService.Remove(email);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void ValidateUser(string email, string tokenUserId)
        {
            try
            {
                var atualId = GetByEmail(email).Id.ToString();

                if (atualId != tokenUserId) throw new Exception("Incorrect user.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
