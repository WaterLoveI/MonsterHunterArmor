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
    public class KutkuHelm : ModItem
    {
        public static readonly int Crit = 3;
        public static readonly int Attack = 1;
        public static readonly int FAttack = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Attack, FAttack);


        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 21;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += FAttack;
            modPlayer.Attack += Attack;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BirdWyvernGem>().
                AddIngredient(ItemID.Feather,3).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}