using MHArmorSkills.Buffs;
using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items
{
    public class TestItem : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.maxStack = 999;
            Item.accessory = true;
        }
        public override void UpdateEquip(Terraria.Player player)
        {
            player.AddBuff(ModContent.BuffType<ThunderBlight>(),2);
        }
    }

}
