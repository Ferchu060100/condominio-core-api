using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using condominio_core_api.Entity;
using condominio_core_api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace condominio_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }



        // GET: api/Company
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(companyService.GetAll());
        }

        // GET: api/Company/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(companyService.Get(id));
        }

        // POST: api/Company
        [HttpPost]
        public ActionResult Post([FromBody] Company company)
        {
            return Ok(companyService.Save(company));
        }

        // PUT: api/Company/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Company company)
        {
            return Ok(companyService.Update(company));
        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(companyService.Delete(id));
        }
    }
}
