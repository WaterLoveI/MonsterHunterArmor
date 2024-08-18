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
    [AutoloadEquip(EquipType.Legs)]
    public class UkanlosGreaves : ModItem
    {
        public static readonly int Crit = 3;
        public static readonly int Move = 10;
        public static readonly int Attack = 2;
        public static readonly int IceAttack = 1;
        public static readonly int Decor1 = 1;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Crit, Move, Attack, IceAttack, Decor1);

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 18;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 10;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.moveSpeed += Move/100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Attack;
            modPlayer.IceAttack += IceAttack;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;

        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<ElderDragonGem>().
                AddIngredient<SnowClod>(3).
                AddIngredient<Bubblefoam>(4).
                AddIngredient<HardArmorSphere>(10).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}