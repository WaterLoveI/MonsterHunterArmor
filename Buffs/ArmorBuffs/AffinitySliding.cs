using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using MHArmorSkills.MHPlayer;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class AffinitySliding : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Affinity Sliding Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Unscathed} ";
            tip = $"Increase critical strike chance by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().aSlidingCrit}%";
        }
    }
}


