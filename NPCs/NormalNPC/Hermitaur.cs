using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC
{
    public class Hermitaur : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, drawModifiers);
        }

        public override void SetDefaults()
        {
            NPC.damage = 19;
            NPC.aiStyle = NPCAIStyleID.Fighter;
            NPC.width = 50;
            NPC.height = 46;
            NPC.defense = 20;
            NPC.lifeMax = 35;
            NPC.knockBackResist = 0.1f;
            AnimationType = NPCID.GiantShelly;
            AIType = NPCID.AnomuraFungus;
            NPC.value = Item.buyPrice(0, 0, 1, 10);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<HermitaurBanner>();
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Ocean,
                new FlavorTextBestiaryInfoElement("Small hard-shelled Carapaceons. Their brains are regarded as a delicacy in some regions.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void OnKill()
        {
            Player player = Main.LocalPlayer;
            if (NPC.Distance(player.Center) > 240f)
            {
                int bubblecount = 6;
                if (Main.hardMode || Main.expertMode)
                {
                    bubblecount = 12;
                }
                for (int k = 0; k < bubblecount; k++)
                {
                    if (Main.rand.NextBool(2))
                    {
                        int n = NPC.NewNPC(NPC.GetSource_FromAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<BubblesNPC>(), NPC.whoAmI);
                        Main.npc[n].velocity.X = Main.rand.NextFloat(-1f, 1f);
                        Main.npc[n].velocity.Y = Main.rand.NextFloat(-1f, -1f);
                    }
                }
            }
        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Water, hit.HitDirection, -1f, 0, default, 1f);
            }
            Player player = Main.LocalPlayer;
            if (NPC.Distance(player.Center) > 240f)
            {
                if (Main.hardMode || Main.expertMode)
                {
                    if (!Main.rand.NextBool(3))
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (Main.rand.NextBool(2))
                            {
                                int n = NPC.NewNPC(NPC.GetSource_FromAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<BubblesNPC>(), 0, NPC.whoAmI);
                                Main.npc[n].velocity.X = Main.rand.NextFloat(-1f, 1f);
                                Main.npc[n].velocity.Y = Main.rand.NextFloat(-1f, -1f);
                            }
                        }
                    }

                }
            }
            if (NPC.life <= 0)
            {
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Water, hit.HitDirection, -1f, 0, default, 1f);
                }
                if (Main.netMode != NetmodeID.Server)
                {
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hermitaur1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hermitaur1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hermitaur2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hermitaur3").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.PlayerSafe || !spawnInfo.Player.ZoneBeach || (!spawnInfo.Player.ZoneDesert && spawnInfo.Water))
            {
                return 0f;
            }
            return 0.02f;
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ItemID.WhitePearl, 5));
            npcLoot.Add(ItemDropRule.Common(ItemID.BlackPearl, 10));
            npcLoot.Add(ItemDropRule.Common(ItemID.PinkPearl, 20));
        }
    }
}

