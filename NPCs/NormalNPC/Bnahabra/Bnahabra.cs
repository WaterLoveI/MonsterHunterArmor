using MHArmorSkills.Projectiles.Enemy;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.NPCs.NormalNPC.Bnahabra
{
    public class Bnahabra : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 2;
        }

        public override void SetDefaults()
        {
            NPC.damage = 15;
            NPC.aiStyle = NPCAIStyleID.Flying;
            NPC.width = 50;
            NPC.height = 28;
            NPC.defense = 7;
            NPC.lifeMax = 40;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.MossHornet;
            NPC.aiStyle = NPCAIStyleID.Bat;
            AIType = NPCID.MossHornet;
            NPC.value = Item.buyPrice(0, 0, 1, 80);
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            Banner = NPC.type;
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            if (NPC.life <= 0)
            {
                if (Main.netMode != NetmodeID.Server)
                {
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bnahabra1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bnahabra2").Type, 1f);
                }
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneJungle && !spawnInfo.Water &&
                (!spawnInfo.Player.ZoneTowerNebula && !spawnInfo.Player.ZoneTowerSolar && !spawnInfo.Player.ZoneTowerStardust &&
                !spawnInfo.Player.ZoneDungeon &&
                !spawnInfo.Player.ZoneTowerVortex &&
                !spawnInfo.PlayerInTown && !spawnInfo.Player.ZoneOldOneArmy && !Main.snowMoon && !Main.pumpkinMoon) ? 0.15f : 0f;
        }

        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            if (hurtInfo.Damage > 0)
                target.AddBuff(BuffID.Slow, 180, true);
        }

        public override void AI()
        {
            // Shoot a proj if within 20 tiles of its target and if its above the player
            Player player = Main.player[NPC.target];
            if (Vector2.Distance(player.Center, NPC.Center) < 320f && NPC.Center.Y < player.Center.Y && Main.rand.NextBool(600)) 
            {
                ShootSpit(player);
            }
        }

        private void ShootSpit(Player target)
        {
            SoundEngine.PlaySound(SoundID.Item17, NPC.Center);
            Vector2 vector = Main.player[NPC.target].Center - NPC.Center;
            vector.Normalize();
            // no idea why the projectile damage is higher than expected
            Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center + (NPC.Center.X < target.Center.X ? -7f : 7f) * Vector2.UnitX, vector * 7f, ModContent.ProjectileType<BnahabraSpit>(), 1, 0f, Main.myPlayer);

        }
    }
}
