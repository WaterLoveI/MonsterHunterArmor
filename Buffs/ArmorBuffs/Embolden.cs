using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Embolden : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Embolden Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Embolden} ";
            tip = $"Increase aggro by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().EmboldenAggro} \n" +
                  $"Increase defense by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().EmboldenDef} \n" +
                  $"Increase evasion and guard levels by {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Embolden + 2}";
        }
    }
}



