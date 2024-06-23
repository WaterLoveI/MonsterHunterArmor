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
    public class HornetaurHelm : ModItem
    {
        public static readonly int Protection = 1;
        public static readonly int SpareShot = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Protection, SpareShot);
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.SpareShot += SpareShot;
            modPlayer.Protection += Protection;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KonchuHelm>().
                AddIngredient<InsectShell>(3).
                AddIngredient<ArmorSphere>(2).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}