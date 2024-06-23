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
    public class BanbaroHelm : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Mushroom = 2;
        public static readonly int Resent = 2;
        public static readonly int Decor = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Mushroom, Resent, Decor);

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.lifeRegen += 2;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Mushroomancer += Mushroom;
            modPlayer.Resentment += Resent;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.VikingHelmet).
                AddIngredient<LrgBeastGem>(2).
                AddIngredient(ItemID.SoulofMight,5).
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }

    }
}