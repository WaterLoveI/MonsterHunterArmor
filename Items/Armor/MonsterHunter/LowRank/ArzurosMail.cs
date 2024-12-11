using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class ArzurosMail : ModItem
    {
        public static readonly int MeleeSpeed = 5;
        public static readonly int Const = 1;
        public static readonly int DefenseBoost = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MeleeSpeed,Const, DefenseBoost);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<MeleeDamageClass>() += MeleeSpeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Constitution += Const;
            modPlayer.DefenseBoost += DefenseBoost;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BeastGem>().
                AddIngredient(ItemID.BottledHoney, 3).
                AddIngredient<ArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}