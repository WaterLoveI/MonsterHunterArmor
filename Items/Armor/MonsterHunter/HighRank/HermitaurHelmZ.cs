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
    public class HermitaurHelmZ : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.15f;
            player.moveSpeed += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Guts += 1;
            modPlayer.CritDraw += 1;
            modPlayer.Guard += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
            SlotPlayer.DecorationTwoSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<HermitaurHelm>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}