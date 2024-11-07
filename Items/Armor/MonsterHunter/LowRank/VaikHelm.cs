using MHArmorSkills.Global;

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
    public class VaikHelm : ModItem
    {
        public static readonly int Melee = 5;
        public static readonly int Amob = 1;
        public static readonly int Razor = 1;
        public static readonly int Water = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Melee, Amob, Razor, Water);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<MeleeDamageClass>() += Melee/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.WaterAttack += Water;
            modPlayer.RazorSharpSpareShot += Razor;
            modPlayer.AMobility += Amob;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.PlatinumHelmet).
                AddIngredient(ItemID.ReaverShark).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
            CreateRecipe().
                AddIngredient(ItemID.GoldHelmet).
                AddIngredient(ItemID.ReaverShark).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}