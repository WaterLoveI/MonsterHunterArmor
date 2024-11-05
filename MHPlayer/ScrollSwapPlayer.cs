using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public int HeaventSentTimer;
        public int HeaventSentActivation;

        public float DragonConversionRate;
        public int DragConvCount;
        public int DragConvCritCount;
        public int DragonConvLimit = 100;

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
            HeaventSentActivation = 0;

            DragonConversionRate = 0f;
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
                    DragConvCritCount = 0;
                    DragConvCount = 0;
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
                Vector2 spread = new Vector2(Main.rand.NextFloat(-1f, 1f), Main.rand.NextFloat(-1f, 1f));
                spread = spread.RotatedBy(Main.rand.NextFloat(0f, 360f)); // Random rotation for spread
                spread *= 0.5f; // Adjust the spread distance
                Main.dust[d].velocity = spread;
                Main.dust[d].noGravity = true;
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
            #region Berserk
            if (BerserkDot >= 0 && Main.rand.NextBool(3))
            {
                BerserkDot--;
            }
            #endregion
            #region Dereliction
            if (modPlayer.Dereliction >= 1 && !(DerelictionStage == 3) && (Player.HasBuff(ModContent.BuffType<RedScroll>()) || Player.HasBuff(ModContent.BuffType<BlueScroll>())))
            {
                DerelictionTimer++;
                if (DerelictionTimer > 0 && DerelictionTimer <= 60 * 60)
                {
                    DerelictionStage = 1;
                }
                if (DerelictionTimer > 30 * 60 && DerelictionTimer <= 120 * 60)
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
            #endregion
        }


        public override void PostUpdateMiscEffects()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            MHPlayerArmorSkill RecUp = Player.GetModPlayer<MHPlayerArmorSkill>();

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
                if (modPlayer.QuickBreath >= 1 || modPlayer.QuickBreath >= 3)
                {
                    int postUpdateDebuffCount = Player.buffType.Count(MHLists.debuffList.Contains);
                    if (postUpdateDebuffCount > QuickBreathHeal && QuickBreathCooldown == 0 && modPlayer.QuickBreath >= 1)
                    {
                        
                        int healamt = (int)((postUpdateDebuffCount - QuickBreathHeal) * 20 * RecUp.RecoveryUp);
                        Player.Heal(healamt);
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
                    
                    int derehealamt = (int)(DerelictionStage * Player.statLifeMax2 / 10 * RecUp.RecoveryUp);
                    Player.Heal(derehealamt);
                    DerelictionTimer = 0;
                    DerelictionStage = 0;
                }
                #region Dragon Conversion
                if (DragConvCount >= DragonConvLimit)
                {
                    int Duration = (int)(60 * 60 * RecUp.ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<DragonConversion>(), Duration);
                }
                #endregion
            }
            #endregion
            #region Heavensent
            if (modPlayer.HeavenSent >= 1)
            {
                int hostileNPCs = 0;
                for (int i = 0; i < Main.maxNPCs; i++)
                {
                    NPC npc = Main.npc[i];
                    if (npc.active && npc.boss && npc.friendly == false && npc.chaseable && !npc.immortal)
                    {
                        // Count the number of active hostile NPCs nearby
                        if (npc.Distance(Player.Center) < 1200f)
                        {
                            hostileNPCs++;
                        }
                    }
                }
                if (hostileNPCs >= 1 && !Player.HasBuff(ModContent.BuffType<HeavenSent>()))
                {
                    HeaventSentTimer++;
                }
                if (HeaventSentTimer >= HeaventSentActivation)
                {
                    Player.AddBuff(ModContent.BuffType<HeavenSent>(), 2);
                }
                if (Player.HasBuff(ModContent.BuffType<HeavenSent>()))
                {
                    float Endure = 0.1f;
                    float Speed = 0.05f;
                    if (modPlayer.HeavenSent >= 2)
                    {
                        Endure = 0.2f;
                        Speed = 0.1f;
                    }
                    if (modPlayer.HeavenSent >= 3)
                    {
                        Player.wingTime = Player.wingTimeMax;
                        Endure = 0.3f;
                        Speed = 0.15f;
                    }

                    Player.endurance += Endure;
                    Player.moveSpeed += Speed;
                    Player.manaCost = 0;
                }

            }

            #endregion
            if (Player.HasBuff(ModContent.BuffType<DragonConversion>()))
            {
                int totaldamage = (int)(DragConvCritCount * DragonConversionRate);
                Player.GetDamage(DamageClass.Generic) += totaldamage / 100f;
            }
            if (DragConvCritCount == 0)
            {
                Player.ClearBuff(ModContent.BuffType<DragonConversion>());
            }

        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                if (FuriousTimer == 0 && FuriousDef > 0)
                {
                    FuriousCount++;
                    FuriousTimer = 30;
                }
            }
            if (Player.HasBuff(ModContent.BuffType<BlueScroll>()))
            {
                if (DragonConversionRate > 0 && DragConvCount <= DragonConvLimit)
                {
                    DragConvCount++;
                    if (hit.Crit)
                    {
                        DragConvCritCount++;
                    }
                }
            }
            AdvancedPopupRequest popup = new AdvancedPopupRequest { Text = damageDone + " damage!!", Color = Color.Blue, DurationInFrames = 180, Velocity = new Vector2(0f, 1f) };
            PopupText.NewText(popup, Player.Top + new Vector2(0, -70));
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Player.HasBuff(ModContent.BuffType<RedScroll>()))
            {
                if (FuriousTimer == 0 && FuriousDef > 0)
                {
                    FuriousCount++;
                    FuriousTimer = 30;
                }
            }
            if (Player.HasBuff(ModContent.BuffType<BlueScroll>()))
            {
                if (DragonConversionRate > 0 && DragConvCount <= DragonConvLimit)
                {
                    DragConvCount++;
                    if (hit.Crit)
                    {
                        DragConvCritCount++;
                    }
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
            if (Player.HasBuff(ModContent.BuffType<Beserk>()) && Player.statLife > 1)
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
        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            if (Player.HasBuff(ModContent.BuffType<HeavenSent>()))
            {
                return false;
            }
            return base.CanConsumeAmmo(weapon, ammo);
        }
    }
}
