using System.ComponentModel.DataAnnotations;

namespace Resturant.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DishName { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }
        [Required]
        public bool Availability { get; set; }

    }
}
