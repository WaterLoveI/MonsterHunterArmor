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
    [AutoloadEquip(EquipType.Body)]
    public class GlavenusMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.15f;
            player.GetAttackSpeed<MeleeDamageClass>() += 0.15f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RazorSharp += 2;
            modPlayer.Grinder += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<GlavenusMail>().
                AddIngredient<FineEbonShell>(3).
                AddIngredient<RathalosRuby>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}