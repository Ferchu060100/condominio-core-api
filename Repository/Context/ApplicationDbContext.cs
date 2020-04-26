using condominio_core_api.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ApartmentFile> ApartmentFiles { get; set; }
        public DbSet<ProjectFile> ProjectFiles { get; set; }
        public DbSet<CompanyService> Services { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }
    
    }
}
