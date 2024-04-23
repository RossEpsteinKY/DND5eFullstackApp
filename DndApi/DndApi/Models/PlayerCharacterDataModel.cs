using Castle.Components.DictionaryAdapter;
using Elasticsearch.Net;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using static DndApi.Models.ClassesData;
using static DndApi.Models.ReusableModels;

namespace DndApi.Models
{
    public class PlayerCharacterDataModel
    {

        public class ClassLevel
        {
            public string? Index { get; set; }
            public int? Level { get; set; }
            public int? Ability_Score_Bonuses { get; set; }

            public int? Prof_Bonus { get; set; }

            public GenericList? Class { get; set; }
            public string? Url { get; set; }

            public List<Features>? Features { get; set; }

            public ClassSpecific? Class_Specific { get; set; }

            public class ClassSpecific
            {
                public Dictionary<string,dynamic>? sneak_attack { get; set; }
                public int? rage_count { get; set; }
                public int? rage_damage_bonus { get; set; }
                public int? brutal_critical_dice { get; set; }
                public int? bardic_inspiration_die { get; set; }
                public int? song_of_rest_die { get; set; }
                public int? magical_secrets_max_5 { get; set; }
                public int? magical_secrets_max_7 { get; set; }
                public int? magical_secrets_max_9 { get; set; }
                public int? channel_divinity_charges { get; set; }
                public int? destroy_undead_cr { get; set; }
                public int? wild_shape_max_cr { get; set; }
                public bool? wild_shape_swim { get; set; }
                public bool? wild_shape_fly { get; set; }
                public int? action_surges { get;set; }
                public int? indomitable_uses { get; set; }
                public int? extra_attacks { get; set; }

                public Dictionary<string, int>? martial_arts { get; set; }
                public int? ki_points { get; set; }
                public int? unarmored_movement { get; set; }
                public int? aura_range { get; set; }
                public int? favored_enemies { get; set; }
                public int? favored_terrain { get; set; }
                public List<CreatingSpellSlot> Creating_Spell_Slots { get; set; }
                public int? sorcery_points { get; set; }
                public int? metamagic_known { get; set; }
                public class CreatingSpellSlot
                {
                    public int Spell_Slot_Level { get; set; }
                    public int Sorcery_Point_Cost { get; set; }
                }
                public int? Invocations_Known { get; set; }
                public int? Mystic_Arcanum_Level_6 { get; set; }
                public int? Mystic_Arcanum_Level_7 { get; set; }
                public int? Mystic_Arcanum_Level_8 { get; set; }
                public int? Mystic_Arcanum_Level_9 { get; set; }
                public int? arcane_recovery_levels { get; set; }


            }

            //[JsonProperty("sneak_attack", NullValueHandling = NullValueHandling.Ignore)]
            public class SneakAttack 
            { 

                public int? Dice_Count { get; set; }
                public int? Dice_Value { get; set; }
            }



            //public string? testThis{ get; set; }
            //public Dictionary<dynamic, Dictionary<dynamic, dynamic>>? Class_Specific { get; set; }



            //public string? testThis{ get; set; }
            //public Dictionary<dynamic, Dictionary<dynamic, dynamic>>? Class_Specific { get; set; }








        }

    }

    public class Features
    {
                
        public string? Index { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

    }
}
/**
                   public class PlayerResources
                   {
                       public class ClassResourcesByLevel
                       {
                           public class Spellcasting
                           {
                               public int? Cantrips_Known { get; set; }
                               public int? Spells_Known { get; set; }
                               public int? Spell_Slots_Level_1 { get; set; }
                               public int? Spell_SlotsLevel_2 { get; set; }
                               public int? Spell_Slots_Level_3 { get; set; }
                               public int? Spell_Slots_Level_4 { get; set; }
                               public int? Spell_Slots_Level_5 { get; set; }
                               public int? Spell_Slots_Level_6 { get; set; }
                               public int? Spell_Slots_Level_7 { get; set; }
                               public int? Spell_Slots_Level_8 { get; set; }
                               public int? Spell_Slots_Level_9 { get; set; }
                           }
                           
                   

                           public class Feature
                           {
                               public string Index { get; set; }
                               public string Name { get; set; }
                               public string Url { get; set; }
                           }

                           public class Class
                           {
                               public string Index { get; set; }
                               public string Name { get; set; }
                               public string Url { get; set; }
                           }

                           public class BardLeveresou
                           {
                               public int? Level { get; set; }
                               public int? Ability_Score_Bonuses { get; set; }
                               public int? Prof_Bonus { get; set; }
                               public List<Feature> Features { get; set; }
                               public Spellcasting Spellcasting { get; set; }
                               public ClassSpecific Class_Specific { get; set; }
                               public string Index { get; set; }
                               public Class Class { get; set; }
                               public string Url { get; set; }
                           }


                           public class ClassSpecific
                           {
                               public int? Bardic_Inspiration_Die { get; set; }
                               public int? Song_Of_Rest_Die { get; set; }
                               public int? Magical_Secrets_Max_5 { get; set; }
                               public int? Magical_Secrets_Max_7 { get; set; }
                               public int? Magical_Secrets_Max_9 { get; set; }
                           }
                       }
                   }
                   

               }
           **/