using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Utilities
{
    public static partial class MHUtils
    {
        
        public static Item ActiveItem(this Player player) => Main.mouseItem.IsAir ? player.HeldItem : Main.mouseItem;
        public static int GetOreItemID(this Tile tile)
        {
            int item = -1;

            // If it's not ore, then return
            if (!TileID.Sets.Ore[tile.TileType])
                return item;

            ModTile moddedTile = TileLoader.GetTile(tile.TileType);

            //Getting the item drop of a modded tile is pretty easy.
            if (moddedTile != null)
                item = TileLoader.GetItemDropFromTypeAndStyle(moddedTile.Type);

            //There is no easy way for getting vanilla item drops :(
            else
            {
                switch (tile.TileType)
                {
                    case TileID.LunarOre:
                        item = ItemID.LunarOre;
                        break;
                    case TileID.Chlorophyte:
                        item = ItemID.ChlorophyteOre;
                        break;
                    case TileID.Titanium:
                        item = ItemID.TitaniumOre;
                        break;
                    case TileID.Adamantite:
                        item = ItemID.AdamantiteOre;
                        break;
                    case TileID.Orichalcum:
                        item = ItemID.OrichalcumOre;
                        break;
                    case TileID.Mythril:
                        item = ItemID.MythrilOre;
                        break;
                    case TileID.Palladium:
                        item = ItemID.PalladiumOre;
                        break;
                    case TileID.Cobalt:
                        item = ItemID.CobaltOre;
                        break;
                    case TileID.Hellstone:
                        item = ItemID.Hellstone;
                        break;
                    case TileID.Obsidian:
                        item = ItemID.Obsidian;
                        break;
                    case TileID.Meteorite:
                        item = ItemID.Meteorite;
                        break;
                    case TileID.Demonite:
                        item = ItemID.DemoniteOre;
                        break;
                    case TileID.Crimtane:
                        item = ItemID.CrimtaneOre;
                        break;
                    case TileID.Platinum:
                        item = ItemID.PlatinumOre;
                        break;
                    case TileID.Gold:
                        item = ItemID.GoldOre;
                        break;
                    case TileID.Tungsten:
                        item = ItemID.TungstenOre;
                        break;
                    case TileID.Silver:
                        item = ItemID.SilverOre;
                        break;
                    case TileID.Lead:
                        item = ItemID.LeadOre;
                        break;
                    case TileID.Iron:
                        item = ItemID.IronOre;
                        break;
                    case TileID.Tin:
                        item = ItemID.TinOre;
                        break;
                    case TileID.Copper:
                        item = ItemID.CopperOre;
                        break;
                    default:
                        break;
                }
            }

            return item;
        }
        public static bool GiveIFrames(this Player player, int frames, bool blink = false)
        {
            // Check to see if there is any way for the player to get iframes from this operation.
            bool anyIFramesWouldBeGiven = false;
            for (int i = 0; i < player.hurtCooldowns.Length; ++i)
                if (player.hurtCooldowns[i] < frames)
                    anyIFramesWouldBeGiven = true;

            // If they would get nothing, don't do it.
            if (!anyIFramesWouldBeGiven)
                return false;

            // Apply iframes thoroughly.
            // Player.AddImmuneTime does exist, but is equivalent to the below code.
            player.immune = true;
            player.immuneNoBlink = !blink;
            player.immuneTime = frames;
            for (int i = 0; i < player.hurtCooldowns.Length; ++i)
                if (player.hurtCooldowns[i] < frames)
                    player.hurtCooldowns[i] = frames;

            return true;
        }
        #region Fraction Struct (thanks Yorai)
        public struct Fraction
        {
            internal readonly int numerator;
            internal readonly int denominator;

            public Fraction(int n, int d)
            {
                numerator = n < 0 ? 0 : n;
                denominator = d <= 0 ? 1 : d;
            }

            public static implicit operator float(Fraction f) => f.numerator / (float)f.denominator;
        }
        #endregion
        
    }
}