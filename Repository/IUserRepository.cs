using condominio_core_api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        public User GetbyEmail(string email);
    }
}
