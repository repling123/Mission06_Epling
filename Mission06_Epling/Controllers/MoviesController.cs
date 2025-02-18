using Microsoft.AspNetCore.Mvc;
using Mission06_Epling.Data;
using Mission06_Epling.Models;

namespace Mission06_Epling.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                Console.WriteLine("✅ Movie saved successfully!");

                // Stay on AddMovie page instead of redirecting
                return View();
            }

            // Show validation errors if they exist
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine("❌ Validation Error: " + error.ErrorMessage);
            }

            return View(movie); // Reload form with validation errors
        }



    }
}

