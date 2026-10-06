using Microsoft.AspNetCore.Mvc;

namespace BibliFilm.Controllers
{
    public class FilmController : Controller
    {
        // GET : Film
        public IActionResult Index()
        {
            return View();
        }

        // GET : Film/5
        public IActionResult GetById(int id)
        {
            return Ok("Film avec l'id : " + id);
        }
    }
}