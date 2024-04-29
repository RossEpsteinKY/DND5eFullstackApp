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

        [HttpPut]
        [Route("/deleteCreatedCharacter/{id}")]
        public async Task<string> DeleteCreatedCharacter(int id)
        {


            try
            {
                var character = await _context.created_characters.SingleOrDefaultAsync(p => p.id == id && p.isDeleted == false);

                

                if (character == null)
                {
                    throw new NotImplementedException();
                }

                character.isDeleted = true;
                _context.created_characters.Update(character);
                await _context.SaveChangesAsync();

                
                return $"successfully deleted character with id of {id}";
            }
            catch (Exception ex)
            {
                throw new Exception($"Entry with ID of {id} Not Found");
            }
        }


        [HttpPost]
        [Route("/createCharacter")]
        public async Task<string> CreateCharacter(CreatedCharacterModel character)
        {


            try
            {
                /** var character = await _context.created_characters.SingleOrDefaultAsync(p => p.id == id && p.isDeleted == false);



                if (character == null)
                {
                    throw new NotImplementedException();
                }

                character.isDeleted = true;
                _context.created_characters.Update(character);
                await _context.SaveChangesAsync();


                return $"successfully created character + {character}"; **/

                CreatedCharacterModel newCharacter = new CreatedCharacterModel();

                newCharacter.character_name = character.character_name;
                newCharacter.character_class= character.character_class;
                newCharacter.character_level = character.character_level;
                newCharacter.character_hitpoints = character.character_hitpoints;


                _context.created_characters.Add(newCharacter);
                await _context.SaveChangesAsync();

                return ($"New character created successfully {newCharacter}");




            }
            catch (Exception ex)
            {
                throw new Exception($"ERROR CREATING CHARACTER! {ex}");
            }
        }








    }
}
