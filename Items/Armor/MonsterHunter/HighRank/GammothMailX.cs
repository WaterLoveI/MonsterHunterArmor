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
    [AutoloadEquip(EquipType.Body)]
    public class GammothMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.moveSpeed += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += 3;
            modPlayer.TremorRes += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GammothHelm>().
                AddIngredient<MizutsuneWaterOrb>().
                AddIngredient<GammothIceOrb>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}