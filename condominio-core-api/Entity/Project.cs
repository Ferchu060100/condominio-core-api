using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public bool State { get; set; }
        public string Type { get; set; }
        public string Benefits { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
