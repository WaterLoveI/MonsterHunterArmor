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
    [AutoloadEquip(EquipType.Head)]
    public class BattleHelmX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Melee = 10;
        public static readonly int Guard = 2;
        public static readonly int Atk = 1;
        public static readonly int Razor = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Melee, Guard, Atk, Razor);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 16;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 12;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetAttackSpeed<MeleeDamageClass>() += Melee/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Atk;
            modPlayer.RazorSharp += Razor;
            modPlayer.Guard += Guard;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BattleHelm>().
                AddIngredient(ItemID.SoulofLight,5).
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}