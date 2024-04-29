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
    public class BasariosMailX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 15;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed<MeleeDamageClass>() += 0.15f;
            player.GetDamage<GenericDamageClass>() += 0.07f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.DefenseBoost += 2;
            modPlayer.Guard += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BasariosMail>().
                AddIngredient<LrgWyvernGem>().
                AddIngredient<HeavyArmorSphere>(3).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}