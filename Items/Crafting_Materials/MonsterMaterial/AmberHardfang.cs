using MHArmorSkills.MHPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using MHArmorSkills.Global;

namespace MHArmorSkills.Items.Crafting_Materials.MonsterMaterial
{
    public class AmberHardfang : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.maxStack = 999;
        }
    }
}
