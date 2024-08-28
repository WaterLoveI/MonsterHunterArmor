using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class Stunned : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            player.controlLeft = false;
            player.controlRight = false;
            player.controlJump = false;
            player.controlDown = false;
            player.controlUseItem = false;
            player.controlUseTile = false;
            player.controlHook = false;
            player.releaseHook = true;
            if (player.mount.Active)
                player.mount.Dismount(player);

        }
    }
}


