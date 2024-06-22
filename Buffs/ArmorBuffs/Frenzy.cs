using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Frenzy : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = "The Frenzy";
            tip = "Reduce natural healing. \n" +
                $"Increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Bloodlust * 4}% \n" +
                $"Reduce mana cost by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Bloodlust * 3}% \n" +
                "Keeping attacking enemies to overcome the frenzy."
                ;
        }
    }
}



