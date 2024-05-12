using MHArmorSkills.Items.Consumables;
using MHArmorSkills.Items.Weapons;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public class MHFishingLoot : ModPlayer
    {
        public override void CatchFish(FishingAttempt attempt, ref int itemDrop, ref int npcSpawn, ref AdvancedPopupRequest sonar, ref Vector2 sonarPosition)
        {
            base.CatchFish(attempt, ref itemDrop, ref npcSpawn, ref sonar, ref sonarPosition);
            bool inWater = !attempt.inLava && !attempt.inHoney;


            if (inWater && Player.ZoneSnow)
            {
                if (attempt.uncommon && Main.rand.NextBool(7))
                {
                    itemDrop = ModContent.ItemType<FrozenSpearTuna>();
                }
            }
            if (inWater && Player.ZoneRockLayerHeight)
            {
                if (attempt.rare && Main.rand.NextBool(5))
                {
                    itemDrop = ModContent.ItemType<Whetfish>();
                }
            }
            if (inWater && (Player.ZoneJungle || Player.ZoneBeach || Player.ZoneNormalUnderground || Player.ZoneForest || Player.ZoneDesert))
            {
                if (attempt.uncommon && Main.rand.NextBool(5))
                {
                    itemDrop = ModContent.ItemType<Sushifish>();
                }
            }
            if (inWater && Player.ZoneRockLayerHeight && (Player.ZoneCorrupt || Player.ZoneCrimson || Player.ZoneHallow) && Main.hardMode)
            {
                if (attempt.legendary && Main.rand.NextBool(7))
                {
                    itemDrop = ModContent.ItemType<GreatWhetfish>();
                }
            }
        }
    }
}
