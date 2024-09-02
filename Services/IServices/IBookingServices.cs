using Resturant.Models;
using Resturant.Models.DTOs;

namespace Resturant.Services.IServices
{
    public interface IBookingServices
    {
        Task<IEnumerable<BookingDTO>> GetAllBookingsAsync();

        Task<BookingDTO> GetBookingByIdAsync(int bookingId);

        Task AddBookingAsync(BookingDTO booking);
        Task UpdateBookingAsync(BookingDTO booking, int bookingId);
        Task DeleteBookingAsync(int bookingId);

        public Task<bool> CheckTableAvailability(int tableId, DateTime date);
       

    }
}
