using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Delete(int id)
        {
            return userRepository.Delete(id);
        }

        public User Get(int id)
        {
            return userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetbyEmail(string email)
        {
            return userRepository.GetbyEmail(email);
        }

        public bool Save(User entity)
        {
            return userRepository.Save(entity);
        }

        public bool Update(User entity)
        {
            return userRepository.Update(entity);
        }
    }
}
