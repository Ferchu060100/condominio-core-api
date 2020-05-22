using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class ApartmentFileRepository : IApartmentFileRepository
    {
        private ApplicationDbContext context;

        public ApartmentFileRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new ApartmentFile { Id = id }).State = EntityState.Deleted;
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public ApartmentFile Get(int id)
        {
            var result = new ApartmentFile();
            try
            {
                result = context.ApartmentFiles.Single(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<ApartmentFile> GetAll()
        {
            var result = new List<ApartmentFile>();
            try
            {
                result = context.ApartmentFiles.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<ApartmentFile> GetApartmentFilesByApartmentId(int? apartmentId)
        {
            var result = new List<ApartmentFile>();
            try
            {
                result = context.ApartmentFiles.Where(x => x.ApartmentId == apartmentId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(ApartmentFile entity)
        {
            try
            {
                context.ApartmentFiles.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(ApartmentFile entity)
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
