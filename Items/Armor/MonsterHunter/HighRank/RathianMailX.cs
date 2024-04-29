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
    public class RathianMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += 7;
            player.moveSpeed += 0.07f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += 2;
            modPlayer.Protection += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<RathianMail>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FeyWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}