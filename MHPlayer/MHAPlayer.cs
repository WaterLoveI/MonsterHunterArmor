using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Default;
using Terraria.ModLoader;
using Terraria;
using MHArmorSkills.Items.Consumables;

namespace MHArmorSkills.MHPlayer
{
    public partial class MHAPlayer : ModPlayer
    {
        #region InventoryStartup

        // makes the player start with a whetstone
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            static Item createItem(int type)
            {
                Item i = new Item();
                i.SetDefaults(type);
                return i;
            }

            yield return createItem(ModContent.ItemType<WhetStone>());
        }
        #endregion
    }
}
