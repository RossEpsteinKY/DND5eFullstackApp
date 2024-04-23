using System.Dynamic;
using DndApi.Models;
using DnDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerCharacterController : ControllerBase
    {
        private readonly ClassLevelService _classLevelService;
        private readonly HttpClient _client;

        public PlayerCharacterController(HttpClient client, ClassLevelService dndClassLevelService)
        {
            _client = client;
            _classLevelService = dndClassLevelService;
        }

        [HttpGet]
        [Route(("/getClassAndLevelData/{className}/levels/{classLevel}"))]
        public async Task<IActionResult> GetClassLevel(string className, int classLevel)
        {
            try
            {
                var dndClassLevelResponseObject = await _classLevelService.GetClassLevel(
                    className,
                    classLevel
                );

                var dndClassLevel = dndClassLevelResponseObject;

                string json = JsonConvert.SerializeObject(dndClassLevel);

                return Ok(dndClassLevel);
            }
            catch (HttpRequestException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route(("/getClassAndLevelFeatures/{className}/levels/{classLevel}"))]
        public async Task<IActionResult> GetClassLevelFeatures(string className, int classLevel)
        {
            var response = await _client.GetAsync($"https://www.dnd5eapi.co/api/classes/{className}/levels/{classLevel}/features");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();

            var featuresData = JsonConvert.DeserializeObject<PlayerCharacterDataModel.Features>(content);

            return Ok(featuresData);
        }
    }
}
