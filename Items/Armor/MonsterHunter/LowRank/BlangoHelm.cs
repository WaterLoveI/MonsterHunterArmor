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
    public class BlangoHelm : ModItem
    {
        public static readonly int Skill1 = 1;
        public static readonly int Skill2 = 2;

        

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.IceAttack += 3;
            modPlayer.PolarHunter += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SnowClod>(2).
                AddIngredient<AmberTusk>(2).
                AddIngredient<HardArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}