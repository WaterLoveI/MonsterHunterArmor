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
    public class SeltasGreaves : ModItem
    {
        public static readonly int Movement = 5;
        public static readonly int Minion = 1;
        public static readonly int Hero = 1;
        public static readonly int GuardUp = 1;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movement, Minion, Hero, GuardUp, Decor);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Movement / 100f;
            player.maxMinions += Minion;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeroShield += Hero;
            modPlayer.GuardUp += GuardUp;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeltasShell>(3).
                AddIngredient<Bubblefoam>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}