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
    [AutoloadEquip(EquipType.Legs)]
    public class DrothGreaves : ModItem
    {
        public static readonly int movespeed = 7;
        public static readonly int WaterRes = 2;
        public static readonly int Decor = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(movespeed, WaterRes, Decor);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 14;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += movespeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.WaterRes += WaterRes;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.RainCoat).
                AddIngredient(ItemID.Leather,3).
                AddIngredient<ArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
            CreateRecipe().
                AddIngredient(ItemID.RainHat).
                AddIngredient(ItemID.Leather, 3).
                AddIngredient<ArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}