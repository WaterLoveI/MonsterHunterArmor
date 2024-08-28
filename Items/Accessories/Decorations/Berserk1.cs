using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria.Localization;

namespace MHArmorSkills.Items.Accessories.Decorations
{
    public class Berserk1 : ModItem
    {
        public static readonly int SkillPoint = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(SkillPoint);
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.accessory = true;
            Item.vanity = true;
            Item.maxStack = 9999;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateEquip(Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Berserk += 1;
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




