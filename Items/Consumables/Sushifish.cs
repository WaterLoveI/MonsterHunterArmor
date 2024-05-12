using MHArmorSkills.Global;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Consumables
{
    public class Sushifish : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.UseSound = SoundID.Item2;
            Item.maxStack = 9999;
            Item.healLife = 75;
            Item.potion = true;
            Item.buffType = BuffID.Regeneration;
            Item.buffTime = 1 * 60 * 60;
            Item.consumable = true;
        }
    }
}