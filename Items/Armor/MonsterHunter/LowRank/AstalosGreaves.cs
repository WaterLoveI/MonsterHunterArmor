using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.Localization;

using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class AstalosGreaves : ModItem
    {
        public static readonly int CritChance = 5;
        public static readonly int Vault = 2;
        public static readonly int Decor1 = 1;
        public static readonly int Decor2 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, Vault, Decor1, Decor2);



        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Vault += Vault;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FulgurBug>(2).
                AddIngredient<ElectroShocker>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}