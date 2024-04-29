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
    public class BariothHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 10;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.CritEye += 1;
            modPlayer.IceAttack += 3;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BariothHelm>().
                AddIngredient<FreezerSac>(3).
                AddIngredient<AmberHardfang>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}