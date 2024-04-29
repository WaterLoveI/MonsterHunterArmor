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
    public class SeltasHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.15f;
            player.ammoCost80 = true;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeroShield += 1;
            modPlayer.Guard += 1;
            modPlayer.Artillery += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 3;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeltasHelm>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<QueenSubstance>(3).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}