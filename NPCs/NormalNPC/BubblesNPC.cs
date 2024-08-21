using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using MHArmorSkills.Utilities;
using Terraria.DataStructures;
using MHArmorSkills.Buffs;

namespace MHArmorSkills.NPCs.NormalNPC
{
    public class BubblesNPC : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 2;
            this.HideFromBestiary();
            NPCID.Sets.CantTakeLunchMoney[Type] = true;
            NPCID.Sets.NeedsExpertScaling[Type] = true;
            NPCID.Sets.ProjectileNPC[Type] = true;
            NPCID.Sets.CanHitPastShimmer[Type] = true;
        }


        public override void SetDefaults()
        {
            NPC.damage = 10;
            NPC.aiStyle = -1;
            NPC.width = 20;
            NPC.height = 20;
            NPC.defense = 0;
            NPC.knockBackResist = 0.7f;
            AnimationType = NPCID.DetonatingBubble;
            AIType = -1;
            NPC.lifeMax = 1;
            NPC.HitSound = SoundID.NPCHit3;
            NPC.DeathSound = SoundID.NPCDeath3;
            NPC.noGravity = true;
            NPC.noTileCollide = true;
            NPC.knockBackResist = 0f;
            NPC.alpha = 255;

        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Ocean,
                new FlavorTextBestiaryInfoElement("Small hard-shelled Carapaceons. Their brains are regarded as a delicacy in some regions.")
            });
        }
        public override void FindFrame(int frameHeight)
        {

            NPC.spriteDirection = NPC.direction;

        }

        public override void OnSpawn(IEntitySource source)
        {
            NPC.immuneTime += 30;
        }
        public override void AI()
        {
            if (NPC.target == 255)
            {
                NPC.TargetClosest();
                NPC.ai[3] = (float)Main.rand.Next(80, 121) / 100f;
                float num70 = (float)Main.rand.Next(165, 265) / 15f;
                NPC.velocity = Vector2.Normalize(Main.player[NPC.target].Center - NPC.Center + new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101))) * num70;
                NPC.netUpdate = true;
            }
            Vector2 vector41 = Vector2.Normalize(Main.player[NPC.target].Center - NPC.Center);
            NPC.velocity = (NPC.velocity * 40f + vector41 * 12f) / 41f;
            NPC.scale = NPC.ai[3];
            NPC.alpha -= 30;
            if (NPC.alpha < 50)
            {
                NPC.alpha = 50;
            }
            NPC.alpha = 50;
            NPC.velocity.X = (NPC.velocity.X * 45f + Main.windSpeedCurrent * 2f + (float)Main.rand.Next(-10, 11) * 0.1f) / 51f;
            NPC.velocity.Y = (NPC.velocity.Y * 45f + -0.25f + (float)Main.rand.Next(-10, 11) * 0.2f) / 51f;
            if (NPC.velocity.Y > 0f)
            {
                NPC.velocity.Y -= 0.04f;
            }
            if (NPC.ai[0] == 0f)
            {
                int num71 = 20;
                Rectangle rect = NPC.getRect();
                rect.X -= num71 + NPC.width / 2;
                rect.Y -= num71 + NPC.height / 2;
                rect.Width += num71 * 2;
                rect.Height += num71 * 2;
                for (int num72 = 0; num72 < 255; num72++)
                {
                    Player player8 = Main.player[num72];
                    if (player8.active && !player8.dead && rect.Intersects(player8.getRect()))
                    {
                        NPC.ai[0] = 1f;
                        NPC.ai[1] = 4f;
                        NPC.netUpdate = true;
                        break;
                    }
                }
            }
            if (NPC.ai[0] == 0f)
            {
                NPC.ai[1]++;
                if (NPC.ai[1] >= 150f)
                {
                    NPC.ai[0] = 1f;
                    NPC.ai[1] = 4f;
                }
            }
            if (NPC.ai[0] == 1f)
            {
                NPC.ai[1]--;
                if (NPC.ai[1] <= 0f)
                {
                    NPC.life = 0;
                    NPC.HitEffect();
                    NPC.active = false;
                    return;
                }
            }
            if (NPC.justHit || NPC.ai[0] == 1f)
            {
                NPC.dontTakeDamage = true;
                NPC.position = NPC.Center;
                NPC.width = (NPC.height = 100);
                NPC.position = new Vector2(NPC.position.X - (float)(NPC.width / 2), NPC.position.Y - (float)(NPC.height / 2));
                NPC.EncourageDespawn(3);
            }
        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Water, hit.HitDirection, -1f, 0, default, 1f);
            }
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        {
            if (hurtInfo.Damage > 0 && Main.rand.NextBool(2))
                target.AddBuff(ModContent.BuffType<BubbleBlight>(), 5 * 60);
        }
    }
}

