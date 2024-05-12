using MHArmorSkills.MHPlayer;
using MHArmorSkills.Projectiles;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class BlastBlight : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            Debuff modPlayer = player.GetModPlayer<Debuff>();
            modPlayer.BlastBlight = true;
            if (player.buffTime[player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] <= 600)
            {
                modPlayer.NearExplosion = true;
            }
            if (player.buffTime[player.FindBuffIndex(ModContent.BuffType<BlastBlight>())] <= 10)
            {
                if (Main.myPlayer == player.whoAmI)
                {
                    var source = player.GetSource_Buff(player.FindBuffIndex(ModContent.BuffType<BlastBlight>()));
                    Projectile.NewProjectile(source, player.Center, Vector2.Zero, ModContent.ProjectileType<BlastExplosionHostile>(), 10, 0f, player.whoAmI);
                    modPlayer.BlastBlight = false;
                    modPlayer.TriggerExplosion = false;
                    player.ClearBuff(ModContent.BuffType<BlastBlight>());
                    SoundEngine.PlaySound(SoundID.Item116, player.Center);
                    for (int i = 0; i < 25; i++) 
                    {
                        int dust = Dust.NewDust(player.position, player.width, player.height, DustID.Torch, 0.7f, 0.7f, 0, default, 1.5f);
                        Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                        spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); 
                        spread *= 2f; 
                        Main.dust[dust].velocity = spread;
                    }
                }
            }
        }
    }
}



