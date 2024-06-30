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
    public class UkanlosHelm : ModItem
    {
        public static readonly int Damage = 5;
        public static readonly int Crit = 5;
        public static readonly int Attack = 2;
        public static readonly int Handicraft = 2;
        public static readonly int IceAttack = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, Attack, Handicraft, IceAttack);

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Handicraft += Handicraft;
            modPlayer.Attack += Attack;
            modPlayer.IceAttack += IceAttack;
            
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ElderDragonGem>().
                AddIngredient<SnowClod>(3).
                AddIngredient<AmberTusk>(4).
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}