using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public class GlobalItemBuffSkills : GlobalItem
    {


        public override void GetHealLife(Item item, Player player, bool quickHeal, ref int healValue)
        {

            if (item.healLife > 0 && player.GetModPlayer<MHPlayerArmorSkill>().RecoveryUp >= 1)
            {
                healValue = (int)(healValue * (player.GetModPlayer<MHPlayerArmorSkill>().RecoveryUp));
            }
        }
        public override bool ConsumeItem(Item item, Terraria.Player player)
        {
            if ((item.consumable && item.buffTime > 0 && player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal >= 1) && Main.rand.NextBool(player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal))
            {
                return false;
            }
            if ((item.consumable && item.healLife > 0 && player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal >= 1) && Main.rand.NextBool(player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal))
            {
                return false;
            }
            if ((item.consumable && item.healMana > 0 && player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal >= 1) && Main.rand.NextBool(player.GetModPlayer<MHPlayerArmorSkill>().FreeMeal))
            {
                return false;
            }
            return base.ConsumeItem(item, player);
        }

        public override void OnConsumeItem(Item item, Terraria.Player player)
        {
            base.OnConsumeItem(item, player);
            if (item.healLife > 0 && player.GetModPlayer<ArmorSkills>().Gluttony == 1)
            {

                player.statMana += (int)(item.healLife * 0.3f);
                player.ManaEffect((int)(item.healLife * 0.3f));
            }
            if (item.healLife > 0 && player.GetModPlayer<ArmorSkills>().Gluttony == 2)
            {

                player.statMana += (int)(item.healLife * 0.6f);
                player.ManaEffect((int)(item.healLife * 0.6f));
            }
            if (item.healLife > 0 && player.GetModPlayer<ArmorSkills>().Gluttony >= 3)
            {

                player.statMana += (int)(item.healLife);
                player.ManaEffect((int)(item.healLife));
            }

        }
        public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            #region Sharpness
            if (player.GetModPlayer<MHPlayerArmorSkill>().Sharpness)
            {
                int SharpnessDust = item.rare + player.GetModPlayer<MHPlayerArmorSkill>().Handicraft;
                if (SharpnessDust > 11)
                {
                    SharpnessDust = 11;
                }
                int dustCount = 5; // Change this value to control the number of dust particles
                switch (SharpnessDust)
                {
                    case 0:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.Cloud, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 1:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.PurificationPowder, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.CursedTorch, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 3:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.YellowStarDust, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 4:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.CrimsonTorch, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 5:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.CorruptTorch, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 6:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.HallowedTorch, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 7:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.TerraBlade, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 8:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.InfernoFork, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 9:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.FrostHydra, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 10:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.DesertTorch, target.velocity.X, target.velocity.Y);
                        }
                        break;
                    case 11:
                        for (int i = 0; i < dustCount; i++)
                        {
                            Dust.NewDust(target.position, target.width, target.height, DustID.VioletMoss, target.velocity.X, target.velocity.Y);
                        }
                        break;
                }
            }
            #endregion
        }
    }
}