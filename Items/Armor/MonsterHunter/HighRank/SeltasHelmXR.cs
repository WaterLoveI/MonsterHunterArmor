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
    public class SeltasHelmXR : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Guard = 1;
        public static readonly int Art = 1;
        public static readonly int Hero = 1;
        public static readonly int Decor1 = 3;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Guard, Art, Hero, Decor1);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.ammoCost80 = true;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeroShield += Hero;
            modPlayer.Guard += Guard;
            modPlayer.Artillery += Art;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeltasHelm>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<QueenSubstance>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}