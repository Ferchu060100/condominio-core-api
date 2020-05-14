using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class Apartment
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public double Area { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
