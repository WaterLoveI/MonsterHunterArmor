using MHArmorSkills.Global;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Items.Weapons
{
    public class BoneClub : ModItem
    {


        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Melee;
            Item.width = 48;
            Item.height = 50;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = false;
            Item.knockBack = 6f;
            Item.value = MHGlobalItems.RarityBlueBuyPrice; ;
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.hammer = 50;
        }
        public override void ModifyHitNPC(Player player, NPC target, ref NPC.HitModifiers modifiers)
        {
            Vector2 relativePosition = target.Center - player.Center;

            // Check if the player is facing the target
            if ((relativePosition.X > 0 && target.direction == -1) || (relativePosition.X < 0 && target.direction == 1))
            {
                // The player is attacking from the front
                modifiers.FinalDamage *= 1.5f;
            }
        }
        public override void AddRecipes()
        {
            CreateRecipe().
                AddIngredient<MonsterBone>(3).
                AddTile(TileID.Anvils).
                Register();
        }
    }
}

