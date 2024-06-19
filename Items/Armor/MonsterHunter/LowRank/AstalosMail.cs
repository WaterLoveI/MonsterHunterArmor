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
    [AutoloadEquip(EquipType.Body)]
    public class AstalosMail : ModItem
    {
        public static readonly int CritChance = 5;
        public static readonly int Windproof = 2;
        public static readonly int ThunderAttack = 1;
        public static readonly int Decor1 = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, Windproof, ThunderAttack, Decor1);



        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.ThunderAttack += ThunderAttack;
            modPlayer.Windproof += Windproof;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor1;
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