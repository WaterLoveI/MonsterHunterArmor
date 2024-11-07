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
    public class BasariosMail : ModItem
    {
        public static readonly int MeleeSpeed = 5;
        public static readonly int DefenseBoost = 2;
        public static readonly int Diversion = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MeleeSpeed, DefenseBoost, Diversion);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<GenericDamageClass>() += MeleeSpeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += DefenseBoost;
            modPlayer.Diversion += Diversion;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient(ItemID.StoneBlock, 25).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }

    }
}