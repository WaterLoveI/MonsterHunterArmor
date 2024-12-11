using MHArmorSkills.Buffs;
using MHArmorSkills.Dusts;
using MHArmorSkills.MHPlayer;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Global
{
    public class MHGlobalNPCsDebuffs : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public int FireBlightCounter = 0;
        public int IceBlightCounter = 0;
        public int WaterBlightCounter = 0;
        public int ThunderBlightCounter = 0;


        
        public override void OnHitByItem(NPC npc, Player player, Item item, NPC.HitInfo hit, int damageDone)
        {
            ElementsPlayer ElementsPlayer = player.GetModPlayer<ElementsPlayer>();
            

            int EleCap = 20;
            for (int i = 0; i < Main.maxPlayers; i++)
            {
                if (!Main.player[i].active)

                    continue;

                EleCap += 20;

            }
            int ElementTimer = 0;
            bool Blighted = true;
            if (!npc.HasBuff(ModContent.BuffType<FireBlight>()) && !npc.HasBuff(ModContent.BuffType<IceBlight>()) && !npc.HasBuff(ModContent.BuffType<ThunderBlight>()) && !npc.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                Blighted = false;
            }

            if (player.HeldItem != null && !Blighted)
            {
                int HasItem = player.HeldItem.type;
                if (MHLists.fireelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    FireBlightCounter += (int)(ElementsPlayer.FinalFireElement / 2);
                    for (int i = 0; i < 5; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<FireblightDust>(), 0.5f, 0f, 0, Color.White, 1.2f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                        Main.dust[dust].noGravity = true;
                    }
                }
                if (MHLists.iceelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    IceBlightCounter += (int)(ElementsPlayer.FinalIceElement / 2);
                    for (int i = 0; i < 3; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 6, npc.height + 7, ModContent.DustType<IceblightDust>(), 0.5f, 0f, 0, Color.White, 0.7f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                }
                if (MHLists.waterelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    WaterBlightCounter += (int)(ElementsPlayer.FinalWaterElement / 2);
                    for (int i = 0; i < 2; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<WaterblightDust>(), 0.5f, 0f, 0, Color.White, 1.1f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 180f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                }
                if (MHLists.thunderelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    ThunderBlightCounter += (int)(ElementsPlayer.FinalThunderElement / 2);
                    for (int i = 0; i < 3; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 10, npc.height + 10, DustID.Electric, 0.5f, 0f, 0, Color.DarkRed, 0.7f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1.3f, 1.3f), Main.rand.NextFloat(-1.3f, 1.3f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.9f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                        Main.dust[dust].noGravity = true;
                    }
                }
                if (FireBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalFireElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalFireElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<FireBlight>(), (ElementTimer) * 60);
                    FireBlightCounter = 0;
                }
                if (WaterBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalWaterElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalWaterElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<WaterBlight>(), (ElementTimer) * 60);
                    WaterBlightCounter = 0;
                }
                if (IceBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalIceElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalIceElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<IceBlight>(), (ElementTimer) * 60);
                    IceBlightCounter = 0;
                }
                if (ThunderBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalThunderElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalThunderElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<ThunderBlight>(), (ElementTimer) * 60);
                    ThunderBlightCounter = 0;
                }
            }
            
        }

        public override void OnHitByProjectile(NPC npc, Projectile projectile, NPC.HitInfo hit, int damageDone)
        {
            Player player = Main.player[npc.lastInteraction];
            ElementsPlayer ElementsPlayer = player.GetModPlayer<ElementsPlayer>();
            

            int EleCap = 40;
            for (int i = 0; i < Main.maxPlayers; i++)
            {
                if (!Main.player[i].active)

                    continue;

                EleCap += 20;

            }
            int ElementTimer = 0;
            bool Blighted = true;
            if (!npc.HasBuff(ModContent.BuffType<FireBlight>()) && !npc.HasBuff(ModContent.BuffType<IceBlight>()) && !npc.HasBuff(ModContent.BuffType<ThunderBlight>()) && !npc.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                Blighted = false;
            }

            if (player.HeldItem != null && !Blighted)
            {
                int HasItem = player.HeldItem.type;
                if (MHLists.fireelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    FireBlightCounter += (int)(ElementsPlayer.FinalFireElement / 3);
                    for (int i = 0; i < 5; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<FireblightDust>(), 0.5f, 0f, 0, Color.White, 1.2f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                        Main.dust[dust].noGravity = true;
                    }
                }
                if (MHLists.iceelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    IceBlightCounter += (int)(ElementsPlayer.FinalIceElement / 3);
                    for (int i = 0; i < 5; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 6, npc.height + 7, ModContent.DustType<IceblightDust>(), 0.5f, 0f, 0, Color.White, 0.7f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                }
                if (MHLists.waterelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    WaterBlightCounter += (int)(ElementsPlayer.FinalWaterElement / 3);
                    for (int i = 0; i < 5; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 4, npc.height + 3, ModContent.DustType<WaterblightDust>(), 0.5f, 0f, 0, Color.White, 1.1f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-2f, 2f), Main.rand.NextFloat(-2f, 2f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 180f)); // Random rotation for spread
                        spread *= 0.7f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                }
                if (MHLists.thunderelementList.Contains(HasItem) && Main.rand.NextBool(3))
                {
                    ThunderBlightCounter += (int)(ElementsPlayer.FinalThunderElement / 3);
                    for (int i = 0; i < 5; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(npc.position, npc.width + 10, npc.height + 10, DustID.Electric, 0.5f, 0f, 0, Color.DarkRed, 0.7f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1.3f, 1.3f), Main.rand.NextFloat(-1.3f, 1.3f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 0.9f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                        Main.dust[dust].noGravity = true;
                    }
                }
                if (FireBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalFireElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalFireElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<FireBlight>(), (ElementTimer) * 60);
                    FireBlightCounter = 0;
                }
                if (WaterBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalWaterElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalWaterElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<WaterBlight>(), (ElementTimer) * 60);
                    WaterBlightCounter = 0;
                }
                if (IceBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalIceElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalIceElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<IceBlight>(), (ElementTimer) * 60);
                    IceBlightCounter = 0;
                }
                if (ThunderBlightCounter >= EleCap)
                {
                    for (int i = 0; i < Main.maxPlayers; i++)
                    {
                        if (!Main.player[i].active)

                            continue;

                        ElementsPlayer elementsPlayer = Main.player[i].GetModPlayer<ElementsPlayer>();
                        if (elementsPlayer.FinalThunderElement > ElementTimer)
                        {
                            ElementTimer = elementsPlayer.FinalThunderElement;
                        }

                    }
                    npc.AddBuff(ModContent.BuffType<ThunderBlight>(), (ElementTimer) * 60);
                    ThunderBlightCounter = 0;
                }
            }
            
        }
    }
}
