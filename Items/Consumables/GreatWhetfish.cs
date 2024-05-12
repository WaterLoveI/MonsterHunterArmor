using MHArmorSkills.Buffs;
using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Consumables
{
    public class GreatWhetfish : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.UseSound = SoundID.Item37;
            Item.maxStack = 1;
            Item.useTurn = false;
            Item.autoReuse = false;
            Item.consumable = false;
        }

        public override void HoldItem(Player player)
        {
            MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            if (!player.HasBuff(ModContent.BuffType<Sharpness>()))
            {
                int Timer = 45;
                if (modPlayer.RazorSharp >= 1)
                {
                    Timer += 45 * modPlayer.RazorSharp;
                }
                player.AddBuff(ModContent.BuffType<Sharpness>(), Timer * 60);
                SoundEngine.PlaySound(SoundID.Item37);
            }
        }
    }
}