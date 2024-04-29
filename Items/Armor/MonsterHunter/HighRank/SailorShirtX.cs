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
    [AutoloadEquip(EquipType.Body)]
    public class SailorShirtX : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AMobility += 1;
            modPlayer.WaterAttack += 3;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SailorShirt>(3).
                AddIngredient(ItemID.SoulofLight, 5).
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}