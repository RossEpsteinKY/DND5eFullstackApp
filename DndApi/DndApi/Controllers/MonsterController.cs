using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MonsterController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/monsters/";

        [HttpGet]
        [Route("/getMonsterData/{id}")]
        public async Task<object> GetMonsterData(string id)
        {

            var response = await _client.GetAsync(baseUrl + id);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);

            return Ok(monsterData);

        }
    }
}

    

