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
    [AutoloadEquip(EquipType.Legs)]
    public class ArzurosGreaves : ModItem
    {
        public static readonly int MeleeSpeed = 5;
        public static readonly int Honey = 1;
        public static readonly int StunRes = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MeleeSpeed,Honey, StunRes);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<MeleeDamageClass>() += MeleeSpeed/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HoneyHunter += Honey;
            modPlayer.Stunresist += StunRes;
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