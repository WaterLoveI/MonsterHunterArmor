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
    [AutoloadEquip(EquipType.Legs)]
    public class LavasiothGreavesX : ModItem
    {
            
        public static readonly int Damage = 10;
        public static readonly int Move = 7;
        public static readonly int Fortified = 1;
        public static readonly int RecUp = 1;
        public static readonly int Resent = 1;
        public static readonly int Decor1 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Fortified, RecUp, Resent, Decor1);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 16;

        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            player.lifeRegen += 1;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RecoveryUp += RecUp;
            modPlayer.Resentment += Resent;
            modPlayer.Fortified += Fortified;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
        }

        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<LavasiothGreaves>().
                AddIngredient<InfernoSac>(3).
                AddIngredient(ItemID.LifeCrystal).
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}