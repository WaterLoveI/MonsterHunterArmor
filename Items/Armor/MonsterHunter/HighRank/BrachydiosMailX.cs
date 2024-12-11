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
    public class BrachydiosMailX : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Melee = 15;
        public static readonly int Bomb = 2;
        public static readonly int Handi = 2;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Melee, Bomb, Handi, Decor);

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetAttackSpeed<MeleeDamageClass>() += Melee/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.ArtilleryBombBoost += Bomb;
            modPlayer.HandicraftRapidFire += Handi;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BrachydiosMail>().
                AddIngredient<GlowingSlime>(3).
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}