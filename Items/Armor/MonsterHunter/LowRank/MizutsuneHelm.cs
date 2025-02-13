﻿using MHArmorSkills.Global;

using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class MizutsuneHelm : ModItem
    {
        public static readonly int Move = 10;
        public static readonly int bubble = 2;
        public static readonly int WaterRes = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, bubble, WaterRes);


        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.BubbleDance += bubble;
            modPlayer.WaterRes += WaterRes;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient<Bubblefoam>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}