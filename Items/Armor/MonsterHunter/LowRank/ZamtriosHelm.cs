using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class ZamtriosHelm : ModItem
    {
        public static readonly int Move = 10;
        public static readonly int RecSpd = 2;
        public static readonly int Ice = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, RecSpd, Ice);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RecSpeed += RecSpd;
            modPlayer.IceAttack += Ice;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<CrabPearl>().
                AddIngredient(ItemID.SharkFin, 5).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}