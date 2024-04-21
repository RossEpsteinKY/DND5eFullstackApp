﻿using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DndApi.Models.PlayerCharacterDataModel;

namespace DndApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerCharacterController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";

        [HttpGet]
        [Route("/getAllAbilityScores")]
        public async Task<ActionResult<CharacterDataModel.AbilityScores.AbilityScoreList>> GetAllAbilityScores()
        {
            try
            {
                // URL from where you fetch the data


                // Fetch data from the URL
                var abilityScoreList = await _client.GetFromJsonAsync<CharacterDataModel.AbilityScores.AbilityScoreList>($"{baseUrl}/ability-scores");

                if (abilityScoreList == null)
                {
                    return NotFound();
                }

                return abilityScoreList;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/getAbilityScoreDetails/{id}")]
        public async Task<object> getAbilityScoreDetails(string id)
        {
            try
            {
                var response = await _client.GetAsync($"{baseUrl}/ability-scores/{id}");

                if (response == null)
                { return NotFound();
                }

                //var content = await response.Content.ReadAsStringAsync();
                //var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);

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
        [Route("/getAlignments/")]
        public async Task<ActionResult<CharacterDataModel.Alignments.AlignmentsList>> GetListOfAlignments()
        {
            try 
            {
                var alignmentsList = await _client.GetFromJsonAsync<CharacterDataModel.Alignments.AlignmentsList>($"{baseUrl}/alignments");

                if (alignmentsList == null)
                {
                    return NotFound();
                }

                return alignmentsList;
            }   
            catch (Exception ex) 
            { 
                return BadRequest(ex);
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

                //var content = await response.Content.ReadAsStringAsync();
                //var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);

                var content = await response.Content.ReadAsStringAsync();
                var alignmentDetails = JsonConvert.DeserializeObject<CharacterDataModel.Alignments.AlignmentsDetails>(content);


                return Ok(alignmentDetails);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
