using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Placeables.Banners;
using MHArmorSkills.NPCs.NormalNPC.Bugs;
using MHArmorSkills.Utilities;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace MHArmorSkills.NPCs.NormalNPC.Delex
{
    public class Delex : ModNPC
    {
        public Player Target => Main.player[NPC.target];

        public ref float VerticalMovementDirection => ref NPC.ai[0];

        public ref float ChargeDelay => ref NPC.ai[2];


        public int TimeBetweenCharges = 60*5;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
        }

        public override void SetDefaults()
        {
            
            NPC.noTileCollide = true;
            NPC.damage = 21;
            NPC.width = 118;
            NPC.height = 55;
            NPC.defense = 3;
            NPC.lifeMax = 45;
            NPC.knockBackResist = 0.3f;
            AnimationType = NPCID.SandShark;
            NPC.value = Item.buyPrice(0, 0, 2, 0);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = NPC.type;
            BannerItem = ModContent.ItemType<DelexBanner>();
            NPC.noGravity = true;
            NPC.behindTiles = true;
            NPCID.Sets.TrailCacheLength[NPC.type] = 8;
            NPCID.Sets.TrailingMode[NPC.type] = 1;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Desert,
                new FlavorTextBestiaryInfoElement("Carnivorous monsters that inhabit deserts. Delex always travel in schools of five or six.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public static bool ValidMovementPosition(Tile tile)
        {
            return tile.HasUnactuatedTile;
        }
        public override void AI()
        {
            if (Main.rand.NextBool(200))
            {
                SoundEngine.PlaySound(SoundID.Zombie7, NPC.Center);
            }
            if (NPC.life <= (NPC.lifeMax / 2))
            {
                TimeBetweenCharges = 60 * 3;
            }
            // Initialize direction if necessary by getting an initial target.
            if (NPC.direction == 0)
                NPC.TargetClosest(true);

            Point tileCheckPoint = NPC.Bottom.ToTileCoordinates();
            Tile checkTile = Framing.GetTileSafely(tileCheckPoint);
            bool canMoveFreely = ValidMovementPosition(checkTile);
            canMoveFreely |= NPC.wet;
            NPC.TargetClosest();

            Vector2 targetCenter = NPC.targetRect.Center.ToVector2();
            float distanceFromTarget = NPC.Distance(targetCenter);
            bool attemptingToAttackTarget = Target.velocity.Y > -0.1f && !Target.dead && distanceFromTarget > 150f;

            if (canMoveFreely)
            {

                tileCheckPoint = (NPC.Center + Vector2.UnitY * 24f).ToTileCoordinates();
                checkTile = Framing.GetTileSafely(tileCheckPoint.X, tileCheckPoint.Y - 2);
                bool belowSand = ValidMovementPosition(checkTile);

                // Increment the charge delay.
                if (ChargeDelay < TimeBetweenCharges / 2)
                    ChargeDelay++;

                // Move towards the target and lunge at them, releasing meteors.
                if (attemptingToAttackTarget)
                {
                    NPC.TargetClosest(true);
                    NPC.velocity += new Vector2(NPC.direction, NPC.directionY) * 0.12f;
                    NPC.velocity.X = MathHelper.Clamp(NPC.velocity.X, -6f, 6f);
                    NPC.velocity.Y = MathHelper.Clamp(NPC.velocity.Y, -3f, 3f);

                    Vector2 aheadPosition = NPC.Center + NPC.velocity.SafeNormalize(Vector2.Zero) * NPC.Size.Length() * 2f + NPC.velocity;
                    tileCheckPoint = aheadPosition.ToTileCoordinates();
                    checkTile = Framing.GetTileSafely(tileCheckPoint);
                    bool shouldntCharge = ValidMovementPosition(checkTile);
                    if (!shouldntCharge && NPC.wet)
                        shouldntCharge = checkTile.LiquidAmount > 0;

                    if (!shouldntCharge && Math.Sign(NPC.velocity.X) == NPC.direction && distanceFromTarget < 540f && (ChargeDelay >= TimeBetweenCharges / 2 || ChargeDelay < 0f))
                    {
                        ChargeDelay = -TimeBetweenCharges / 2;
                        NPC.velocity = NPC.SafeDirectionTo(targetCenter - Vector2.UnitY * 80f) * 16f;
                        NPC.netUpdate = true;
                    }
                }
                else
                {
                    // Rebound on collision.
                    if (NPC.collideX)
                    {
                        NPC.velocity.X *= -1f;
                        NPC.direction *= -1;
                        NPC.netUpdate = true;
                    }
                    if (NPC.collideY)
                    {
                        NPC.netUpdate = true;
                        NPC.velocity.Y *= -1f;
                        NPC.directionY = Math.Sign(NPC.velocity.Y);
                        VerticalMovementDirection = NPC.directionY;
                    }

                    // Accelerate in the current direction.
                    // If the speed is too high, exponentially decelerate.
                    float movementDirectionSwitchThreshold = 0.05f;
                    float horizontalSearchAcceleration = 0.1f;
                    float horizontalSearchMaxSpeed = 6f;
                    float verticalSearchAcceleration = 0.01f;
                    float verticalSearchMaxSpeed = 0.5f;
                    VerticalMovementDirection = (!belowSand).ToDirectionInt();
                    NPC.velocity.X += NPC.direction * horizontalSearchAcceleration;
                    if (Math.Abs(NPC.velocity.X) > horizontalSearchMaxSpeed)
                        NPC.velocity.X *= 0.95f;

                    if (VerticalMovementDirection == -1f)
                    {
                        NPC.velocity.Y = NPC.velocity.Y - verticalSearchAcceleration;
                        if (NPC.velocity.Y < -movementDirectionSwitchThreshold)
                            VerticalMovementDirection = 1f;
                    }
                    else
                    {
                        NPC.velocity.Y += verticalSearchAcceleration;
                        if (NPC.velocity.Y > movementDirectionSwitchThreshold)
                            VerticalMovementDirection = -1f;
                    }
                    if (Math.Abs(NPC.velocity.Y) > verticalSearchMaxSpeed)
                        NPC.velocity.Y *= 0.95f;
                }
            }
            else
            {
                if (NPC.velocity.Y == 0f)
                {
                    // Search for any potential closer targets if attempting to attack.
                    if (attemptingToAttackTarget)
                        NPC.TargetClosest(true);

                    // Accelerate in the current direction.
                    // If the speed is too high, exponentially decelerate.
                    NPC.velocity.X += 0.1f;
                    if (Math.Abs(NPC.velocity.X) > 1f)
                        NPC.velocity.X *= 0.95f;
                }

                // Fall downward.
                NPC.velocity.Y += 0.3f;
                if (NPC.velocity.Y > 12f)
                    NPC.velocity.Y = 12f;
                VerticalMovementDirection = 1f;
            }
            NPC.rotation = MathHelper.Clamp(NPC.velocity.Y * NPC.direction * 0.1f, -0.2f, 0.2f);
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
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Delex1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Delex2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Delex3").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Delex4").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.PlayerSafe || !spawnInfo.Player.ZoneDesert || !NPC.downedBoss2 || !spawnInfo.Player.ZoneOverworldHeight)
            {
                return 0f;
            }
            return 0.03f;
        }

        public override void OnSpawn(IEntitySource source)
        {

            for (int k = 0; k < 2; k++)
            {
                if (Main.rand.NextBool(2))
                {
                    if (NPC.CountNPCS(ModContent.NPCType<Delex>()) < 4)
                    {
                        int n = NPC.NewNPC(NPC.GetSource_FromAI(), (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<Delex>(), 0, NPC.whoAmI);
                        Main.npc[n].velocity.X = Main.rand.NextFloat(-1f, 1f);
                        Main.npc[n].velocity.Y = Main.rand.NextFloat(-1f, -1f);
                    }
                }
            }
        }
        
    }
}
