using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    public class CharacterController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";

        
        [HttpGet]
        [Route("/getAbilityScoreDetails/{id}")]
        public async Task<object> getAbilityScoreDetails(string id)
        {
            try
            {
                var response = await _client.GetAsync($"{baseUrl}/ability-scores/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var abilityScoreDetails = JsonConvert.DeserializeObject<CharacterDataModel.AbilityScoreDetails>(content);


                return Ok(abilityScoreDetails);

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }


        [HttpGet]
        [Route("/getAlignmentDetails/{id}/")]
        public async Task<object> GetAlignmentDetails(string id)
        {
            try
            {
                var response = await _client.GetAsync($"{baseUrl}/alignments/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var alignmentDetails = JsonConvert.DeserializeObject<CharacterDataModel.Alignments.AlignmentsDetails>(content);


                return Ok(alignmentDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        [Route("/getLanguageDetails/{id}")]
        public async Task<object> GetLanguageDetails(string id)
        {
            try
            {

                var response = await _client.GetAsync($"{baseUrl}/languages/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();
                var languageDetails = JsonConvert.DeserializeObject<CharacterDataModel.Languages.LanguagesDetails>(content);

                return Ok(languageDetails);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        

        [HttpGet]
        [Route("/getProficiency/{id}")]
        public async Task<object> GetProficiency(string id)
        {
            try
            {
                var response = await _client.GetAsync($"{baseUrl}/proficiencies/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();


                var proficiencyDetails = JsonConvert.DeserializeObject<CharacterDataModel.Proficiencies.ProficiencyDetails>(content);


                return Ok(proficiencyDetails);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        

        [HttpGet]
        [Route("/getSkill/{id}")]
        public async Task<object> GetSkill(string id)
        {
            try
            {

                var response = await _client.GetAsync($"{baseUrl}/skills/{id}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();


                var skillDetails = JsonConvert.DeserializeObject<CharacterDataModel.Skills.Skill>(content);


                return Ok(skillDetails);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


    }
}

