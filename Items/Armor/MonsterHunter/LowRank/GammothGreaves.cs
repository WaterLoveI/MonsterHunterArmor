using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class GammothGreaves : ModItem
    {
        public static readonly int MoveSpeed = 7;
        public static readonly int Attack = 1;
        public static readonly int Polar = 1;
        public static readonly int Decor = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeed, Attack, Polar, Decor);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += MoveSpeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PolarHunter += Polar;
            modPlayer.Attack += Attack;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SnowClod>(2).
                AddIngredient<AmberTusk>(4).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}