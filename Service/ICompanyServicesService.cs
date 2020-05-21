using condominio_core_api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
   public interface ICompanyServicesService : IService<CompanyServices>
    {
        public IEnumerable<CompanyServices> GetCompanyServicesByDistrict(string district);
        public IEnumerable<CompanyServices> GetCompanyServicesByDepartment(string department);
    }
}
