namespace DndApi.Models
{
    public class RacesData
    {
      
    }

    public class RacesList
    {
        public int? Count { get; set; }
        public List<Races>? Results { get; set; }
    }

    public class Races
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }


    //individual player race data

    public class PlayerRace 
    { 
        public string? Index { get; set; } 
        public string? Name { get; set; }
        public int? Speed { get; set; }
        public List<AbilityBonuses>? Ability_Bonuses { get; set; }
        public string? Alignment { get; set; }
        public string? Age { get; set; }
        public string? Size { get; set; }
        public string? Size_Description { get; set; }
    }

    public class AbilityBonuses 
    { 
        public AbilityScore? ability_Score { get; set; }
        public string? bonus { get; set; }
    }
}
