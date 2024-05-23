using System.ComponentModel.DataAnnotations;

namespace SpasOnlineMenuProjectFinal.Models
{
    public class DishFormModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 8)]
        public string Ingredients { get; set; }

        [Range(1, 50)]
        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
