using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC.Bugs
{
    public class Hornetaur : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 3;
            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, drawModifiers);
        }

        public override void SetDefaults()
        {
            NPC.damage = 21;
            NPC.aiStyle = NPCAIStyleID.Fighter;
            NPC.width = 60;
            NPC.height = 30;
            NPC.defense = 15;
            NPC.lifeMax = 24;
            NPC.knockBackResist = 0.7f;
            AnimationType = NPCID.CorruptPenguin;
            AIType = NPCID.AnomuraFungus;
            NPC.value = Item.buyPrice(0, 0, 0, 90);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<HornetaurBanner>();
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.UndergroundJungle,
                new FlavorTextBestiaryInfoElement("Extremely territorial, Hornetaurs attack any who approach without mercy.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void AI()
        {
            if (NPC.life < (NPC.lifeMax / 3))
            {
                NPC.aiStyle = NPCAIStyleID.Unicorn;
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
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hornetaur1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hornetaur2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hornetaur2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Hornetaur3").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.PlayerSafe || spawnInfo.Water || !spawnInfo.Player.ZoneJungle || (!spawnInfo.Player.ZoneJungle && !spawnInfo.Player.ZoneDirtLayerHeight))
            {
                return 0f;
            }
            return 0.03f;
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterFluid>(), 12));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InsectShell>(), 12));
            if (Main.hardMode)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InsectCarapace>(), 12));
            }
        }
        public override void OnKill()
        {
            if ((NPC.HasBuff(BuffID.Poisoned) || NPC.HasBuff(BuffID.Venom)) && Main.rand.NextBool(2))
            {
                Item.NewItem(NPC.GetSource_Loot(), (int)NPC.position.X, (int)NPC.position.Y, NPC.width, NPC.height, ModContent.ItemType<MonsterFluid>());
            }
            if ((NPC.HasBuff(BuffID.Poisoned) || NPC.HasBuff(BuffID.Venom)) && Main.rand.NextBool(2))
            {
                Item.NewItem(NPC.GetSource_Loot(), (int)NPC.position.X, (int)NPC.position.Y, NPC.width, NPC.height, ModContent.ItemType<InsectShell>());
            }
            if ((NPC.HasBuff(BuffID.Poisoned) || NPC.HasBuff(BuffID.Venom)) && Main.rand.NextBool(2) && Main.hardMode)
            {
                Item.NewItem(NPC.GetSource_Loot(), (int)NPC.position.X, (int)NPC.position.Y, NPC.width, NPC.height, ModContent.ItemType<InsectCarapace>());
            }
        }
    }
}

