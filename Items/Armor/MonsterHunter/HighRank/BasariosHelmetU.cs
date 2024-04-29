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
    public class BasariosHelmetU : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.1f;
            player.GetAttackSpeed<MeleeDamageClass>() += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeatRes += 2;
            modPlayer.Guard += 2;
            modPlayer.OffensiveGuard += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BasariosHelmet>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<LrgWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}