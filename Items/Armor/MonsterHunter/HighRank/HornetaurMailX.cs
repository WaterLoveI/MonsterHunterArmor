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
    [AutoloadEquip(EquipType.Body)]
    public class HornetaurMailX : ModItem
    {
            
        public static readonly int Damage = 10;
        public static readonly int FreeMeal = 2;
        public static readonly int Guard = 1;
        public static readonly int Tenderizer = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, FreeMeal, Guard, Tenderizer, Decor1);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 13;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.maxMinions += 1;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FreeMeal += FreeMeal;
            modPlayer.Tenderizer += Tenderizer;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.BeeBreastplate).
                AddIngredient<InsectCarapace>(4).
                AddIngredient<HeavyArmorSphere>(4).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}