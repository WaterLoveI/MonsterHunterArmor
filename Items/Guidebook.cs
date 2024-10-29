using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items
{
    public class GuideBook : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 999;
        }

    }

}
