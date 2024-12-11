using MHArmorSkills.Global;
using MHArmorSkills.Utilities;
using MHArmorSkills.DrawLayers;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Items.Armor.MonsterHunter.HighRank
{
    [AutoloadEquip(EquipType.Head)]
    public class ValstraxHelm : ModItem
    {
        public static readonly int Damage = 15;
        public static readonly int Crit = 15;
        public static readonly int AttackBoost = 4;
        public static readonly int DragConv = 1;
        public static readonly int Decor1 = 2;
            public static readonly int Decor2 = 1;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(Damage, Crit, AttackBoost, DragConv, Decor1, Decor2);
        public static Lazy<Asset<Texture2D>> glowmask;

        public override void Unload()
        {
            glowmask = null;
        }

        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();

            if (!Main.dedServ)
            {
                glowmask = new(() => ModContent.Request<Texture2D>(Texture + "_Glow"));

                HeadLayer.RegisterData(Item.headSlot, new DrawLayerData()
                {
                    Texture = ModContent.Request<Texture2D>(Texture + "_Head_Glow")
                });
            }

        }
        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 24;
            Item.value = MHGlobalItems.RarityRedBuyPrice;
            Item.rare = ItemRarityID.Red;
            Item.defense = 22;
        }

        public override void UpdateEquip(Terraria.Player player)
        {
            player.GetDamage<GenericDamageClass>() += Damage / 100f;
            player.GetCritChance<GenericDamageClass>() += Crit;
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            modPlayer.Attack += AttackBoost;
            modPlayer.DragonConversion += DragConv;
            DecorationSlots SlotPlayer = player.GetModPlayer<DecorationSlots>();
            SlotPlayer.DecorationThreeSlots += Decor1;
            SlotPlayer.DecorationOneSlots += Decor2;

            Lighting.AddLight(player.Center, 0.3f, 0.1f, 0.3f);
        }
        public override void UpdateVanity(Player player)
        {
            Lighting.AddLight(player.Center, 0.3f, 0.1f, 0.3f);
        }
        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, 0.3f, 0.1f, 0.3f);
        }
        public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
        {
            Item.BasicInWorldGlowmask(spriteBatch, glowmask.Value.Value, new Color(255, 255, 255, 0) * 0.8f, rotation, scale);
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