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
    public class AkantorHelm : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int CritChance = 15;
        public static readonly int CritEye = 2;
        public static readonly int FireAttack = 3;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, CritChance, CritEye, FireAttack);
        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.CritEye += CritEye;
            modPlayer.FireAttack += FireAttack;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FlameSac>(3).
                AddIngredient<FlamingScale>(4).
                AddIngredient<ElderDragonGem>().
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}