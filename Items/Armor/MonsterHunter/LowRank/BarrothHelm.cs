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
    public class BarrothHelm : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int AttackBoost = 1;
        public static readonly int DefenceBoost = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, AttackBoost, DefenceBoost);

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += DefenceBoost;
            modPlayer.Attack += AttackBoost;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient(ItemID.MudBlock, 50).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}