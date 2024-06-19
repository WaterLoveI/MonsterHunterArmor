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
        public static readonly int Damage = 5;
        public static readonly int IceAttack = 3;
        public static readonly int PolarHunter = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, IceAttack, PolarHunter);


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
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.IceAttack += IceAttack;
            modPlayer.PolarHunter += PolarHunter;
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