using condominio_core_api.Entity;
using condominio_core_api.Repository;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class ApartmentService : IApartmentService
    {
        private IApartmentRepository apartmentRepository;

        public ApartmentService(IApartmentRepository apartmentRepository)
        {
            this.apartmentRepository = apartmentRepository;
        }

        public bool Delete(int id)
        {
            return apartmentRepository.Delete(id);
        }

        public Apartment Get(int id)
        {
            return apartmentRepository.Get(id);
        }

        public IEnumerable<Apartment> GetAll()
        {
            return apartmentRepository.GetAll();
        }

        public IEnumerable<Apartment> GetApartmentsByProjectId(int? projectId)
        {
            return apartmentRepository.GetApartmentsByProjectId(projectId);
        }

        public bool Save(Apartment entity)
        {
            return apartmentRepository.Save(entity);
        }

        public bool Update(Apartment entity)
        {
            return apartmentRepository.Update(entity);
        }
    }
}
