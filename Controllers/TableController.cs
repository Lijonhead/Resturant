using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant.Models.DTOs;
using Resturant.Services;
using Resturant.Services.IServices;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableServices _tableServices;

        public TableController(ITableServices tableServices)
        {
            _tableServices = tableServices;
        }

        [HttpGet("GetAllTables")]
        public async Task<IActionResult> GetAllTables()
        {
            var tables = await _tableServices.GetAllTablesAsync();
            return Ok(tables);
        }

        [HttpGet("GetTableById")]
        public async Task<IActionResult> GetTableById(int id)
        {
            var table = await _tableServices.GetTableByIdAsync(id);
            if (table == null) return NotFound();
            return Ok(table);
        }

        [HttpPost("AddTable")]
        public async Task<IActionResult> AddTable([FromBody] TableDTO table)
        {
            await _tableServices.AddTableAsync(table);
            return CreatedAtAction(nameof(GetTableById), new { id = table.TableId }, table);
        }

        [HttpPut("UpdateTable")]
        public async Task<IActionResult> UpdateTable(int id, [FromBody] TableDTO table)
        {
            await _tableServices.UpdateTableAsync(table, id);
            return NoContent();
        }

        [HttpDelete("DeleteTable")]
        public async Task<IActionResult> DeleteTable(int id)
        {
            await _tableServices.DeleteTableAsync(id);
            return NoContent();
        }
        
    }
}
