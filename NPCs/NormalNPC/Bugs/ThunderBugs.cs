using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace MHArmorSkills.NPCs.NormalNPC.Bugs
{
    public class ThunderBugs : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 2;
        }

        public override void SetDefaults()
        {
            NPC.damage = 7;
            NPC.aiStyle = NPCAIStyleID.Firefly;
            NPC.width = 18;
            NPC.height = 18;
            NPC.defense = 5;
            NPC.lifeMax = 18;
            NPC.knockBackResist = 0.2f;
            AnimationType = NPCID.DemonEye;
            NPC.aiStyle = NPCAIStyleID.Bat;
            AIType = NPCID.Firefly;
            NPC.value = Item.buyPrice(0, 0, 0, 90);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<ThunderBugsBanner>();
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.UndergroundJungle,
                new FlavorTextBestiaryInfoElement("They are imbued with formidable electric powers. They congregate at night and in caves where the sunlight doesn't reach.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            for (int k = 0; k < 4; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, hit.HitDirection, -1f, 0, default, 1f);
            }
            if (NPC.life <= 0)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    for (int k = 0; k < 12; k++)
                    {
                        Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, hit.HitDirection, -1f, 0, default, 1f);
                    }
                }
            }
        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.PlayerSafe || !spawnInfo.Player.ZoneJungle || (!spawnInfo.Player.ZoneJungle && !spawnInfo.Player.ZoneDirtLayerHeight) || !NPC.downedBoss1)
            {
                return 0f;
            }
            return SpawnCondition.OverworldNightMonster.Chance * 0.04f;
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            if (hurtInfo.Damage > 0 && Main.rand.NextBool(4))
                target.AddBuff(BuffID.Electrified, 5 * 60, true);
        }

        public override void AI()
        {
            Lighting.AddLight(NPC.Center, 0.15f, (255 - NPC.alpha) * 1f / 255f, (255 - NPC.alpha) * 1f / 255f);
            if (Main.rand.NextBool(60))
            {
                for (int k = 0; k < 3; k++)
                {
                    Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Electric, NPC.direction, -1f, 0, default, 1f);
                }
            }
            float maxVelocity = 1.5f;
            float acceleration = 0.1f;
            bool Hostile = false;

            for (int i = 0; i < Main.maxPlayers; i++)
            {
                Player player = Main.player[i];
                if (NPC.Distance(player.Center) < 500f)
                {
                    Hostile = true;
                    maxVelocity += (4f) - ((Main.player[NPC.target].Center - NPC.Center).Length() * 0.01f);
                }
            }
            if (NPC.velocity.X < -maxVelocity || NPC.velocity.X > maxVelocity)
            {
                if (NPC.velocity.Y == 0f)
                    NPC.velocity *= 0.7f;
            }
            else if (NPC.velocity.X < maxVelocity && NPC.direction == 1)
            {
                NPC.velocity.X = NPC.velocity.X + acceleration;
                if (NPC.velocity.X > maxVelocity)
                    NPC.velocity.X = maxVelocity;
            }
            else if (NPC.velocity.X > -maxVelocity && NPC.direction == -1)
            {
                NPC.velocity.X = NPC.velocity.X - acceleration;
                if (NPC.velocity.X < -maxVelocity)
                    NPC.velocity.X = -maxVelocity;
            }
            if (NPC.life < NPC.lifeMax || Hostile == true)
            {
                NPC.aiStyle = NPCAIStyleID.DemonEye;
            }
        }



        public override void OnSpawn(IEntitySource source)
        {
            
            for (int k = 0; k < 3; k++)
            {
                if (Main.rand.NextBool(2))
                {
                    if (NPC.CountNPCS(ModContent.NPCType<ThunderBugs>()) < 10)
                    {
                        int n = NPC.NewNPC(NPC.GetSource_FromAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<ThunderBugs>(), 0, NPC.whoAmI);
                        Main.npc[n].velocity.X = Main.rand.NextFloat(-0.7f, 0.6f);
                        Main.npc[n].velocity.Y = Main.rand.NextFloat(-0.7f, -0.07f);
                    }
                }
            }
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterFluid>(), 12));

        }
        public override void PostDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
        {
            // Draw glowmask.
            Texture2D tex = ModContent.Request<Texture2D>("MHArmorSkills/NPCs/NormalNPC/Bugs/ThunderBugs_Glow").Value;

            var effects = NPC.direction == -1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;

            Main.EntitySpriteDraw(tex, NPC.Center - Main.screenPosition + new Vector2(0, NPC.gfxOffY + 4),
            NPC.frame, Color.White * 0.5f, NPC.rotation, NPC.frame.Size() / 2f, NPC.scale, effects, 0);
        }
    }
}
