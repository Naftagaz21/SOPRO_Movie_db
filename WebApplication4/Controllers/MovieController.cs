using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Data.Services;


namespace WebApplication4.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMoviesService _service; 

        public MovieController(IMoviesService service) 
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var allMovies = await _service.GetAll();
            return View(allMovies);
        }

        public IActionResult Create()
        {
            return View();
        }

       // public async Task<IActionResult> Details()
    }
}
