using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class CritDraw : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Critical Draw Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().CritDraw} ";
            tip = $"Increase critical strike chance by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().CritDraw}%";
        }
    }
}

