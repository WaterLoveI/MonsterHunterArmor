using MHArmorSkills.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class ThunderBlight : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = true;
        }
        internal static void DrawEffects(NPC npc, ref Color drawColor)
        {
            for (int i = 0; i < 2; i++) // Adjust the number of dusts spawned
            {
                int dust = Dust.NewDust(npc.position, npc.width + 10, npc.height + 10, DustID.Electric, 0f, 0f, 0, Color.DarkRed, 0.4f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                spread *= 0.8f; // Adjust the spread distance
                Main.dust[dust].velocity = spread;
                Main.dust[dust].noGravity = true;
            }
        }
    }
}


