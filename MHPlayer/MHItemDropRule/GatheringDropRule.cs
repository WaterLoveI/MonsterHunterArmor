using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer.PKMItemDropRule
{
    public class GatheringDropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;

                if (npc.lifeMax > 5 && npc.value < 1f && Main.LocalPlayer.HasBuff(ModContent.BuffType<Gathering>()))
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