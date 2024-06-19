using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class BoneGreaves : ModItem
    {
        public static readonly int Decor1 = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Decor1);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 2;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterBone>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}