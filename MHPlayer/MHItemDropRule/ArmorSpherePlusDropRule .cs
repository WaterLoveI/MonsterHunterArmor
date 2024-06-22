using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace MHArmorSkills.MHPlayer.MHItemDropRule
{
    public class ArmorSpherePlusDropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 1000 || NPC.downedBoss2)
                {
                    return false;
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
            return "If the NPC has 2000 or more HP and either Eater of Worlds or Brain of Cthulu has been defeated.";
        }
    }
}