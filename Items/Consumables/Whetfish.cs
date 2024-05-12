using MHArmorSkills.Buffs;
using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Consumables
{
    public class Whetfish : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.UseSound = SoundID.Item37;
            Item.maxStack = 1;
            Item.useTurn = false;
            Item.autoReuse = false;
            Item.consumable = false;
        }

        public override bool? UseItem(Player player)
        {
            MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            int Timer = 30;
            if (modPlayer.RazorSharp >= 1)
            {
                Timer += 30 * modPlayer.RazorSharp;
            }
            player.AddBuff(ModContent.BuffType<Sharpness>(), Timer * 60);
            if (modPlayer.Grinder >= 1)
            {
                Timer /= 3;
                player.AddBuff(ModContent.BuffType<Sharpness>(), Timer * 60);
            }
            return base.UseItem(player);
        }
    }
}