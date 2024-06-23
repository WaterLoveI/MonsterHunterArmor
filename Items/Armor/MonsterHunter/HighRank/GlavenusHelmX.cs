using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class GlavenusHelmX : ModItem
    {
            
        public static readonly int Damage = 12;
        public static readonly int Crit = 12;
        public static readonly int Handicraft = 2;
        public static readonly int Grinder = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Handicraft, Grinder, Decor1);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Handicraft += Handicraft;
            modPlayer.Grinder += Grinder;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GlavenusHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingShard>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}