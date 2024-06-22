using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Accessories.Decorations
{
    public class IceAttack3 : ModItem
    {
        public static readonly int SkillPoint = 3;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(SkillPoint);
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.accessory = true;
            Item.vanity = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateEquip(Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.IceAttack += 3;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots -= 1;
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            if (SlotPlayer.DecorationThreeSlots >= 1)
            {
                SlotPlayer.DecorationThreeSlots -= 1;
                return true;

            }
            return false;
        }
    }

}




