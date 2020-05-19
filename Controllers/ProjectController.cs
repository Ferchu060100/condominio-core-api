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
    public class ProjectController : ControllerBase
    {
        private IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        // GET: api/Project
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(projectService.GetAll());
        }

        // GET: api/Project/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(projectService.Get(id));
        }

        // POST: api/Project
        [HttpPost]
        public ActionResult Post([FromBody] Project project)
        {
            return Ok(projectService.Save(project));
        }

        // PUT: api/Project/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Project project)
        {
            return Ok(projectService.Update(project));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(projectService.Delete(id));
        }
    }
}
