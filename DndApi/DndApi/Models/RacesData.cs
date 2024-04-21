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

    public class RaceTraitDetails
    { 
        public string? Index { get; set; }
        public List<GenericList>? Races { get; set; }
        public List<GenericList>? Subraces { get; set; }
        public string? Name { get; set; }
        public string[]? Desc { get; set; }
        public List<GenericList>? Proficiencies { get;set; }

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
        public List<StartingProficiencies>? starting_proficiencies { get; set; }
        public StartingProficiencyOptions? starting_proficiency_options { get; set; }

        public  List<GenericList>? languages { get; set; }
        public string? Language_Desc { get; set; }
        public List<RaceTraits>? traits { get; set; }
        public List<RaceTraits>? subraces { get; set; }
        public string? Url { get; set; }
    }

    public class GenericList
    {

        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

    }

    public class RaceTraits
    {

        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

    }


    public class AbilityBonuses 
    { 
        public AbilityScore? ability_Score { get; set; }
        public string? bonus { get; set; }
    }

    public class StartingProficiencies
    { 
    
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

    }

    public class StartingProficiencyOptions
    {
        public string? Desc { get; set; }
        public int? Choose { get; set; }
        public string? Type { get; set; }
        public From? From { get; set; }
    }

    public class From
    {
        public string? Option_Set_Type { get; set; }
        public List<RaceOption>? Options { get; set; }
    }

    public class RaceOption
    {
        public string? Option_Type { get; set; }
        public RaceItem? Item { get; set; }
    }

    public class RaceItem
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
