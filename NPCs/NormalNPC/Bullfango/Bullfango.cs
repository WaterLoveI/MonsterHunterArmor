using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using MHArmorSkills.NPCs.NormalNPC.Bugs;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC.Bullfango
{
    public class Bullfango : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 10;
            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, drawModifiers);
        }

        public override void SetDefaults()
        {
            NPC.damage = 13;
            NPC.aiStyle = NPCAIStyleID.Passive;
            NPC.width = 50;
            NPC.height = 28;
            NPC.defense = 3;
            NPC.lifeMax = 38;
            NPC.knockBackResist = 0.3f;
            AnimationType = NPCID.Hellhound;
            NPC.value = Item.buyPrice(0, 0, 2, 0);
            NPC.HitSound = SoundID.NPCHit27;
            NPC.DeathSound = SoundID.NPCDeath30;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<BullfangoBanner>();
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
                new FlavorTextBestiaryInfoElement("Large, wild boars with a foul temper. Fertile and wide-ranging.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void AI()
        {

            bool Hostile = false;

            for (int i = 0; i < Main.maxPlayers; i++)
            {
                Player player = Main.player[i];
                if (NPC.Distance(player.Center) < 200f)
                {
                    Hostile = true;
                }
            }

            if (NPC.life < NPC.lifeMax || Hostile == true)
            {
                NPC.aiStyle = NPCAIStyleID.Unicorn;
            }

            int oinkrate = 500;
            if (Hostile)
            {
                oinkrate = 200;
            }

            if (Main.rand.NextBool(oinkrate))
            {

                int oinksound = Main.rand.Next(3);
                switch (oinksound)
                {
                    case 0:
                        SoundEngine.PlaySound(SoundID.Zombie39, NPC.Center);
                        break;
                    case 1:
                        SoundEngine.PlaySound(SoundID.Zombie40, NPC.Center);
                        break;
                    case 2:
                        SoundEngine.PlaySound(SoundID.Zombie38, NPC.Center);
                        break;
                }
            }
        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hit.HitDirection, -1f, 0, default, 1f);
            }
            if (NPC.life <= 0)
            {
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hit.HitDirection, -1f, 0, default, 1f);
                }
                if (Main.netMode != NetmodeID.Server)
                {
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango3").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango3").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneSnow || spawnInfo.Player.ZoneJungle && !spawnInfo.Water &&
                (!spawnInfo.Player.ZoneTowerNebula && !spawnInfo.Player.ZoneTowerSolar && !spawnInfo.Player.ZoneTowerStardust &&
                !spawnInfo.Player.ZoneDungeon &&
                !spawnInfo.Player.ZoneTowerVortex &&
                !spawnInfo.PlayerInTown && !spawnInfo.Player.ZoneOldOneArmy && !Main.snowMoon && !Main.pumpkinMoon) ? 0.06f : 0f;
        }
        public override void OnSpawn(IEntitySource source)
        {

            for (int k = 0; k < 3; k++)
            {
                if (Main.rand.NextBool(2))
                {
                    if (NPC.CountNPCS(ModContent.NPCType<Bullfango>()) < 4)
                    {
                        int n = NPC.NewNPC(NPC.GetSource_FromAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<Bullfango>(), 0, NPC.whoAmI);
                        Main.npc[n].velocity.X = Main.rand.NextFloat(-1f, 1f);
                        Main.npc[n].velocity.Y = Main.rand.NextFloat(-1f, -1f);
                    }
                }
            }
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BullfangoMask>(), 50));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterBone>(), 4));
            npcLoot.Add(ItemDropRule.Common(ItemID.Leather, 5));
        }
    }
}
