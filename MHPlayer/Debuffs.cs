using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Dusts;
using MHArmorSkills.NPCs.NormalNPC;
using MHArmorSkills.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public partial class Debuffs : ModPlayer
    {
        public bool BubbleBlight;
        public bool BlastBlight;
        public bool NearExplosion;
        public bool TriggerExplosion;
        public int BlastTimer;
        public int StunnedHealthCheck;
        public int StunnedTimer;

        public int FireBlightDoT;

        public override void ResetEffects()
        {
            BubbleBlight = false;
            NearExplosion = false;
            FireBlightDoT = 0;
        }

        public override void PreUpdate()
        {
            #region Blastblight
            if (BlastTimer > 0)
            {
                BlastTimer--;
            }
            #endregion
            #region Stunned
            StunnedHealthCheck = Player.statLife;
            if (StunnedTimer > 0)
            {
                StunnedTimer--;
            }
            #endregion
            if (Player.HasBuff(ModContent.BuffType<FireBlight>()))
            {

            }
        }
        public override void PostUpdateMiscEffects()
        {
            #region Bubble Blight
            if (BubbleBlight)
            {
                Player.accRunSpeed *= 0.5f; // Reduce run speed
                Player.maxRunSpeed *= 0.5f; // Slow down horizontal movement
            }
            #endregion
            #region Blast Blight
            if (Player.HasBuff(ModContent.BuffType<BlastBlight>()))
            {
                if (Player.wet)
                {
                    BlastBlight = false;
                    Player.ClearBuff(ModContent.BuffType<BlastBlight>());
                    for (int i = 0; i < 19; i++) // Adjust the number of dusts spawned
                    {
                        int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Smoke, 0f, 0f, 0, default, 1f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                        spread *= 2f; // Adjust the spread distance
                        Main.dust[dust].velocity = spread;
                    }
                }
            }
            #endregion

            if (Player.active && !Player.dead)
            {
                if (Main.expertMode)
                {
                    if (StunnedHealthCheck >= (Player.statLife + Player.statLifeMax2 * 0.25f) && StunnedTimer == 0)
                    {
                        if (Main.rand.NextBool(8))
                        {
                            Player.AddBuff(ModContent.BuffType<Stunned>(), 60);
                            StunnedTimer = 10 * 60;
                        }
                    }
                }
            }

            if (Player.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                Player.maxRunSpeed *= 0.25f;
                Player.moveSpeed *= 0.75f;
            }

            if (Player.wet)
            {
                Player.ClearBuff(ModContent.BuffType<FireBlight>());
            }
            Explosion();


        }
        private void Explosion()
        {
            if (TriggerExplosion)
            {
                if (Main.myPlayer == Player.whoAmI)
                {
                    var source = Player.GetSource_Buff(Player.FindBuffIndex(ModContent.BuffType<BlastBlight>()));
                    int damage = Player.statDefense + 30;
                    if (Main.GameModeInfo.IsExpertMode)
                    {
                        damage += 50;
                    }
                    if (Main.GameModeInfo.IsMasterMode)
                    {
                        damage += 50;
                    }
                    if (NPC.downedGolemBoss)
                    {
                        damage += 50;
                    }
                    Projectile.NewProjectile(source, Player.Center, Vector2.Zero, ModContent.ProjectileType<BlastExplosionHostile>(), damage, 0.5f, Player.whoAmI);
                    BlastBlight = false;
                    TriggerExplosion = false;
                    Player.ClearBuff(ModContent.BuffType<BlastBlight>());
                }
            }
        }

        public override void OnHitByNPC(NPC npc, Terraria.Player.HurtInfo hurtInfo)
        {
            base.OnHitByNPC(npc, hurtInfo);

            #region Blast Explosion
            if (Player.HasBuff(ModContent.BuffType<BlastBlight>()) && Player.buffTime[Player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] >= 190)
            {
                Player.buffTime[Player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] -= 180;
            }
            #endregion
            #region BubbleBlight
            if (Player.HasBuff(ModContent.BuffType<BubbleBlight>()) && !(npc.type == ModContent.NPCType<BubblesNPC>()))
            {
                Player.ClearBuff(ModContent.BuffType<BubbleBlight>());
                SoundEngine.PlaySound(SoundID.Item54, Player.Center);
            }
            #endregion
            #region Thunderblight
            if (Player.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                if (!Main.rand.NextBool(3))
                {
                    Player.AddBuff(ModContent.BuffType<Stunned>(), 3 * 60);
                    Player.ClearBuff(ModContent.BuffType<ThunderBlight>());
                }
            }
            #endregion
        }

        public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
        {
            base.OnHitByProjectile(proj, hurtInfo);
            #region Blast Explosion
            if (Player.HasBuff(ModContent.BuffType<BlastBlight>()) && Player.buffTime[Player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] >= 190)
            {
                Player.buffTime[Player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] -= 180;
            }
            #endregion
            #region BubbleBlight
            if (Player.HasBuff(ModContent.BuffType<BubbleBlight>()))
            {
                Player.ClearBuff(ModContent.BuffType<BubbleBlight>());
                SoundEngine.PlaySound(SoundID.Item54, Player.Center);
            }
            #endregion
            #region Thunderblight
            if (Player.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                if (!Main.rand.NextBool(3))
                {
                    Player.AddBuff(ModContent.BuffType<Stunned>(), 3 * 60);
                    Player.ClearBuff(ModContent.BuffType<ThunderBlight>());
                }
            }
            #endregion
        }

        public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            #region Bubble Blight
            if (BubbleBlight && Main.netMode != NetmodeID.Server && drawInfo.shadow == 0f)
            {
                if (Main.rand.NextBool(4))
                {
                    Vector2 velocity = Main.rand.NextVector2Unit();
                    velocity.X *= 0.66f;
                    velocity *= Main.rand.NextFloat(1f, 2f);

                    int bubble = Gore.NewGore(Player.GetSource_FromThis(), drawInfo.Position + new Vector2(Main.rand.Next(Player.width + 1), Main.rand.Next(Player.height + 1)), velocity, 411, Main.rand.NextFloat(0.4f, 1.2f));
                    Main.gore[bubble].sticky = false;
                    Main.gore[bubble].velocity *= 0.4f;
                    Main.gore[bubble].velocity.Y -= 0.6f;
                    drawInfo.GoreCache.Add(bubble);
                }
            }
            #endregion
            #region Blast Blight
            if (Player.HasBuff(ModContent.BuffType<BlastBlight>()) && BlastTimer == 0)
            {
                for (int i = 0; i < 17; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Torch, 0f, 0f, 0, default, 1.1f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 2f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
                for (int i = 0; i < 6; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Torch, 0f, 0f, 0, Color.DarkRed, 1.2f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 1.1f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
                int Cooldown = 150;
                if (NearExplosion)
                {
                    Cooldown = 60;
                }
                BlastTimer = Cooldown;
            }
            #endregion
            if (Player.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                for (int i = 0; i < 2; i++) // Adjust the number of dusts spawned
                {
                    int dust = Dust.NewDust(Player.position, Player.width + 10, Player.height + 10, DustID.Electric, 0f, 0f, 0, Color.DarkRed, 0.4f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 0.8f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                    Main.dust[dust].noGravity = true;
                }
            }
            if (Player.HasBuff(ModContent.BuffType<WaterBlight>()))
            {
                if (Main.rand.NextBool(3))
                {
                    int dust = Dust.NewDust(Player.position, Player.width + 4, Player.height + 3, ModContent.DustType<WaterblightDust>(), 0f, 0f, 0, Color.White, 1f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-1.5f, 1.5f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 180f)); // Random rotation for spread
                    spread *= 0.5f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }



            }
            if (Player.HasBuff(ModContent.BuffType<IceBlight>()))
            {

                if (Main.rand.NextBool(2))
                {
                    int dust = Dust.NewDust(Player.position, Player.width + 6, Player.height + 7, ModContent.DustType<IceblightDust>(), 0f, 0f, 0, Color.White, 0.4f);
                    Vector2 spread = new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-1.5f, 1.5f));
                    spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                    spread *= 0.5f; // Adjust the spread distance
                    Main.dust[dust].velocity = spread;
                }
            }
            if (Player.HasBuff(ModContent.BuffType<FireBlight>()))
            {

                int dust = Dust.NewDust(Player.position, Player.width + 4, Player.height + 3, ModContent.DustType<FireblightDust>(), 0f, 0f, 0, Color.White, 1f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1.5f, 1.5f), Main.rand.NextFloat(-1.5f, 1.5f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                spread *= 0.5f; // Adjust the spread distance
                Main.dust[dust].velocity = spread;
                Main.dust[dust].noGravity = true;
            }


        }

        public override void OnRespawn()
        {
            base.OnRespawn();
            TriggerExplosion = false;
            BlastBlight = false;

        }
        public override void UpdateBadLifeRegen()
        {
            base.UpdateBadLifeRegen();
            #region bleed
            if (Player.HasBuff(BuffID.Bleeding))
            {
                if (Player.itemAnimation > 0)
                {
                    Player.lifeRegen -= 15;
                    Player.lifeRegenTime += 10;
                    Player.lifeRegenCount -= 20;
                    if (Main.rand.NextBool(3))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Blood, 0.3f, 0.3f, 0, default, 1.1f);
                            Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                            spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                            spread *= 1.1f;
                            Main.dust[dust].velocity = spread;
                        }
                    }

                }
                if (Player.velocity.Length() > 0)
                {
                    Player.lifeRegen -= 15;
                    Player.lifeRegenTime += 10;
                    Player.lifeRegenCount -= 20;
                    if (Main.rand.NextBool(3))
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Blood, 0.3f, 0.3f, 0, default, 1.1f);
                            Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                            spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                            spread *= 1.1f;
                            Main.dust[dust].velocity = spread;
                        }
                    }
                }
                if (Player.velocity.Length() >= 0)
                {
                    Player.lifeRegen = 0;
                }
                if (Player.sitting.isSitting)
                {
                    --Player.buffTime[BuffID.Bleeding];
                }
            }
            #endregion

            if (Player.HasBuff(ModContent.BuffType<FireBlight>()))
            {
                Player.lifeRegen -= 6;
                FireBlightDoT = Player.lifeRegen / 2;
                Player.lifeRegen += FireBlightDoT;
            }
        }

        public override float UseSpeedMultiplier(Item item)
        {
            if (Player.HasBuff(ModContent.BuffType<IceBlight>()))
            {
                return 0.7f;
            }
            return base.UseSpeedMultiplier(item);
        }
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            if (TriggerExplosion)
            {
                damageSource = PlayerDeathReason.ByCustomReason(Language.GetTextValue("Mods.MHArmorSkills.DeathMessage.Blastblight", Player.name));
            }
            if (Player.HasBuff(ModContent.BuffType<Beserk>()))
            {
                damageSource = PlayerDeathReason.ByCustomReason(Language.GetTextValue("Mods.MHArmorSkills.DeathMessage.Berserk", Player.name));
            }
            return base.PreKill(damage, hitDirection, pvp, ref playSound, ref genDust, ref damageSource);
        }

        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if (target.HasBuff(ModContent.BuffType<IceBlight>()))
            {
                modifiers.FinalDamage *= 1.05f;
            }
            if (target.HasBuff(ModContent.BuffType<ThunderBlight>()))
            {
                modifiers.CritDamage *= 1.05f;
            }
        }
    }
}

