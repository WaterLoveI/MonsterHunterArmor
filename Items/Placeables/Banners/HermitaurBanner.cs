using MHArmorSkills.Global;
using MHArmorSkills.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Placeables.Banners
{
    public class HermitaurBanner : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 28;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.rare = ItemRarityID.Blue;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.createTile = ModContent.TileType<MonsterBanner>();
            Item.placeStyle = 9;
        }
    }
}
