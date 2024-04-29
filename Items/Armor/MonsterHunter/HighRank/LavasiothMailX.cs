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
    public class LavasiothMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += 7;
            player.GetAttackSpeed<GenericDamageClass>() += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Guard += 2;
            modPlayer.Resentment += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<LavasiothMail>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<LrgWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}