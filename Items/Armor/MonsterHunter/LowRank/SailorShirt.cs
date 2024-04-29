using MHArmorSkills.Global;

using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class SailorShirt : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Evasion += 1;
            modPlayer.WaterAttack += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.AnglerVest).
                AddIngredient(ItemID.Moonglow, 5).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}