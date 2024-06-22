using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace MHArmorSkills.MHPlayer.MHItemDropRule
{
    public class DecorationDropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;

                if (npc.lifeMax >= 5)
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
            return "If the NPC has more than 5 HP";
        }
    }
}