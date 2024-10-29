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
    [AutoloadEquip(EquipType.Legs)]
    public class KirinLegGuards : ModItem
    {
        public static readonly int Move = 12;
        public static readonly int Mana = 20;
        public static readonly int Blight = 1;
        public static readonly int Lasting = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, Mana, Blight, Lasting, Decor1);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move/100f;
            player.statManaMax2 += Mana;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.BlightProof += Blight;
            modPlayer.LastingPower += Lasting;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ElderDragonGem>().
                AddIngredient<FulgurBug>(3).
                AddIngredient<ElectroShocker>(4).
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}