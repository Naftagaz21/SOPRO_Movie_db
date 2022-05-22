using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Data.Services;

namespace WebApplication4.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonService _service;

        public PeopleController(IPersonService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allPeople = await _service.GetAll();
            return View(allPeople);
        }

        public async Task<ActionResult> Run()
        {
            var allPeople = await _service.GetAll();
            Console.WriteLine(allPeople);
            return View(allPeople);
        }
    }
}
