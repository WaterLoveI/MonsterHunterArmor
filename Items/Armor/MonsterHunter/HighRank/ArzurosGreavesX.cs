using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class ArzurosGreavesX : ModItem
    {
        public static readonly int Move = 10;
        public static readonly int Def = 1;
        public static readonly int Honey = 1;
        public static readonly int StunRes = 1;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, Def, Honey,StunRes, Decor);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 12;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move / 100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += Def;
            modPlayer.HoneyHunter += Honey;
            modPlayer.Stunresist += StunRes;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ArzurosGreaves>().
                AddIngredient<LrgBeastGem>(3).
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}