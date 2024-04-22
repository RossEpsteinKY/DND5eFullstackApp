using static DndApi.Models.ReusableModels;

namespace DndApi.Models
{
    public class RulesModel
    {
        public class Conditions
        {

            public class ConditionsList
            {
                public int? Count { get; set; }
                public List<GenericList> Results { get; set; }
            }

            public class Condition
            { 
                public string? Index { get; set; }    
                public string? Name { get; set; }    
                public string[]? Desc { get; set; }
                public string? Url { get; set; }
            }
        }

    }
}
