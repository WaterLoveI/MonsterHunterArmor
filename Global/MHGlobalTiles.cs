using MHArmorSkills.MHPlayer;
using MHArmorSkills.Utilities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public class MHGlobalTiles : GlobalTile
    {

        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {



            Tile tile = Main.tile[i, j];

            if (Main.LocalPlayer.GetModPlayer<ArmorSkills>().Geologist >= 1)
            {
                int item = tile.GetOreItemID();
                Vector2 pos = new Vector2(i, j) * 16;
                int GeologistChance = 4 - Main.LocalPlayer.GetModPlayer<ArmorSkills>().Geologist;

                if (Main.rand.NextBool(GeologistChance) && item != -1)
                {
                    Item.NewItem(new EntitySource_TileBreak(i, j), pos, item);
                }
            }
        }


    }
}