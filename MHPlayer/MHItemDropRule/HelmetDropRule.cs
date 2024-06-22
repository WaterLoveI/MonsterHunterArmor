using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace MHArmorSkills.MHPlayer.MHItemDropRule
{
    public class JungleCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneJungle;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the jungle.";
        }
    }
    public class HMJungleCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneJungle;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode jungle.";
        }
    }
    public class ForestCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneForest;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the forest.";
        }
    }
    public class HMForestCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneForest;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode forest.";
        }
    }
    public class DesertCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneDesert;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the desert.";
        }
    }
    public class HMDesertCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneDesert;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode desert.";
        }
    }
    public class SnowCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneSnow;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the snow.";
        }
    }
    public class HMSnowCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneSnow;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode snow.";
        }
    }
    public class UndergroundCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneDirtLayerHeight;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the underground.";
        }
    }
    public class HMUndergroundCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneDirtLayerHeight;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode underground.";
        }
    }
    public class HallowedCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneHallow;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the Hallowed.";
        }
    }
    public class OceanCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneBeach;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the Beach.";
        }
    }
    public class HMOceanCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneBeach;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode beach.";
        }
    }
    public class DungeonCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneDungeon;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the Dungeon.";
        }
    }
    public class HMDungeonCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneDungeon;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode dungeon.";
        }
    }
    public class CavernCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneRockLayerHeight;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the cavern.";
        }
    }
    public class HMCavernCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneRockLayerHeight;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode cavern.";
        }
    }
    public class GlowingMushroomCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneGlowshroom;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the mushroom biome.";
        }
    }
    public class HMGlowingMushroomCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneGlowshroom;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the mushroom biome.";
        }
    }
    public class EvilCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneCorrupt;
            }
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneCrimson;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in the evil biome.";
        }
    }
    public class HMEvilCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneCorrupt;
            }
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneCrimson;
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode evil biome.";
        }
    }
    public class UnderworldCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneUnderworldHeight;
            }

            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode evil biome.";
        }
    }
    public class HMUnderworldCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation && Main.hardMode)
            {
                return info.player.ZoneUnderworldHeight;
            }
            
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Drop from NPCs in hard mode evil biome.";
        }
    }
}