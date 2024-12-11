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
    public class BnahabraHat : ModItem
    {
        public static readonly int Fencing = 1;
        public static readonly int RazorSharp = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Fencing, RazorSharp);
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Fencing += Fencing;
            modPlayer.RazorSharpSpareShot += RazorSharp;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterFluid>(3).
                AddIngredient<InsectShell>(5).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}