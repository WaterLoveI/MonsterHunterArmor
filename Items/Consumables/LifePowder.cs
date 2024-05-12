using MHArmorSkills.Global;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Consumables
{
    public class LifePowder : ModItem
    {
        // trying to make it work but it doesnt seem to work right now.
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.UseSound = SoundID.Item4;
            Item.maxStack = 9999;
            Item.healLife = 75;
            Item.potion = true;
            Item.UseSound = SoundID.Item3;
            Item.useTurn = true;
            Item.autoReuse = true;
        }

        public override void OnConsumeItem(Terraria.Player player)
        {
            base.OnConsumeItem(player);
            float range = 800f;
            for (int i = 0; i < Main.player.Length; i++)
            {
                Terraria.Player teammate = Main.player[i];

                if (i != player.whoAmI && teammate.active && teammate.team == player.team && Vector2.Distance(player.Center, teammate.Center) < range)
                {
                    teammate.statLife += Item.healLife;
                    teammate.HealEffect(Item.healLife);
                    teammate.AddBuff(BuffID.PotionSickness, 3600);
                    Dust.NewDust(teammate.position, teammate.width, teammate.height, DustID.GreenFairy, 0f, -1f, 0, default, 1f);
                }
            }
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];

                if (npc.active && npc.CanBeChasedBy(player) && Vector2.Distance(player.Center, npc.Center) < range && npc.friendly)
                {
                    npc.life += Item.healLife;
                    npc.HealEffect(Item.healLife);
                    npc.AddBuff(BuffID.PotionSickness, 3600);
                    Dust.NewDust(npc.position, npc.width, npc.height, DustID.GreenFairy, 0f, -1f, 0, default, 1f);
                }
            }
        }


    }
}