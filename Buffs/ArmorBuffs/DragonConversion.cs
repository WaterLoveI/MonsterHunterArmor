using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class DragonConversion : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Dragon Conversion Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().DragonConversion} ";
            tip = $"Increase damage by {(int)(Main.LocalPlayer.GetModPlayer<ScrollSwapPlayer>().DragConvCritCount * Main.LocalPlayer.GetModPlayer<ScrollSwapPlayer>().DragonConversionRate)}%";
        }
    }
}



