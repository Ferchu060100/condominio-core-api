using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class ApartmentFileService : IApartmentFileService
    {
        private IApartmentFileRepository apartmentFileRepository;

        public ApartmentFileService(IApartmentFileRepository apartmentFileRepository)
        {
            this.apartmentFileRepository = apartmentFileRepository;
        }

        public bool Delete(int id)
        {
            return apartmentFileRepository.Delete(id);
        }

        public ApartmentFile Get(int id)
        {
            return apartmentFileRepository.Get(id);
        }

        public IEnumerable<ApartmentFile> GetAll()
        {
            return apartmentFileRepository.GetAll();
        }

        public IEnumerable<ApartmentFile> GetApartmentFilesByApartmentId(int? apartmentId)
        {
            return apartmentFileRepository.GetApartmentFilesByApartmentId(apartmentId);
        }

        public bool Save(ApartmentFile entity)
        {
            return apartmentFileRepository.Save(entity);
        }

        public bool Update(ApartmentFile entity)
        {
            return apartmentFileRepository.Update(entity);
        }
    }
}
