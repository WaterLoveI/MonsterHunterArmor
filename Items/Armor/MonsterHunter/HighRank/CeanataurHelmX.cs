﻿using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class CeanataurHelmX : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int Crit = 10;
        public static readonly int CritEye = 3;
        public static readonly int Water = 2;
        public static readonly int Decor = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, CritEye, Water, Decor);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 15;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.WaterAttack += Water;
            modPlayer.CritEye += CritEye;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<CeanataurHelm>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<FineBlackPearl>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}