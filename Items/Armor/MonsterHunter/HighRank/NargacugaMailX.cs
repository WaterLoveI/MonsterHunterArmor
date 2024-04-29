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
    public class NargacugaMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.05f;
            player.GetCritChance<GenericDamageClass>() += 10;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Evasion += 2;
            modPlayer.AdrenalineRush += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<NargacugaMail>().
                AddIngredient<FineBlackPearl>().
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}