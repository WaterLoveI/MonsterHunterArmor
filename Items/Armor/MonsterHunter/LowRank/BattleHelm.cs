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
    [AutoloadEquip(EquipType.Head)]
    public class BattleHelm : ModItem
    {
        public static readonly int MeleeSpeed = 5;
        public static readonly int AutoTracker = 1;
        public static readonly int RazorSharp = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MeleeSpeed, AutoTracker,RazorSharp);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 16;
            Item.value = MHGlobalItems.RarityBlueBuyPrice;
            Item.rare = ItemRarityID.Blue;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<MeleeDamageClass>() += MeleeSpeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AutoTracker += AutoTracker;
            modPlayer.RazorSharpSpareShot += RazorSharp;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<YukumoKasa>().
                AddIngredient<ArmorSphere>(2).
                AddTile(TileID.Anvils).
                Register();
            CreateRecipe().
                AddIngredient<BoneHelmet>().
                AddIngredient<ArmorSphere>(2).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}