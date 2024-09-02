using Resturant.Models;

namespace Resturant.Data.Repos.IRepos
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookingsAsync();

        Task<Booking> GetBookingByIdAsync(int bookingId);

        Task AddBookingAsync(Booking booking);
        Task UpdateBookingAsync(Booking booking);
        Task DeleteBookingAsync(int bookingId);

        Task<bool> IsTableAvailableAsync(int tableId, DateTime date);

    }
}
