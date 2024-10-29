using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Buffs;
using Terraria.Audio;

namespace MHArmorSkills.Projectiles.Weapon
{
    public class BladeScale3 : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 14;
            Projectile.height = 22;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.Generic;
            Projectile.tileCollide = true;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 200;
            AIType = ProjectileID.Bullet;
            Projectile.usesLocalNPCImmunity = true;
            Projectile.localNPCHitCooldown = 10;
        }

        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation() + (float)Math.Atan(90);
        }

        public override void OnKill(int timeLeft)
        {
            for (int k = 0; k < 7; k++)
            {
                int ScaleDust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Dirt, 0f, 0f, 150, Color.Gold, 1.2f);
                Main.dust[ScaleDust].noGravity = true;
            }
            SoundEngine.PlaySound(SoundID.Dig, Projectile.Center);

        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Main.rand.NextBool(5))
            {
                target.AddBuff(ModContent.BuffType<Bleed>(), 5 * 60);
            }
        }
    }
}
