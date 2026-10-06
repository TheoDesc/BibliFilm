using BibliFilm.Models.Entities;

namespace BibliFilm.Services
{
    private readonly FilmContext _context;

        public FilmService(FilmContext context)
        {
            _context = context;
        }

        public async Task<List<Film>> GetAllAsync() => await _context.Film
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .ToListAsync();

        public async Task<Film?> GetByIdAsync(Guid id) => await _context.Films.FindAsync(id);
    }
