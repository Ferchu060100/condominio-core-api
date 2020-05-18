using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public Person Person { get; set; }
        public string Password { get; set; }
        public int IdentificationNumber { get; set; }
        public string Role { get; set; }
    }
}
