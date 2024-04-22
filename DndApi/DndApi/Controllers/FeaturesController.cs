using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FeaturesController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/features/";

        [HttpGet]
        [Route("/getFeature/{id}")]
        public async Task<object> GetOneFeature(string id)
        {

            var response = await _client.GetAsync(baseUrl + id);

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var featuresData = JsonConvert.DeserializeObject<FeaturesModel.FeaturesData>(content);

            return Ok(featuresData);
        }
    }
}


