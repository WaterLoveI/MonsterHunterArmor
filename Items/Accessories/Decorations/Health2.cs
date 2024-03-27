﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.Buffs.ArmorBuffs;

namespace MHArmorSkills.Items.Accessories.Decorations
{
    public class Health2 : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.accessory = true;
            Item.vanity = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateEquip(Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Health += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots -= 1;
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            if (SlotPlayer.DecorationThreeSlots >= 1)
            {
                SlotPlayer.DecorationThreeSlots -= 1;
                return true;
                
            }
            return false;
        }
    }
    
}



