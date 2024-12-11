using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Body)]
    public class AgnaktorMailX : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int CritChance = 10;
        public static readonly int Guard = 2;
        public static readonly int Elemental = 2;
        public static readonly int Razor = 1;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, CritChance, Guard, Elemental, Razor,Decor);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Guard += Guard;
            modPlayer.Elemental += Elemental;
            modPlayer.RazorSharpSpareShot += Razor;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor;


        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AgnaktorMail>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingScale>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }

    }
}