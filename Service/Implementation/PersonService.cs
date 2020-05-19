using condominio_core_api.Entity;
using condominio_core_api.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace condominio_core_api.Service.Implementation
{
    public class PersonService : IPersonService
    {
        private IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public bool Delete(int id)
        {
            return personRepository.Delete(id);
        }

        public Person Get(int id)
        {
            return personRepository.Get(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return personRepository.GetAll();
        }

        public bool Save(Person entity)
        {
            return personRepository.Save(entity);
        }

        public bool Update(Person entity)
        {
            return personRepository.Update(entity);
        }
    }
}
