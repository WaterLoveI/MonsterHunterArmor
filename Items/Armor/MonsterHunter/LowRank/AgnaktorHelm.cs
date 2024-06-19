using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class AgnaktorHelm : ModItem
    {
        public static readonly int CritChance = 5;
        public static readonly int FireAttack = 1;
        public static readonly int Guard = 2;
        public static readonly int RazorSharp = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, FireAttack, Guard, RazorSharp);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += FireAttack;
            modPlayer.Guard += Guard;
            modPlayer.RazorSharp += RazorSharp;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FlameSac>(2).
                AddIngredient<FlamingScale>(3).
                AddIngredient<HardArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}