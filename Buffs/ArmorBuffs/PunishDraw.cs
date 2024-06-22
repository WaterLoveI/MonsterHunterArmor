using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class PunishDraw : ModBuff
    {
        public static readonly int FreeEle = 1;
        
        public override LocalizedText Description => base.Description.WithFormatArgs(FreeEle);
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Punish Draw Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().PunishDraw} ";
            tip = $"Increase melee damage by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().PunishDraw}%\n" +
                  $"Increase Knockback by {Main.LocalPlayer.GetModPlayer<MHPlayerArmorSkill>().PunishDraw * 10}%";
        }

    }
}

