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
    public class BasariosMailU : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityPinkBuyPrice;
            Item.rare = ItemRarityID.Pink;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += 10;
            player.GetAttackSpeed<MeleeDamageClass>() += 0.12f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PunishDraw += 2;
            modPlayer.OffensiveGuard += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BasariosMail>().
                AddIngredient<InfernoSac>(3).
                AddIngredient<LrgWyvernGem>().
                AddIngredient<HeavyArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}