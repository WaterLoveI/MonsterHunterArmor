using MHArmorSkills.MHPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria;
using MHArmorSkills.Buffs;
using Microsoft.Xna.Framework;
using MHArmorSkills.Items.Crafting_Materials;
using MHArmorSkills.Global;

namespace MHArmorSkills.Items.Consumables
{
    public class LifePowder : ModItem
    {
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
            Item.healLife = 75; // Modify this value to change the amount healed
            Item.potion = true; // Treat it as a healing potion
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
                    teammate.AddBuff(BuffID.PotionSickness, 3600); // Apply potion sickness for 60 seconds (60 * 60 = 3600 frames)
                    Dust.NewDust(teammate.position, teammate.width, teammate.height, DustID.GreenFairy, 0f, -1f, 0, default, 1f);
                }
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.HealingPotion, 4).
                AddIngredient(ItemID.PurificationPowder, 4).
                AddIngredient(ItemID.JungleSpores, 4).
                AddTile(TileID.AlchemyTable).
                Register();
        }
    }
}