using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Defiance : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance == 1 || Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance == 2)
            {
                buffName = $"Defiance Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance} ";
                tip = $"Increase Defense by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} \n" +
                      "grant immunity to KnockBack.";
            }
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance == 3 || Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance == 4)
            {
                buffName = $"Defiance Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance} ";
                tip = $"Increase Defense by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} \n" +
                      "grant immunity to KnockBack.\n" +
                      "Debuffs wears off twice as fast.";

            }
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Defiance >= 5)
            {
                buffName = $"Defiance Level: 5 ";
                tip = $"Increase Defense by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} \n" +
                      "Grant immunity to KnockBack.\n" +
                      "Debuffs wears off twice as fast.\n" +
                      "Enemies may drop life boosters when hit";
            }
        }
    }
}



