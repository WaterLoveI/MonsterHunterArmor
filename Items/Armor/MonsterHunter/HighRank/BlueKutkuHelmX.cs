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
    [AutoloadEquip(EquipType.Head)]
    public class BlueKutkuHelmX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Move = 10;
        public static readonly int Atk = 2;
        public static readonly int CritEye = 1;
        public static readonly int FireAttack = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Atk, CritEye, FireAttack);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 12;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += FireAttack;
            modPlayer.Attack += Atk;
            modPlayer.CritEye += CritEye;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BlueKutkuHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FeyWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}