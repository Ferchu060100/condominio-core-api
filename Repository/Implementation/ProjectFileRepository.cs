using condominio_core_api.Entity;
using condominio_core_api.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository.Implementation
{
    public class ProjectFileRepository : IProjectFileRepository
    {
        private ApplicationDbContext context;

        public ProjectFileRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            try
            {
                context.Entry(new ProjectFile { Id = id }).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public ProjectFile Get(int id)
        {
            var result = new ProjectFile();
            try
            {
                result = context.ProjectFiles.Single(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<ProjectFile> GetAll()
        {
            var result = new List<ProjectFile>();
            try
            {
                result = context.ProjectFiles.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<ProjectFile> GetProjectFilesByProject(int Projectid)
        {
            var result = new List<ProjectFile>();
            try
            {
                result = context.ProjectFiles.Where(x => x.ProjectId == Projectid).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(ProjectFile entity)
        {
            try
            {
                context.ProjectFiles.Add(entity);
                context.SaveChanges();

            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(ProjectFile entity)
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
