using MHArmorSkills.Global;

using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class SailorSocks : ModItem
    {
        public static readonly int Move = 5;
        public static readonly int AMob = 1;
        public static readonly int Water = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, AMob, Water);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AMobility += AMob;
            modPlayer.WaterAttack += Water;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.AnglerPants).
                AddIngredient(ItemID.Waterleaf, 5).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}