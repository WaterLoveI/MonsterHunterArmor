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
    [AutoloadEquip(EquipType.Head)]
    public class AgnaktorHelmX : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int CritChance = 10;
        public static readonly int Fire = 2;
        public static readonly int Guard = 1;
        public static readonly int Razor = 1;
        public static readonly int Decor = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, CritChance, Fire, Guard,Razor,Decor);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += Fire;
            modPlayer.RazorSharpSpareShot += Razor;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor;
            SlotPlayer.DecorationOneSlots += Decor;

        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AgnaktorHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<FlamingScale>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }

    }
}