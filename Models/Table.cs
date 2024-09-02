using System.ComponentModel.DataAnnotations;

namespace Resturant.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int Capacity { get; set; }

        public ICollection<Booking> Bookings { get; set; }


    }
}
