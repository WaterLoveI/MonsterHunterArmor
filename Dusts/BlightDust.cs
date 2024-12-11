using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Dusts
{
    public class FireblightDust : ModDust
    {
        public override string Texture => null;
        public override void OnSpawn(Dust dust)
        {
            int desiredVanillaDustTexture = DustID.HeatRay;
            int frameX = desiredVanillaDustTexture * 10 % 1000;
            int frameY = desiredVanillaDustTexture * 10 / 1000 * 30 + Main.rand.Next(3) * 10;
            dust.frame = new Rectangle(frameX, frameY, 8, 8);

            dust.velocity.Y = Main.rand.Next(-10, 6) * 0.1f;
            dust.velocity.X *= 0.2f;
            dust.scale *= 0.9f;
            dust.alpha *= (int)1.1f;
        }

        public override bool Update(Dust dust)
        {
            dust.rotation += 0.1f * (dust.dustIndex % 2 == 0 ? -1 : 1);
            dust.position += dust.velocity;
            dust.scale -= 0.01f;
            dust.alpha++;
            if (dust.velocity.Y > 0)
            {
                dust.velocity.Y = -dust.velocity.Y;
            }
            float light = 0.35f * dust.scale;
            dust.velocity.X *= 0.9f;
            Lighting.AddLight(dust.position, light, light, light);
            if (dust.scale < 0.3f)
                dust.active = false;

            return false;
        }
    }
    public class WaterblightDust : ModDust
    {
        public override string Texture => null;
        public override void OnSpawn(Dust dust)
        {
            int desiredVanillaDustTexture = DustID.Water;
            int frameX = desiredVanillaDustTexture * 10 % 1000;
            int frameY = desiredVanillaDustTexture * 10 / 1000 * 30 + Main.rand.Next(3) * 10;
            dust.frame = new Rectangle(frameX, frameY, 8, 8);

            dust.velocity.Y = Main.rand.Next(-10, 6) * 0.1f;
            dust.velocity.X *= 0.3f;
            dust.scale *= 1f;
            dust.alpha = 180;
        }

        public override bool Update(Dust dust)
        {
            dust.rotation += 0.1f * (dust.dustIndex % 2 == 0 ? -1 : 1);
            if (dust.velocity.Y < 0)
            {
                dust.velocity.Y = -dust.velocity.Y;
            }
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.Y * 0.15f;
            dust.velocity.X = 0;
            dust.scale -= 0.01f;
            
            if (dust.scale < 0.5f)
                dust.active = false;

            return false;
        }
    }
    public class IceblightDust : ModDust
    {
        public override string Texture => null;
        public override void OnSpawn(Dust dust)
        {
            int desiredVanillaDustTexture = DustID.Snow;
            int frameX = desiredVanillaDustTexture * 10 % 1000;
            int frameY = desiredVanillaDustTexture * 10 / 1000 * 30 + Main.rand.Next(3) * 10;
            dust.frame = new Rectangle(frameX, frameY, 8, 8);

            dust.velocity.Y = Main.rand.Next(-10, 6) * 0.1f;
            dust.velocity.X = Main.rand.Next(-10, 6) * 0.1f;
            dust.scale *= 1.4f;
            dust.alpha = 150;
        }

        public override bool Update(Dust dust)
        {
            dust.rotation += 0.1f * (dust.dustIndex % 2 == 0 ? -1 : 1);
            if (Main.rand.NextBool(2))
            {
                if (dust.velocity.Y < 0)
                {
                    dust.velocity.Y *= 1.01f;
                }
                else
                {
                    dust.velocity.Y *= 0.99f;
                }
            }
            
            dust.position += dust.velocity/2;
            dust.rotation += dust.velocity.Y * 0.15f;
            if (Main.rand.NextBool(3))
            {
                if (dust.velocity.X < 0)
                {
                    dust.velocity.X *= 1.01f;
                }
                else
                {
                    dust.velocity.X *= 0.99f;
                }
            }
            
            dust.scale = Main.rand.Next(-10, 6) * 0.1f;
            dust.alpha--;

            if (dust.alpha == 60)
                dust.active = false;

            return false;
        }
    }
}
