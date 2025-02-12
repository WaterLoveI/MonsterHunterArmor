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
    public class GoreMagalaHelmEX : ModItem
    {
            
        public static readonly int Damage = 12;
        public static readonly int Crit = 12;
        public static readonly int Coal = 2;
        public static readonly int Spirit = 2;
        public static readonly int Bloodlust = 1;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Coal, Spirit, Bloodlust, Decor2);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Bloodlust += Bloodlust;
            modPlayer.Spirit += Spirit;
            modPlayer.Coalescence += Coal;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GoreMagalaHelm>().
                AddIngredient<FineEbonShell>(4).
                AddIngredient<RathalosRuby>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}