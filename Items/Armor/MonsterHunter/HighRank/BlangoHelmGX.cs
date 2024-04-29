using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class BlangoHelmGX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 19;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.IceAttack += 1;
            modPlayer.HastenRecovery += 1;
            modPlayer.PolarHunter += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BlangoHelm>().
                AddIngredient<LrgSnowClod>().
                AddIngredient<LrgBeastGem>().
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}