using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class ZinogreMail : ModItem
    {
        public static readonly int Crit = 5;
        public static readonly int Latent = 2;
        public static readonly int Thunder = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Latent, Thunder);

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.LatentPower += Latent;
            modPlayer.ThunderAttack += Thunder;
            modPlayer.ZinogreEssence += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient<ElectroShocker>(4).
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}