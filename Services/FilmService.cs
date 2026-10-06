using BibliFilm.Data;
using BibliFilm.Models.Entities;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace BibliFilm.Services
{
    public class FilmService : IFilmService
    {
        private readonly FilmContext _filmService;

        public FilmService(FilmContext context)
        {
            _filmService = context;
        }

        public async Task<List<Film>> GetAllAsync() =>
            await _filmService.Films
                .AsNoTracking()
                .OrderBy(f => f.Name)
                .ToListAsync();

        public async Task<Film?> GetByIdAsync(int id) =>
            await _filmService.Films.FindAsync(id);

        public async Task CreateAsync(Film film)
        {

        }

        public async Task UpdateAsync(Film film)
        {

        }

        public async Task DeleteAsync(int id)
        {

        }
    }
}