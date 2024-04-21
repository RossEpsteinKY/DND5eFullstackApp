namespace DndApi.Models
{
    public class PlayerCharacterDataModel
    {

        public class PlayerAbilityScores
        {
            public class AbilityScoreList
            {
                public int? Count { get; set; }
                public List<AbilityScoreResults>? Results { get; set; }
            }

            public class AbilityScoreResults
            {
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Url { get; set; }
            }
        }

    }

    
}
