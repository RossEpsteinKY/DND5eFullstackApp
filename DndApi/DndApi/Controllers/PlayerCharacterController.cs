using DndApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerCharacterController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";

        [HttpGet]
        [Route("/getAllAbilityScores")]
        public async Task<ActionResult<PlayerCharacterDataModel.PlayerAbilityScores.AbilityScoreList>> GetAllAbilityScores()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var abilityScoreList = await _client.GetFromJsonAsync<PlayerCharacterDataModel.PlayerAbilityScores.AbilityScoreList>($"{ baseUrl}/ability-scores");

                if (abilityScoreList == null)
                {
                    return NotFound();
                }

                return abilityScoreList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
