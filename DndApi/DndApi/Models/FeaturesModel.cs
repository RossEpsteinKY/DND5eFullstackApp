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
    }
}
