using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class CompanyService : ICompanyService
    {
        private ICompanyRepository companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }


        public bool Delete(int id)
        {
            return companyRepository.Delete(id);
        }

        public Company Get(int id)
        {
            return companyRepository.Get(id);
        }

        public IEnumerable<Company> GetAll()
        {
            return companyRepository.GetAll();
        }

        public bool Save(Company entity)
        {
            return companyRepository.Save(entity);
        }

        public bool Update(Company entity)
        {
            return companyRepository.Update(entity);
        }
    }
}
