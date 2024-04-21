using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;
using static DndApi.Models.CharacterDataModel.Proficiencies;
using static DndApi.Models.ReusableModels;
using static DndApi.Models.SpellData;

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

        public class Languages
        {
            public class LanguagesList
            {
                public List<GenericList>? Results {get; set;}
                public int? Count { get; set; }
            }

            public class LanguagesDetails
            { 
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Type { get; set; }
                public string[]? Typical_Speakers { get; set; }
                public string? Script { get; set; }
                public string? Url { get; set; }
            }
        }

        public class Proficiencies
        {
            public class ProficienciesList 
            { 
                public List<GenericList>? Results { get; set;}
                public int? Count { get; set; }
            }

            public class ProficiencyDetails 
            {
                public string? Index { get; set; }
                public string? Type { get; set; }
                public string? Name { get; set; }
                public List<Class>? Classes { get; set; }
                public List<Race>? Races { get; set; }
                public string? Url { get; set; }

                public ReferenceMaterials? Reference { get; set; }
                //public static List<ReferenceMaterial>? referenceMaterial { get; set; }
            }

            public class Race
            {
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Url { get; set; }
            }
            public class Class
            {
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Url { get; set; }
            }

            public class ReferenceMaterials
            {
                public string? Index { get; set; }
                public string? Name { get; set; }
                public string? Url { get; set; }
            }


        }
    }

 
}
