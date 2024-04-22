using DndApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReusableController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";

        [HttpGet]
        [Route("/dynamicGetAll/{id}")]
        public async Task<ActionResult<ReusableModels.GenericListData>> GetAllClasses(string id)
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var conditionsList = await _client.GetFromJsonAsync<ReusableModels.GenericListData>($"{baseUrl}/{id}");

                if (conditionsList == null)
                {
                    return NotFound();
                }

                return conditionsList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
