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
    public class PersonController : ControllerBase
    {
        private IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        // GET: api/Person
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(personService.GetAll());
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(personService.Get(id));
        }

        // POST: api/Person
        [HttpPost]
        public ActionResult Post([FromBody] Person person)
        {
            return Ok(personService.Save(person));
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Person person)
        {
            return Ok(personService.Update(person));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(personService.Delete(id));
        }
    }
}
