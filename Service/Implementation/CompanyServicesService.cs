using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class CompanyServicesService : ICompanyServicesService
    {
        private ICompanyServicesRepository companyServicesRepository;

        public CompanyServicesService(ICompanyServicesRepository companyServicesRepository)
        {
            this.companyServicesRepository = companyServicesRepository;
        }

        public bool Delete(int id)
        {
            return companyServicesRepository.Delete(id);
        }

        public CompanyServices Get(int id)
        {
            return companyServicesRepository.Get(id);
        }

        public IEnumerable<CompanyServices> GetAll()
        {
            return companyServicesRepository.GetAll();
        }

        public IEnumerable<CompanyServices> GetCompanyServicesByDepartment(string department)
        {
            return companyServicesRepository.GetCompanyServicesByDepartment(department);
        }

        public IEnumerable<CompanyServices> GetCompanyServicesByDistrict(string district)
        {
            return companyServicesRepository.GetCompanyServicesByDistrict(district);
        }

        public bool Save(CompanyServices entity)
        {
            return companyServicesRepository.Save(entity);
        }

        public bool Update(CompanyServices entity)
        {
            return companyServicesRepository.Update(entity);
        }
    }
}
