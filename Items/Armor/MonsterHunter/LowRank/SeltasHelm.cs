using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class SeltasHelm : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int Minion = 1;
        public static readonly int Hero = 2;
        public static readonly int Guard = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Minion,Hero, Guard);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.maxMinions += Minion;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeroShield += Hero;
            modPlayer.Guard += Guard;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeltasShell>(3).
                AddIngredient<Bubblefoam>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}