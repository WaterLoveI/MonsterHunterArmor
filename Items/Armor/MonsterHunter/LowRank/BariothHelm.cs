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
    public class BariothHelm : ModItem
    {
        public static readonly int Movespeed = 10;
        public static readonly int CritEye = 1;
        public static readonly int IceAttack = 1;
        public static readonly int Evasion = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movespeed, CritEye, IceAttack, Evasion);


        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Movespeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.CritEye += CritEye;
            modPlayer.IceAttack += IceAttack;
            modPlayer.Evasion += Evasion;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FrostSac>(2).
                AddIngredient<AmberTusk>(3).
                AddIngredient<HardArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}