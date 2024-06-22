using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class OffensiveGuard : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Offensive Guard Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().OffensiveGuard} ";
            tip = $"Increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().OffensiveGuardBoost}% after successfully guarding.";
        }
    }
}


