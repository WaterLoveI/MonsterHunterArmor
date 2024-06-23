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
    public class MoofahHeadX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Move = 15;
        public static readonly int Gather = 1;
        public static readonly int IceRes = 1;
        public static readonly int ThunderAtk = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Gather, IceRes, ThunderAtk, Decor1);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 8;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Gathering += Gather;
            modPlayer.ThunderAttack += ThunderAtk;
            modPlayer.IceRes += IceRes;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MoofahHead>().
                AddIngredient(ItemID.SoulofLight,5).
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}