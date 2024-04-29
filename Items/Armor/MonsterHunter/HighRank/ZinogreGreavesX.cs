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
    public class ZinogreGreavesX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 10;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.LatentPower += 2;
            modPlayer.Evasion += 2;
            modPlayer.ZinogreEssence += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ZinogreGreaves>().
                AddIngredient<BoltScale>(3).
                AddIngredient<DeathlyShocker>(3).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}