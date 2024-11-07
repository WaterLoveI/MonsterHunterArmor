﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class ProtectivePolish : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void ModifyBuffText(ref string buffName, ref string tip, ref int rare)
        {
            buffName = $"Protective Polish Level: {Main.LocalPlayer.GetModPlayer<ArmorSkills>().ProtectivePolish} ";
            tip = $"Prevents sharpness from being lost";
        }
    }
}

