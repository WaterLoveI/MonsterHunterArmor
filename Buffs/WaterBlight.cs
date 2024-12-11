using MHArmorSkills.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class WaterBlight : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.defDefense -= 5;
        }

        internal static void DrawEffects(NPC npc, ref Color drawColor)
        {
            for (int i = 0; i < 2; i++) // Adjust the number of dusts spawned
            {
                if (Main.rand.NextBool(5))
                {
                    int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<WaterblightDust>(), 0f, 0f, 0, Color.White, 1f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-1.5f, 1.5f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 180f)); // Random rotation for spread
                    spread *= 0.5f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
            }
        }
    }
}


