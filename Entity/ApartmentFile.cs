using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class ApartmentFile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BinaryCode { get; set; }
        public string TypeDocument { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        
    }
}
