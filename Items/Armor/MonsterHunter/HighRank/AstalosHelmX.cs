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
    public class AstalosHelmX : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.12f;
            player.GetCritChance<GenericDamageClass>() += 12;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.ThunderAttack += 1;
            modPlayer.Vault += 1;
            modPlayer.PierceUp += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AstalosHelm>().
                AddIngredient<ThunderSac>(3).
                AddIngredient<ZinogreJasper>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}