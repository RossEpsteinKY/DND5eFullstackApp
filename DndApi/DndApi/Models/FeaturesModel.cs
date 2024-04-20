namespace DndApi.Models
{
    public class FeaturesModel
    {

        public class FeaturesList
        {
            public int? Count { get; set; }
            public List<FeaturesListResult>? Results { get; set; }
        }

        public class FeaturesListResult
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Url { get; set; }
        }

        //single feature data
        public class FeaturesData
        {
            public string? Index { get; set; }
            public PlayerClassData? Class { get; set; }
            public string? Name { get; set; }
            public int? Level { get; set; }
            public List<object>? Prerequisites { get; set; }
            public List<string>? Desc { get; set; }
            public string? Url { get; set; }
        }

        public class PlayerClassData
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Url { get; set; }
        }

        public class Prerequisites 
        { 
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Url { get; set; }
        }



    }
}
