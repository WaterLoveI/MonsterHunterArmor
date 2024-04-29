using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class NargacugaMail : ModItem
    {
        public static readonly int Skill1 = 3;
        public static readonly int Skill2 = 2;



        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance(DamageClass.Generic) += 6;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Sneak += 2;
            modPlayer.CritEye += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.NinjaShirt).
                AddIngredient<EbonShell>(4).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}