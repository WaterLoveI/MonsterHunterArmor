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
    public class KonchuHelmX : ModItem
    {
            
        public static readonly int Move = 15;
        public static readonly int Def = 2;
        public static readonly int DefLock = 2;
        public static readonly int Protect = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Move, Def, DefLock, Protect);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.ammoCost80 = true;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Protection += Protect;
            modPlayer.DefLock += DefLock;
            modPlayer.DefenseBoost += Def;

        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AgnaktorHelm>().
                AddIngredient(ItemID.SoulofNight,5).
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}