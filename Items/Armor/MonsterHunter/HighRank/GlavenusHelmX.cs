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
    [AutoloadEquip(EquipType.Head)]
    public class GlavenusHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 12;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Handicraft += 2;
            modPlayer.Grinder += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GlavenusHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingShard>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}