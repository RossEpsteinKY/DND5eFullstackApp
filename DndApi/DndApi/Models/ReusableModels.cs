namespace DndApi.Models
{
    public class ReusableModels
    {
        public class GenericList
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Url { get; set; }

        }
        public class GenericListData
        {
            public int? Count { get; set; }
            public List<GenericList>? Results { get; set; }
        }
    }
}
