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
    public class KirinHelm : ModItem
    {
        public static readonly int Crit = 7;
        public static readonly int Move = 7;
        public static readonly int Lasting = 2;
        public static readonly int Prot = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Move, Lasting, Prot);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Crit;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Protection += Prot;
            modPlayer.LastingPower += Lasting;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ElderDragonGem>().
                AddIngredient<FulgurBug>(3).
                AddIngredient<ElectroShocker>(4).
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}