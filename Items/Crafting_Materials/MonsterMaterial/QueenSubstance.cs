using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class QueenSubstance : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityLightPurpleBuyPrice;
            Item.rare = ItemRarityID.LightPurple;
            Item.maxStack = 999;
        }
    }
}
