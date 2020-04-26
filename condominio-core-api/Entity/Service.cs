using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class CompanyService
    {
        [Key]
        public int Id { get; set; }
        public string Phone { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
