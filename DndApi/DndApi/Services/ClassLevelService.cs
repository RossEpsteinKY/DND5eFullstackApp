using DndApi.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using static DndApi.Models.PlayerCharacterDataModel;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DnDAPI.Services
{
    public class ClassLevelService(HttpClient client)
    {
        
        private HttpClient _client = client;
        private HttpClient _httpClient;

      

  

        public async Task<ClassLevel> GetClassLevel(string className, int classLevel)
        {
            //var response = await _httpClient.GetAsync($"https://www.dnd5eapi.co/api/classes/{className}/levels/{classLevel}");
            try
            {
  


                //var dndClassLevel = await ClassLevelService.GetClassLevel(className, classLevel);
                


                var response = await _client.GetAsync($"https://www.dnd5eapi.co/api/classes/{className}/levels/{classLevel}");

                if (response == null)
                {
                    return NotFound();
                }

                var content = await response.Content.ReadAsStringAsync();

        


                var classLevelData = JsonConvert.DeserializeObject<ClassLevel>(content);

                

                return (classLevelData);
            }

            catch (HttpRequestException)
            {
                return NotFound();
            }
            //return await response.Content.ReadAsAsync<ClassLevel>();
        }

  

        private ClassLevel NotFound()
        {
            throw new NotImplementedException();
        }
    }
}