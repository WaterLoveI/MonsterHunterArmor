using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Fortified : ModBuff
    {
        public static readonly int FortBuff = 7;
        public static readonly int FortDefBuff = 7;
        public override LocalizedText Description => base.Description.WithFormatArgs(FortBuff, FortDefBuff);
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) += FortBuff / 100f;
            player.statDefense += FortDefBuff;
        }
    }
}


