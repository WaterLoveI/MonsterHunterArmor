using MHArmorSkills;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

public class DecorationSlots : ModPlayer
{
    public int DecorationOneSlots;
    public int DecorationTwoSlots;
    public int DecorationThreeSlots;
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

                Item item = Main.HoverItem;
                if (MHLists.ArmorDecorations.Contains(item.type))
                {

                    hoveredItem = item;
                    Main.HoverItem.social = false;
                }
            }
            else
            {

                Item item = Main.HoverItem;
                if (MHLists.ArmorDecorations.Contains(item.type))
                {

                    hoveredItem = item;
                    Main.HoverItem.social = false;
                }
            }
        }
        if (context == ItemSlot.Context.EquipArmorVanity)
        {

            Item item = Main.HoverItem;
            if (MHLists.ArmorDecorations.Contains(item.type))
            {

                hoveredItem = item;
                hoveredItemIsSocialArmor = true;
                Main.HoverItem.social = false;
            }
        }
    }

    public override void UpdateEquips()
    {

        int start = 13;
        int end = 20;

        for (int k = start; k < end; k++)
        {
            Item item = Player.armor[k];
            if (!item.IsAir && Player.IsItemSlotUnlockedAndUsable(k) && (!item.expertOnly || Main.expertMode))
            {
                if (MHLists.ArmorDecorations.Contains(item.type))
                {
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