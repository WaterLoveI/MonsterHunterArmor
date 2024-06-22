using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Unscathed : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Unscathed Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Unscathed} ";
            tip = $"Increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Unscathed}% when health is full"; 
        }
    }
}


