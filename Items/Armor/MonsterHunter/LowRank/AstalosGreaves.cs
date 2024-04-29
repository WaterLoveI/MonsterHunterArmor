using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.Localization;

using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class AstalosGreaves : ModItem
    {
        public static readonly int Skill1 = 1;
        public static readonly int Skill2 = 1;

        

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += 5;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Vault += 2;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += 1;
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<FulgurBug>(2).
                AddIngredient<ElectroShocker>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}