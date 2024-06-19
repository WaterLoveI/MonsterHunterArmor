using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class BoneMail : ModItem
    {
        public static readonly int TropicHunter = 1;
        public static readonly int Decor1 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(TropicHunter, Decor1);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 3;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.TropicHunter += TropicHunter;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterBone>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}