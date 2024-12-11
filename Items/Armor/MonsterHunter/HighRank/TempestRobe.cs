using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Body)]
    public class TempestRobe : ModItem
    {
        public static readonly int Damage = 20;
        public static readonly int Crit = 20;
        public static readonly int Latent = 5;
        public static readonly int Heaven = 1;
        public static readonly int Decor1 = 2;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Latent, Heaven, Decor1, Decor2);
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityRedBuyPrice;
            Item.rare = ItemRarityID.Red;
            Item.defense = 32;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.HeavenSent += Heaven;
            modPlayer.LatentPower += Latent;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<LrgElderDragonGem>().
                AddIngredient<TrueArmorSphere>(12).
                AddTile(TileID.LunarCraftingStation).
                Register();
        }
    }
}