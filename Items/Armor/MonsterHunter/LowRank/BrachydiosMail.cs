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
    [AutoloadEquip(EquipType.Body)]
    public class BrachydiosMail : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int Chall = 2;
        public static readonly int Spirit = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Chall, Spirit);



        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 28;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Spirit += Spirit;
            modPlayer.ChallengeSheatheCloseRangeUp += Chall;
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