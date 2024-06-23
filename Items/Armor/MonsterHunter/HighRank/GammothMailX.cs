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
    [AutoloadEquip(EquipType.Body)]
    public class GammothMailX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Move = 5;
        public static readonly int Atk = 3;
        public static readonly int Tremor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Atk, Tremor);

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Atk;
            modPlayer.TremorRes += Tremor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GammothHelm>().
                AddIngredient<MizutsuneWaterOrb>().
                AddIngredient<GammothIceOrb>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}