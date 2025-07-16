using System.ComponentModel.DataAnnotations;

namespace Ratatouille.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Ingredients { get; set; }

        public string? ImageURL { get; set; }
    }
}
