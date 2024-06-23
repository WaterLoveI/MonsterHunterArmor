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
    public class BrachydiosHelmX : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Melee = 15;
        public static readonly int Spirit = 2;
        public static readonly int Slugger = 2;
        public static readonly int Decor = 3;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Melee, Spirit, Slugger, Decor);

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 30;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetAttackSpeed<MeleeDamageClass>() += Melee/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Spirit += Spirit;
            modPlayer.Slugger += Slugger;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BrachydiosHelm>().
                AddIngredient<GlowingSlime>(3).
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}