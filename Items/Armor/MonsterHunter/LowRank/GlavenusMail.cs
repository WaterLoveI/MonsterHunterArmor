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
    [AutoloadEquip(EquipType.Body)]
    public class GlavenusMail : ModItem
    {
        public static readonly int Critical = 5;
        public static readonly int Attack = 1;
        public static readonly int RazorSharp = 1;
        public static readonly int Decor = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Critical, Attack, RazorSharp, Decor);
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 8;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += Critical;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RazorSharp += RazorSharp;
            modPlayer.Attack += Attack;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FlameSac>(3).
                AddIngredient<FlamingScale>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}