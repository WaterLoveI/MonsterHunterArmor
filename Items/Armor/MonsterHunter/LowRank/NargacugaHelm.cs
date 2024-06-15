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
    public class NargacugaHelm : ModItem
    {
        public static readonly int Skill1 = 3;
        public static readonly int Skill2 = 2;

        

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance(DamageClass.Generic) += 5;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.EvadeDistance += 2;
            modPlayer.Evasion += 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient(ItemID.NinjaHood).
                AddIngredient<EbonShell>(3).
                AddIngredient<HardArmorSphere>(4).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}