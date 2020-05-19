using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        private ApplicationDbContext context;

        public PersonRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new Person { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public Person Get(int id)
        {
            var result = new Person();
            try
            {
                result = context.People.Single(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Person> GetAll()
        {
            var result = new List<Person>();
            try
            {
                result = context.People.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Person entity)
        {
            try
            {
                context.People.Add(entity);
                context.SaveChanges();

            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Person entity)
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
