using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class HoneyHunter : ModBuff
    {
        public static readonly int HoneyBoost = 5;
        public override LocalizedText Description => base.Description.WithFormatArgs(HoneyBoost);
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


