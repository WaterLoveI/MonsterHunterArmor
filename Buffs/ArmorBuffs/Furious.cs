using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Furious : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Furious >= 1)
            {
                buffName = $"Furious Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Fortified} ";
                tip = $"Temporary unlimited flight time and mana";
            }
        }

    }
}


