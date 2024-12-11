using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class ValstraxGreaves : ModItem
    {
        public static readonly int Move = 20;
        public static readonly int Crit = 20;
        public static readonly int Attack = 3;
        public static readonly int CritBoost = 2;
        public static readonly int Decor1 = 2;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Move, Attack, CritBoost, Decor1, Decor2);
        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityRedBuyPrice;
            Item.rare = ItemRarityID.Red;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move / 100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.CriticalBoost += CritBoost;
            modPlayer.Attack += Attack;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<LrgElderDragonGem>().
                AddIngredient<TrueArmorSphere>(12).
                AddTile(TileID.LunarCraftingStation).
                Register();
        }
    }
}