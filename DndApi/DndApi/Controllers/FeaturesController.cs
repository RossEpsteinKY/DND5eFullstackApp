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
        [Route("/getFeatures")]
        public async Task<ActionResult<FeaturesModel.FeaturesList>> GetAllFeatures()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var featuresList = await _client.GetFromJsonAsync<FeaturesModel.FeaturesList>(baseUrl);

                if (featuresList == null)
                {
                    return NotFound();
                }

                return featuresList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

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


