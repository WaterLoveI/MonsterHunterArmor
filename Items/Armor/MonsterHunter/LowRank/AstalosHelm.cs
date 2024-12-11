using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.Localization;

using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class AstalosHelm : ModItem
    {
        public static readonly int Movespeed = 10;
        public static readonly int ThunderAttack = 2;
        public static readonly int Vault = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movespeed, ThunderAttack, Vault);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Movespeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.ThunderAttack += ThunderAttack;
            modPlayer.Vault += Vault;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FulgurBug>(2).
                AddIngredient<ElectroShocker>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}