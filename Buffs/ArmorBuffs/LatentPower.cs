using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class LatentPower : ModBuff
    {
        
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Latent Power Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().LatentPower} ";
            tip = $"Increase critical strike chance by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().LatentPowerAffinity}% \n" +
                  $"Reduce mana cost by {100-Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().LatentPowerManaCost}%";
        }
    }
}



