using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class Bleed : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.debuff[Type] = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            if (npc.defense > 5)
            {
                npc.defense = npc.defDefense - 5;
            }
            else
            {
                npc.defense = 1;
            }
            int scaledmg = (int)(npc.lifeMax * 0.01);
            npc.lifeRegen -= 15 + scaledmg;

            for (int i = 0; i < 2; i++)
            {
                float Size = Main.rand.NextFloat(0.75f, 1.1f);
                int d = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Blood, 0, 0, 100, Color.Transparent, 0.7f);
                Main.dust[d].noGravity = true;
                Main.dust[d].noLight = false;
                Main.dust[d].fadeIn = 1f;
                Main.dust[d].velocity *= 0.6f;
            }
        }
    }
}


