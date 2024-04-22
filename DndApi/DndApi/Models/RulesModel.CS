using static DndApi.Models.ReusableModels;

namespace DndApi.Models
{
    public class RulesModel
    {

        public class DamageTypes
        {
            public class DamageTypeData
            {

                public string? Index { get; set; }
                public string? Name { get; set; }
                public string[]? Desc { get; set; }
                public string? Url { get; set; }
            }

        }

        public class Conditions
        {

 

            public class Condition
            { 
                public string? Index { get; set; }    
                public string? Name { get; set; }    
                public string[]? Desc { get; set; }
                public string? Url { get; set; }
            }
        }

        internal class RuleSectionByIndex
        {
            public string? Index { get; set;}
            public string? Name { get; set;}
            public string? Desc { get; set;}
            public string? Url { get; set;}
        }
    }
}
