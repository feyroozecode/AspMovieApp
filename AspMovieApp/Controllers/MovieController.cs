using AspMovieApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspMovieApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index() {

            Movie[] movies = GetMovies();
   
            return View(movies);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            Movie movie = GetMovieById(id);

            if(movie == null)
            {

                return NotFound();
            }


            return View(movie);
        }

        [HttpGet("/api/movies")]
        public IActionResult GetMoviesApi()
        {
            Movie[] movies = GetMovies();

            return Json(movies);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        private Movie[] GetMovies()
        {
            var movies = new Movie[]
           {
                new Movie {
                    id = 1,
                    Title = "Movie 1",
                    Description = "",
                    Author = "Hisham O",
                    Director = "Malick Hd",
                    Year = 2022,
                    Genre = "Documentary",
                    PostUrl = ""
                   },
                new Movie {
                    id = 1,
                    Title = "Movie 1",
                    Description = "",
                    Author = "Hisham",
                    Director = "Malick hd",
                    Year = 2022,
                    Genre = "Documentary",
                    PostUrl = ""
                }
            };

            return movies;
        }

        private Movie GetMovieById(int id)
        {
            var movies = new Movie[]
            {
                new Movie {
                    id = 1,
                    Title = "Movie 1",
                    Description = "",
                    Author = "Malick hd",
                    Year = 2022,
                    Genre = "Documentary",
                    PostUrl = ""
                   },
                new Movie {
                    id = 1,
                    Title = "Movie 1",
                    Description = "",
                    Author = "Malick hd",
                    Year = 2022,
                    Genre = "Documentary",
                    PostUrl = ""
                }
             };
            
            foreach(var movie in movies)
            {
                if(movie.id == id)
                {
                    return movie;
                }
            }

            return null;
        }    
 
    }
}
