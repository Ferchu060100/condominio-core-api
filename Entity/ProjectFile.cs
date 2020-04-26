using condominio_core_api.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace condominio_core_api.Entity
{
    public class ProjectFile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description { get; set; }
        public string BinaryCode { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
