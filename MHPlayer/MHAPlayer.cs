using MHArmorSkills.Config;
using MHArmorSkills.Items.Consumables;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

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

        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModContent.GetInstance<MHAconfigs>().OnEnterMessage;
        }
        public override void OnEnterWorld()
        {
            // This data can only be checked in Single Player
            if (Main.netMode != NetmodeID.SinglePlayer)
            {
                return;
            }

            Main.NewText(Language.GetTextValue(Mod.GetLocalizationKey("CheckTheDocs")), Color.Orange);
            Main.NewText(Language.GetTextValue(Mod.GetLocalizationKey("Disable")), Color.Orange);
        }
    }
}
