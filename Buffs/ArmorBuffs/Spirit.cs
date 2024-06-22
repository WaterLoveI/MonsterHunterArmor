using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Spirit : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Spirit Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Spirit} ";
            tip = $"Increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().SpiritAttack}% \n" +
                  $"Increase critical strike chance by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().SpiritCrit}%";
        }
    }
}


