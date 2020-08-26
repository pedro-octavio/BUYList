using BUYList.Domain.Core.Interfaces.Repositories;
using BUYList.Domain.Core.Interfaces.Services;
using BUYList.Domain.Entities;
using FluentValidation;
using System;

namespace BUYList.Domain.Services.Services
{
    public class UserService :
    IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IValidator<User> _validator;

        public UserService
        (IUserRepository userRepository, IValidator<User> validator)
        {
            _userRepository = userRepository;
            _validator = validator;
        }

        public User GetByEmail(string email)
        {
            try
            {
                return _userRepository.GetByEmail(email);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(User user)
        {
            try
            {
                var validateResult = _validator.Validate(user);

                if (validateResult.IsValid) _userRepository.Add(user);
                else throw new Exception(validateResult.Errors[0].ErrorMessage);
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
                var validateResult = _validator.Validate(user);

                if (validateResult.IsValid) _userRepository.Update(user);
                else throw new Exception(validateResult.Errors[0].ErrorMessage);
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
                _userRepository.Remove(email);
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }
    }
}
