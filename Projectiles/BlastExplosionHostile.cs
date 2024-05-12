using Terraria;
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
    }
}