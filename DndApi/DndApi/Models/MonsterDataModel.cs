

namespace DndApi.Models
{
    public class MonsterDataModel
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Type { get; set; }
        public string? Alignment { get; set; }
        public List<ArmorClass>? Armor_Class { get; set; }
        public int? Hit_Points { get; set; }
        public string? Hit_Dice { get; set; }
        public string? Hit_Points_Roll { get; set; }
        public Dictionary<string, string>? Speed { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
        public List<ProficiencyItem>? Proficiencies { get; set; }
        public List<string>? Damage_Vulnerabilities { get; set; }
        public List<string>? Damage_Resistances { get; set; }
        public List<string>? Damage_Immunities { get; set; }
        public List<string>? Condition_Immunities { get; set; }
        public Dictionary<string, string>? Senses { get; set; }
        public string? Languages { get; set; }
        public double? Challenge_Rating { get; set; }
        public int? Proficiency_Bonus { get; set; }
        public int? Xp { get; set; }
        public List<SpecialAbility>? Special_Abilities { get; set; }
        public List<Action>? Actions { get; set; }
        public List<Action>? Legendary_Actions { get; set; }
        public string? Image { get; set; }
        public string? Url { get; set; }
    }

    public class ArmorClass
    {
        public string? Type { get; set; }
        public int? Value { get; set; }
    }

    public class ProficiencyItem
    {
        public int? Value { get; set; }
        public ProficiencyDetail? Proficiency { get; set; }
    }

    public class ProficiencyDetail
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class SpecialAbility
    {
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public Usage? Usage { get; set; }
    }

    public class Usage
    {
        public string? Type { get; set; }
        public int? Times { get; set; }
        public List<string>? Rest_Types { get; set; }
    }

    public class Action
    {
        public string? Name { get; set; }
        public string? Multiattack_Type { get; set; }
        public string? Desc { get; set; }
        public List<ActionDetail>? Actions { get; set; }
        public int? Attack_Bonus { get; set; }
        public List<Damage>? Damage { get; set; }
        public Dc? Dc { get; set; }
    }

    public class ActionDetail
    {
        public string? Action_Name { get; set; }
        public int? Count { get; set; }
        public string? Type { get; set; }
    }

    public class Damage
    {
        public DamageType? Damage_Type { get; set; }
        public string? Damage_Dice { get; set; }
    }

    public class DamageType
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Dc
    {
        public DcType? Dc_Type { get; set; }
        public int? Dc_Value { get; set; }
        public string? Success_Type { get; set; }
    }

    public class DcType
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class MonsterListModel
    {
        public int? Count { get; set; }
        public List<MonsterResult>? Results { get; set; }
    }

    public class MonsterResult
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}