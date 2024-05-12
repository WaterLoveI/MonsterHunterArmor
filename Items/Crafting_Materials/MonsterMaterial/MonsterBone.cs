using MHArmorSkills.Global;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class MonsterBone : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.maxStack = 999;
        }
    }
}
