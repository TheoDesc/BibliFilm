using System.ComponentModel.DataAnnotations;

namespace BibliFilm.Models.Entities
{
    public class Film
    {
        public int Id { get; set; }


        [Required, StringLength(100)]
        [Display(Name = "Nom")]
        public string Name { get; set; } = string.Empty;


        [Required, StringLength(1000)]
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        public string Realisateur { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;


        [Required, Range(0, 5)]
        public float Note { get; set; }

    }
}
