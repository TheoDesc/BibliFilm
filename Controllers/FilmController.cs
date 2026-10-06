using Microsoft.AspNetCore.Mvc;

namespace BibliFilm.Controllers
{
    public class FilmController : Controller
    {
        // GET : Film
        public async Task<IActionResult> Index()
        {
            var films = await _filmService.GetAllFilms();
            return View();
        }

        // GET : Film par id
        public IActionResult GetById(int id)
        {
            return Ok("Film avec l'id : " + id);
        }
    }
}