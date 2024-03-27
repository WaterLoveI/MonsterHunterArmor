﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using Terraria.Localization;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class SpiritBirdPrism : ModBuff
    {
        public override void SetStaticDefaults()
        {

            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 5 / 100f;
            player.statDefense += 5;
            player.GetDamage(DamageClass.Generic) += 5 / 100f;
            player.statLifeMax2 += 20;
            player.statManaMax2 += 20;
        }
    }
    

}

