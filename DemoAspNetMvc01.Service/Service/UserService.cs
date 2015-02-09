using DemoAspNetMvc01.Data.Repository.Interface;
using DemoAspNetMvc01.Domain.Model;
using DemoAspNetMvc01.Service.Service.Interface;
using System;
using System.Collections.Generic;

namespace DemoAspNetMvc01.Service.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetById(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> List()
        {
            return _userRepository.List();
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public void Dispose()
        {
            if (_userRepository != null)
            {
                _userRepository.Dispose();
            }
        }
    }
}
