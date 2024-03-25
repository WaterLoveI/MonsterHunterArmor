using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Protection : ModBuff
    {
        public static readonly int ProtectionChance = 5;
        public override LocalizedText Description => base.Description.WithFormatArgs(ProtectionChance);
        public override void SetStaticDefaults()
        {

            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            
        }
    }
}


