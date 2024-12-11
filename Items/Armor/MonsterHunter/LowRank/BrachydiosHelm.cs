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
    public class BrachydiosHelm : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int Spirit = 2;
        public static readonly int BombBoost = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage,Spirit, BombBoost);



        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Spirit += Spirit;
            modPlayer.ArtilleryBombBoost += BombBoost;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MysteriousSlime>(2).
                AddIngredient<EbonShell>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}