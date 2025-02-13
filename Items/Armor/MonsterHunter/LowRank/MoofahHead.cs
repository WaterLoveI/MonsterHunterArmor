﻿using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class MoofahHead : ModItem
    {
        public static readonly int thunder = 2;
        public static readonly int gather = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(thunder, gather);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 2;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Gathering += gather;
            modPlayer.ThunderAttack += thunder;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterBone>(3).
                AddIngredient(ItemID.FlinxFur, 3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}