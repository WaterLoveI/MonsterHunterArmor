using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class GammothHelm : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int PolarHunter = 2;
        public static readonly int Decor1 = 1;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, PolarHunter, Decor1, Decor2);



        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PolarHunter += PolarHunter;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SnowClod>(2).
                AddIngredient<AmberTusk>(4).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}