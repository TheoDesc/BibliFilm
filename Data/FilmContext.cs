using BibliFilm.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BibliFilm.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}
