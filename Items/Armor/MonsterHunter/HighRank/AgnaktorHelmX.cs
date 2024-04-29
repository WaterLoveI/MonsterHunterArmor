using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class AgnaktorHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 26;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 20;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 10;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += 2;
            modPlayer.RazorSharp += 1;
            modPlayer.Guard += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += 1;


        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AgnaktorHelm>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<RathalosRuby>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }

    }
}