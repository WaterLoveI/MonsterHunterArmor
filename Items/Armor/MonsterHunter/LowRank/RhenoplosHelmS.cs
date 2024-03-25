using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class RhenoplosHelmS : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 3;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.BombBoost += 1;
            modPlayer.DefenseBoost += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BullfangoMask>().
                AddIngredient<ArmorSphere>(2).
                AddTile(TileID.Anvils).
                Register();
            CreateRecipe().
                AddIngredient<MossSwineHat>().
                AddIngredient<ArmorSphere>(2).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}