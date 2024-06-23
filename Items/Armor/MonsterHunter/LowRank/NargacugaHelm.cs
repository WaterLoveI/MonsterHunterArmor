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
    public class NargacugaHelm : ModItem
    {
        public static readonly int Crit = 5;
        public static readonly int evade = 2;
        public static readonly int evasion = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, evade, evasion);

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance(DamageClass.Generic) += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.EvadeDistance += evade;
            modPlayer.Evasion += evasion;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.NinjaHood).
                AddIngredient<EbonShell>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}