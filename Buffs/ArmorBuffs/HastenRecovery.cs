﻿using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class HastenRecovery : ModBuff
    {
        public override void SetStaticDefaults()
        {

            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

    }
}
