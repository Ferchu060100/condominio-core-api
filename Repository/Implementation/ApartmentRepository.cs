using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class ApartmentRepository : IApartmentRepository
    {
        private ApplicationDbContext context;

        public ApartmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new Apartment { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public Apartment Get(int id)
        {
            var result = new Apartment();
            try
            {
                result = context.Apartments.Single(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

        public IEnumerable<Apartment> GetAll()
        {
            var result = new List<Apartment>();
            try
            {
                result = context.Apartments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Apartment> GetApartmentsByProjectId(int? projectId)
        {
            var result = new List<Apartment>();
            try
            {
                result = context.Apartments.Where(x => x.ProjectId == projectId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;

        }

        public bool Save(Apartment entity)
        {
            try
            {
                context.Apartments.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Apartment entity)
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
