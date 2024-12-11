using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.BiomeBones
{
    public class CoralBone1 : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(2).
                AddIngredient<CoralBone2>(1).
                AddTile(TileID.DemonAltar).
                Register();
        }
    }
}
