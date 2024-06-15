using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class NargacugaGreaves : ModItem
    {
        public static readonly int Skill1 = 3;
        public static readonly int Skill2 = 2;



        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += 0.1f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.EvadeDistance += 1;
            modPlayer.CritEye += 1; 
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.NinjaPants).
                AddIngredient<EbonShell>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}