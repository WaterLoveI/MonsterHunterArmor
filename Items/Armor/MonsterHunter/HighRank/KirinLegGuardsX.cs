using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class KirinLegGuardsX : ModItem
    {
        public static readonly int Crit = 12;
        public static readonly int Move = 20;
        public static readonly int CritEye = 4;
        public static readonly int Fate = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Move, CritEye, Fate, Decor1);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityCyanBuyPrice;
            Item.rare = ItemRarityID.Cyan;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move / 100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.CritEye += CritEye;
            modPlayer.Fate += Fate;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KirinLegGuards>().
                AddIngredient<ZinogreJasper>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.LunarCraftingStation).
                Register();
        }
    }
}