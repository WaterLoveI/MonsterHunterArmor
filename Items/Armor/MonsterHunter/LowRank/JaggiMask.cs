using MHArmorSkills.Global;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class JaggiMask : ModItem
    {
        public static readonly int Skill1 = 1;
        public static readonly int Skill2 = 1;

        

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityWhiteBuyPrice;
            Item.rare = ItemRarityID.White;
            Item.defense = 2;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Skill1;
            modPlayer.CritEye += Skill1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterBone>(3).
                AddIngredient(ItemID.Leather, 3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}