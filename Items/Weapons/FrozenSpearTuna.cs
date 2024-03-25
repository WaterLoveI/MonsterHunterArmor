using Terraria;
using Terraria.ModLoader;
using MHArmorSkills.MHPlayer;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Audio;
using MHArmorSkills.Global;

namespace MHArmorSkills.Items.Weapons
{
    public class FrozenSpearTuna : ModItem
    {
        

        public override void SetDefaults()
        {
            Item.damage = 21;
            Item.DamageType = DamageClass.Melee;
            Item.width = 76;
            Item.height = 74;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = false;
            Item.knockBack = 6f;
            Item.value = MHGlobalItems.RarityBlueBuyPrice; ;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
        }
        public override void OnHitNPC(Terraria.Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            base.OnHitNPC(player, target, hit, damageDone);
            SoundEngine.PlaySound(SoundID.Item153);
            target.AddBuff(BuffID.Wet, 120);
        }

    }
}

