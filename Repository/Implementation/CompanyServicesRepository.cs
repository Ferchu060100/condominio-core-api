using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class CompanyServicesRepository : ICompanyServicesRepository
    {
        private ApplicationDbContext context;

        public CompanyServicesRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new CompanyServices { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;

        }

        public CompanyServices Get(int id)
        {
            var result = new CompanyServices();
            try
            {
                result = context.Services.Single(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<CompanyServices> GetAll()
        {
            var result = new List<CompanyServices>();
            try
            {
                result = context.Services.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<CompanyServices> GetCompanyServicesByDistrict(string district)
        {
            var result = new List<CompanyServices>();
            try
            {
                result = context.Services.Where(x => x.District == district).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<CompanyServices> GetCompanyServicesByDepartment(string department)
        {
            var result = new List<CompanyServices>();
            try
            {
                result = context.Services.Where(x => x.Department == department).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(CompanyServices entity)
        {
            try
            {
                context.Services.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(CompanyServices entity)
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
