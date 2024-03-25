using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using MHArmorSkills.Items.Consumables;

namespace MHArmorSkills.Global
{
    public class GlobalNPCShop : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {

            int type = shop.NpcType; base.ModifyShop(shop);
            if (type == NPCID.Merchant)
            {
                shop.Add<WhetStone>();
            }
        }
    }
}
