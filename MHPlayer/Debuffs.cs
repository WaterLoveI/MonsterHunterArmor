using MHArmorSkills.Buffs;
using MHArmorSkills.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public partial class Debuff : ModPlayer
    {
        public bool BubbleBlight;
        public bool BlastBlight;
        public bool NearExplosion;
        public bool TriggerExplosion;
        public int BlastTimer;

        public override void ResetEffects()
        {
            BubbleBlight = false;
            NearExplosion = false;
        }

        public override void PreUpdate()
        {
            #region Blastblight
            if (BlastTimer > 0)
            {
                BlastTimer--;
            }
            #endregion
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


            Explosion();

            #endregion
        }
        private void Explosion()
        {
            if (TriggerExplosion)
            {
                if (Main.myPlayer == Player.whoAmI)
                {
                    var source = Player.GetSource_Buff(Player.FindBuffIndex(ModContent.BuffType<BlastBlight>()));
                    Projectile.NewProjectile(source, Player.Center, Vector2.Zero, ModContent.ProjectileType<BlastExplosionHostile>(), 10, 0f, Player.whoAmI);
                    BlastBlight = false;
                    TriggerExplosion = false;
                    Player.ClearBuff(ModContent.BuffType<BlastBlight>());
                    SoundEngine.PlaySound(SoundID.Item116, Player.Center);
                    for (int i = 0; i < 29; i++)
                    {
                        int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Torch, 0.7f, 0.7f, 0, default, 1.7f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                        spread *= 2f;
                        Main.dust[dust].velocity = spread;
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Torch, 0.3f, 0.3f, 0, Color.Yellow, 1.1f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                        spread *= 1.1f;
                        Main.dust[dust].velocity = spread;
                    }
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
                    int dust = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Torch, 0f, 0f, 0, Color.Yellow, 1.1f);
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
            }
        }
    }
}
