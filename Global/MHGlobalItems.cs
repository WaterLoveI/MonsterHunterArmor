﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public class MHGlobalItems : GlobalItem
    {
        #region Money From Rarity
        public static readonly int Rarity0BuyPrice = Item.buyPrice(0, 0, 50, 0);
        public static readonly int Rarity1BuyPrice = Item.buyPrice(0, 1, 0, 0);
        public static readonly int Rarity2BuyPrice = Item.buyPrice(0, 2, 0, 0);
        public static readonly int Rarity3BuyPrice = Item.buyPrice(0, 3, 0, 0);
        public static readonly int Rarity4BuyPrice = Item.buyPrice(0, 10, 0, 0);
        public static readonly int Rarity5BuyPrice = Item.buyPrice(0, 20, 0, 0);
        public static readonly int Rarity6BuyPrice = Item.buyPrice(0, 30, 0, 0);
        public static readonly int Rarity7BuyPrice = Item.buyPrice(0, 40, 0, 0);
        public static readonly int Rarity8BuyPrice = Item.buyPrice(0, 50, 0, 0);
        public static readonly int Rarity9BuyPrice = Item.buyPrice(0, 60, 0, 0);
        public static readonly int Rarity10BuyPrice = Item.buyPrice(1, 0, 0, 0);
        public static readonly int Rarity11BuyPrice = Item.buyPrice(1, 10, 0, 0);


        public static readonly int RarityWhiteBuyPrice = Item.buyPrice(0, 0, 50, 0);
        public static readonly int RarityBlueBuyPrice = Item.buyPrice(0, 1, 0, 0);
        public static readonly int RarityGreenBuyPrice = Item.buyPrice(0, 2, 0, 0);
        public static readonly int RarityOrangeBuyPrice = Item.buyPrice(0, 3, 0, 0);
        public static readonly int RarityLightRedBuyPrice = Item.buyPrice(0, 10, 0, 0);
        public static readonly int RarityPinkBuyPrice = Item.buyPrice(0, 20, 0, 0);
        public static readonly int RarityLightPurpleBuyPrice = Item.buyPrice(0, 30, 0, 0);
        public static readonly int RarityLimeBuyPrice = Item.buyPrice(0, 40, 0, 0);
        public static readonly int RarityYellowBuyPrice = Item.buyPrice(0, 50, 0, 0);
        public static readonly int RarityCyanBuyPrice = Item.buyPrice(0, 60, 0, 0);
        public static readonly int RarityRedBuyPrice = Item.buyPrice(1, 0, 0, 0);
        public static readonly int RarityPurpleBuyPrice = Item.buyPrice(1, 10, 0, 0);


        public static int GetBuyPrice(int rarity)
        {
            switch (rarity)
            {
                case 0:
                    return Rarity0BuyPrice;
                case 1:
                    return Rarity1BuyPrice;
                case 2:
                    return Rarity2BuyPrice;
                case 3:
                    return Rarity3BuyPrice;
                case 4:
                    return Rarity4BuyPrice;
                case 5:
                    return Rarity5BuyPrice;
                case 6:
                    return Rarity6BuyPrice;
                case 7:
                    return Rarity7BuyPrice;
                case 8:
                    return Rarity8BuyPrice;
                case 9:
                    return Rarity9BuyPrice;
                case 10:
                    return Rarity10BuyPrice;
                case 11:
                    return Rarity11BuyPrice;
            }


            // Return 0 if it's not a progression based or other mod's rarity
            return 0;
        }

        public static int GetBuyPrice(Item item)
        {
            return GetBuyPrice(item.rare);
        }
        #endregion

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            bool isIncomingItemInList = MHLists.ArmorDecorations.Contains(incomingItem.type);
            if (isIncomingItemInList)
            {
                return false;
            }
            if (!isIncomingItemInList)
            {
                for (int i = 0; i < player.armor.Length; i++)
                {
                    // If the player has an item equipped that is the same type as the incoming item
                    if (player.armor[i].type == incomingItem.type)
                    {
                        // Prevent the incoming item from being equipped if it's a duplicate
                        return true;
                    }
                }
            }
            return false;
        }
        public override void SetDefaults(Item entity)
        {
            // got lazy to copy paste to all the decor .cs
            
            bool isIncomingItemInList = MHLists.ArmorDecorations.Contains(entity.type);
            if (isIncomingItemInList)
            {
                entity.maxStack = 9999;
                entity.value = Item.sellPrice(0, 0, 50, 0);
            }
        }

    }
}