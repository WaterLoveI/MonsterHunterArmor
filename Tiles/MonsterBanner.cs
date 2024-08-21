using MHArmorSkills.NPCs.NormalNPC.Bnahabra;
using MHArmorSkills.NPCs.NormalNPC.Bullfango;
using MHArmorSkills.NPCs.NormalNPC.Bugs;
using MHArmorSkills.NPCs.NormalNPC.Delex;
using MHArmorSkills.NPCs.NormalNPC.Remobra;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MHArmorSkills.Tiles
{
    public class MonsterBanner : ModTile
    {
        public override void SetStaticDefaults()
        {
            DustType = -1;

            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[3]
            {
                16,
                16,
                16
            };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom | AnchorType.PlanterBox, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.Platform, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.DrawYOffset = -10;
            TileObjectData.addAlternate(0);
            TileObjectData.addTile(Type);
        }
        public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
        {
            if ((tileFrameY == 0 && Main.tileSolidTop[Main.tile[i, j - 1].TileType]) || (tileFrameY == 18 && Main.tileSolidTop[Main.tile[i, j - 2].TileType]) || (tileFrameY == 36 && Main.tileSolidTop[Main.tile[i, j - 3].TileType]))
            {
                offsetY -= 8;
            }
            base.SetDrawPositions(i, j, ref width, ref offsetY, ref height, ref tileFrameX, ref tileFrameY);
        }
        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].TileFrameX / 18;
                int npc = GetBannerNPC(style);
                if (npc != -1)
                {
                    Main.SceneMetrics.NPCBannerBuff[npc] = true;
                    Main.SceneMetrics.hasBanner = true;
                }

            }

        }
        public static int GetBannerNPC(int style)
        {
            int npc = -1;
            switch (style)
            {
                case 0:
                    npc = ModContent.NPCType<Bullfango>();
                    break;

                case 1:
                    npc = ModContent.NPCType<BnahabraBlue>();
                    break;
                case 2:
                    npc = ModContent.NPCType<BnahabraBrown>();
                    break;
                case 3:
                    npc = ModContent.NPCType<BnahabraGreen>();
                    break;
                case 4:
                    npc = ModContent.NPCType<BnahabraRed>();
                    break;
                case 5:
                    npc = ModContent.NPCType<ThunderBugs>();
                    break;
                case 6:
                    npc = ModContent.NPCType<Delex>();
                    break;
                case 7:
                    npc = ModContent.NPCType<Hornetaur>();
                    break;
                case 8:
                    npc = ModContent.NPCType<Remobra>();
                    break;

                default:
                    break;
            }
            return npc;
        }
    
    

        public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
        {
            if (i % 2 == 1)
            {
                spriteEffects = SpriteEffects.FlipHorizontally;
            }
        }
    }
}