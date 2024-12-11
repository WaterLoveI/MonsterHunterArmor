using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.LowRank
{
    [AutoloadEquip(EquipType.Legs)]
    public class TetsucabraGreaves : ModItem
    {
        public static readonly int MoveSpeed = 5;
        public static readonly int TremorRes = 2;
        public static readonly int StunRes = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(MoveSpeed, TremorRes);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += MoveSpeed / 100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.TremorRes += TremorRes;
        }
        
    }
}