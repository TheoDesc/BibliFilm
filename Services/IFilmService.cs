using BibliFilm.Models.Entities;

namespace BibliFilm.Services
{

        public interface IFilmService
        {
            Task<List<Film>> GetAllAsync();
            Task<Film?> GetByIdAsync(int id);
            Task CreateAsync(Film film);
            Task UpdateAsync(Film film);
            Task DeleteAsync(int id);
        }
    }

