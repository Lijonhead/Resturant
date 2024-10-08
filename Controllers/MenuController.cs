﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant.Models.DTOs;
using Resturant.Services.IServices;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuServices _menuServices;

        public MenuController(IMenuServices menuServices)
        {
            _menuServices = menuServices;
        }

        [HttpGet("GetAllMenus")]
        public async Task<IActionResult> GetAllMenus()
        {
            var menus = await _menuServices.GetAllMenusAsync();
            return Ok(menus);
        }

        [HttpGet("GetMenuById/{id}")]
        public async Task<IActionResult> GetMenuById(int id)
        {
            var menu = await _menuServices.GetMenuByIdAsync(id);
            if (menu == null) return NotFound();
            return Ok(menu);
        }

        [HttpPost("AddMenu")]
        public async Task<IActionResult> AddMenu([FromBody] MenuDTO menu)
        {
            await _menuServices.AddMenuAsync(menu);
            return CreatedAtAction(nameof(GetMenuById), new { id = menu.MenuId }, menu);
        }

        [HttpPut("UpdateMenu/{id}")]
        public async Task<IActionResult> UpdateMenu(int id, [FromBody] MenuDTO menu)
        {
            await _menuServices.UpdateMenuAsync(menu, id);
            return NoContent();
        }

        [HttpDelete("DeleteMenu/{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            await _menuServices.DeleteMenuAsync(id);
            return NoContent();
        }
    }
}
