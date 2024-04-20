using DndApi.Models;
using Microsoft.AspNetCore.Mvc;

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

        }
}


