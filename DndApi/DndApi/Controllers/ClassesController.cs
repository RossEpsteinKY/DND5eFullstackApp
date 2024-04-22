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
        [Route("/getSubClass/{id}")]
        public async Task<ActionResult<SubClassesData.Subclass>> GetSubClass(string id)
        {
            try
            {
                var subClass = await _client.GetFromJsonAsync<SubClassesData.Subclass>($"{baseUrl}/subclasses/{id}");

                if (subClass == null)
                {
                    return NotFound();
                }

                return subClass;
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getSpellcastingDataForCLass/{id}")]
        public async Task<ActionResult<ClassesData.Spellcasting.SpellcastingData>> GetClassSpellcastingData(string id)
        {
            try
            {
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
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getMulticlassingDataForClass/{id}")]
        public async Task<ActionResult<ClassesData.Multiclassing.MulticlassingData>> GetClassMulticlassingData(string id)
        {

            try
            {
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
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpGet]
        [Route("/getFeaturesByClass/{id}")]
        public async Task<ActionResult<FeaturesModel.FeaturesList>> GetFeaturesByClass(string id)
        {

            try
            {
                var response = await _client.GetAsync($"{baseUrl}/classes/{id}/features");

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var classFeatures = JsonConvert.DeserializeObject<FeaturesModel.FeaturesList>(content);

                return Ok(classFeatures);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getProficienciesByClass/{id}")]
        public async Task<ActionResult<CharacterDataModel.Proficiencies.ProficienciesList>> GetProficienciesByClass(string id)
        {

            try
            {
                var response = await _client.GetAsync($"{baseUrl}/classes/{id}/proficiencies");

                if (!response.IsSuccessStatusCode)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var classProficiencies = JsonConvert.DeserializeObject<CharacterDataModel.Proficiencies.ProficienciesList>(content);

                return Ok(classProficiencies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

    


    

