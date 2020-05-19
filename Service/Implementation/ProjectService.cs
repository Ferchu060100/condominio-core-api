using condominio_core_api.Entity;
using condominio_core_api.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class ProjectService : IProjectService
    {
        private IProjectRepository projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public bool Delete(int id)
        {
           return projectRepository.Delete(id);
        }

        public Project Get(int id)
        {
            return projectRepository.Get(id);
        }

        public IEnumerable<Project> GetAll()
        {
            return projectRepository.GetAll();
        }

        public bool Save(Project entity)
        {
            return projectRepository.Save(entity);
        }

        public bool Update(Project entity)
        {
            return projectRepository.Update(entity);
        }
    }
}
