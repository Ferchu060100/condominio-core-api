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
    public class ApartmentController : ControllerBase
    {
        private IApartmentService apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            this.apartmentService = apartmentService;
        }

        // GET: api/Apartment
        [HttpGet]
        public ActionResult Get([FromQuery] int? projectid)
        {
            if (projectid.HasValue) 
            {
                return Ok(apartmentService.GetApartmentsByProjectId(projectid.Value));
            }
            else
            {
                return Ok(apartmentService.GetAll());
            }


        }

        // GET: api/Apartment/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(apartmentService.Get(id)) ;
        }

        // POST: api/Apartment
        [HttpPost]
        public ActionResult Post([FromBody] Apartment apartment)
        {
            return Ok(apartmentService.Save(apartment));
        }

        // PUT: api/Apartment/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Apartment apartment)
        {
            return Ok(apartmentService.Update(apartment));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(apartmentService.Delete(id));
        }
    }
}
