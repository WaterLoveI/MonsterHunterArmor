using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.Audio;
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
            /*MHPlayerArmorSkill modPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
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
            }*/
            SharpnessPlayer modPlayer = player.GetModPlayer<SharpnessPlayer>();
            int SharpnessRestored = 50;
            if (modPlayer.MaxSharpness < modPlayer.CurrentSharpness +50)
            {
                SharpnessRestored = modPlayer.MaxSharpness - modPlayer.CurrentSharpness;
            }
            modPlayer.CurrentSharpness += SharpnessRestored;
            ArmorSkills ModPlayer = player.GetModPlayer<ArmorSkills>();
            MHPlayerArmorSkill SkillPlayer = player.GetModPlayer<MHPlayerArmorSkill>();
            if (ModPlayer.ProtectivePolish >= 1)
            {
                int Duration = (int)(ModPlayer.ProtectivePolish * 15 * 60 * SkillPlayer.ProlongerTime);
                player.AddBuff(ModContent.BuffType<ProtectivePolish>(), Duration);
            }
            return base.UseItem(player);
        }
    }
}