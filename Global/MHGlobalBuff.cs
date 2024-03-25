using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public partial class MHGlobalBuffs : GlobalBuff
    {
        public override bool ReApply(int type, NPC npc, int time, int buffIndex)
        {
            //Player player = Main.player[npc.lastInteraction];
            //int extendedDuration = (int)(npc.buffTime[buffIndex] * player.GetModPlayer<MHPlayerArmorSkill>().SpiritAttack);

            // Set the buff time to the extended duration if it's larger than the current duration
            //if (extendedDuration > npc.buffTime[buffIndex])
            //{
            //    npc.buffTime[buffIndex] += extendedDuration;
            //}
            return base.ReApply(type, npc, time, buffIndex);
        }
    }
}

