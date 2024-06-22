using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class BladeHoneScale : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Bladehone Scale Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().BladeScaleHone} ";
            tip = $"Reduce mana cost by by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().BladeHoneScale * 3}% \n" +
                  $"{Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().BladeHoneScale * 25}% to not consume ammo";
        }
    }
}



