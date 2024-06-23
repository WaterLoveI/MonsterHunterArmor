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
    public class HermitaurHelmZ : ModItem
    {
            
        public static readonly int Damage = 15;
        public static readonly int Move = 10;
        public static readonly int Guard = 1;
        public static readonly int CritDraw = 1;
        public static readonly int Guts = 1;
        public static readonly int Decor1 = 1;
        public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Move, Guard, CritDraw, Guts, Decor1 , Decor2);

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 22;
            Item.value = MHGlobalItems.RarityLimeBuyPrice;
            Item.rare = ItemRarityID.Lime;
            Item.defense = 16;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage/100f;
            player.moveSpeed += Move/100f;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Guts += Guts;
            modPlayer.CritDraw += CritDraw;
            modPlayer.Guard += Guard;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationOneSlots += Decor1;
            SlotPlayer.DecorationTwoSlots += Decor2;
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<HermitaurHelm>().
                AddIngredient<TorrentSac>(3).
                AddIngredient<FineEbonShell>(4).
                AddIngredient<KingArmorSphere>(5).
                AddTile(TileID.MythrilAnvil).
                Register();
        }
    }
}