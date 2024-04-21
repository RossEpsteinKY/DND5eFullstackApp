using DndApi.Models;

namespace DndApi.Models
{
    public class ClassesData
    {

        public string? Index { get; set; }
        public string? Name { get; set; }
        public int? Hit_Die { get; set; }
        public List<ProficiencyChoice>? Proficiency_Choices { get; set; }
        public List<Proficiency>? Proficiencies { get; set; }
        public List<SavingThrow>? Saving_Throws { get; set; }
        public List<StartingEquipment>? Starting_Equipment { get; set; }
        public List<StartingEquipmentOption>? Starting_Equipment_Options { get; set; }
        public string? Class_Levels { get; set; }
        public MultiClassing? Multi_Classing { get; set; }
        public List<Subclass>? Subclasses { get; set; }
        public string? Url { get; set; }
    }

    public class ProficiencyChoice
    {
        public string? Desc { get; set; }
        public int? Choose { get; set; }
        public string? Type { get; set; }
        public ProficiencyChoiceFrom? From { get; set; }
    }

    public class ProficiencyChoiceFrom
    {
        public string? Option_Set_Type { get; set; }
        public List<Option>? Options { get; set; }
    }

    public class Option
    {
        public string? Option_Type { get; set; }
        public Item? Item { get; set; }
    }

    public class Item
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Proficiency
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class SavingThrow
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class StartingEquipment
    {
        public Equipment? Equipment { get; set; }
        public int? Quantity { get; set; }
    }

    public class Equipment
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class StartingEquipmentOption
    {
        public string? Desc { get; set; }
        public int? Choose { get; set; }
        public string? Type { get; set; }
        public StartingEquipmentOptionFrom? From { get; set; }
    }

    public class StartingEquipmentOptionFrom
    {
        public string? Option_Set_Type { get; set; }
        public List<Option>? Options { get; set; }
    }

    public class MultiClassing
    {
        public List<Prerequisite>? Prerequisites { get; set; }
        public List<Proficiency>? Proficiencies { get; set; }
    }

    public class Prerequisite
    {
        public AbilityScore? Ability_Score { get; set; }
        public int? Minimum_Score { get; set; }
    }

    public class AbilityScore
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Subclass
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }


    

        /**
        public class Classes
        {
            public string Index { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class ClassesList
        {
            public int Count { get; set; }
            public List<Classes> Results { get; set; }
        } **/


        public class ClassList
        {
            public int? Count { get; set; }
            public List<ClassData>? Results { get; set; }
        }

        public class ClassData
        {
            public string? Index { get; set; }
            public string? Name { get; set; }
            public string? Url { get; set; }
        }
    }





public class SubClassesData
{
    public class SubClassesList
    {
        public int? Count { get; set; }
        public List<SubClassesListData>? Results { get; set; }
    }

    public class SubClassesListData
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class Subclass
    {
        public string? Index { get; set; }
        public SubClassData? Class { get; set; }
        public string? Name { get; set; }
        public string? SubclassFlavor { get; set; }
        public List<string>? Desc { get; set; }
        public string? SubclassLevels { get; set; }
        public string? Url { get; set; }
        public List<object>? Spells { get; set; }
    }

    public class SubClassData
    {
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

}



