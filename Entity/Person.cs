using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Entity
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required, MaxLength(100)]
        public string ShortName { get; set; }

        [MaxLength(20)]
        public string IdentificationNumber { get; set; }


        public int UserId { get; set; }

        public User User { get; set; }



    }
}
