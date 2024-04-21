using DndApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacesController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/races/";



        [HttpGet]
        [Route("/getAllRaces")]
        public async Task<ActionResult<RacesList>> GetAllRaces()
        {
            try 
            {
                var _racesList = await _client.GetFromJsonAsync<RacesList>(baseUrl);

                if(_racesList == null) 
                {
                    return NotFound();
                        
                }
                return _racesList;
            }

            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

    }
}
