using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Net.Http;
using static DndApi.Models.SpellData;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellDataController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/spells/";

        [HttpGet]
        [Route("/getSpellData")]
        public async Task<object> GetSpellData(string id)
        {

            var response = await _client.GetAsync(baseUrl + id);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var spellData = JsonConvert.DeserializeObject<Spell>(content);

            return Ok(spellData);

        }

        [HttpGet]
        public async Task<ActionResult<SpellListModel.SpellList>> GetSpellsAsync()
        {
            try
            {
                // URL from where you fetch the data
            

                // Fetch data from the URL
                var spellList = await _client.GetFromJsonAsync<SpellListModel.SpellList>(baseUrl);

                if (spellList == null)
                {
                    return NotFound();
                }

                return spellList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
