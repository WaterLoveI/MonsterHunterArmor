using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;

namespace MHArmorSkills.MHPlayer.PKMItemDropRule
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
    public class UndergroundCondition : IItemDropRuleCondition, IProvideItemConditionDescription
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (info.npc.value > 0f && !info.IsInSimulation)
            {
                return info.player.ZoneNormalUnderground;
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
}