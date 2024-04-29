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
    public class AstalosGreavesX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.moveSpeed += 0.15f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.ThunderAttack += 2;
            modPlayer.Vault += 1;
            modPlayer.PierceUp += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AstalosGreaves>().
                AddIngredient<ThunderSac>(3).
                AddIngredient<ZinogreJasper>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}