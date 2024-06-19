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
    public class CeanataurHelm : ModItem
    {
        public static readonly int Crit = 5;
        public static readonly int CriticalEye = 1;
        public static readonly int RazorSharp = 1;
        public static readonly int Decor1 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, CriticalEye, RazorSharp, Decor1);
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += 5;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RazorSharp += 1;
            modPlayer.CritEye += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<HermitaurHelm>().
                AddIngredient<CrabPearl>(1).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}