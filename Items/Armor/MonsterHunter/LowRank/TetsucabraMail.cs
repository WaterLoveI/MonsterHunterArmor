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
    [AutoloadEquip(EquipType.Body)]
    public class TetsucabraMail : ModItem
    {
        public static readonly int CritChance = 3;
        public static readonly int HeatRes = 2;
        public static readonly int PunishDraw = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, HeatRes, PunishDraw);

        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 6;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PunishDrawPelletUp += PunishDraw;
            modPlayer.HeatRes += HeatRes;
        }
        
    }
}