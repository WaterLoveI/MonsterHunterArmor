using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Grinder : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Grinder Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Grinder} ";
            tip = $"Increase melee damage based on weapon rarity.\n" +
                $"Further increase damage by 10% due to grinder.";
        }
    }
}



