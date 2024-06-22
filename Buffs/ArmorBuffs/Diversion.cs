using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Diversion : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance == 2)
            {
                buffName = $"Diversion Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Diversion} ";
                tip = "Increase melee speed by 15%";
            }
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance >= 3)
            {
                buffName = $"Diversion Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Diversion} ";
                tip = "Increase melee damage by 5% \n" +
                      "Increase melee speed by 15%";
            }
        }
    }
}



