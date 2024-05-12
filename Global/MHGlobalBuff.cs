using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public partial class MHGlobalBuffs : GlobalBuff
    {
        public override bool ReApply(int type, NPC npc, int time, int buffIndex)
        {
            Player player = Main.player[npc.lastInteraction];
            int extendedDuration = (int)(npc.buffTime[buffIndex] * 1.1);

            if (extendedDuration > npc.buffTime[buffIndex] && player.GetModPlayer<MHPlayerArmorSkill>().ChamBlessing >= 3)
            {
                npc.buffTime[buffIndex] += extendedDuration;
            }
            return base.ReApply(type, npc, time, buffIndex);
        }
    }
}

