using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.BiomeBones;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class LagiacrusHelm : ModItem
    {
        public static readonly int Crit = 5;
        public static readonly int Mana = 20;
        public static readonly int Stamina = 2;
        public static readonly int Guard = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Mana,Stamina, Guard);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Crit;
            player.statManaMax2 += Mana;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.StamRec += Stamina;
            modPlayer.Guard += Guard;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<CoralBone2>(1).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}