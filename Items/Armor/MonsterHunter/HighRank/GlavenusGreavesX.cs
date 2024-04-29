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
    public class GlavenusGreavesX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.15f;
            player.moveSpeed += 0.15f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Spirit += 2;
            modPlayer.RazorSharp += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GlavenusGreaves>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingShard>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}