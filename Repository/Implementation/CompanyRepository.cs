using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext context;

        public CompanyRepository(ApplicationDbContext context)
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

        public Company Get(int id)
        {
            var result = new Company();
            try
            {
                result = context.Companies.Single(x => x.Id == id);
            }
            catch
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Company> GetAll()
        {
            var result = new List<Company>();
            try
            {
                result = context.Companies.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Company entity)
        {
            try
            {
                Company company = new Company
                {
                    Name = entity.Name,
                    Phone = entity.Phone,
                    Email = entity.Email,
                    Description = entity.Description
                };
                context.Companies.Add(company);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Company entity)
        {
            try
            {
                Company company = context.Companies.Single(x => x.Id == entity.Id);
                company.Name = entity.Name;
                company.Phone = entity.Phone;
                company.Description = entity.Description;
                context.Update(company);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }


            return true;
        }
    }
    }
