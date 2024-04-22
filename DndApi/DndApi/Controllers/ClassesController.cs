using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassesController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api/";

        [HttpGet]
        [Route("/getClassData/{id}")]
        public async Task<object> GetClassData(string id)
        {

            var response = await _client.GetAsync($"{baseUrl}/classes/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            var content = await response.Content.ReadAsStringAsync();
            var classData = JsonConvert.DeserializeObject<ClassesData>(content);

            return Ok(classData);

        }

        [HttpGet]
        [Route("/getAllClasses")]
        public async Task<ActionResult<ClassList>> GetAllClasses()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var classesList = await _client.GetFromJsonAsync<ClassList>($"{baseUrl}/classes");

                if (classesList == null)
                {
                    return NotFound();
                }

                return classesList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getAllSubClasses")]
        public async Task<ActionResult<SubClassesData.SubClassesList>> GetAllSubClasses()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var subClassesList = await _client.GetFromJsonAsync<SubClassesData.SubClassesList>($"{baseUrl}/subclasses");

                if (subClassesList == null)
                {
                    return NotFound();
                }

                return subClassesList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getSubClass/{id}")]
        public async Task<ActionResult<SubClassesData.Subclass>> GetSubClass(string id)
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var subClass = await _client.GetFromJsonAsync<SubClassesData.Subclass>($"{baseUrl}/subclasses/{id}");

                if (subClass == null)
                {
                    return NotFound();
                }

                return subClass;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getSpellcastingDataForCLass/{id}")]
        public async Task<ActionResult<ClassesData.Spellcasting.SpellcastingData>> GetClassSpellcastingData(string id)
        {
            try
            {
                // URL from where you fetch the data

                var response = await _client.GetAsync($"{baseUrl}/classes/{id}/spellcasting");

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var classSpellData = JsonConvert.DeserializeObject<ClassesData.Spellcasting.SpellcastingData>(content);

                return Ok(classSpellData);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getMulticlassingDataForClass/{id}")]
        public async Task<ActionResult<ClassesData.Multiclassing.MulticlassingData>> GetClassMulticlassingData(string id)
        {

            try
            {
                // URL from where you fetch the data

                var response = await _client.GetAsync($"{baseUrl}/classes/{id}/multi-classing");

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var multiclassingData = JsonConvert.DeserializeObject<ClassesData.Multiclassing.MulticlassingData>(content);

                return Ok(multiclassingData);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

    


    

