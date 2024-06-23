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
    public class CongalaHelmU : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Atk = 1;
        public static readonly int FreeMeal = 1;
        public static readonly int Mushroom = 1;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Atk, FreeMeal, Mushroom, Decor);

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.statManaMax2 += 20;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Mushroomancer += Mushroom;
            modPlayer.Attack += Atk;
            modPlayer.FreeMeal += FreeMeal;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<CongalaHelm>().
                AddIngredient<LrgBeastGem>(3).
                AddIngredient(ItemID.TurtleShell).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}