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
    public class QurupecoHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 36;
            Item.height = 30;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.10f;
            player.GetCritChance<GenericDamageClass>() += 10;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Evasion += 1;
            modPlayer.FreeMeal += 1;
            modPlayer.RecoveryUp += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KutkuHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FeyWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}