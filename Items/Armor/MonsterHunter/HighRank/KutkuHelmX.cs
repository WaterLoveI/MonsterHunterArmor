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
    [AutoloadEquip(EquipType.Head)]
    public class KutkuHelmX : ModItem
    {
            
        public static readonly int Damage = 12;
        public static readonly int Move = 10;
        public static readonly int FireAtk = 2;
        public static readonly int Atk = 1;
        public static readonly int Decor1 = 2;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, FireAtk, Atk, Decor1);

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLightRedBuyPrice;
            Item.rare = ItemRarityID.LightRed;
            Item.defense = 8;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += Atk;
            modPlayer.FireAttack += FireAtk;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<KutkuHelm>().
                AddIngredient<FeyWyvernGem>().
                AddIngredient<HardArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}