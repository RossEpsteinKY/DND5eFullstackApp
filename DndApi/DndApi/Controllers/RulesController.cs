using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RulesController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/";

        
        [HttpGet]
        [Route("/getCondition/{id}")]
        public async Task<object> GetConditionDetails(string id)
        {
            try
            {
                var response = await _client.GetAsync($"{baseUrl}/conditions/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
    
                var condition = JsonConvert.DeserializeObject<RulesModel.Conditions.Condition>(content);


                
                return Ok(condition);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getDamageType/{id}")]
        public async Task<object> GetDamageType(string id)
        {
            try
            {
               
                var response = await _client.GetAsync($"{baseUrl}/damage-types/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();

                var damageTypesData = JsonConvert.DeserializeObject<RulesModel.DamageTypes.DamageTypeData>(content);

                return Ok(damageTypesData);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getRuleSectionByIndex/{id}")]
        public async Task<object> GetRuleSectionByIndex(string id)
        {
            try
            {

                var response = await _client.GetAsync($"{baseUrl}/rule-sections/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();

                var ruleByIndex = JsonConvert.DeserializeObject<RulesModel.RuleSectionByIndex>(content);

                return Ok(ruleByIndex);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
