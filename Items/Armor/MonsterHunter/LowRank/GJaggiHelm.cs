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
    public class GJaggiHelm : ModItem
    {
        public static readonly int Movement = 5;
        public static readonly int AttackBoost = 2;
        public static readonly int Gluttony = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movement, AttackBoost, Gluttony);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Movement/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += AttackBoost;
            modPlayer.Gluttony += Gluttony;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<JaggiMask>().
                AddIngredient<BirdWyvernGem>().
                AddIngredient<ArmorSpherePlus>(2).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}