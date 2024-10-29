using MHArmorSkills.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Global
{
    public class MHGlobalProj : GlobalProjectile
    {

        public override void OnHitPlayer(Projectile projectile, Player target, Player.HurtInfo info)
        {
            if (MHLists.fireresprojList.Contains(projectile.type))
            {
                if (info.Damage > 0 && !Main.rand.NextBool(3))
                {
                    target.AddBuff(ModContent.BuffType<FireBlight>(), 15 * 60);
                }
            }
            if (MHLists.iceresprojList.Contains(projectile.type))
            {
                if (info.Damage > 0 && !Main.rand.NextBool(3))
                {
                    target.AddBuff(ModContent.BuffType<IceBlight>(), 15 * 60);
                }
            }
            if (MHLists.thunderresprojList.Contains(projectile.type))
            {
                if (info.Damage > 0 && !Main.rand.NextBool(3))
                {
                    target.AddBuff(ModContent.BuffType<ThunderBlight>(), 15 * 60);
                }
            }
            if (MHLists.waterresprojList.Contains(projectile.type))
            {
                if (info.Damage > 0 && !Main.rand.NextBool(3))
                {
                    target.AddBuff(ModContent.BuffType<WaterBlight>(), 15 * 60);
                }
            }
        }
    }

}

