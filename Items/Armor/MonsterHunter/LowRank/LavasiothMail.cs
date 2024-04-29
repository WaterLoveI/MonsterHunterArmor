using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Body)]
    public class LavasiothMail : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetAttackSpeed(DamageClass.Melee) += 0.07f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Guard += 1;
            modPlayer.Resentment += 1;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<WyvernGem>().
                AddIngredient(ItemID.Obsidian,5).
                AddIngredient<ArmorSpherePlus>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}