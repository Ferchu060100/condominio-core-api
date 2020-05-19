﻿using condominio_core_api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Repository
{
    public interface IProjectFileRepository : IRepository<ProjectFile>
    {
        IEnumerable<ProjectFile> GetProjectFilesByProject(int Projectid);
    }
}