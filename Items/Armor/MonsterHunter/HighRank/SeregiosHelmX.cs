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
    public class SeregiosHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 12;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.BladeScaleHone += 1;
            modPlayer.Constitution += 2;
            modPlayer.AntiBleeding = true;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<SeregiosHelm>().
                AddIngredient<AmberHardfang>(3).
                AddIngredient<RathalosRuby>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}