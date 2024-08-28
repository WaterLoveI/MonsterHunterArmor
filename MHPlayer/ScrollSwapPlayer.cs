﻿using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public class ScrollSwapPlayer : ModPlayer
    {
        // false is red and true is blue
        public bool SkillScrolls = false;
        public bool ScrollActive = false;



        public float MailofHellfireMelee;
        public int MailofHellfireDefDrop;
        public float MailofHellfireShoot;
        public float MailofHellfireEndurance;

        public int QuickBreathHeal;
        public int QuickBreathCooldown;

        public int FuriousDef;
        public int FuriousCount;
        public int FuriousTimer;

        public int BerserkDot;
        public int BerserkRegen;

        public int DerelictionTimer;
        public int DerelictionStage;
        public int DerelictionBoost;
        public override void ResetEffects()
        {
            MailofHellfireMelee = 1f;
            MailofHellfireDefDrop = 0;
            MailofHellfireShoot = 1f;
            MailofHellfireEndurance = 1f;
            ScrollActive = false;
            QuickBreathHeal = 0;
            FuriousDef = 0;
            DerelictionBoost = 0;
        }

        #region hotkey
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (MHArmorSkills.ScrollSwap.JustPressed && !Player.HasBuff(ModContent.BuffType<ScrollChange>()) && ScrollActive)
            {
                if (!SkillScrolls)
                {
                    SkillScrolls = true;
                    Player.AddBuff(ModContent.BuffType<ScrollChange>(), 60);
                    ScrollswapDust();
                }
                else
                {
                    SkillScrolls = false;
                    Player.AddBuff(ModContent.BuffType<ScrollChange>(), 60);
                    ScrollswapDust();
                }
            }
        }
        #endregion
        #region Scroll Swap Dust
        // dusts for scroll swap
        public void ScrollswapDust()
        {
            for (int i = 0; i < 12; i++)
            {
                int colour = DustID.RedTorch;
                if (SkillScrolls)
                {
                    colour = DustID.BlueTorch;
                }

                int d = Dust.NewDust(Player.position, Player.width, Player.height, colour, 0f, -1f, 100, default(Color), 1.5f);
                Main.dust[d].noGravity = true;
                Main.dust[d].noLight = false;
                Main.dust[d].fadeIn = 0.2f;
                Main.dust[d].velocity *= 0.3f;
            }
        }
        #endregion

        public override void PreUpdate()
        {
            int Debuffcount = Player.buffType.Count(MHLists.debuffList.Contains);

            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            #region Quick Breath
            if (Player.HasBuff(ModContent.BuffType<ScrollChange>()))
            {
                if (modPlayer.QuickBreath >= 1)
                {
                    QuickBreathHeal = Debuffcount;

                }
            }
            if (QuickBreathCooldown > 0)
            {
                QuickBreathCooldown--;
            }
            #endregion
            #region Furious
            if (FuriousTimer > 0)
            {
                FuriousTimer--;
            }
            #endregion
            if (BerserkDot >= 0 && Main.rand.NextBool(3))
            {
                BerserkDot--;
            }
            if (modPlayer.Dereliction >= 1 && !(DerelictionStage == 3) && (Player.HasBuff(ModContent.BuffType<RedScroll>()) || Player.HasBuff(ModContent.BuffType<BlueScroll>())))
            {
                DerelictionTimer++;
                if (DerelictionTimer > 0 && DerelictionTimer <= 30 * 60)
                {
                    DerelictionStage = 1;
                }
                if (DerelictionTimer > 30 * 60 && DerelictionTimer <= 60 * 60)
                {
                    DerelictionStage = 2;
                }
                if (DerelictionTimer > 60 * 60)
                {
                    DerelictionStage = 3;
                }

            }
            if (modPlayer.Dereliction == 0)
            {
                DerelictionStage = 0;
                DerelictionTimer = 0;
            }
        }


        public override void PostUpdateMiscEffects()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();

            #region Scroll buff change
            if (SkillScrolls && !Player.HasBuff(ModContent.BuffType<ScrollChange>()) && ScrollActive)
            {
                Player.AddBuff(ModContent.BuffType<BlueScroll>(), 2);
            }
            if (!SkillScrolls && !Player.HasBuff(ModContent.BuffType<ScrollChange>()) && ScrollActive)
            {
                Player.AddBuff(ModContent.BuffType<RedScroll>(), 2);
            }
            #endregion
            #region Red Scroll
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                if (Player.statDefense >= MailofHellfireDefDrop)
                {
                    Player.statDefense -= MailofHellfireDefDrop;
                }

                Player.statDefense += FuriousDef;

                if (Player.HasBuff(ModContent.BuffType<Furious>()))
                {
                    Player.ClearBuff(ModContent.BuffType<Furious>());
                }
                if (modPlayer.Dereliction >= 1)
                {
                    int Derecrit = DerelictionBoost * DerelictionStage;
                    Player.GetCritChance(DamageClass.Generic) += Derecrit;
                }
            }
            #endregion
            #region Blue Scroll
            if (Player.HasBuff(ModContent.BuffType<BlueScroll>()))
            {
                if (FuriousCount >= 60)
                {
                    FuriousCount = 0;
                    Player.AddBuff(ModContent.BuffType<Furious>(), FuriousDef * 3 * 60);
                }
                if (Player.HasBuff(ModContent.BuffType<Furious>()) && FuriousDef > 0)
                {
                    Player.statMana = Player.statLifeMax2;
                    Player.wingTime = Player.wingTimeMax;
                }
                if (modPlayer.Berserk >= 1)
                {
                    Player.AddBuff(ModContent.BuffType<Beserk>(), 2);
                }
                if (modPlayer.Dereliction >= 1)
                {
                    int Derecrit = DerelictionBoost * DerelictionStage;
                    Player.GetDamage(DamageClass.Generic) += Derecrit / 100f;
                }

            }
            #endregion
            #region Scroll Change
            if (Player.HasBuff(ModContent.BuffType<ScrollChange>()))
            {
                #region Redirection
                if (modPlayer.Redirection == 1)
                {
                    if (Player.endurance <= 0.75f)
                    {
                        Player.endurance = 0.75f;
                    }
                    Player.noKnockback = true;
                }
                if (modPlayer.Redirection >= 2)
                {
                    Player.immune = true;

                    for (int i = 0; i < Main.npc.Length; i++)
                    {
                        NPC npc = Main.npc[i];

                        if (npc.active && !npc.friendly)
                        {
                            float distance = Vector2.Distance(Player.Center, npc.Center);

                            if (distance < Player.Hitbox.Width / 2 + npc.Hitbox.Width / 2)
                            {
                                Vector2 teleportLocation;
                                teleportLocation.X = (float)Main.mouseX + Main.screenPosition.X;
                                if (Player.gravDir == 1f)
                                {
                                    teleportLocation.Y = (float)Main.mouseY + Main.screenPosition.Y - (float)Player.height;
                                }
                                else
                                {
                                    teleportLocation.Y = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY;
                                }
                                teleportLocation.X -= (float)(Player.width / 2);
                                if (teleportLocation.X > 50f && teleportLocation.X < (float)(Main.maxTilesX * 16 - 50) && teleportLocation.Y > 50f && teleportLocation.Y < (float)(Main.maxTilesY * 16 - 50))
                                {
                                    if (!Collision.SolidCollision(teleportLocation, Player.width, Player.height))
                                    {
                                        Player.Teleport(teleportLocation, 4, 0);
                                        NetMessage.SendData(MessageID.TeleportEntity, -1, -1, null, 0, (float)Player.whoAmI, teleportLocation.X, teleportLocation.Y, 1, 0, 0);
                                        Player.AddBuff(BuffID.ChaosState, 60 * 3, true);
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Quick Breath
                if (modPlayer.QuickBreath >= 1)
                {
                    int postUpdateDebuffCount = Player.buffType.Count(MHLists.debuffList.Contains);
                    if (postUpdateDebuffCount > QuickBreathHeal && QuickBreathCooldown == 0)
                    {
                        Player.Heal((postUpdateDebuffCount - QuickBreathHeal) * 20);
                        QuickBreathCooldown = 60;
                        SoundEngine.PlaySound(SoundID.Item4);
                    }
                    bool hasDebuff = false;
                    foreach (int debuff in MHLists.debuffList)
                    {
                        if (Player.HasBuff(debuff))
                        {
                            hasDebuff = true;
                            break;
                        }
                    }
                    if (hasDebuff)
                    {
                        foreach (int debuff in MHLists.debuffList)
                            Player.buffImmune[debuff] = true;

                        if (QuickBreathCooldown == 0)
                        {
                            for (int i = 0; i < 6; i++)
                            {
                                int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.GreenFairy, 0f, -1f, 100, default(Color), 1.5f);
                                Main.dust[d].noGravity = true;
                                Main.dust[d].noLight = false;
                                Main.dust[d].fadeIn = 0.2f;
                                Main.dust[d].velocity *= 0.3f;
                            }

                        }
                    }
                    
                }
                #endregion
                if (DerelictionStage >= 2)
                {
                    
                    int derehealamt = DerelictionStage * Player.statLifeMax2 / 10;
                    Player.Heal(derehealamt);
                    DerelictionTimer = 0;
                }
            }
            #endregion

        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                if (FuriousTimer == 0 && FuriousDef >= 0)
                {
                    FuriousCount++;
                    FuriousTimer = 30;
                }
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                if (FuriousTimer == 0 && FuriousDef >= 0)
                {
                    FuriousCount++;
                    FuriousTimer = 30;
                }
            }
        }
        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            #region Blue Scroll
            if (Player.HasBuff(ModContent.BuffType<BlueScroll>()))
            {
                #region Mail of Hellfire
                modifiers.FinalDamage *= MailofHellfireEndurance;
                #endregion

                if (Player.HasBuff(ModContent.BuffType<Beserk>()))
                {
                    modifiers.FinalDamage *= 0.25f;
                }
            }
            #endregion
        }

        public override void ModifyHitNPCWithItem(Item item, NPC target, ref NPC.HitModifiers modifiers)
        {
            #region Red Scroll
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                modifiers.FinalDamage *= MailofHellfireMelee;
            }
            #endregion
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            #region Blue Scroll
            if (Player.HasBuff(ModContent.BuffType<BlueScroll>()))
            {
                modifiers.FinalDamage *= MailofHellfireShoot;
            }
            #endregion
        }
        public override void ModifyItemScale(Item item, ref float scale)
        {
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                scale *= MailofHellfireMelee;
            }
        }
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (Player.HasBuff(ModContent.BuffType<Beserk>()))
            {
                BerserkDot += 35;
            }
        }
        public override void UpdateBadLifeRegen()
        {
            if (Player.HasBuff(ModContent.BuffType<Beserk>()))
            {
                Player.lifeRegen = BerserkRegen - BerserkDot;


                Player.lifeRegenTime = 0;

                if (Player.lifeRegenCount > 0)
                    Player.lifeRegenCount = -100;
            }
            if ((Player.HasBuff(ModContent.BuffType<RedScroll>()) || Player.HasBuff(ModContent.BuffType<BlueScroll>())) && DerelictionStage >=1)
            {
                if (Player.lifeRegen >= -5)
                {
                    Player.lifeRegen = -11;
                }
            }
        }
    }
}