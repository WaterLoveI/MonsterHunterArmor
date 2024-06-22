using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class FrenzyCure : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = "Frenzy Cured!";
            tip = $"Increase critical strike chance by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Bloodlust * 3}%";

        }
    }
}


