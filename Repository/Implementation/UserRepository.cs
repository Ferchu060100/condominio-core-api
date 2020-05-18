using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext context;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new Company { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;

        }

        public User Get(int id)
        {
            var result = new User();
            try {
                result = context.Users.Single(x => x.Id == id);
            } catch
            {
                throw;
            }
            return result;

        }

        public IEnumerable<User> GetAll()
        {
            var result = new List<User>();
            try
            {
                result = context.Users.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public User GetbyEmail(string email)
        {
            var result = new User();
            try
            {
                result = context.Users.Single(x => x.Email == email);
            }
            catch
            {
                throw;
            }
            return result;
        }

        public bool Save(User entity)
        {
            try
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(User entity)
        {
            try
            {
                context.Update(entity);
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
