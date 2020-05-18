using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using condominio_core_api.Entity;
using condominio_core_api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace condominio_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(userService.GetAll());
        }


        // POST: api/User
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            return Ok(userService.Save(user));
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] User user)
        {
            return Ok(userService.Update(user));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(userService.Delete(id));
        }
    }
}
