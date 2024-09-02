using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resturant.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Table")]
        public int FK_TableId { get; set; }
        public Table Table { get; set; }


        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public int CustomerAmount { get; set; }

    }
}
