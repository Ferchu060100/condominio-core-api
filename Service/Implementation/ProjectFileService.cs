using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class ProjectFileService : IProjectFileService
    {
        private IProjectFileRepository projectFileRepository;

        public ProjectFileService(IProjectFileRepository projectFileRepository)
        {
            this.projectFileRepository = projectFileRepository;
        }

        public bool Delete(int id)
        {
           return projectFileRepository.Delete(id);
        }

        public ProjectFile Get(int id)
        {
            return projectFileRepository.Get(id);
        }

        public IEnumerable<ProjectFile> GetAll()
        {
            return projectFileRepository.GetAll();
        }

        public IEnumerable<ProjectFile> GetProjectFilesByProject(int ProjectId)
        {
            return projectFileRepository.GetProjectFilesByProject(ProjectId);
        }

        public bool Save(ProjectFile entity)
        {
            return projectFileRepository.Save(entity);
        }

        public bool Update(ProjectFile entity)
        {
            return projectFileRepository.Update(entity);
        }
    }
}
