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
    [AutoloadEquip(EquipType.Head)]
    public class BasariosHelmet : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int Guard = 2;
        public static readonly int AntiPoison = 1;
        public static readonly int Decor1 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Guard,AntiPoison,Decor1);

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.AntiPoison += AntiPoison;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient(ItemID.StoneBlock, 25).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }

    }
}