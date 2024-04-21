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
}
