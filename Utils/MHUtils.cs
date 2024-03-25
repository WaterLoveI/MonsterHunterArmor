using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills
{
    public static partial class MHUtils
    {
        public static Vector2 RandomVelocity(float directionMult, float speedLowerLimit, float speedCap, float speedMult = 0.1f)
        {
            Vector2 velocity = new Vector2(Main.rand.NextFloat(-directionMult, directionMult), Main.rand.NextFloat(-directionMult, directionMult));
            //Rerolling to avoid dividing by zero
            while (velocity.X == 0f && velocity.Y == 0f)
            {
                velocity = new Vector2(Main.rand.NextFloat(-directionMult, directionMult), Main.rand.NextFloat(-directionMult, directionMult));
            }
            velocity.Normalize();
            velocity *= Main.rand.NextFloat(speedLowerLimit, speedCap) * speedMult;
            return velocity;
        }
        public static bool StandingStill(this Terraria.Player player, float velocity = 0.05f) => player.velocity.Length() < velocity;
        /// <summary>
        /// Checks if the player is ontop of solid ground. May also check for solid ground for X tiles in front of them
        /// </summary>
        /// <param name="player">The Player whose position is being checked</param>
        /// <param name="solidGroundAhead">How many tiles in front of the player to check</param>
        /// <param name="airExposureNeeded">How many tiles above every checked tile are checked for non-solid ground</param>
        public static bool CheckSolidGround(this Terraria.Player player, int solidGroundAhead = 0, int airExposureNeeded = 0)
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
        public static Item ActiveItem(this Player player) => Main.mouseItem.IsAir ? player.HeldItem : Main.mouseItem;
        public static bool IsTileSolidGround(this Tile tile) => tile != null && tile.HasUnactuatedTile && (Main.tileSolid[tile.TileType] || Main.tileSolidTop[tile.TileType]);
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

    }
}