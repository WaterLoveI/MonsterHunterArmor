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
    public class GammothHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 12;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PolarHunter += 2;
            modPlayer.Attack += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GammothHelm>().
                AddIngredient<LrgSnowClod>().
                AddIngredient<GammothIceOrb>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}