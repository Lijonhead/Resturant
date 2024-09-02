namespace Resturant.Models.DTOs
{
    public class BookingDTO
    {

        public int BookingId { get; set; }

        public int FK_CustomerId { get; set; }
        public int FK_TableId { get; set; }

        public DateTime BookingDate { get; set; }
        public int CustomerAmount { get; set; }
    }
}
