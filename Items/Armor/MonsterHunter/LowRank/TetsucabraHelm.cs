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
    [AutoloadEquip(EquipType.Head)]
    public class TetsucabraHelm : ModItem
    {
        public static readonly int CritChance = 3;
        public static readonly int PunishDraw = 1;
        public static readonly int StamRec = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(CritChance, PunishDraw, StamRec);

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityGreenBuyPrice;
            Item.rare = ItemRarityID.Green;
            Item.defense = 5;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.PunishDrawPelletUp += PunishDraw;
            modPlayer.StamRec += StamRec;
        }
        
    }
}