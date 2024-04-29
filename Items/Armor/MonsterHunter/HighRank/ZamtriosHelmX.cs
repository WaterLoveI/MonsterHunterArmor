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
    public class ZamtriosHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.moveSpeed += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AMobility += 2;
            modPlayer.RecSpeed += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ZamtriosHelm>().
                AddIngredient<FreezerSac>(3).
                AddIngredient(ItemID.IceSickle).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}