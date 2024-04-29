namespace DndApi.Models
{
    public class CreatedCharacterModel
    {
        public int id { get; set; }
        public string? character_name { get; set; }
        public int? character_level { get; set; }
        public string? character_class { get; set; }
        public int? character_hitpoints { get; set; }

    }
}
