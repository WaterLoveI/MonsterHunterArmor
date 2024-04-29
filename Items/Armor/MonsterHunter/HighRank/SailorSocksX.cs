using MHArmorSkills.Global;

using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class SailorSocksX : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AMobility += 2;
            modPlayer.WaterAttack += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SailorSocks>(3).
                AddIngredient(ItemID.SoulofLight, 5).
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}