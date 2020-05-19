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
    public class ProjectFileController : ControllerBase
    {
        private IProjectFileService projectfileService;

        public ProjectFileController(IProjectFileService projectfileService)
        {
            this.projectfileService = projectfileService;
        }
        //GET: api/ProjectFile
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(projectfileService.GetAll());
        }


        // GET: api/ProjectFile/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(projectfileService.Get(id));
        }

        // POST: api/ProjectFile
        [HttpPost]
        public ActionResult Post([FromBody] ProjectFile projectFile)
        {
            return Ok(projectfileService.Save(projectFile));
        }

        // PUT: api/ProjectFile/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] ProjectFile projectFile)
        {
            return Ok(projectfileService.Update(projectFile));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(projectfileService.Delete(id));
        }

    }
}