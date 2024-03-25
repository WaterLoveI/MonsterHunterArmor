using MHArmorSkills;
using MHArmorSkills.Items.Accessories.Decorations;
using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

public partial class DecorationSlots : ModPlayer
{
    public int DecorationOneSlots { get; set; }
    public int DecorationTwoSlots { get; set; }
    public int DecorationThreeSlots { get; set; }
    public override void ResetEffects()
    {
        DecorationOneSlots = 1;
        DecorationTwoSlots = 1;
        DecorationThreeSlots = 1;
    }

    internal Item hoveredItem;
    internal bool hoveredItemIsSocialArmor;

    public override void Load()
    {
        Terraria.UI.On_ItemSlot.MouseHover_ItemArray_int_int += ItemSlot_MouseHover_ItemArray_int_int;
    }

    private void ItemSlot_MouseHover_ItemArray_int_int(Terraria.UI.On_ItemSlot.orig_MouseHover_ItemArray_int_int orig, Item[] inv, int context, int slot)
    {
        orig(inv, context, slot);

        hoveredItem = null;
        hoveredItemIsSocialArmor = false;
        if (context == ItemSlot.Context.EquipAccessoryVanity)
        {
            if (inv == Main.LocalPlayer.armor)
            {
                // Assuming ArmorDecorations is accessible and contains the type IDs of the items you want to affect
                Item item = Main.HoverItem;
                if (MHLists.ArmorDecorations.Contains(item.type))
                {
                    // The item being hovered over is in the ArmorDecorations list
                    hoveredItem = item;
                    Main.HoverItem.social = false;
                }
            }
            else
            {
                // Is a modded slot.
                // Assuming ArmorDecorations is accessible and contains the type IDs of the items you want to affect
                Item item = Main.HoverItem;
                if (MHLists.ArmorDecorations.Contains(item.type))
                {
                    // The item being hovered over is in the ArmorDecorations list
                    hoveredItem = item;
                    Main.HoverItem.social = false;
                }
            }
        }
        if (context == ItemSlot.Context.EquipArmorVanity)
        {
            // Assuming ArmorDecorations is accessible and contains the type IDs of the items you want to affect
            Item item = Main.HoverItem;
            if (MHLists.ArmorDecorations.Contains(item.type))
            {
                // The item being hovered over is in the ArmorDecorations list
                hoveredItem = item;
                hoveredItemIsSocialArmor = true;
                Main.HoverItem.social = false;
            }
        }
    }

    public override void UpdateEquips()
    {
        // Assuming you want to start from the 10th slot for social armor and from the 13th slot otherwise
        int start = 13; // Start from the 10th slot for social armor
        int end = 19; // End at the 20th slot

        for (int k = start; k < end; k++)
        {
            Item item = Player.armor[k];
            if (!item.IsAir && Player.IsItemSlotUnlockedAndUsable(k) && (!item.expertOnly || Main.expertMode))
            {
                if (MHLists.ArmorDecorations.Contains(item.type))
                {
                    if (item.accessory)
                        Player.GrantPrefixBenefits(item);

                    Player.GrantArmorBenefits(item);
                }
                    
            }
        }

        // Apply functional effects for items in slots 13 through 19
        for (int l = 13; l < end; l++)
        {
            Item item = Player.armor[l];
            if (MHLists.ArmorDecorations.Contains(item.type) && Player.IsItemSlotUnlockedAndUsable(l))
                Player.ApplyEquipFunctional(Player.armor[l], Player.hideVisibleAccessory[l - 10]);
        }

        // Handling modded accessory slots
        var loader = LoaderManager.Get<AccessorySlotLoader>();
        var bonusSlotPlayer = Player.GetModPlayer<Terraria.ModLoader.Default.ModAccessorySlotPlayer>();
        for (int k = 0; k < bonusSlotPlayer.SlotCount; k++)
        {
            if (loader.ModdedIsItemSlotUnlockedAndUsable(k, Player))
            {
                var slot = loader.Get(k, Player);
                Item item = slot.VanityItem;

                if (item.accessory)
                    Player.GrantPrefixBenefits(item);

                Player.GrantArmorBenefits(item);
                Player.ApplyEquipFunctional(item, slot.HideVisuals);
            }
        }
    }
}