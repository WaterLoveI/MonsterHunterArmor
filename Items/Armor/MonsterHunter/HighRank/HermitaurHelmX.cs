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
    public class HermitaurHelmX : ModItem
    {
            
        public static readonly int Damage = 15;
        public static readonly int Move = 5;
        public static readonly int FreeMeal = 2;
        public static readonly int Guard = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, FreeMeal, Guard, Decor1);

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 12;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FreeMeal += FreeMeal;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<HermitaurHelm>().
                AddIngredient<FineBlackPearl>().
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}