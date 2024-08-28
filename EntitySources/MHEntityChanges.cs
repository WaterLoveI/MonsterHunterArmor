using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using MHArmorSkills.MHPlayer;



namespace MHArmorSkills.EntitySources
{
    public sealed class ExtraItemSkills : GlobalItem
    {
        public override void OnSpawn(Item item, IEntitySource source)
        {
            Player player = Main.LocalPlayer;
            if (player.GetModPlayer<ArmorSkills>().OutdoorsMan >= 2)
            {
                for (int i = 0; i < player.GetModPlayer<ArmorSkills>().OutdoorsMan; i++)
                {

                    if (Main.rand.NextBool(3))
                    {
                        if (source is EntitySource_ShakeTree)
                        {
                            item.stack += player.GetModPlayer<ArmorSkills>().OutdoorsMan;
                        }

                        if (source is EntitySource_Caught)
                        {
                            item.stack += player.GetModPlayer<ArmorSkills>().OutdoorsMan;
                        }
                        if (source is EntitySource_TileBreak)
                        {
                            if (MHLists.OutdoorsmanList.Contains(item.type))
                            {
                                item.stack += player.GetModPlayer<ArmorSkills>().OutdoorsMan;
                            }
                        }
                    }

                }
                if (player.GetModPlayer<ArmorSkills>().OutdoorsMan >= 3)
                {
                    player.GetModPlayer<ArmorSkills>().OutdoorsMan = 3;
                }


            }
        }
        public override void OnCreated(Item item, ItemCreationContext context)
        {
            Player player = Main.LocalPlayer;
            if (player.GetModPlayer<ArmorSkills>().BBQExpert >= 1)
            {
                if (context is RecipeItemCreationContext)
                {
                    if (item.buffType == BuffID.WellFed || item.buffType == BuffID.WellFed2 || item.buffType == BuffID.WellFed3)
                    {
                        item.stack += 1;
                    }
                }
            }
            
        }
    }
}
