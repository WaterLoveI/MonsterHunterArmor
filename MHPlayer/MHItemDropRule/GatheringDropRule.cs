using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer.MHItemDropRule
{
    public class GatheringDropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;

                if (npc.lifeMax > 5 && Main.LocalPlayer.GetModPlayer<ArmorSkills>().Gathering == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "If player has the Gathering Skill.";
        }
    }
    public class Gathering2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;

                if (npc.lifeMax > 5 && Main.LocalPlayer.GetModPlayer<ArmorSkills>().Gathering > 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "If player has the Gathering Skill.";
        }
    }
}