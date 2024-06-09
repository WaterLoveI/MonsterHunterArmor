using MHArmorSkills.Items.Accessories.Decorations;
using MHArmorSkills.Items.Consumables;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MHArmorSkills
{
    public class MHARecipes : ModSystem
    {
        public static int Any1SlotDecor, Any2SlotDecor, Any3SlotDecor;
        public static int Rare;

        public override void AddRecipeGroups()
        {
            int[] OneSlotArray = MHLists.OneSlotDecorations.ToArray();
            int[] TwoSlotArray = MHLists.TwoSlotDecorations.ToArray();
            int[] ThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
            RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} 1 slot decoration",
                OneSlotArray)
                ;
            Any1SlotDecor = RecipeGroup.RegisterGroup("Any1SlotDecor", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} 2 slot decoration",
                TwoSlotArray)
                ;
            Any2SlotDecor = RecipeGroup.RegisterGroup("Any2SlotDecor", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} 3 slot decoration",
                ThreeSlotArray)
                ;
            Any3SlotDecor = RecipeGroup.RegisterGroup("Any3SlotDecor", group);

            group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} Rare Drop",
                ModContent.ItemType<RathalosRuby>(),
                ModContent.ItemType<ZinogreJasper>(),
                ModContent.ItemType<MizutsuneWaterOrb>(),
                ModContent.ItemType<GammothIceOrb>()
                )
                ;
            Any3SlotDecor = RecipeGroup.RegisterGroup("Any3SlotDecor", group);
        }
       public override void AddRecipes()
        {
            foreach (int itemType in MHLists.OneSlotDecorations)
            {
                Recipe recipe = Recipe.Create(itemType);
                recipe.AddIngredient(ModContent.ItemType<HeavyArmorSphere>(),10);
                recipe.AddRecipeGroup(Any1SlotDecor);
                recipe.AddRecipeGroup(Any1SlotDecor);
                recipe.AddRecipeGroup(Any1SlotDecor);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.DisableDecraft();
                recipe.Register();
            }
            foreach (int itemType in MHLists.TwoSlotDecorations)
            {
                Recipe recipe = Recipe.Create(itemType);
                recipe.AddIngredient(ModContent.ItemType<KingArmorSphere>(), 10);
                recipe.AddRecipeGroup(Any2SlotDecor);
                recipe.AddRecipeGroup(Any2SlotDecor);
                recipe.AddRecipeGroup(Any2SlotDecor);
                recipe.AddRecipeGroup(Any2SlotDecor);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.DisableDecraft();
                recipe.Register();
            }
            foreach (int itemType in MHLists.ThreeSlotDecorations)
            {
                Recipe recipe = Recipe.Create(itemType);
                recipe.AddIngredient(ModContent.ItemType<TrueArmorSphere>(), 10);
                recipe.AddRecipeGroup(Any3SlotDecor);
                recipe.AddRecipeGroup(Any3SlotDecor);
                recipe.AddRecipeGroup(Any3SlotDecor);
                recipe.AddRecipeGroup(Any3SlotDecor);
                recipe.AddRecipeGroup(Any3SlotDecor);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.DisableDecraft();
                recipe.Register();
            }
            Recipe WhetfishFood = Recipe.Create(ItemID.SeafoodDinner);
            WhetfishFood.AddIngredient(ModContent.ItemType<Whetfish>(), 1);
            WhetfishFood.AddTile(TileID.CookingPots);
            WhetfishFood.DisableDecraft();
            WhetfishFood.Register();

            Recipe GWhetfishFood = Recipe.Create(ItemID.SeafoodDinner);
            GWhetfishFood.AddIngredient(ModContent.ItemType<GreatWhetfish>(), 1);
            GWhetfishFood.AddTile(TileID.CookingPots);
            GWhetfishFood.DisableDecraft();
            GWhetfishFood.Register();

            Recipe SushifishFood = Recipe.Create(ItemID.SeafoodDinner);
            SushifishFood.AddIngredient(ModContent.ItemType<Sushifish>(), 1);
            SushifishFood.AddTile(TileID.CookingPots);
            SushifishFood.DisableDecraft();
            SushifishFood.Register();
        }
    }
}
