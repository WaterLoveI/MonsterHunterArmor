using MHArmorSkills.Buffs;
using MHArmorSkills.Projectiles.Enemy;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Bestiary;
using Terraria.Graphics.CameraModifiers;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.Seltas
{
    [AutoloadBossHead]
    public class Seltas : ModNPC
    {
        public bool SecondStage
        {
            get => NPC.ai[0] == 1f;
            set => NPC.ai[0] = value ? 1f : 0f;
        }
        private const int FirstStageTimerMax = 300;
        public ref float FirstStageTimer => ref NPC.localAI[1];
        public  int AttackCooldown = 0;
        private const int CooldownCap = 90;
        private bool exhaust = false;

        public int stamina = 50;
        public int exhausttimer = 0;
        public ref float SecondStageTimer_SpawnEyes => ref NPC.localAI[3];
        public Vector2 FirstStageDestination
        {
            get => new Vector2(NPC.ai[1], NPC.ai[2]);
            set
            {
                NPC.ai[1] = value.X;
                NPC.ai[2] = value.Y;
            }
        }
        public Vector2 LastFirstStageDestination { get; set; } = Vector2.Zero;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 4;
            // Add this in for bosses that have a summon item, requires corresponding code in the item (See MinionBossSummonItem.cs)
            NPCID.Sets.MPAllowedEnemies[Type] = true;
            // Automatically group with other bosses
            NPCID.Sets.BossBestiaryPriority.Add(Type);
            NPCID.Sets.SpecificDebuffImmunity[Type][BuffID.Confused] = true;
        }

        public override void SetDefaults()
        {
            NPC.damage = 28;
            NPC.width = 50;
            NPC.height = 28;
            NPC.defense = 7;
            NPC.lifeMax = 1500;
            NPC.knockBackResist = 0f;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.value = Item.buyPrice(0, 0, 1, 80);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.aiStyle = -1;
            NPC.boss = true;
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Jungle,
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Snow,
                new FlavorTextBestiaryInfoElement("Pervasive flying insects that attack invaders with paralyzing venom and lay eggs in carrion along with a fluid that hastens decomposition.")
            });
        }

        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write(FirstStageTimer);
            writer.Write(stamina);
            writer.Write(exhausttimer);
            writer.Write(AttackCooldown);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            FirstStageTimer = reader.ReadSingle();
            stamina = reader.ReadInt32();
            exhausttimer = reader.ReadInt32();
            AttackCooldown = reader.ReadInt32();
        }
        public override void FindFrame(int frameHeight)
        {


            // This NPC animates with a simple "go from start frame to final frame, and loop back to start frame" rule
            // In this case: First stage: 0-1-2-0-1-2, Second stage: 3-4-5-3-4-5, 5 being "total frame count - 1"
            int startFrame = 0;
            int finalFrame = 3;



            int frameSpeed = 5;
            NPC.frameCounter += 0.5f;
            NPC.frameCounter += NPC.velocity.Length() / 10f; // Make the counter go faster with more movement speed
            if (NPC.frameCounter > frameSpeed)
            {
                NPC.frameCounter = 0;
                NPC.frame.Y += frameHeight;

                if (NPC.frame.Y > finalFrame * frameHeight)
                {
                    NPC.frame.Y = startFrame * frameHeight;
                }
            }

            NPC.spriteDirection = NPC.direction;

        }




        public override void AI()
        {
            if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || !Main.player[NPC.target].active)
            {
                NPC.TargetClosest();
            }

            Player player = Main.player[NPC.target];

            if (player.dead)
            {
                // If the targeted player is dead, flee
                NPC.velocity.Y -= 0.04f;
                // This method makes it so when the boss is in "despawn range" (outside of the screen), it despawns in 10 ticks
                NPC.EncourageDespawn(10);
                return;
            }
            if (exhausttimer > 0)
            {
                exhausttimer--;
            }
            if (stamina <= 0)
            {
                exhausttimer = 180;
                stamina = 50;
            }
            if (AttackCooldown > 0)
            {
                AttackCooldown--;
            }
            if (exhausttimer == 0)
            {
                DoFirstStage(player);
            }
            else
            {
                Exhausted(player);
            }
            
        }
        private void DoFirstStage(Player player)
        {
            
            float offsetX = 150f;

            Vector2 abovePlayer = player.Top + new Vector2(NPC.direction * offsetX, -NPC.height);

            Vector2 toAbovePlayer = abovePlayer - NPC.Center;
            Vector2 toAbovePlayerNormalized = toAbovePlayer.SafeNormalize(Vector2.UnitY);

            // The NPC tries to go towards the offsetX position, but most likely it will never get there exactly, or close to if the player is moving
            // This checks if the npc is "70% there", and then changes direction
            float changeDirOffset = offsetX * 0.7f;

            if (NPC.direction == -1 && NPC.Center.X - changeDirOffset < abovePlayer.X ||
                NPC.direction == 1 && NPC.Center.X + changeDirOffset > abovePlayer.X)
            {
                NPC.direction *= -1;
            }

            float speed = 9f;
            float inertia = 40f;
            float lifeRatio = NPC.life / (float)NPC.lifeMax;
            // If the boss is somehow below the player, move faster to catch up
            if (NPC.Top.Y > player.Bottom.Y || lifeRatio < 0.5f)
            {
                speed = 12f;
                if (lifeRatio < 0.1f)
                {
                    speed = 16f;
                }

            }
            else
            {
                float timerMax = Utils.Clamp((float)NPC.life / NPC.lifeMax, 0.33f, 1f) * 90;

                SecondStageTimer_SpawnEyes++;
                if (SecondStageTimer_SpawnEyes > timerMax && AttackCooldown == 0)
                {
                    SecondStageTimer_SpawnEyes = 0;
                    DoSecondStage_SpawnEyes(player);
                }

            }

            Vector2 moveTo = toAbovePlayerNormalized * speed;
            NPC.velocity = (NPC.velocity * (inertia - 1) + moveTo) / inertia;


            NPC.damage = NPC.defDamage;

            NPC.alpha = 0;
            FirstStageTimer++;
            if (AttackCooldown == 0)
            {
                if (FirstStageTimer == (FirstStageTimerMax - 45))
                {
                    for (int i = 0; i < 12; i++) // Adjust the number of dusts spawned
                    {

                        int dust = Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.YellowStarDust, 0f, 0f, 0, default, 1.1f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 2f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                    SoundEngine.PlaySound(SoundID.Zombie125, NPC.Center);
                }
                if (FirstStageTimer > FirstStageTimerMax)
                {
                    FirstStageTimer = 0;
                    
                    DashAttack(player);

                }
            }
            

        }
        private void Exhausted(Player player)
        {

            float offsetX = 300f;

            Vector2 abovePlayer = player.Top + new Vector2(NPC.direction * offsetX, -NPC.height);

            Vector2 toAbovePlayer = abovePlayer - NPC.Center;
            Vector2 toAbovePlayerNormalized = toAbovePlayer.SafeNormalize(Vector2.UnitY);

            // The NPC tries to go towards the offsetX position, but most likely it will never get there exactly, or close to if the player is moving
            // This checks if the npc is "70% there", and then changes direction
            float changeDirOffset = offsetX * 0.7f;

            if (NPC.direction == -1 && NPC.Center.X - changeDirOffset < abovePlayer.X ||
                NPC.direction == 1 && NPC.Center.X + changeDirOffset > abovePlayer.X)
            {
                NPC.direction *= -1;
            }

            float speed = 6f;
            float inertia = 30f;

            // If the boss is somehow below the player, move faster to catch up
            if (NPC.Top.Y > player.Bottom.Y)
            {
                speed = 10f;

            }
            

            Vector2 moveTo = toAbovePlayerNormalized * speed;
            NPC.velocity = (NPC.velocity * (inertia - 1) + moveTo) / inertia;


            NPC.damage = NPC.defDamage;

            NPC.alpha = 0;
            
        }
        private void DashAttack(Player player)
        {

            AttackCooldown = 75;
            float distance = 350; // Distance in pixels behind the player
            Vector2 fromPlayer = NPC.Center - player.Center;

            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                // Important multiplayer consideration: drastic change in behavior (that is also decided by randomness) like this requires
                // to be executed on the server (or singleplayer) to keep the boss in sync

                float angle = fromPlayer.ToRotation();
                float twelfth = MathHelper.Pi / 6;

                angle += MathHelper.Pi + Main.rand.NextFloat(-twelfth, twelfth);
                if (angle > MathHelper.TwoPi)
                {
                    angle -= MathHelper.TwoPi;
                }
                else if (angle < 0)
                {
                    angle += MathHelper.TwoPi;
                }

                Vector2 relativeDestination = angle.ToRotationVector2() * distance;

                FirstStageDestination = player.Center + relativeDestination;
                NPC.netUpdate = true;
            }

            // Move along the vector
            Vector2 toDestination = FirstStageDestination - NPC.Center;
            Vector2 toDestinationNormalized = toDestination.SafeNormalize(Vector2.UnitY);
            float speed = Math.Min(distance, toDestination.Length());
            NPC.velocity = toDestinationNormalized * speed / 20;

            if (FirstStageDestination != LastFirstStageDestination)
            {
                // If destination changed
                NPC.TargetClosest(); // Pick the closest player target again

                // "Why is this not in the same code that sets FirstStageDestination?" Because in multiplayer it's ran by the server.
                // The client has to know when the destination changes a different way. Keeping track of the previous ticks' destination is one way
                if (Main.netMode != NetmodeID.Server)
                {
                    // For visuals regarding NPC position, netOffset has to be concidered to make visuals align properly
                    NPC.position += NPC.netOffset;

                    // Draw a line between the NPC and its destination, represented as dusts every 20 pixels
                    Dust.QuickDustLine(NPC.Center + toDestinationNormalized * NPC.width, FirstStageDestination, toDestination.Length() / 20f, Color.Yellow);

                    NPC.position -= NPC.netOffset;
                }
            }
            LastFirstStageDestination = FirstStageDestination;
            if (Main.netMode != NetmodeID.MultiplayerClient)
            {
                float lifeRatio = NPC.life / (float)NPC.lifeMax;
                // If the boss is somehow below the player, move faster to catch up
                if (lifeRatio < 0.25f)
                {

                    if (!Main.rand.NextBool(3))
                    {
                        FirstStageTimer = FirstStageTimerMax - 90;
                    }
                    NPC.netUpdate = true;
                }
                
            }
            float lifeRatio2 = NPC.life / (float)NPC.lifeMax;
            if (lifeRatio2 > 0.15f)
            {
                stamina -= 10;
            }

        }

        private void DoSecondStage_SpawnEyes(Player player)
        {
            AttackCooldown = 120;
            float lifeRatio = NPC.life / (float)NPC.lifeMax;

            if (NPC.HasValidTarget && SecondStageTimer_SpawnEyes == 0 && Main.netMode != NetmodeID.MultiplayerClient)
            {
                // Spawn projectile randomly below player, based on horizontal velocity to make kiting harder, starting velocity 1f upwards
                // (The projectiles accelerate from their initial velocity)
                float angles = 0f;
                float angel = 12f;
                int count = 1;
                if (lifeRatio < 0.75f)
                {
                    count = 2;
                }
                if (lifeRatio < 0.5f)
                {
                    count = 3;
                }
                for (int i = 0; i < count; i++)
                {
                    float kitingOffsetX = Utils.Clamp(player.velocity.X * 16, -75, 75);
                    Vector2 position = NPC.Bottom + (NPC.Bottom.X < player.Center.X ? -angles : angles) * Vector2.UnitX;

                    int type = ModContent.ProjectileType<SeltasGoop>();
                    int damage = NPC.damage / 3;
                    var entitySource = NPC.GetSource_FromAI();
                    Vector2 vector = Main.player[NPC.target].Center - NPC.Bottom;
                    vector.Normalize();


                    Projectile.NewProjectile(entitySource, position, vector * angel, type, damage, 0.3f, Main.myPlayer);
                    angles += 25f;
                    angel += 6f;
                }
                for (int i = 0; i < 8; i++)
                {
                    int WaterShot = Dust.NewDust(new Vector2(NPC.Bottom.X, NPC.Bottom.Y), NPC.width, NPC.height, DustID.JungleSpore, 0f, 0f, 100, default, 0.6f);
                    Main.dust[WaterShot].velocity *= 2f;
                    Main.dust[WaterShot].noGravity = false;
                }
                angles = 0f;
                angel = 12;
                SoundEngine.PlaySound(SoundID.Item17, NPC.Center);
                
                if (lifeRatio > 0.15f)
                {
                    stamina -= 5;
                }
                NPC.netUpdate = true;
            }
            
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            if (Main.rand.NextBool(3))
            {
                target.AddBuff(BuffID.Poisoned, 600);
            }

        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            // If the NPC dies, spawn gore and play a sound
            if (Main.netMode == NetmodeID.Server)
            {
                // We don't want Mod.Find<ModGore> to run on servers as it will crash because gores are not loaded on servers
                return;
            }

            if (NPC.life <= 0)
            {
                // These gores work by simply existing as a texture inside any folder which path contains "Gores/"
                var entitySource = NPC.GetSource_Death();
                Gore.NewGore(entitySource, NPC.position, new Vector2(Main.rand.Next(-6, 7), Main.rand.Next(-6, 7)), Mod.Find<ModGore>("Seltas1").Type, 1f);
                for (int i = 0; i < 2; i++)
                {
                    Gore.NewGore(entitySource, NPC.position, new Vector2(Main.rand.Next(-6, 7), Main.rand.Next(-6, 7)), Mod.Find<ModGore>("Seltas2").Type, 1f);
                    Gore.NewGore(entitySource, NPC.position, new Vector2(Main.rand.Next(-6, 7), Main.rand.Next(-6, 7)), Mod.Find<ModGore>("Seltas5").Type, 1f);
                    Gore.NewGore(entitySource, NPC.position, new Vector2(Main.rand.Next(-6, 7), Main.rand.Next(-6, 7)), Mod.Find<ModGore>("Seltas3").Type, 1f);
                }
                Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Seltas4").Type, 1f);

            }
        }

    }

}
