using MHArmorSkills.Global;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Body)]
    public class AstalosMailX : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int CritChance = 12;
        public static readonly int Spare = 2;
        public static readonly int Pierce = 1;
        public static readonly int Vault = 1;
        public static readonly int Decor = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, CritChance, Spare, Pierce, Vault, Decor);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 18;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += CritChance;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.RazorSharpSpareShot += Spare;
            modPlayer.Vault += Vault;
            modPlayer.CritDrawPierceUp += Pierce;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationTwoSlots += Decor;
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<AstalosMail>().
                AddIngredient<ThunderSac>(3).
                AddIngredient<ZinogreJasper>().
                AddIngredient<KingArmorSphere>(10).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}