using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.BiomeBones
{
    public class TundraBone2 : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(2).
                AddIngredient<TundraBone3>(1).
                AddTile(TileID.DemonAltar).
                Register();
        }
    }
}
