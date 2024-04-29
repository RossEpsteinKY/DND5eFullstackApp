using DndApi.Data;
using DndApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        [Route("/getCreatedCharacters")]
        public async Task<ActionResult<IEnumerable<CreatedCharacterModel>>> GetCreatedCharacters()
        {
            return await _context.created_characters.Where(p => p.isDeleted == false).ToListAsync();
        }

        [HttpGet]
        [Route("/getCreatedCharacter/{id}")]
        public async Task<ActionResult<CreatedCharacterModel>> GetOneCreatedCharacter(int id)
        {
         

            try
            {
                var character = await _context.created_characters.SingleOrDefaultAsync(p => p.id == id && p.isDeleted == false);

                if(character == null)
                {
                    throw new NotImplementedException();
                }

                return character;

            }
            catch (Exception ex)
            {
                throw new Exception($"Entry with ID of {id} Not Found");
            }
        }

 


    }
}
