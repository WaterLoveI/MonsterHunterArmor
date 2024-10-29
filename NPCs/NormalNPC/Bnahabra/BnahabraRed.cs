using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using MHArmorSkills.Projectiles.Enemy;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC.Bnahabra
{
    public class BnahabraRed : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 2;
        }

        public override void SetDefaults()
        {
            NPC.damage = 12;
            NPC.aiStyle = NPCAIStyleID.Flying;
            NPC.width = 50;
            NPC.height = 28;
            NPC.defense = 5;
            NPC.lifeMax = 32;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.MossHornet;
            NPC.aiStyle = NPCAIStyleID.Bat;
            AIType = NPCID.MossHornet;
            NPC.value = Item.buyPrice(0, 0, 1, 80);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = ModContent.NPCType<BnahabraRed>();
            BannerItem = ModContent.ItemType<BnahabraRedBanner>();
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
                new FlavorTextBestiaryInfoElement("Pervasive flying insects that attack invaders with paralyzing venom and lay eggs in carrion along with a fluid that hastens decomposition.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            if (NPC.life <= 0)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("BnahabraRed1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("BnahabraRed2").Type, 1f);
                }
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneJungle && !spawnInfo.Water &&
                (!spawnInfo.Player.ZoneTowerNebula && !spawnInfo.Player.ZoneTowerSolar && !spawnInfo.Player.ZoneTowerStardust &&
                !spawnInfo.Player.ZoneDungeon &&
                !spawnInfo.Player.ZoneTowerVortex &&
                !spawnInfo.PlayerInTown && !spawnInfo.Player.ZoneOldOneArmy && !Main.snowMoon && !Main.pumpkinMoon) ? 0.03f : 0f;
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            if (hurtInfo.Damage > 0)
                target.AddBuff(BuffID.Slow, 180, true);
        }

        public override void AI()
        {
            // Shoot a proj if within 20 tiles of its target and if its above the player
            Player player = Main.player[NPC.target];
            if (Vector2.Distance(player.Center, NPC.Center) < 320f && NPC.Center.Y < player.Center.Y && Main.rand.NextBool(600)) 
            {
                ShootSpit(player);
            }
        }

        private void ShootSpit(Player target)
        {
            SoundEngine.PlaySound(SoundID.Item17, NPC.Center);
            Vector2 vector = Main.player[NPC.target].Center - NPC.Center;
            vector.Normalize();
            // no idea why the projectile damage is higher than expected
            Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center + (NPC.Center.X < target.Center.X ? -7f : 7f) * Vector2.UnitX, vector * 7f, ModContent.ProjectileType<BnahabraSpit>(), 7, 0f, Main.myPlayer);

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
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InsectShell>(), 10));
            npcLoot.Add(ItemDropRule.Common(ItemID.Stinger, 3));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterFluid>(), 10));
            if (Main.hardMode)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<InsectCarapace>(), 10));
            }
        }
    }
}
