using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class GlavenusGreavesX : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Move = 15;
        public static readonly int Spirit = 2;
        public static readonly int Razor = 1;
        public static readonly int Decor1 = 1;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Spirit, Razor, Decor1, Decor2);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Spirit += Spirit;
            modPlayer.RazorSharp += Razor;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
            SlotPlayer.DecorationTwoSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GlavenusGreaves>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingShard>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}