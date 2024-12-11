﻿using MHArmorSkills.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MHArmorSkills.DrawLayers
{
    public class ThunderBlightDrawPlayer : PlayerDrawLayer
    {
        public override bool IsHeadLayer => false;

        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo) =>
            drawInfo.drawPlayer.whoAmI == Main.myPlayer
            && drawInfo.drawPlayer.active
            && !drawInfo.drawPlayer.dead
            && !drawInfo.drawPlayer.ghost
            && drawInfo.shadow == 0
            && (drawInfo.drawPlayer.HasBuff(ModContent.BuffType<ThunderBlight>()));

        public override Position GetDefaultPosition() => new Between();

        protected override void Draw(ref PlayerDrawSet drawInfo)
        {
            Player drawPlayer = drawInfo.drawPlayer;

            Texture2D texture = ModContent.Request<Texture2D>("MHArmorSkills/DrawLayers/ThunderBlightDrawPlayer", ReLogic.Content.AssetRequestMode.ImmediateLoad).Value;
            int num156 = texture.Height / 3; //ypos of lower right corner of sprite to draw
            int y3 = num156 * (int)(Main.GlobalTimeWrappedHourly % 0.5 * 3); //ypos of upper left corner of sprite to draw
            Rectangle rectangle = new(0, y3, texture.Width, num156);

            Vector2 drawPos = (drawPlayer.gravDir > 0 ? drawPlayer.Top : drawPlayer.Bottom) - Main.screenPosition;
            drawPos.Y += 20 * drawPlayer.gravDir;
            DrawData data = new(texture, drawPos, rectangle, Color.White, drawPlayer.gravDir < 0 ? MathHelper.Pi : 0f, rectangle.Size() / 2, 1f, SpriteEffects.None, 0);
            drawInfo.DrawDataCache.Add(data);
        }
    }
}
