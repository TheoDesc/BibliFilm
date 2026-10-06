using Microsoft.AspNetCore.Mvc;

namespace BibliFilm.Controllers
{
    public class GenreController : Controller
    {
        // GET : Genre
        public IActionResult Index()
        {
            return View();
        }

        // GET : Genre/GetById
        public IActionResult GetById(int id)
        {
            return Ok("Genre avec l'id : " + id);
        }
    }
}
