using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Head)]
    public class BlueKutkuHelm : ModItem
    {
        public static readonly int CritChance = 5;
        public static readonly int FireAttack = 4;
        public static readonly int CritEye = 2;
        public static readonly int Decor1 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, FireAttack, CritEye, Decor1);


        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 21;
            Item.value = MHGlobalItems.RarityOrangeBuyPrice;
            Item.rare = ItemRarityID.Orange;
            Item.defense = 4;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.FireAttack += FireAttack;
            modPlayer.CritEye += CritEye;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KutkuHelm>().
                AddIngredient<FlameSac>(3).
                AddIngredient<HardArmorSphere>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}