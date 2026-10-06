using Microsoft.AspNetCore.Mvc;
using BibliFilm.Services;
using BibliFilm.Models;

namespace BibliFilm.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        // GET : Film
        public async Task<IActionResult> Index()
        {
            var films = await _filmService.GetAllAsync();
            return View(films);
        }

        // GET : Film par id
        public IActionResult GetById(int id)
        {
            return Ok("Film avec l'id : " + id);
        }
    }
}