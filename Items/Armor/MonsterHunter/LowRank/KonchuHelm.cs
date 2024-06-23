using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class KonchuHelm : ModItem
    {
        public static readonly int Prot = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Prot);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 2;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Protection += Prot;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterFluid>(2).
                AddIngredient<InsectShell>(2).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}