using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant.Models.DTOs;
using Resturant.Services;
using Resturant.Services.IServices;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingServices _bookingServices;

        public BookingController(IBookingServices bookingServices)
        {
            _bookingServices = bookingServices;
        }

        [HttpGet("GetAllBookings")]
        public async Task<IActionResult> GetAllBookings()
        {
            var bookings = await _bookingServices.GetAllBookingsAsync();
            return Ok(bookings);
        }

        [HttpGet("GetBookingById")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var booking = await _bookingServices.GetBookingByIdAsync(id);
            if (booking == null) return NotFound();
            return Ok(booking);
        }

        [HttpPost("AddBooking")]
        public async Task<IActionResult> AddBooking([FromBody] BookingDTO booking)
        {
            await _bookingServices.AddBookingAsync(booking);
            return CreatedAtAction(nameof(GetBookingById), new { id = booking.BookingId }, booking);
        }

        [HttpPut("UpdateBooking")]
        public async Task<IActionResult> UpdateBooking(int id, [FromBody] BookingDTO booking)
        {
            await _bookingServices.UpdateBookingAsync(booking, id);
            return NoContent();
        }

        [HttpDelete("DeleteBooking")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _bookingServices.DeleteBookingAsync(id);
            return NoContent();
        }

        [HttpGet("available/{tableId}/{date}")]
        public async Task<IActionResult> IsTableAvailable(int tableId, DateTime date)
        {
            var isAvailable = await _bookingServices.CheckTableAvailability(tableId, date);
            return Ok(new { TableId = tableId, Date = date, IsAvailable = isAvailable });
        }


    }
}
