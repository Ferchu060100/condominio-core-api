using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using condominio_core_api.Entity;
using condominio_core_api.Service.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace condominio_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyServicesController : ControllerBase
    {
        private ICompanyServicesService companyserviceService;

        public CompanyServicesController(ICompanyServicesService companyserviceService)
        {
            this.companyserviceService = companyserviceService;
        }


        // GET: api/CompanyServices
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(companyserviceService.GetAll());
        }

        // GET: api/CompanyServices/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(companyserviceService.Get(id));
        }

        // POST: api/CompanyServices
        [HttpPost]
        public ActionResult Post([FromBody] CompanyServices entity)
        {
            return Ok(companyserviceService.Save(entity));
        }

        // PUT: api/CompanyServices/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] CompanyServices entity)
        {
            return Ok(companyserviceService.Update(entity));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(companyserviceService.Delete(id));
        }
    }
}
