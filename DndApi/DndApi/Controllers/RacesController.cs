﻿using DndApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DndApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RacesController(HttpClient client) : ControllerBase
    {
        private HttpClient _client = client;
        private string baseUrl = "https://www.dnd5eapi.co/api";



        [HttpGet]
        [Route("/getAllRaces")]
        public async Task<ActionResult<RacesList>> GetAllRaces()
        {
            try
            {
                var _racesList = await _client.GetFromJsonAsync<RacesList>($"{ baseUrl}/races");

                if (_racesList == null)
                {
                    return NotFound();

                }
                return _racesList;
            }

            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("/getRace/{id}")]
        public async Task<object> GetPlayerRace(string id)
        {
            var response = await _client.GetAsync($"{baseUrl}/races/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            //var content = await response.Content.ReadAsStringAsync();
            //var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);
            
            
            var content = await response.Content.ReadAsStringAsync();

            var raceData = JsonConvert.DeserializeObject<PlayerRace>(content);

            return Ok(raceData);


        }

        [HttpGet]
        [Route("/getRaceTraits/{id}")]
        public async Task<object> GetPlayerRaceTraits(string id)
        {
            var response = await _client.GetAsync($"{baseUrl}/traits/{id}");

            if (!response.IsSuccessStatusCode)
            {
                return NotFound();
            }

            //var content = await response.Content.ReadAsStringAsync();
            //var monsterData = JsonConvert.DeserializeObject<MonsterData>(content);


            var content = await response.Content.ReadAsStringAsync();

            var traitData = JsonConvert.DeserializeObject<RaceTraitDetails>(content);

            return Ok(traitData);


        }

    }
}
