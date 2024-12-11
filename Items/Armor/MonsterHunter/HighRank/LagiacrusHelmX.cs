using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;
using MHArmorSkills.Items.Crafting_Materials.BiomeBones;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class LagiacrusHelmX : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Mana = 20;
        public static readonly int Stamina = 2;
        public static readonly int Elemental = 1;
        public static readonly int Guard = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Mana, Stamina, Elemental, Guard, Decor1);

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 28;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.statManaMax2 += Mana;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.StamRec += Stamina;
            modPlayer.Elemental += Elemental;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<LagiacrusHelm>().
                AddIngredient<CoralBone3>().
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}