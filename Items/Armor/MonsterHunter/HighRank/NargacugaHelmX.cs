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
    public class NargacugaHelmX : ModItem
    {
        public static readonly int Damage = 10;
        public static readonly int Crit = 10;
        public static readonly int CritEye = 1;
        public static readonly int Distance = 1;
        public static readonly int Evasion = 1;
        public static readonly int Unscathed = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, CritEye,Distance, Evasion,Unscathed, Decor1);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Evasion += Evasion;
            modPlayer.CritEye += CritEye;
            modPlayer.EvadeDistance += Distance;
            modPlayer.Unscathed += Unscathed;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<NargacugaHelm>().
                AddIngredient<LrgWyvernGem>().
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}