using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Dynamic;

using static DndApi.Models.PlayerCharacterDataModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DndApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerCharacterController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/";

        [HttpGet]
        [Route("/testingTheReturn/{id}")]
        public async Task<object> GetClassData(string id)
        {

            var response = await _client.GetAsync($"{baseUrl}/classes/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();

            var classData = JsonConvert.DeserializeObject<object>(content);

            var formattedData = JsonConvert.DeserializeObject<dynamic>(content)!;

            return Ok(formattedData);

        }

    }
}