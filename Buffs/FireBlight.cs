using MHArmorSkills.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class FireBlight : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = true;
        }
        internal static void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (Main.rand.NextBool(2))
            {
                int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<FireblightDust>(), 0f, 0f, 0, Color.White, 1f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-1.5f, 1.5f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                spread *= 0.5f; // Adjust the spread distance
                Main.dust[dust].velocity = spread;
                Main.dust[dust].noGravity = true;
            }
        }
    }
}


