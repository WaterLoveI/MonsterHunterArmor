using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class FineBlackPearl : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLightPurpleBuyPrice;
            Item.rare = ItemRarityID.LightPurple;
            Item.maxStack = 999;
        }
    }
}
