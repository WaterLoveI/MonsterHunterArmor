using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class LrgBeastGem : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLightPurpleBuyPrice;
            Item.rare = ItemRarityID.LightPurple;
            Item.maxStack = 999;
        }
    }
}
