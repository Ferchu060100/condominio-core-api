﻿using condominio_core_api.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service
{
    public interface IApartmentFileService:IService<ApartmentFile>
    {
        public IEnumerable<ApartmentFile> GetApartmentFilesByApartmentId(int? apartmentId);

    }
}
