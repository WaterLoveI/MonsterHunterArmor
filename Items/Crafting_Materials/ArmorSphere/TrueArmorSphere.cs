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

namespace MHArmorSkills.Items.Crafting_Materials.ArmorSphere
{
    public class TrueArmorSphere : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(0, 1, 75, 0);
            Item.rare = ItemRarityID.Cyan;
        }
    }
}
