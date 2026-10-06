using Microsoft.AspNetCore.Mvc;

namespace BibliFilm.Controllers
{
    public class RealisateurController : Controller
    {
        // GET : Realisateur
        public IActionResult Index()
        {
            return View();
        }

        // GET : Realisateur/GetById/
        public IActionResult GetById(int id)
        {
            return Ok("Réalisateur avec l'id : " + id);
        }
    }
}