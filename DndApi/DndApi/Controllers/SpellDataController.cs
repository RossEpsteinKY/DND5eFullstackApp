using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Net.Http;
using static DndApi.Models.SpellDataModel;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellDataController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";

        [HttpGet]
        [Route("/getSpellData/{id}")]
        public async Task<object> GetSpellData(string id)
        {

            var response = await _client.GetAsync($"{baseUrl}/spells/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var spellData = JsonConvert.DeserializeObject<Spell>(content);

            return Ok(spellData);
        }


        [HttpGet]
        [Route("/getMagicSchoolData/{id}")]
        public async Task<object> GetMagicSchoolData(string id)
        {

            var response = await _client.GetAsync($"{baseUrl}/magic-schools/{id}");

            if (response == null) 
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var magicSchoolData = JsonConvert.DeserializeObject<MagicSchool.MagicSchoolData>(content);

            return Ok(magicSchoolData);
            
        }
        
    }
}
