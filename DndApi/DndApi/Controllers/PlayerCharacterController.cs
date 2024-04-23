using DndApi.Models;
using DnDAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Dynamic;

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
                
                    var dndClassLevelResponseObject = await _classLevelService.GetClassLevel(className, classLevel);

                    var dndClassLevel = dndClassLevelResponseObject;

                    

                    string json = JsonConvert.SerializeObject(dndClassLevel);

                    
                    






                return Ok(dndClassLevel);
                }
                catch (HttpRequestException)
                {
                    return NotFound();
                }
            }

     }
    }
