using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Data.Entities
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(10000)]
        public string Ingredients { get; set; }
        [Required]

        public decimal Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
