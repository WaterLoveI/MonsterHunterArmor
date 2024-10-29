using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.SharpnessBuff
{
    public class SharpnessWhite : ModBuff
    {

        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            tip = $"Current sharpness: {Main.LocalPlayer.GetModPlayer<SharpnessPlayer>().CurrentSharpness} / {Main.LocalPlayer.GetModPlayer<SharpnessPlayer>().MaxSharpness}\n" +
                  $"Increase true melee damage by 32%";
        }
    }
}


