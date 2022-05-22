using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data.Services
{
    public interface IPersonService
    {
        Task <IEnumerable<Person>> GetAll();

        Person GetById(int id);

        void Add(Person person);

        Person Update(int id, Person newPerson);

        void Delete(int id);

    }
}
