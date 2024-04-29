using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class BasariosMail : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<GenericDamageClass>() += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += 2;
            modPlayer.Diversion += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient(ItemID.StoneBlock, 25).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }

    }
}