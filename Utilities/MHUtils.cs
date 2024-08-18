using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MHArmorSkills.Utilities
{
    public static partial class MHUtils
    {
        // yea pretty much all from calamity
        public static Vector2 SafeDirectionTo(this Entity entity, Vector2 destination, Vector2? fallback = null)
        {
            // Fall back to zero by default. default(Vector2) could be used in the parameter definition, but
            // this is more clear.
            if (!fallback.HasValue)
                fallback = Vector2.Zero;

            return (destination - entity.Center).SafeNormalize(fallback.Value);
        }
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
        public static bool IsTileSolidGround(this Tile tile) => tile != null && tile.HasUnactuatedTile && (Main.tileSolid[tile.TileType] || Main.tileSolidTop[tile.TileType]);
        public static bool CheckSolidGround(this Player player, int solidGroundAhead = 0, int airExposureNeeded = 0)
        {
            if (player.velocity.Y != 0) // Player gotta be standing still in any case.
                return false;

            Tile checkedTile;
            bool ConditionMet = true;

            int playerCenterX = (int)player.Center.X / 16;
            int playerCenterY = (int)(player.position.Y + (float)player.height - 1f) / 16 + 1;
            for (int i = 0; i <= solidGroundAhead; i++) // Check i tiles in front of the player.
            {
                ConditionMet = Main.tile[playerCenterX + player.direction * i, playerCenterY].IsTileSolidGround();
                if (!ConditionMet)
                    return ConditionMet;

                for (int j = 1; j <= airExposureNeeded; j++) // Check j tiles ontop of each checked tiles for non-solid ground.
                {
                    checkedTile = Main.tile[playerCenterX + player.direction * i, playerCenterY - j];

                    ConditionMet = !(checkedTile != null && checkedTile.HasUnactuatedTile && Main.tileSolid[checkedTile.TileType]); // IsTileSolidGround minus the ground part, to avoid platforms and other half solid tiles messing it up.
                    if (!ConditionMet)
                        return ConditionMet;
                }
            }
            return ConditionMet;

        }
    }
}