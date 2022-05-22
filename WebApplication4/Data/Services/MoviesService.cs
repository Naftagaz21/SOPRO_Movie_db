using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return allMovies;
        }

        public Movie Update(int id, Movie newMovie)
        {
            throw new System.NotImplementedException();
        }
    }
}
