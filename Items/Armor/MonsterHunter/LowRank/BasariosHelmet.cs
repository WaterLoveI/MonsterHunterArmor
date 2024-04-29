using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class BasariosHelmet : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AntiPoison += 1;
            modPlayer.Guard += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
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