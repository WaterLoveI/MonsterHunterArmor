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
    public class KirinJacket : ModItem
    {
        public static readonly int Crit = 10;
        public static readonly int Mana = 20;
        public static readonly int Protect = 2;
        public static readonly int BlightProof = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Mana, Protect, BlightProof, Decor1);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Crit;
            player.statManaMax2 += Mana;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Protection += Protect;
            modPlayer.BlightProof += BlightProof;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ElderDragonGem>().
                AddIngredient<FulgurBug>(3).
                AddIngredient<ElectroShocker>(4).
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}