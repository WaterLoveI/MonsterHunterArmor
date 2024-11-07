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
    public class BarrothHelmU : ModItem
    {
        public static readonly int Damage = 12;
        public static readonly int Move = 15;
        public static readonly int Ice = 1;
        public static readonly int Guard = 1;
        public static readonly int Punish = 1;
        public static readonly int Decor = 3;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Ice, Guard, Punish, Decor);

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityYellowBuyPrice;
            Item.rare = ItemRarityID.Yellow;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.IceAttack += Ice;
            modPlayer.PunishDrawPelletUp += Punish;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<BarrothHelm>().
                AddIngredient<LrgSnowClod>().
                AddIngredient<LrgWyvernGem>().
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}