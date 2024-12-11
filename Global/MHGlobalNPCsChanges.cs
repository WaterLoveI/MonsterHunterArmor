using MHArmorSkills.Buffs;
using MHArmorSkills.Dusts;
using MHArmorSkills.MHPlayer;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Global
{
    public class MHGlobalNPCsChanges : GlobalNPC
    {


        public override void SetDefaults(NPC entity)
        {
            if (!(entity.realLife == -1))
            {
                NPCID.Sets.SpecificDebuffImmunity[entity.type][ModContent.BuffType<FireBlight>()] = true;
                NPCID.Sets.SpecificDebuffImmunity[entity.type][ModContent.BuffType<WaterBlight>()] = true;
                NPCID.Sets.SpecificDebuffImmunity[entity.type][ModContent.BuffType<ThunderBlight>()] = true;
                NPCID.Sets.SpecificDebuffImmunity[entity.type][ModContent.BuffType<IceBlight>()] = true;
            }
        }


        public override void HitEffect(NPC npc, NPC.HitInfo hit)
        {
            #region Blight Effect
            if (npc.HasBuff(ModContent.BuffType<FireBlight>()))
            {
                for (int i = 0; i < 6; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<FireblightDust>(), 1.5f, 0f, 0, Color.White, 1.2f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 0.7f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                    Main.dust[dust].noGravity = true;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<IceBlight>()))
            {
                for (int i = 0; i < 6; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(npc.position, npc.width + 6, npc.height + 7, ModContent.DustType<IceblightDust>(), 1.5f, 0f, 0, Color.White, 0.7f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 0.7f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                for (int i = 0; i < 6; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<WaterblightDust>(), 1.5f, 0f, 0, Color.White, 1.1f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 180f)); // Random rotation for spread
                    spread *= 0.7f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                for (int i = 0; i < 6; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(npc.position, npc.width + 10, npc.height + 10, DustID.Electric, 1.5f, 0f, 0, Color.DarkRed, 0.7f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1.3f, 1.3f), Main.rand.NextFloat(-1.3f, 1.3f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 0.9f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                    Main.dust[dust].noGravity = true;
                }
            }
            #endregion
        }
        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (npc.HasBuff(ModContent.BuffType<FireBlight>()))
            {
                FireBlight.DrawEffects(npc, ref drawColor);
            }
            if (npc.HasBuff(ModContent.BuffType<IceBlight>()))
            {
                IceBlight.DrawEffects(npc, ref drawColor);
            }
            if (npc.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                WaterBlight.DrawEffects(npc, ref drawColor);
            }
            if (npc.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                ThunderBlight.DrawEffects(npc, ref drawColor);
            }
        }




        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (npc.HasBuff(ModContent.BuffType<FireBlight>()))
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int elementdamage = 0;

                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (!Main.player[i].active)

                        continue;

                    ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                    if (elementsPlayer.FinalFireElement > elementdamage)
                    {
                        elementdamage = (int)(elementsPlayer.FinalFireElement * 1.5f);
                    }
                    if (npc.HasBuff(BuffID.Oiled))
                    {
                        elementdamage *= 2;
                    }
                }
                npc.lifeRegen -= elementdamage * 2;
                if (damage < elementdamage)
                {
                    damage = elementdamage;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<IceBlight>()))
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int elementdamage = 0;

                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (!Main.player[i].active)

                        continue;

                    ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                    if (elementsPlayer.FinalIceElement > elementdamage)
                    {
                        elementdamage = (int)(elementsPlayer.FinalIceElement * 0.9f);
                    }
                }
                npc.lifeRegen -= elementdamage * 2;
                if (damage < elementdamage)
                {
                    damage = elementdamage;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int elementdamage = 0;

                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (!Main.player[i].active)

                        continue;

                    ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                    if (elementsPlayer.FinalWaterElement > elementdamage)
                    {
                        elementdamage = (int)(elementsPlayer.FinalWaterElement);
                    }
                }
                npc.lifeRegen -= elementdamage * 2;
                if (damage < elementdamage)
                {
                    damage = elementdamage;
                }
            }
            if (npc.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int elementdamage = 0;

                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    if (!Main.player[i].active)

                        continue;

                    ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                    if (elementsPlayer.FinalThunderElement > elementdamage)
                    {
                        elementdamage = (int)(elementsPlayer.FinalThunderElement * 1.1f);
                    }
                }
                npc.lifeRegen -= elementdamage * 2;
                if (damage < elementdamage)
                {
                    damage = elementdamage;
                }
            }
        }
    }
}
