using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data.Services
{
    public class PersonService : IPersonService
    {

        private readonly AppDbContext _context;

        public PersonService(AppDbContext context)
        {
            _context = context;
        }


        public void Add(Person person)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var result = await _context.People.ToListAsync();
            return result;
        }

        public Person GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Person Update(int id, Person newPerson)
        {
            throw new System.NotImplementedException();
        }
    }
}
