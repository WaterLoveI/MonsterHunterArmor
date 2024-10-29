using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Projectiles.Enemy
{
    public class DesertSeltasGoop : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 14;
            Projectile.height = 14;
            Projectile.penetrate = -1;
            Projectile.hostile = true;
            Projectile.timeLeft = 240;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            
        }
        public override void AI()
        {
            Projectile.rotation = (float)Math.Atan2((double)Projectile.velocity.Y, (double)Projectile.velocity.X) + MathHelper.ToRadians(45f);

            Projectile.velocity.Y += 0.03f;
            if (Projectile.velocity.Y > 12f)
            {
                Projectile.velocity.Y = 12f;
            }
            if (Main.rand.NextBool(3))
            {
                int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.JungleSpore, 0f, 0f, 0, Color.Green, 0.5f);
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                spread *= 2f; // Adjust the spread distance
                Main.dust[dust].velocity = spread;
            }
            
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            if (info.Damage <= 0)
                return;

            target.AddBuff(BuffID.Slow, 60*10);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Dig, Projectile.position);
            Projectile.Kill();
            return false;
        }
        public override void OnKill(int timeLeft)
        {
            for (int i = 0; i < 7; i++)
            {
                Dust.NewDust(Projectile.Center, 1, 1, DustID.JungleSpore, Projectile.velocity.X, Projectile.velocity.Y,0,Color.Green);
            }
        }
    }

}
