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
    [AutoloadEquip(EquipType.Body)]
    public class ZinogreMailZ : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Minion = 1;
        public static readonly int Windproof = 2;
        public static readonly int Negative = 1;
        public static readonly int Unscathed = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage,Minion, Windproof, Negative, Unscathed,Decor1);

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.maxMinions += Minion;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Windproof += Windproof;
            modPlayer.Unscathed += Unscathed;
            modPlayer.NegativeCrit += Negative;
            modPlayer.ZinogreEssence += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ZinogreMail>().
                AddIngredient<DeathlyShocker>(4).
                AddIngredient<ThunderSac>(3).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}