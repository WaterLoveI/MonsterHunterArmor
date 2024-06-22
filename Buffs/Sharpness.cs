using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs
{
    public class Sharpness : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            modPlayer.Sharpness = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Grinder >= 1)
            {
                buffName = $"Sharpness";
                tip = $"Increase melee damage based on weapon rarity.\n" +
                $"Further increase damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().Grinder}% due to grinder.";
            }
        }
    }
}


