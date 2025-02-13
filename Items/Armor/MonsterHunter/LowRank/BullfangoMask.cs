﻿using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class BullfangoMask : ModItem
    {
        public static readonly int Attack = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Attack);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 1;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Attack;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BoneHelmet>().
                AddIngredient<ArmorSphere>(3).
                AddTile(TileID.Furnaces).
                Register();
        }
    }
}