using DndApi.Data;
using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreatedCharacterController
    {
        private readonly AppDbContext _context;

        public CreatedCharacterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreatedCharacterModel>>> GetArticles()
        {
            return await _context.created_characters.ToListAsync();
        }
    }
}
