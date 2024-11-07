using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using MHArmorSkills.Projectiles.Enemy;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC.Remobra
{
    public class Remobra : ModNPC
    {

        public int spitcooldown = 45;
        public bool checkedRotationDir = false;
        public int rotationDir;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
        }

        public override void SetDefaults()
        {
            NPC.damage = 19;
            NPC.aiStyle = NPCAIStyleID.Flying;
            AIType = NPCID.EaterofSouls;
            NPC.noGravity = true;
            NPC.width = 56;
            NPC.height = 52;
            NPC.defense = 3;
            NPC.lifeMax = 45;
            NPC.knockBackResist = 0.8f;
            AnimationType = NPCID.FlyingSnake;
            NPC.value = Item.buyPrice(0, 0, 1, 0);
            NPC.HitSound = SoundID.NPCHit27;
            NPC.DeathSound = SoundID.NPCDeath30;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<RemobraBanner>();
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheCorruption,
                new FlavorTextBestiaryInfoElement("Small wyverns with outstanding flying abilities, they loiter in the skies waiting to prey upon weakened animals.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void AI()
        {


            // Shoot a proj if within 20 tiles of its target and if its above the player
            Player player = Main.player[NPC.target];
            if (NPC.target < 0 || NPC.target == Main.maxPlayers || player.dead || !player.active)
                NPC.TargetClosest(true);

            AIMovement(player);

            float distToTarget = NPC.Distance(player.Center) + .1f;
            // When it's not dashing, it'll just look at the player normally.
            // When it is dashing, so it's not unfair, it'll be slower when it's closer to the player.
            NPC.rotation = NPC.rotation.AngleTowards(NPC.AngleTo(player.Center), .3f);

            if (Vector2.Distance(player.Center, NPC.Center) < 320f && NPC.Center.Y < player.Center.Y && Main.rand.NextBool(300) && spitcooldown == 0)
            {
                ShootSpit(player);
                spitcooldown = 45;
            }
            spitcooldown--;
            if (player.statLife < player.statLifeMax2 / 3 || NPC.life < NPC.lifeMax / 2)
            {
                NPC.aiStyle = NPCAIStyleID.Flying;
                AIType = NPCID.EaterofSouls;
            }
            
        }
        public void AIMovement(Player player)
        {
            // Randomly chooses to go clockwise or anti-clockwise around the player.
            if (!checkedRotationDir)
            {
                rotationDir = (Main.rand.NextBool()).ToDirectionInt();
                checkedRotationDir = true;
                NPC.netUpdate = true;
            }


            NPC.netUpdate = true;
        }

        private void ShootSpit(Player target)
        {
            SoundEngine.PlaySound(SoundID.Item17, NPC.Center);
            Vector2 vector = Main.player[NPC.target].Center - NPC.Center;
            vector.Normalize();
            // no idea why the projectile damage is higher than expected
            Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center + (NPC.Center.X < target.Center.X ? -7f : 7f) * Vector2.UnitX, vector * 9f, ModContent.ProjectileType<PoisonSpit>(), 7, 0f, Main.myPlayer);

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
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Remobra1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Remobra2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Remobra3").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.Player.ZoneCorrupt && spawnInfo.Player.ZoneOverworldHeight || spawnInfo.Player.ZoneCrimson && spawnInfo.Player.ZoneOverworldHeight || spawnInfo.Player.ZoneDesert && spawnInfo.Player.ZoneOverworldHeight)
            {
                return 0.05f;
            }
            return 0f;
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RemobraHeadgear>(), 5));
        }
    }
}
