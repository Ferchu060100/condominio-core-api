using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string CompanyLogo { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}
