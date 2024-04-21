using static DndApi.Models.ReusableModels;

namespace DndApi.Models
{
    public class CharacterDataModel
    {
        public class AbilityScores
        {
            public class AbilityScoreList
            {
                public int? Count { get; set; }
                public List<GenericList>? Results { get; set; }
            }

       /**     public class AbilityScoreResults
            {
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Url { get; set; }
            } **/


        }
        public class AbilityScoreDetails
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Full_Name { get; set; }
            public string[]? Desc { get; set; }
            public List<GenericList>? Skills { get; set; }
            public string? Url { get; set; }
        }

        public class Alignments
        {
            public class AlignmentsList
            {
                public int? Count { get; set; }

                public List<GenericList>? Results { get; set; }
            }

            public class AlignmentsDetails 
            { 
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Abbreviation { get; set; }
                public string? Desc { get; set; }

                public string? Url { get; set; }
            }
        }
    }

 
}
