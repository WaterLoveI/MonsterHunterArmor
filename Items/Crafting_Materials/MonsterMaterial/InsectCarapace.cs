using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class InsectCarapace : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityLightPurpleBuyPrice;
            Item.rare = ItemRarityID.LightPurple;
            Item.maxStack = 999;
        }
    }
}
