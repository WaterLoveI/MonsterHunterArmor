using Microsoft.Xna.Framework;
using Mono.Cecil;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Projectiles
{
    public class BlastExplosionHostile : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.SolarWhipSwordExplosion); // Copy the sprite and other properties of Solar Flare Explosion but doesnt even show up
            Projectile.hostile = true;
            Projectile.localNPCHitCooldown = -1;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.ArmorPenetration = 10;
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            if (info.Damage <= 0)
                return;
        }
        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item116, Projectile.Center);
            for (int i = 0; i < 29; i++)
            {
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Torch, 0.7f, 0.7f, 0, default, 1.7f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                spread *= 2f;
                Main.dust[dust].velocity = spread;
            }
            for (int i = 0; i < 9; i++)
            {
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Torch, 0.3f, 0.3f, 0, Color.Yellow, 1.5f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f));
                spread *= 0.7f;
                Main.dust[dust].velocity = spread;
            }
            Vector2 goreSource = Projectile.Center;
            int goreAmt = 3;
            Vector2 source = new Vector2(goreSource.X - 24f, goreSource.Y - 24f);
            for (int goreIndex = 0; goreIndex < goreAmt; goreIndex++)
            {
                float velocityMult = 0.33f;
                if (goreIndex < (goreAmt / 3))
                {
                    velocityMult = 0.66f;
                }
                if (goreIndex >= (2 * goreAmt / 3))
                {
                    velocityMult = 1f;
                }
                int type = Main.rand.Next(61, 64);
                int smoke = Gore.NewGore(Projectile.GetSource_Death(), source, default, type, 1f);
                Gore gore = Main.gore[smoke];
                gore.velocity *= velocityMult;
                gore.velocity.X += 1f;
                gore.velocity.Y += 1f;
                type = Main.rand.Next(61, 64);
                smoke = Gore.NewGore(Projectile.GetSource_Death(), source, default, type, 1f);
                gore = Main.gore[smoke];
                gore.velocity *= velocityMult;
                gore.velocity.X -= 1f;
                gore.velocity.Y += 1f;
                type = Main.rand.Next(61, 64);
                smoke = Gore.NewGore(Projectile.GetSource_Death(), source, default, type, 1f);
                gore = Main.gore[smoke];
                gore.velocity *= velocityMult;
                gore.velocity.X += 1f;
                gore.velocity.Y -= 1f;
                type = Main.rand.Next(61, 64);
                smoke = Gore.NewGore(Projectile.GetSource_Death(), source, default, type, 1f);
                gore = Main.gore[smoke];
                gore.velocity *= velocityMult;
                gore.velocity.X -= 1f;
                gore.velocity.Y -= 1f;
            }
        }
    }
}