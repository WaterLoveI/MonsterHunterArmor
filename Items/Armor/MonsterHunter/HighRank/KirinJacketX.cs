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
    [AutoloadEquip(EquipType.Body)]
    public class KirinJacketX : ModItem
    {
        public static readonly int Damage = 20;
        public static readonly int Crit = 10;
        public static readonly int Protection = 3;
        public static readonly int Fate = 2;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Protection, Fate, Decor1);
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityCyanBuyPrice;
            Item.rare = ItemRarityID.Cyan;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Protection += Protection;
            modPlayer.Fate += Fate;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KirinJacket>().
                AddIngredient<ZinogreJasper>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.LunarCraftingStation).
                Register();
        }
    }
}