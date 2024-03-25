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
        }
    }
}
