using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DndApi.Models.PlayerCharacterDataModel;

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
        public async Task<ActionResult<PlayerAbilityScores.AbilityScoreList>> GetAllAbilityScores()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var abilityScoreList = await _client.GetFromJsonAsync<PlayerAbilityScores.AbilityScoreList>($"{ baseUrl}/ability-scores");

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

        [HttpGet]
        [Route("/getAbilityScoreDetails/{id}")]
        public async Task<object> getAbilityScoreDetails(string id)
        {
            try 
            {
                var response = await _client.GetAsync($"{baseUrl}/ability-scores/{id}");

                if (response== null)
                {  return NotFound(); 
                }

                //var content = await response.Content.ReadAsStringAsync();
                //var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);
                
                var content = await response.Content.ReadAsStringAsync();
                var abilityScoreDetails = JsonConvert.DeserializeObject<AbilityScoreDetails>(content);


                return Ok(abilityScoreDetails);

            }
            catch (Exception ex) 
            {
                return NotFound(ex);
            }
        }
    }
}
