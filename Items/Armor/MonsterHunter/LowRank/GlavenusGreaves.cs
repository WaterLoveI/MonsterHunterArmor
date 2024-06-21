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
    public class GlavenusGreaves : ModItem
    {
        public static readonly int Movement = 7;
        public static readonly int FireAttack = 1;
        public static readonly int Handicraft = 1;
        public static readonly int RazorSharp = 1;
        public static readonly int Decor = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Movement, FireAttack, Handicraft, RazorSharp, Decor);
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
            player.moveSpeed += Movement/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Handicraft += Handicraft;
            modPlayer.RazorSharp += RazorSharp;
            modPlayer.FireAttack += FireAttack;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FlameSac>(2).
                AddIngredient<EbonShell>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}