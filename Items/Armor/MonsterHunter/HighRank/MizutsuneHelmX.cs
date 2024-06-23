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
    public class MizutsuneHelmX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Crit = 12;
        public static readonly int Const = 1;
        public static readonly int Evasion = 1;
        public static readonly int WaterAtk = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Const, Evasion, WaterAtk, Decor1);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 28;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;

        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.WaterAttack += WaterAtk;
            modPlayer.Constitution += Const;
            modPlayer.Evasion += Evasion;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MizutsuneHelm>().
                AddIngredient<DistilledBubblefoam>(3).
                AddIngredient<MizutsuneWaterOrb>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}