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
    public class ApartmentFileController : ControllerBase
    {
        private IApartmentFileService apartmentFileService;

        public ApartmentFileController(IApartmentFileService apartmentFileService)
        {
            this.apartmentFileService = apartmentFileService;
        }

        // GET: api/ApartmentFile
        [HttpGet]
        public ActionResult Get([FromQuery] int? apartmentid)
        {
            if (apartmentid.HasValue)
            {
                return Ok(apartmentFileService.GetApartmentFilesByApartmentId(apartmentid.Value));
            }
            else
            {
                return Ok(apartmentFileService.GetAll());
            }


        }

        // GET: api/ApartmentFile/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(apartmentFileService.Get(id));
        }

        // POST: api/ApartmentFile
        [HttpPost]
        public ActionResult Post([FromBody] ApartmentFile apartmentFile)
        {
            return Ok(apartmentFileService.Save(apartmentFile));
        }

        // PUT: api/ApartmentFile/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] ApartmentFile apartmentFile)
        {
            return Ok(apartmentFileService.Update(apartmentFile));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(apartmentFileService.Delete(id));
        }
    }
}
