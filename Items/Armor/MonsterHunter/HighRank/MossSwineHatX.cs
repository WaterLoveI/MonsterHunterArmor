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
    public class MossSwineHatX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Mushroom = 2;
        public static readonly int Gather = 2;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Mushroom, Gather, Decor1);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 8;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.statManaMax2 += 20;
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Mushroomancer += Mushroom;
            modPlayer.Gathering += Gather;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MossSwineHat>().
                AddIngredient(ItemID.SoulofLight,5).
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}