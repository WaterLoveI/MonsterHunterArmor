using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Coalescence : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Coalescence Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Coalescence} ";
            tip = $"Increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Coalescence}% after overcoming a debuff.";
        }
    }
}


