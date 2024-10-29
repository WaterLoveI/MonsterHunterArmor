using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Buffs.SharpnessBuff;
using MHArmorSkills.MHPlayer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
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

        public override bool PreDraw(SpriteBatch spriteBatch, int type, int buffIndex, ref BuffDrawParams drawParams)
        {
            // make blastblight shake
            Player player = Main.LocalPlayer;
            if (type == ModContent.BuffType<BlastBlight>() && player.GetModPlayer<Debuffs>().BlastTimer == 3)
            {
                Vector2 shake = new Vector2(Main.rand.Next(-3, 4), Main.rand.Next(-3, 4));

                drawParams.Position += shake;
                drawParams.TextPosition += shake;
            }
            if (type == ModContent.BuffType<RedScroll>() && player.GetModPlayer<ScrollSwapPlayer>().FuriousCount >= 60)
            {
                Vector2 shake = new Vector2(Main.rand.Next(-1, 2), Main.rand.Next(-1, 2));

                drawParams.Position += shake;
                drawParams.TextPosition += shake;
            }
            if (type == ModContent.BuffType<SharpnessRed>() || type == ModContent.BuffType<SharpnessYellow>() || type == ModContent.BuffType<SharpnessGreen>() || type == ModContent.BuffType<SharpnessBlue>() || type == ModContent.BuffType<SharpnessWhite>() || type == ModContent.BuffType<SharpnessPurple>())
            {
                if (player.GetModPlayer<SharpnessPlayer>().SharpnessLossAnimation)
                {
                    Vector2 shake = new Vector2(Main.rand.Next(-3, 4), Main.rand.Next(-3, 4));

                    drawParams.Position += shake;
                    drawParams.TextPosition += shake;
                }
                
            }

            return true;
        }
    }
}

