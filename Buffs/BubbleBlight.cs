using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class BubbleBlight : ModBuff
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
            modPlayer.BubbleBlight = true;
            
        }
    }
}


