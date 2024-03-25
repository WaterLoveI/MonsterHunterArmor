using MHArmorSkills.Buffs;
using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Consumables
{
    public class WhetStone : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.UseSound = SoundID.Item37;
            Item.maxStack = 1;
            Item.useTurn = false;
            Item.autoReuse = false;
            Item.consumable = false;
            Item.reuseDelay = 70;
        }

        public override bool? UseItem(Player player)
        {
            MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            int Timer = 45;
            if (modPlayer.RazorSharp >= 1)
            {
                Timer += 45 * modPlayer.RazorSharp;
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