namespace DndApi.Models
{
    public class SpellData
    {



    public class DamageType
    {
        public string? index { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class DamageAtSlotLevel
    {
        public string? _2 { get; set; }
        public string? _3 { get; set; }
        public string? _4 { get; set; }
        public string? _5 { get; set; }
        public string? _6 { get; set; }
        public string? _7 { get; set; }
        public string? _8 { get; set; }
        public string? _9 { get; set; }
    }

    public class Damage
    {
        public DamageType? damage_type { get; set; }
        public DamageAtSlotLevel? damage_at_slot_level { get; set; }
    }

    public class School
    {
        public string? index { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class Class
    {
        public string? index { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class Subclass
    {
        public string? index { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
    }

    public class Spell
    {
        public string? index { get; set; }
        public string? name { get; set; }
        public List<string>? desc { get; set; }
        public List<string>? higher_level { get; set; }
        public string? range { get; set; }
        public List<string>? components { get; set; }
        public string? material { get; set; }
        public bool? ritual { get; set; }
        public string? duration { get; set; }
        public bool? concentration { get; set; }
        public string? casting_time { get; set; }
        public int? level { get; set; }
        public string? attack_type { get; set; }
        public Damage? damage { get; set; }
        public School? school { get; set; }
        public List<Class>? classes { get; set; }
        public List<Subclass>? subclasses { get; set; }
        public string? url { get; set; }
    }

    }

    public class SpellListModel
    {


        public class Spell
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public int? Level { get; set; }
            public string? Url { get; set; }
        }

        public class SpellList
        {
            public int? Count { get; set; }
            public List<Spell>? Results { get; set; }
        }
    }

}
