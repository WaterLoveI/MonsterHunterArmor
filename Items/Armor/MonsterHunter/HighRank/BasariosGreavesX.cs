using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class BasariosGreavesX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 14;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.15f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += 3;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BasariosGreaves>().
                AddIngredient<LrgWyvernGem>().
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}