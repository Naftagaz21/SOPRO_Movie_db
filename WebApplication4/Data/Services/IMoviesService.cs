using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data.Services
{
    public interface IMoviesService
    {
        // Add a new movie
        void Add(Movie movie);

        // Delete an existing movie
        void Delete(int id);

        // Update an existing movie
        Movie Update(int id, Movie newMovie);

        Task<IEnumerable<Movie>> GetAll();
    }
}
