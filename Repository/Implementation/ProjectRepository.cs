using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class ProjectRepository : IProjectRepository
    {
        private ApplicationDbContext context;

        public ProjectRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new Project { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public Project Get(int id)
        {
            var result = new Project();
            try
            {
                result = context.Projects.Single(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Project> GetAll()
        {
            var result = new List<Project>();
            try
            {
                result = context.Projects.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Project entity)
        {
            try
            {
                context.Projects.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Project entity)
        {
            try
            {
                context.Update(entity);
                context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }
    }
}
