using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Spirit : ModBuff
    {
        public static readonly int DamageIncrease = 3;
        public static readonly int CritIncrease = 3;
        public override LocalizedText Description => base.Description.WithFormatArgs(DamageIncrease, CritIncrease);
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


