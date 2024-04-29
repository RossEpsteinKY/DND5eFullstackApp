using DndApi.Data;
using DndApi.Models;
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
            return await _context.created_characters.ToListAsync();
        }

        [HttpGet]
        [HttpGet]
        [Route("/getCreatedCharacter/{id}")]
        public async Task<ActionResult<CreatedCharacterModel>> GetOneCreatedCharacter(int id)
        {
         

            try
            {
                var character = await _context.created_characters.SingleOrDefaultAsync(p => p.id == id);

                if(character == null)
                {
                    throw new NotImplementedException();
                }

                return character;
                /**     var content = await response.Content.ReadAsStringAsync();
                var abilityScoreDetails = JsonConvert.DeserializeObject<CharacterDataModel.AbilityScoreDetails>(content);


                return Ok(abilityScoreDetails);**/

            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        
    }
}
