using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class SeltasGreavesX : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int Minion = 1;
        public static readonly int Move = 10;
        public static readonly int Hero = 2;
        public static readonly int Handicraft = 1;
        public static readonly int Razor = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Minion, Move, Hero,Handicraft,Razor, Decor1);

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.maxMinions += Minion;
            player.moveSpeed += Move / 100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RazorSharpSpareShot += Razor;
            modPlayer.HeroShield += Hero;
            modPlayer.HandicraftRapidFire += Handicraft;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeltasGreaves>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<QueenSubstance>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}