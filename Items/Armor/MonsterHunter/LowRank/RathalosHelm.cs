using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class RathalosHelm : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += 0.05f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Tenderizer += 2;
            modPlayer.Attack += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FlameSac>(3).
                AddIngredient<FlamingScale>(4).
                AddIngredient<HardArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}