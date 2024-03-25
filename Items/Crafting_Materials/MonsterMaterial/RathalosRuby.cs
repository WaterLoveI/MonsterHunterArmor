using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class RathalosRuby : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityCyanBuyPrice;
            Item.rare = ItemRarityID.Cyan;
            Item.maxStack = 999;
        }
    }
}
