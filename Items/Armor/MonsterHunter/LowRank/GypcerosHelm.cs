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
    public class GypcerosHelm : ModItem
    {
        public static readonly int Movement = 5;
        public static readonly int FreeMeal = 2;
        public static readonly int Poison = 1;
        public static readonly int Decor = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movement, FreeMeal, Poison, Decor);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 30;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Movement/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FreeMeal += FreeMeal;
            modPlayer.AntiPoison += Poison;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BirdWyvernGem>().
                AddIngredient(ItemID.Leather, 3).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}