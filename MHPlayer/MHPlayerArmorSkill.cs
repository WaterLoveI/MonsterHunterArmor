﻿using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Items.Consumables;
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using System;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.MHPlayer
{
    public partial class MHPlayerArmorSkill : ModPlayer
    {
        #region Skills
        public bool AquaMobility;

        public bool BlightImmune;
        public bool BlightSpeedup;
        public bool Fortified;
        public bool Guard;
        public bool GuardRaised;
        public bool IntrepidHeart;
        public bool LatentPower;
        public bool LatentPowerHostile;
        public bool PowderMantle;
        public bool qBreathClear;
        public bool qBreathHeal;
        public bool SpiritBirdCall;
        public int SpeedSetup;
        public double Tenderizer;
        public float DeadEye;
        public float CritEle;
        public float LatentPowerManaCost;
        public bool RapidFire;
        public int RapidFireReuse;
        public float RapidFireDamage;
        public float RecoveryUp;
        public float SpeedEating;
        public float QuickGather;
        public int aSlidingCrit;
        public int aSlidingTimer;
        public int ArtilleryBuff;
        public bool Berserk;
        public int BerserkRegen;
        public int BerserkDot;
        public int BladeHoneScale;
        public int Bloodlust;
        public int BloodlustCount;
        public int BloodlustHeal;
        public int BloodRite;
        public int BloodRiteTimer;
        public int BombBoostBuff;
        public int Constitution;
        public int BubbleDance;
        public int CarvingChance;
        public int CliffHanger;
        public int Coalescence;
        public int CoalescenceCount;
        public int CounterStrike;
        public int CritBoost;
        public int Defiance;
        public int DefianceCooldown;
        public int Embolden;
        public int EmboldenAggro;
        public int EmboldenDef;
        public int EvasionChance;
        public int EvadeDistance;
        public int Evasion;
        public int EvadeTimer;
        public int FireAttack;
        public int Foray;
        public int FreeElement;
        public int FreeMeal;
        public int Gatherer;
        public int Geologist;
        public int GuardCooldown;
        public int GuardMovement;
        public int GuardReduction;
        public int Guardup;
        public int Guts;
        public bool GutsActive;
        public int GutsTimer;
        public int Handicraft;
        public int HastenRec;
        public int HeroicsAttack;
        public int HeroicsDefence;
        public int HoneyHunter;
        public int IceAttack;
        public int IHeartCountdown;
        public int LatentPowerAffinity;
        public int LatentPowerCounter;
        public int LastingPower;
        public int MailofHellfire;
        public int MastersTouch;
        public int MastersTouchCooldown;
        public int Mushroomancer;
        public int NormalBuff;
        public int OffensiveGuardBoost;
        public int PelletBuff;
        public int PieceBuff;
        public int PolarHunterAtk;
        public int PolarHunterDef;
        public int PolarHunterMovement;
        public int PowderMantleCount;
        public int Protection;
        public int ProtectivePolish;
        public int RazorSharp;
        public int RecoverySpeed;
        public int ResentmentBuff;
        public int ResusitateBuff;
        public int Scholar;
        public bool Sharpness;
        public float SneakAttack;
        public int SpareShot;
        public int SpiritAttack;
        public int SpiritCrit;
        public int StrifeCrit;
        public float SpeedSharpening;
        public int ThunderAttack;
        public int TropicHunterAtk;
        public int TropicHunterDef;
        public int TropicHunterMovement;
        public int Unscathed;
        public int Vault;
        public int WaterAttack;
        public bool CRangePlus;
        public int Elemental;
        public bool PCoatingUp;
        public bool CritELeTrue;
        public int CritDraw;
        public int PunishDraw;
        public int ChallengeSheathe;
        public int Grinder;
        public int QuickSheath;
        public int StaminaRec;
        public float FireRes;
        public float WaterRes;
        public float IceRes;
        public float ThunderRes;
        public float ElementalRes;
        #endregion
        public bool BubbleBlight;
        private int lastWeaponType = -1;
        private float cooldownTimer = 0;

        public override void ResetEffects()
        {
            #region Skills
            AquaMobility = false;
            ArtilleryBuff = 0;
            aSlidingCrit = 0;
            Berserk = false;
            BerserkRegen = 0;
            BladeHoneScale = 0;
            BlightImmune = false;
            BlightSpeedup = false;
            Bloodlust = 0;
            BloodlustHeal = 0;
            BloodRite = 0;
            BloodRiteTimer = 0;
            BombBoostBuff = 0;
            BubbleDance = 0;
            CarvingChance = 0;
            CliffHanger = 0;
            Coalescence = 0;
            Constitution = 0;
            CounterStrike = 0;
            CRangePlus = false;
            CritBoost = 0;
            CritDraw = 0;
            CritEle = 0f;
            CritELeTrue = false;
            DeadEye = 0;
            Defiance = 0;
            Elemental = 0;
            ElementalRes = 0;
            Embolden = 0;
            EmboldenAggro = 0;
            EmboldenDef = 0;
            EvadeDistance = 0;
            EvasionChance = 0;
            Evasion = 0;
            FireAttack = 0;
            FireRes = 0;
            Foray = 0;
            Fortified = false;
            FreeElement = 0;
            FreeMeal = 0;
            Gatherer = 0;
            Geologist = 0;
            Grinder = 0;
            Guard = false;
            GuardMovement = 0;
            GuardReduction = 0;
            Guardup = 0;
            Guts = 0;
            GutsActive = false;
            GutsTimer = 0;
            Handicraft = 0;
            HastenRec = 0;
            HeroicsAttack = 0;
            HeroicsDefence = 0;
            HoneyHunter = 0;
            IceAttack = 0;
            IceRes = 0;
            IntrepidHeart = false;
            LastingPower = 0;
            LatentPower = false;
            LatentPowerAffinity = 0;
            LatentPowerHostile = false;
            LatentPowerManaCost = 0;
            MailofHellfire = 0;
            MastersTouch = 0;
            Mushroomancer = 0;
            NormalBuff = 0;
            OffensiveGuardBoost = 0;
            PCoatingUp = false;
            PelletBuff = 0;
            PieceBuff = 0;
            PolarHunterAtk = 0;
            PolarHunterDef = 0;
            PolarHunterMovement = 0;
            Protection = 0;
            ProtectivePolish = 0;
            PunishDraw = 0;
            QuickGather = 0;
            QuickSheath = 0;
            RapidFire = false;
            RapidFireDamage = 0.25f;
            RapidFireReuse = 35;
            RazorSharp = 0;
            RecoverySpeed = 0;
            RecoveryUp = 1f;
            ResentmentBuff = 0;
            ResusitateBuff = 0;
            Scholar = 0;
            Sharpness = false;
            SneakAttack = 1f;
            SpareShot = 0;
            SpeedEating = 0;
            SpeedSetup = 0;
            SpeedSharpening = 1f;
            SpiritAttack = 0;
            SpiritBirdCall = false;
            SpiritCrit = 0;
            StrifeCrit = 0;
            Tenderizer = 0;
            ThunderAttack = 0;
            ThunderRes = 0;
            TropicHunterAtk = 0;
            TropicHunterDef = 0;
            TropicHunterMovement = 0;
            Unscathed = 0;
            Vault = 0;
            WaterAttack = 0;
            WaterRes = 0;
            StaminaRec = 0;
            #endregion

            BubbleBlight = false;
        }


        public override void PreUpdate()
        {
            int Debuffcount = Player.buffType.Count(MHLists.debuffList.Contains);
            #region Latent Power
            if (LatentPowerHostile && LatentPowerCounter == 0)
            {
                LatentPowerCounter++;
            }
            if (LatentPowerCounter >= 1)
            {
                LatentPowerCounter++;
                if (Main.rand.NextBool(5))
                {
                    Lighting.AddLight((int)Player.Center.X / 16, (int)Player.Center.Y / 16, 0.4f, 0.6f, 1f);
                    for (int i = 0; i < 2; i++)
                    {
                        int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Electric, 0, 0, 100, Color.Transparent, 0.5f);
                        Main.dust[d].noGravity = true;
                        Main.dust[d].noLight = false;
                        Main.dust[d].fadeIn = 1f;
                        Main.dust[d].velocity *= 0.6f;
                    }
                }

            }
            #endregion
            #region Affinity Sliding
            if (aSlidingTimer > 0)
            {
                aSlidingTimer--;
            }
            #endregion
            #region Guard
            if (GuardCooldown > 0)
            {
                GuardCooldown--;
            }
            #endregion
            #region Coalescence
            if (Coalescence >= 1)
            {
                CoalescenceCount = Debuffcount;
            }
            #endregion
            #region Quick Breath
            if (qBreathHeal && PlayerInput.Triggers.Current.MouseRight)
            {
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
                    int DebuffHeal = Debuffcount * 20;
                    Player.Heal(DebuffHeal);
                    SoundEngine.PlaySound(SoundID.Item4);
                }
            }
            #endregion
            #region Defiance
            if (DefianceCooldown > 0)
            {
                DefianceCooldown--;
            }
            #endregion
            #region Blood Rite
            if (BloodRiteTimer > 0)
            {
                BloodRiteTimer--;
            }
            #endregion
            #region Berserk
            if (BerserkDot >= 0 && Main.rand.NextBool(3))
            {
                BerserkDot--;
            }
            #endregion
            #region Masters Touch
            if (MastersTouchCooldown > 0)
            {
                MastersTouchCooldown--;
            }
            #endregion
            #region Guts
            if (GutsTimer > 0)
            {
                GutsTimer--;
            }
            if (Guts >= 1 && GutsTimer == 0)
            {
                float HPThresh = (6 - Guts) / 10;
                int GutsHP = (int)(Player.statLifeMax2 * HPThresh);
                if (Player.statLife >= GutsHP)
                {
                    GutsActive = true;
                }
            }
            #endregion
            #region Sheath
            int currentWeaponType = Player.HeldItem.type;

            if (currentWeaponType != lastWeaponType && cooldownTimer == 0)
            {
                int Chance = 7 - QuickSheath;
                int rand = Main.rand.Next(1, Chance);
                if (rand <= 1)
                {
                    if (PunishDraw >= 1)
                    {
                        Player.AddBuff(ModContent.BuffType<PunishDraw>(), 7 * 60);
                        cooldownTimer = 10 * 60;
                    }
                    if (CritDraw >= 1)
                    {
                        Player.AddBuff(ModContent.BuffType<CritDraw>(), 7 * 60);
                        cooldownTimer = 10 * 60;
                    }
                    if (ChallengeSheathe >= 1)
                    {
                        int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));
                        int CSheath = 3 + (ChallengeSheathe * 2);
                        // Check if the player has the Regeneration buff
                        if (SharpnessBuffIndex != -1)
                        {
                            // Add one second to the Regeneration buff
                            Player.buffTime[SharpnessBuffIndex] += CSheath * 60;
                            cooldownTimer = 10 * 60;
                        }
                        if (SharpnessBuffIndex == -1)
                        {
                            // Add one second to the Regeneration buff
                            Player.AddBuff(ModContent.BuffType<Sharpness>(), CSheath * 60);
                            cooldownTimer = 10 * 60;
                        }
                    }
                }
                if (rand > 1 && cooldownTimer == 0)
                {
                    cooldownTimer = 60;
                }
            }
            if (cooldownTimer > 0)
            {
                cooldownTimer--;
            }

            lastWeaponType = currentWeaponType;
            #endregion
            #region Constitution
            if (Constitution >= 1 && Player.dashDelay >= 4)
            {
                int constsec = Constitution * 4;
                Player.dashDelay -= constsec;

                if (Player.dashDelay <= -2)
                {
                    Player.dashDelay = 0;
                }
            }
            #endregion
            #region Grinder
            if (Grinder >= 1 && Player.HasBuff(ModContent.BuffType<Sharpness>()))
            {
                Player.AddBuff(ModContent.BuffType<Grinder>(), 1);
            }
            #endregion
            #region Resentment/Strife
            if (Player.HasBuff(BuffID.PotionSickness))
            {
                if (StrifeCrit >= 1)
                {
                    Player.GetCritChance(DamageClass.Generic) += StrifeCrit;
                }
                if (ResentmentBuff >= 1)
                {
                    Player.GetDamage(DamageClass.Generic) += ResentmentBuff / 100f;
                }
            }
            #endregion
            #region Evade Distance
            if (EvadeTimer > 0)
            {
                EvadeTimer--;
            }
            #endregion
            #region Stam Rec
            if (StaminaRec >= 1)
            {
                int StamRecLevel = 11 - StaminaRec;
                if (Main.rand.NextBool(StamRecLevel))
                {
                    if (Player.statManaMax2 > Player.statMana)
                    {
                        Player.statMana++;
                    }
                }

            }
            #endregion
        }

        public override void PostUpdateMiscEffects()
        {
            #region Mail of Hellfire
            if (MailofHellfire >= 1)
            {
                Player.GetDamage(DamageClass.Generic) += (MailofHellfire * 5) / 100f;
                Player.statDefense /= MailofHellfire;
                Player.endurance /= MailofHellfire;
            }
            #endregion
            #region Bubble Blight/Dance
            if (BubbleBlight && BubbleDance == 0)
            {
                if (BubbleDance == 0)
                {
                    Player.accRunSpeed = 0.5f; // Reduce run speed
                    Player.jumpBoost = false; // Remove jump boost
                    Player.maxRunSpeed *= 0.5f; // Slow down horizontal movement
                    Player.wingAccRunSpeed /= 2;
                }
                if (BubbleDance >= 3)
                {
                    Player.maxRunSpeed *= 1.2f;
                }
            }
            #endregion
            #region Speed Sharpening
            if (SpeedSharpening >= 3)
            {
                if (Player.ActiveItem().type == ModContent.ItemType<WhetStone>() && !Player.HasBuff(ModContent.BuffType<Sharpness>()))
                {
                    int Timer = 45;
                    if (RazorSharp >= 1)
                    {
                        Timer += 45 * RazorSharp;
                    }
                    Player.AddBuff(ModContent.BuffType<Sharpness>(), Timer * 60);
                    SoundEngine.PlaySound(SoundID.Item37);
                }
            }
            #endregion
            #region Protective Polish
            if (ProtectivePolish >= 1)
            {
                for (int l = 0; l < Player.MaxBuffs; l++)
                {
                    int hasBuff = Player.buffType[l];
                    if (hasBuff == ModContent.BuffType<Sharpness>())
                    {
                        if (Player.miscCounter % ProtectivePolish == 0)
                            Player.buffTime[l] += 1;
                    }
                }
            }
            #endregion
            #region Lasting Power
            if (LastingPower >= 1)
            {
                for (int l = 0; l < Player.MaxBuffs; l++)
                {
                    int hasBuff = Player.buffType[l];
                    if (MHLists.buffList.Contains(hasBuff))
                    {
                        // Every 3 frames, increase the buff timer by one frame. Thus, the buff lasts three times longer.
                        if (Player.miscCounter % LastingPower == 0)
                            Player.buffTime[l] += 1;
                    }
                }
            }
            #endregion
            #region CounterStrike
            if (Player.HasBuff(ModContent.BuffType<CounterStrike>()))
            {
                Player.GetCritChance(DamageClass.Generic) += CounterStrike / 100f;
            }
            #endregion
            #region Resusitate
            if (ResusitateBuff >= 1)
            {
                for (int l = 0; l < Player.MaxBuffs; ++l)
                {
                    int buffID = Player.buffType[l];
                    if (Player.buffTime[l] <= 2)
                        continue;
                    bool Statused = MHLists.debuffList.Contains(buffID);
                    if (Statused)
                    {
                        Player.GetDamage(DamageClass.Generic) += ResusitateBuff / 100f;
                    }
                }
            }
            #endregion
            #region Crit Draw
            if (Player.HasBuff(ModContent.BuffType<CritDraw>()))
            {
                int CDraw = CritDraw * 7;
                Player.GetCritChance(DamageClass.Generic) += CDraw;
            }
            #endregion
            #region Punish Draw
            if (Player.HasBuff(ModContent.BuffType<PunishDraw>()))
            {
                int pDraw = PunishDraw * 10;
                Player.GetKnockback(DamageClass.Generic) += pDraw / 100f;
                Player.GetDamage(DamageClass.Melee) += PunishDraw / 100f;
            }
            #endregion
            #region Grinder
            if (Player.HasBuff(ModContent.BuffType<Grinder>()))
            {

                Player.GetDamage(DamageClass.Generic) += Grinder / 100f;
            }
            #endregion
            #region Intrepid Heart
            if (IHeartCountdown >= 60)
            {
                Player.AddBuff(ModContent.BuffType<IntrepidHeart>(), 2);
                Player.noKnockback = true;
            }
            #endregion
            #region Latent Power
            if (LatentPowerCounter >= 30 * 60)
            {
                Player.AddBuff(ModContent.BuffType<LatentPower>(), 30 * 60);
            }

            if (Player.HasBuff(ModContent.BuffType<LatentPower>()))
            {
                Player.GetCritChance(DamageClass.Generic) += LatentPowerAffinity;
                Player.manaCost *= LatentPowerManaCost / 100;
                if (Main.rand.NextBool(5))
                {
                    Lighting.AddLight((int)Player.Center.X / 16, (int)Player.Center.Y / 16, 0.4f, 0.6f, 1f);
                    for (int i = 0; i < 2; i++)
                    {
                        int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.Electric, 0, 0, 100, Color.Transparent, 0.5f);
                        Main.dust[d].noGravity = true;
                        Main.dust[d].noLight = false;
                        Main.dust[d].fadeIn = 1f;
                        Main.dust[d].velocity *= 1.1f;
                    }
                }

                LatentPowerCounter = 0;
            }
            #endregion
            #region Unscathed
            if (Unscathed >= 1 && Player.statLife == Player.statLifeMax2)
            {
                Player.AddBuff(ModContent.BuffType<Unscathed>(), 2);
                Player.GetDamage(DamageClass.Generic) += Unscathed / 100f;
            }
            #endregion
            #region Vault
            if (Vault >= 1 && (Player.velocity.Y != 0f || Player.wingTime > 0))
            {
                Player.AddBuff(ModContent.BuffType<Vault>(), 2);
                Player.GetDamage(DamageClass.Generic) += Vault / 100f;
            }
            #endregion
            #region Offensive Guard
            if (Player.HasBuff(ModContent.BuffType<OffensiveGuard>()))
            {
                Player.GetDamage(DamageClass.Generic) += OffensiveGuardBoost / 100f;
            }
            #endregion
            #region Polar Hunter
            if (PolarHunterDef >= 1 && Player.ZoneSnow)
            {
                Player.AddBuff(ModContent.BuffType<PolarHunter>(), 2);
                Player.GetDamage(DamageClass.Generic) += PolarHunterAtk / 100f;
                Player.moveSpeed += PolarHunterMovement / 100f;
                Player.statDefense += PolarHunterDef;
            }
            #endregion
            #region Tropic Hunter
            if (TropicHunterDef >= 1 && (Player.ZoneDesert || Player.ZoneJungle || Player.ZoneUnderworldHeight))
            {
                Player.AddBuff(ModContent.BuffType<TropicHunter>(), 2);
                Player.GetDamage(DamageClass.Generic) += TropicHunterAtk / 100f;
                Player.moveSpeed += TropicHunterMovement / 100f;
                Player.statDefense += TropicHunterDef;
            }
            #endregion
            #region Guard
            if (Guard)
            {
                GuardEffect();
            }
            #endregion
            #region Aqua Mobility
            if (AquaMobility)
            {
                Player.iceSkate = true;
                Player.accFlipper = true;
                if (Player.wet)
                {
                    Player.AddBuff(ModContent.BuffType<AquaticMobility>(), 2);
                }
            }
            #endregion
            #region Coalescence
            int postUpdateDebuffCount = Player.buffType.Count(MHLists.debuffList.Contains);

            if (postUpdateDebuffCount < CoalescenceCount)
            {
                Player.AddBuff(ModContent.BuffType<Coalescence>(), 600);
            }
            if (Player.HasBuff(ModContent.BuffType<Coalescence>()))
            {
                Player.GetDamage(DamageClass.Generic) += Coalescence / 100f;
            }

            #endregion
            #region Quick Breath
            if (qBreathClear && PlayerInput.Triggers.Current.MouseRight)
            {
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
                    SoundEngine.PlaySound(SoundID.Item4);
                }
            }
            #endregion
            #region Blight Immune
            if (BlightImmune || Defiance >= 3)
            {
                foreach (int debuff in MHLists.debuffList)
                    Player.buffImmune[debuff] = true;
            }
            #endregion
            #region Spiritbird
            if (SpiritBirdCall && !(Player.HasBuff(ModContent.BuffType<SpiritBirdBlue>()) || Player.HasBuff(ModContent.BuffType<SpiritBirdGreen>()) || Player.HasBuff(ModContent.BuffType<SpiritBirdOrange>()) || Player.HasBuff(ModContent.BuffType<SpiritBirdPrism>()) || Player.HasBuff(ModContent.BuffType<SpiritBirdYellow>())))
            {
                Random random = new Random();
                int effectIndex = random.Next(0, 5); // Random number from 0 to 2

                switch (effectIndex)
                {
                    case 0:
                        if (!Player.HasBuff(ModContent.BuffType<SpiritBirdBlue>()))
                        {
                            SoundEngine.PlaySound(SoundID.Zombie14);
                            Player.AddBuff(ModContent.BuffType<SpiritBirdBlue>(), 5 * 60 * 60);
                        }
                        break;
                    case 1:
                        if (!Player.HasBuff(ModContent.BuffType<SpiritBirdGreen>()))
                        {
                            SoundEngine.PlaySound(SoundID.Zombie14);
                            Player.AddBuff(ModContent.BuffType<SpiritBirdGreen>(), 5 * 60 * 60);
                        }
                        break;
                    case 2:
                        if (!Player.HasBuff(ModContent.BuffType<SpiritBirdOrange>()))
                        {
                            SoundEngine.PlaySound(SoundID.Zombie14);
                            Player.AddBuff(ModContent.BuffType<SpiritBirdOrange>(), 5 * 60 * 60);
                        }
                        break;
                    case 3:
                        if (!Player.HasBuff(ModContent.BuffType<SpiritBirdPrism>()))
                        {
                            SoundEngine.PlaySound(SoundID.Zombie14);
                            Player.AddBuff(ModContent.BuffType<SpiritBirdPrism>(), 5 * 60 * 60);
                        }
                        break;
                    case 4:
                        if (!Player.HasBuff(ModContent.BuffType<SpiritBirdYellow>()))
                        {
                            SoundEngine.PlaySound(SoundID.Zombie14);
                            Player.AddBuff(ModContent.BuffType<SpiritBirdYellow>(), 5 * 60 * 60);
                        }
                        break;
                    default:
                        // This should not happen under normal circumstances
                        break;
                }
            }
            #endregion
            #region Mushroomancer
            if (Mushroomancer >= 1)
            {
                Item[] inventory = Main.LocalPlayer.inventory;
                bool Mushroom = inventory.Any(slot => slot != null && slot.type == ItemID.Mushroom);
                bool GlowingMushroom = inventory.Any(slot => slot != null && slot.type == ItemID.GlowingMushroom);
                bool GreenMushroom = inventory.Any(slot => slot != null && slot.type == ItemID.GreenMushroom);
                if (Mushroom)
                {
                    Player.AddBuff(BuffID.Regeneration, 2);
                }
                if (GlowingMushroom)
                {
                    Player.statManaMax2 += 20;
                }
                if (GreenMushroom)
                {
                    Player.jumpBoost = true;
                }
                if (Mushroomancer >= 2)
                {
                    bool Vile = inventory.Any(slot => slot != null && slot.type == ItemID.VileMushroom);
                    bool Vicious = inventory.Any(slot => slot != null && slot.type == ItemID.ViciousMushroom);
                    bool Teal = inventory.Any(slot => slot != null && slot.type == ItemID.TealMushroom);
                    if (Vile)
                    {
                        Player.AddBuff(BuffID.Wrath, 2);
                    }
                    if (Vicious)
                    {
                        Player.AddBuff(BuffID.Rage, 2);
                    }
                    if (Teal)
                    {
                        Player.statLifeMax2 += 20;
                    }
                }
            }
            #endregion
            #region NPC Check
            int hostileNPCs = 0;
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (npc.active && npc.boss && npc.friendly == false && npc.chaseable && !npc.immortal)
                {
                    // Count the number of active hostile NPCs nearby
                    if (npc.Distance(Player.Center) < 1000f) // Adjust the range as desired
                    {
                        hostileNPCs++;
                    }
                }
            }
            if (hostileNPCs >= 1)
            {
                if (Bloodlust >= 1)
                {
                    BloodLustEffect();
                }
                if (Defiance >= 1)
                {
                    DefianceEffect();
                }
                if (SpiritAttack >= 1)
                {
                    SpiritEffect();
                }
                if (LatentPower)
                {
                    LatentPowerHostile = true;
                }
                if (Embolden >= 1)
                {
                    EmboldenEffect();
                }
            }
            #endregion
            #region Dashing
            if (Player.timeSinceLastDashStarted <= 2)
            {
                #region Affinity Sliding
                if (aSlidingCrit >= 1 && aSlidingTimer == 0)
                {
                    Player.AddBuff(ModContent.BuffType<AffinitySliding>(), 5 * 60);
                    aSlidingTimer = 5 * 60;
                    if (Player.HasBuff(ModContent.BuffType<AffinitySliding>()))
                    {
                        Player.GetCritChance(DamageClass.Generic) += aSlidingCrit;
                    }
                }
                #endregion
                #region Bladehone Scale
                if (BladeHoneScale >= 1 && aSlidingTimer == 0)
                {
                    Player.AddBuff(ModContent.BuffType<BladeHoneScale>(), 7 * 60);
                    aSlidingTimer = 7 * 60;
                    if (Player.HasBuff(ModContent.BuffType<BladeHoneScale>()))
                    {
                        Player.manaCost *= (100 - BladeHoneScale * 3) / 100;

                        if (Player.HasBuff(ModContent.BuffType<Sharpness>()))
                        {
                            int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));
                            Player.buffTime[SharpnessBuffIndex] += 60;
                        }

                        if (!Player.HasBuff(ModContent.BuffType<Sharpness>()))
                        {
                            Player.AddBuff(ModContent.BuffType<Sharpness>(), 7 * 60);
                        }

                        if (BladeHoneScale >= SpareShot)
                        {
                            SpareShot = BladeHoneScale;
                        }
                    }
                }
                #endregion
                #region Bubble Dance
                if (BubbleDance >= 1 && !Player.HasBuff(ModContent.BuffType<BubbleBlight>()))
                {
                    Player.AddBuff(ModContent.BuffType<BubbleBlight>(), 15 * 60);
                }
                #endregion
                #region Evade Distance
                if (EvadeDistance >= 1)
                {

                    float ED = EvadeDistance / 10;
                    if (Player.direction == 1 && Player.velocity.X != 0f) // If true, the player is facing right
                    {

                        Player.velocity.X += ED;
                    }
                    else if (Player.direction == -1 && Player.velocity.X != 0f)
                    {

                        Player.velocity.X -= ED;
                    }
                }
                #endregion
                #region Evasion
                if (Evasion >= 1 && EvadeTimer == 0)
                {
                    int EvasionTime = Evasion;
                    Player.GiveIFrames(EvasionTime, true);
                    EvadeTimer = 60;
                }
                #endregion
            }
            #endregion
        }
        #region Guard
        public void GuardEffect()
        {

            GuardRaised = false;
            if (Player.inventory[Player.selectedItem].type == ItemID.DD2SquireDemonSword || Player.inventory[Player.selectedItem].type == ItemID.BouncingShield)
            {
                return;
            }
            Player.shieldRaised = Player.selectedItem != 58 && Player.controlUseTile && !Player.tileInteractionHappened && Player.releaseUseItem
                && !Player.controlUseItem && !Player.mouseInterface && !CaptureManager.Instance.Active && !Main.HoveringOverAnNPC
                && !Main.SmartInteractShowingGenuine &&
                Player.itemAnimation == 0 && Player.itemTime == 0 && Player.reuseDelay == 0 && PlayerInput.Triggers.Current.MouseRight && Player.hasRaisableShield && GuardCooldown == 0;

            if (Player.shieldRaised)
            {
                GuardRaised = true;
                Player.AddBuff(ModContent.BuffType<Guard>(), 2);
                Player.shieldRaised = true;
                Player.moveSpeed += GuardMovement / 100f;

                int GDef = 5 + (Guardup * 5);

                Player.statDefense += GDef;
                Player.moveSpeed /= 3;
                if (Player.velocity.Y == 0f && Math.Abs(Player.velocity.X) > 3f)
                {
                    Player.velocity.X /= 2f;
                }

            }
            else
            {
                Player.shield_parry_cooldown = 0;
            }
        }
        #endregion
        #region BloodLust
        public void BloodLustEffect()
        {
            if (!(Player.HasBuff(ModContent.BuffType<Frenzy>()) || Player.HasBuff(ModContent.BuffType<FrenzyCure>()) || Player.HasBuff(ModContent.BuffType<FrenzyFail>())) && BloodlustCount == 0)
            {
                BloodlustCount += 1;
                Player.AddBuff(ModContent.BuffType<Frenzy>(), 60 * 60);
                BloodlustHeal = 0;
            }
            if (!(Player.HasBuff(ModContent.BuffType<Frenzy>()) || Player.HasBuff(ModContent.BuffType<FrenzyCure>()) || Player.HasBuff(ModContent.BuffType<FrenzyFail>())) && BloodlustCount >= 1)
            {
                Player.AddBuff(ModContent.BuffType<FrenzyFail>(), 60 * 60);
            }
            if (Player.HasBuff(ModContent.BuffType<Frenzy>()) && BloodlustCount >= 240)
            {
                Player.ClearBuff(ModContent.BuffType<Frenzy>());
                BloodlustCount = 0;
                if (BloodlustHeal == 0)
                {
                    Player.Heal(Bloodlust * 5);
                    BloodlustHeal += 1;
                }
                if (Bloodlust >= 3)
                {
                    Player.AddBuff(ModContent.BuffType<FrenzyCure>(), 90 * 60);
                }
                else
                {
                    Player.AddBuff(ModContent.BuffType<FrenzyCure>(), 60 * 60);
                }

            }
            if (Player.HasBuff(ModContent.BuffType<Frenzy>()))
            {
                Player.manaCost *= ((100 - (Bloodlust * 3))) / 100f;
                Player.GetDamage(DamageClass.Generic) += (Bloodlust * 4) / 100f;
                Player.lifeRegen = 0;
                if (EvasionChance > 0 && EvasionChance > 19)
                {
                    EvasionChance = 20;
                }
                if (Main.rand.NextBool(5))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.SpookyWood, 0, 0, 100, Color.Transparent, 0.7f);
                        Main.dust[d].noGravity = true;
                        Main.dust[d].noLight = false;
                        Main.dust[d].fadeIn = 1f;
                        Main.dust[d].velocity *= 0.6f;
                    }
                }

            }
            if (Player.HasBuff(ModContent.BuffType<FrenzyCure>()))
            {
                Player.GetCritChance(DamageClass.Generic) += Bloodlust * 5;

            }
            if (Player.HasBuff(ModContent.BuffType<FrenzyFail>()))
            {
                Player.endurance /= 2;
                BloodlustCount = 0;
            }
        }
        #endregion
        #region Heroics
        public void HeroicsEffect()
        {
            int HeroicsRange = (int)(Player.statLifeMax2 * 0.35f);
            if (Player.statLife <= HeroicsRange)
            {
                Player.AddBuff(ModContent.BuffType<Heroics>(), 2);
                Player.statDefense += HeroicsDefence;
                Player.GetDamage(DamageClass.Generic) += HeroicsAttack / 100f;
            }
        }
        #endregion
        #region Spirit
        public void SpiritEffect()
        {
            Player.GetDamage(DamageClass.Generic) += SpiritAttack / 100f;
            Player.GetCritChance(DamageClass.Generic) += SpiritCrit;
            if (Main.rand.NextBool(5))
            {
                for (int i = 0; i < 2; i++)
                {
                    int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.CrimsonTorch, 0, 0, 100, Color.Transparent, 0.6f);
                    Main.dust[d].noGravity = true;
                    Main.dust[d].noLight = false;
                    Main.dust[d].fadeIn = 0.5f;
                    Main.dust[d].velocity *= 0.5f;
                }
            }
            Lighting.AddLight((int)Player.Center.X / 16, (int)Player.Center.Y / 16, 1f, 0.8f, 0.8f);
            Player.AddBuff(ModContent.BuffType<Spirit>(), 2);

        }
        #endregion
        #region Defiance
        public void DefianceEffect()
        {
            Player.AddBuff(ModContent.BuffType<Defiance>(), 2);
            if (Defiance >= 1)
            {
                Player.statDefense += 5;
                Player.noKnockback = true;
            }
            if (Defiance >= 2)
            {
                Player.statDefense += 5;
            }
            if (Defiance >= 3)
            {
                Player.statDefense += 5;
            }
            if (Defiance >= 4)
            {
                Player.statDefense += 5;
                Player.longInvince = true;
            }
            if (Defiance >= 5)
            {
                Player.statDefense += 5;
            }
            if (Main.rand.NextBool(5))
            {
                Lighting.AddLight((int)Player.Center.X / 16, (int)Player.Center.Y / 16, 1f, 0.6f, 0f);
                for (int i = 0; i < 3; i++)
                {
                    int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.SolarFlare, 0, 0, 100, Color.Transparent, 0.7f);
                    Main.dust[d].noGravity = true;
                    Main.dust[d].noLight = false;
                    Main.dust[d].fadeIn = 1f;
                    Main.dust[d].velocity *= 0.4f;
                }
            }


        }
        #endregion
        #region Embolden
        public void EmboldenEffect()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            Player.aggro += EmboldenAggro;
            Player.statDefense += EmboldenDef;
            int evasionboost = modPlayer.Embolden - modPlayer.Evasion;
            int guardboost = modPlayer.Embolden - modPlayer.Guard;
            int neweva = 20 - Embolden;
            if (evasionboost > EvasionChance)
            {
                EvasionChance = evasionboost;
            }
            modPlayer.Guard += guardboost;
            if (Main.rand.NextBool(5))
            {
                for (int i = 0; i < 3; i++)
                {
                    int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.GoldFlame, 0, 0, 100, Color.Transparent, 0.6f);
                    Main.dust[d].noGravity = true;
                    Main.dust[d].noLight = false;
                    Main.dust[d].fadeIn = 1f;
                    Main.dust[d].velocity *= 0.5f;
                }
            }

            GuardEffect();
        }
        #endregion
        #region Masters Touch
        public void MastersTouchEffect(NPC target, int damage, bool crit)
        {
            if (MastersTouch >= 1 && Main.rand.NextBool(MastersTouch) && MastersTouchCooldown == 0 && Player.HasBuff(ModContent.BuffType<Sharpness>()))
            {
                MastersTouchCooldown = 60;
                int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));

                // Check if the player has the Regeneration buff
                if (SharpnessBuffIndex != -1)
                {
                    // Add one second to the Regeneration buff
                    Player.buffTime[SharpnessBuffIndex] += 60;
                }
            }
        }
        #endregion
        #region CritELe
        public void CritELementEffect(NPC target, int damage, bool crit)
        {
            if ((MHLists.fireelementList.Contains(Player.HeldItem.type) ||
        MHLists.thunderelementList.Contains(Player.HeldItem.type) ||
        MHLists.iceelementList.Contains(Player.HeldItem.type) ||
        MHLists.waterelementList.Contains(Player.HeldItem.type)) &&
       CritEle > 0)
            {
                CritELeTrue = true;
            }
        }
        #endregion

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            base.OnHitNPC(target, hit, damageDone);
            #region Free Element
            if (FreeElement >= 1)
            {
                int Timer = Main.rand.Next(360, 600);
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(BuffID.Poisoned, Timer);
                }
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(BuffID.OnFire, Timer);
                }

                if (FreeElement >= 2)
                {
                    if (Main.rand.NextBool(5))
                    {
                        target.AddBuff(BuffID.Electrified, Timer);
                    }
                    if (Main.rand.NextBool(5))
                    {
                        target.AddBuff(BuffID.OnFire3, Timer);
                    }
                }

                if (FreeElement >= 3)
                {
                    if (Main.rand.NextBool(5))
                    {
                        target.AddBuff(BuffID.Venom, Timer);
                    }
                    if (Main.rand.NextBool(5))
                    {
                        target.AddBuff(BuffID.Frostburn2, Timer);
                    }
                }
            }
            #endregion
            #region Intrepid Heart
            if (IntrepidHeart)
            {
                IHeartCountdown += 1;
            }
            #endregion
            #region Bloodlust
            if (Bloodlust >= 1 && Player.HasBuff(ModContent.BuffType<Frenzy>()))
            {
                BloodlustCount += 3;
            }
            #endregion
            #region Defiance
            if (Defiance >= 5 && !target.friendly && Main.rand.NextBool(7) && DefianceCooldown == 0)
            {
                Item.NewItem(target.GetSource_Loot(), target.Hitbox, 3454);
                DefianceCooldown = 2 * 60;
            }
            #endregion
            #region Blood Rite
            if (BloodRite >= 1 && BloodRiteTimer == 0 && !target.friendly && Main.rand.NextBool(5))
            {
                float bruh = (float)(0.25 * BloodRite);
                int NPCHP = (int)(target.lifeMax * bruh);
                if (target.life < NPCHP)
                {
                    Item.NewItem(target.GetSource_Loot(), target.Hitbox, ItemID.Heart);
                    BloodRiteTimer = 10 * 60;
                }
            }
            #endregion
            #region Hasten Recovery
            if (HastenRec >= 1 && !Player.HasBuff(ModContent.BuffType<HastenRecovery>()))
            {
                Player.AddBuff(ModContent.BuffType<HastenRecovery>(), 5 * 60);
            }
            #endregion
            MastersTouchEffect(target, damageDone, hit.Crit);
            CritELementEffect(target, damageDone, hit.Crit);
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            #region Intrepid Heart
            if (IntrepidHeart)
            {
                if (!Main.rand.NextBool(4))
                {
                    IHeartCountdown += 1;
                }

            }
            #endregion
            #region Bloodlust
            if (Bloodlust >= 1 && Player.HasBuff(ModContent.BuffType<Frenzy>()))
            {

                BloodlustCount += 1;
            }
            #endregion
            #region Hasten Recovery
            if (HastenRec >= 1 && !Player.HasBuff(ModContent.BuffType<HastenRecovery>()))
            {
                Player.AddBuff(ModContent.BuffType<HastenRecovery>(), 5 * 60);
            }
            #endregion
            #region Defiance
            if (Defiance >= 5 && !target.friendly && Main.rand.NextBool(12) && DefianceCooldown == 0)
            {
                Item.NewItem(target.GetSource_Loot(), target.Hitbox, 3454);
                DefianceCooldown = 2 * 60;
            }
            #endregion
            #region Blood Rite
            if (BloodRite >= 1 && BloodRiteTimer == 0 && !target.friendly && Main.rand.NextBool(10))
            {
                float bruh = (float)(0.25 * BloodRite);
                int NPCHP = (int)(target.lifeMax * bruh);
                if (target.life < NPCHP && BloodRiteTimer == 0)
                {
                    int i = Item.NewItem(Player.GetSource_OpenItem(58), (int)target.position.X, (int)target.position.Y, target.width, target.height, 58, 1, false, 0, false, false);
                    Main.item[i].velocity.Y = Main.rand.Next(-20, 1) * 0.2f;
                    Main.item[i].velocity.X = Main.rand.Next(10, 31) * 0.2f * (proj == null ? Player.direction : proj.direction);
                    BloodRiteTimer = 7 * 60;
                }
            }
            #endregion
            #region Poison Coating Up
            if (PCoatingUp && proj.type == ProjectileID.WoodenArrowFriendly)
            {
                int Timer = Main.rand.Next(360, 600);
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(BuffID.Poisoned, Timer);
                }
            }

            #endregion
            CritELementEffect(target, damageDone, hit.Crit);
        }
        public override void ModifyHitByNPC(NPC npc, ref Terraria.Player.HurtModifiers modifiers)
        {
            base.ModifyHitByNPC(npc, ref modifiers);
            #region Protection
            if (Protection >= 1)
            {
                if (Main.rand.NextBool(Protection))
                {
                    modifiers.FinalDamage *= 0.75f;
                    SoundEngine.PlaySound(SoundID.NPCHit4);
                }
            }
            #endregion
            #region Intrepid Heart
            if (Player.HasBuff(ModContent.BuffType<IntrepidHeart>()))
            {
                modifiers.FinalDamage *= 0.5f;
                SoundEngine.PlaySound(SoundID.NPCDeath7);
            }
            #endregion
            #region Guard
            if (Guard && Player.shieldRaised && GuardCooldown == 0)
            {
                modifiers.SourceDamage *= GuardReduction / 100;
                SoundEngine.PlaySound(SoundID.NPCHit4);
                GuardCooldown = 3 * 60;
                if (OffensiveGuardBoost > 0)
                {
                    Player.AddBuff(ModContent.BuffType<OffensiveGuard>(), 7 * 60);
                }

            }
            #endregion
            #region Berserk
            if (Berserk)
            {
                modifiers.FinalDamage *= 0.25f;
            }
            #endregion
            #region Element
            if (FireRes >= 1 && MHLists.fireresList.Contains(npc.type))
            {
                float Res = 1 - FireRes;
                modifiers.FinalDamage *= Res;
            }
            if (WaterRes >= 1 && MHLists.waterresList.Contains(npc.type))
            {
                float Res = 1 - WaterRes;
                modifiers.FinalDamage *= Res;
            }
            if (IceRes >= 1 && MHLists.iceresList.Contains(npc.type))
            {
                float Res = 1 - IceRes;
                modifiers.FinalDamage *= Res;
            }
            if (ThunderRes >= 1 && MHLists.thunderresList.Contains(npc.type))
            {
                float Res = 1 - ThunderRes;
                modifiers.FinalDamage *= Res;
            }
            #endregion
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            #region Element
            if (FireRes >= 1 && MHLists.fireresprojList.Contains(proj.type))
            {
                float Res = 1 - FireRes;
                modifiers.FinalDamage *= Res;
            }
            if (WaterRes >= 1 && MHLists.waterresprojList.Contains(proj.type))
            {
                float Res = 1 - WaterRes;
                modifiers.FinalDamage *= Res;
            }
            if (IceRes >= 1 && MHLists.iceresprojList.Contains(proj.type))
            {
                float Res = 1 - IceRes;
                modifiers.FinalDamage *= Res;
            }
            if (ThunderRes >= 1 && MHLists.iceresprojList.Contains(proj.type))
            {
                float Res = 1 - ThunderRes;
                modifiers.FinalDamage *= Res;
            }
            #endregion
        }
        public override bool FreeDodge(Player.HurtInfo info)
        {
            // #region Evasion
            //if (EvasionChance >= 1 && Main.rand.NextBool(EvasionChance))
            //{
            //    Player.NinjaDodge();
            //    return true;
            // }
            // #endregion


            return base.FreeDodge(info);
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            base.ModifyHitNPCWithProj(proj, target, ref modifiers);
            #region Artillery
            if (ArtilleryBuff >= 1)
            {
                if (proj.type >= ProjectileID.RocketFireworkRed && proj.type <= ProjectileID.RocketFireworkYellow || proj.type >= ProjectileID.GrenadeI && proj.type <= ProjectileID.ProximityMineIV || proj.type >= ProjectileID.RocketSnowmanI && proj.type <= ProjectileID.RocketSnowmanIV || proj.type >= ProjectileID.Celeb2Rocket && proj.type <= ProjectileID.Celeb2RocketLarge
                    || proj.type >= ProjectileID.ClusterRocketI && proj.type <= ProjectileID.DryMine || proj.type >= ProjectileID.ClusterSnowmanRocketI && proj.type <= ProjectileID.DrySnowmanRocket || proj.type >= ProjectileID.ClusterSnowmanFragmentsI && proj.type <= ProjectileID.ClusterSnowmanFragmentsII)
                {
                    proj.damage *= ArtilleryBuff + 100 / 100;
                }
            }
            #endregion
            #region Bomb Boost
            if (BombBoostBuff >= 1)
            {
                if (proj.type >= ProjectileID.Bomb && proj.type <= ProjectileID.Grenade || proj.type == ProjectileID.StickyBomb || proj.type == ProjectileID.Beenade || proj.type == ProjectileID.StickyGrenade || proj.type == ProjectileID.StickyDynamite || proj.type == ProjectileID.BouncyBomb || proj.type == ProjectileID.BouncyDynamite ||
                    proj.type == ProjectileID.BouncyGrenade || proj.type == ProjectileID.ScarabBomb || proj.type >= ProjectileID.WetBomb && proj.type <= ProjectileID.DryBomb || proj.type == ProjectileID.DirtBomb || proj.type == ProjectileID.DirtStickyBomb)
                {
                    proj.damage *= BombBoostBuff + 100 / 100;
                }
            }
            #endregion
            #region Normal Up
            if (NormalBuff >= 1)
            {
                if (proj.type == ProjectileID.Bullet || proj.type == ProjectileID.WoodenArrowFriendly || proj.type == ProjectileID.SilverBullet)
                {
                    proj.damage *= NormalBuff + 100 / 100;
                }
            }
            #endregion
            #region Pellet Up
            if (PelletBuff >= 1)
            {
                if (proj.type == ProjectileID.CrystalBullet || proj.type == ProjectileID.HolyArrow)
                {
                    proj.damage *= PelletBuff + 100 / 100;
                }
            }
            #endregion
            #region Pierce Up
            if (PieceBuff >= 1)
            {
                if (proj.type == ProjectileID.MeteorShot || proj.type == ProjectileID.BulletHighVelocity || proj.type == ProjectileID.MoonlordBullet || proj.type == ProjectileID.JestersArrow || proj.type == ProjectileID.UnholyArrow || proj.type == ProjectileID.BoneArrow)
                {
                    proj.damage *= PieceBuff + 100 / 100;
                }
            }
            #endregion
            #region Dead Eye
            if (DeadEye > 0)
            {
                float DistanceInterpolant = Utils.GetLerpValue(300f, 800f, target.Distance(Main.player[Main.myPlayer].Center), true);
                float rangedBoost = MathHelper.Lerp(0f, DeadEye, DistanceInterpolant);
                modifiers.SourceDamage += rangedBoost;
            }
            #endregion
            #region Ranged Arrow
            if (proj.type == ProjectileID.WoodenArrowFriendly)
            {
                #region Close Range
                if (CRangePlus)
                {
                    float DistanceInterpolant = Utils.GetLerpValue(1f, 320f, target.Distance(Main.player[Main.myPlayer].Center), true);
                    float rangedBoost = MathHelper.Lerp(0f, 0.1f, DistanceInterpolant);
                    modifiers.SourceDamage += rangedBoost;
                }

                #endregion
            }
            #endregion
        }

        public override void OnHitByNPC(NPC npc, Terraria.Player.HurtInfo hurtInfo)
        {
            base.OnHitByNPC(npc, hurtInfo);

            #region Intrepid Heart
            if (IHeartCountdown >= 1)
            {
                IHeartCountdown = 0;
            }
            #endregion
            #region Latent Power
            if (LatentPowerHostile)
            {
                LatentPowerCounter += 5 * 60;
            }
            #endregion
            #region Counter Strike
            if (CounterStrike >= 1)
            {
                Player.AddBuff(ModContent.BuffType<CounterStrike>(), 10 * 60);
            }
            #endregion
            #region Berserk
            if (Berserk)
            {
                BerserkDot += 35;
            }
            #endregion
            #region Honey Hunter
            if (HoneyHunter >= 6)
            {
                Player.AddBuff(BuffID.Honey, 7 * 60);
            }
            #endregion
        }
        public override void OnRespawn()
        {
            base.OnRespawn();
            #region Fortified
            if (Fortified)
            {
                Player.AddBuff(ModContent.BuffType<Fortified>(), 10 * 60);
            }
            #endregion
            BloodlustCount = 0;
            LatentPowerCounter = 0;
            Player.timeSinceLastDashStarted = 3;
            cooldownTimer = 30;
            Player.dashDelay = 2;
        }
        public override bool CanUseItem(Item item)
        {

            return base.CanUseItem(item);
        }
        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            #region Spare Shot
            if (SpareShot >= 1)
            {
                if (Main.rand.NextBool(SpareShot))
                {
                    return false;
                }
            }
            #endregion
            return base.CanConsumeAmmo(weapon, ammo);
        }
        public override void UpdateEquips()
        {

        }
        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            #region Fire Attack
            if (FireAttack >= 1 && MHLists.fireelementList.Contains(item.type))
            {
                damage.Base += FireAttack;
            }
            if (FireAttack >= 5 && MHLists.fireelementList.Contains(item.type))
            {
                damage += 0.1f;
            }
            #endregion
            #region Ice Attack
            if (IceAttack >= 1 && MHLists.iceelementList.Contains(item.type))
            {
                damage.Base += IceAttack;
            }
            if (IceAttack >= 5 && MHLists.iceelementList.Contains(item.type))
            {
                damage += 0.1f;
            }
            #endregion
            #region Thunder Attack
            if (ThunderAttack >= 1 && MHLists.thunderelementList.Contains(item.type))
            {
                damage.Base += ThunderAttack;
            }
            if (ThunderAttack >= 5 && MHLists.thunderelementList.Contains(item.type))
            {
                damage += 0.1f;
            }
            #endregion
            #region Water Attack
            if (WaterAttack >= 1 && MHLists.waterelementList.Contains(item.type))
            {
                damage.Base += WaterAttack;
            }
            if (WaterAttack >= 5 && MHLists.waterelementList.Contains(item.type))
            {
                damage += 0.1f;
            }
            #endregion
            #region Elemental
            if (Elemental >= 1 && (MHLists.fireelementList.Contains(item.type) || MHLists.thunderelementList.Contains(item.type) || MHLists.iceelementList.Contains(item.type) || MHLists.waterelementList.Contains(item.type)))
            {
                damage.Base += 4 * Elemental;
            }
            #endregion
            #region Sharpness Element buff
            if (Sharpness && item.CountsAsClass<MeleeDamageClass>())
            {
                float SharpnessBoost = item.rare + Handicraft;
                if (SharpnessBoost > 11)
                {
                    SharpnessBoost = 11;
                }
                damage += SharpnessBoost / 100;
                if (MHLists.fireelementList.Contains(item.type) || MHLists.iceelementList.Contains(item.type) || MHLists.thunderelementList.Contains(item.type) || MHLists.waterelementList.Contains(item.type))
                {
                    damage.Base += SharpnessBoost;
                }
            }
            #endregion

            #region Rapid Fire
            if (RapidFire && item.CountsAsClass<RangedDamageClass>())
            {
                damage -= RapidFireDamage;
            }
            #endregion
        }

        public override void ModifyWeaponKnockback(Item item, ref StatModifier knockback)
        {
            #region Fire Attack
            if (FireAttack >= 1 && MHLists.fireelementList.Contains(item.type))
            {
                knockback.Flat += item.knockBack * (FireAttack / 10) + 1;
            }
            #endregion
            #region Ice Attack
            if (IceAttack >= 1 && MHLists.iceelementList.Contains(item.type))
            {
                knockback.Flat += item.knockBack * (IceAttack / 10) + 1;
            }
            #endregion
            #region Thunder Attack
            if (ThunderAttack >= 1 && MHLists.thunderelementList.Contains(item.type))
            {
                knockback.Flat += item.knockBack * (ThunderAttack / 10) + 1;
            }
            #endregion
            #region Water Attack
            if (WaterAttack >= 1 && MHLists.waterelementList.Contains(item.type))
            {
                knockback.Flat += item.knockBack * (WaterAttack / 10) + 1;
            }
            #endregion
            #region Sharpness
            if (Sharpness && item.CountsAsClass<MeleeDamageClass>() && item.rare >= ItemRarityID.LightPurple)
            {
                int Handicraftboost = item.rare + Handicraft;
                if (Handicraftboost > 11)
                {
                    Handicraftboost = 11;
                }
                int Sharpness = (Handicraftboost) / 2;
                knockback.Flat += item.knockBack * (Sharpness / 10) + 1;
            }
            #endregion
        }

        public override void ModifyWeaponCrit(Item item, ref float crit)
        {
            #region Fire Attack
            if (FireAttack >= 3 && MHLists.fireelementList.Contains(item.type))
            {
                crit += FireAttack + 2;
            }
            #endregion
            #region Ice Attack
            if (IceAttack >= 3 && MHLists.iceelementList.Contains(item.type))
            {
                crit += IceAttack + 2;
            }
            #endregion
            #region Thunder Attack
            if (ThunderAttack >= 3 && MHLists.thunderelementList.Contains(item.type))
            {
                crit += ThunderAttack + 2;
            }
            #endregion
            #region Water Attack
            if (WaterAttack >= 3 && MHLists.waterelementList.Contains(item.type))
            {
                crit += WaterAttack + 2;
            }
            #endregion
        }
        public override bool? CanAutoReuseItem(Item item)
        {
            #region Fire Attack
            if (FireAttack >= 3 && MHLists.fireelementList.Contains(item.type))
            {
                return true;
            }
            #endregion
            #region Ice Attack
            if (IceAttack >= 3 && MHLists.iceelementList.Contains(item.type))
            {
                return true;
            }
            #endregion
            #region Thunder Attack
            if (ThunderAttack >= 3 && MHLists.thunderelementList.Contains(item.type))
            {
                return true;
            }
            #endregion
            #region Water Attack
            if (WaterAttack >= 3 && MHLists.waterelementList.Contains(item.type))
            {
                return true;
            }
            #endregion
            #region Rapid Fire
            if (RapidFire && item.CountsAsClass<RangedDamageClass>())
            {
                if (item.useTime >= RapidFireReuse)
                {
                    return true;
                }
                return false;
            }
            #endregion
            #region Speed Setup
            if (SpeedSetup >= 1)
            {
                if (item.consumable && item.useStyle == ItemUseStyleID.Swing)
                {
                    return true;
                }
            }
            #endregion
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            if (modPlayer.Autoreload && item.CountsAsClass<RangedDamageClass>() && !RapidFire && item.consumable == false)
            {
                return true;
            }

            return base.CanAutoReuseItem(item);
        }
        public override bool Shoot(Item item, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            #region Rapid Fire
            if (RapidFire && item.CountsAsClass<RangedDamageClass>())
            {
                float speedX = velocity.X;
                float speedY = velocity.Y;
                int numberOfProjectiles = 2;
                Random rand = new Random();

                // Rotation angle for spreading the projectiles
                float rotation = MathHelper.ToRadians(rand.Next(1, 5));

                // Adjust the position for spreading the projectiles
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * rand.Next(1, 5);

                // Loop through the number of projectiles
                for (int i = 0; i < numberOfProjectiles; i++)
                {
                    // Calculate the perturbed speed for spreading the projectiles
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberOfProjectiles - 1)));

                    // Create a new projectile
                    Projectile.NewProjectile(source, position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage / 3, knockback / 2, Player.whoAmI);
                }
            }
            #endregion
            return base.Shoot(item, source, position, velocity, type, damage, knockback);
        }
        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            base.ModifyShootStats(item, ref position, ref velocity, ref type, ref damage, ref knockback);
        }
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            #region Guts
            if (Guts >= 1 && GutsTimer == 0 && GutsActive)
            {
                if (Player.statLife < 1)
                {
                    Player.statLife = (int)(Player.statLifeMax2 * 0.3f);
                    GutsTimer = 3 * 60 * 60;

                    Dust.NewDust(Player.position, Player.width, Player.height, DustID.Blood, 0f, 0f, 0, default, 1f);

                    SoundEngine.PlaySound(SoundID.Item10, Player.Center);
                }
            }
            #endregion
            return base.PreKill(damage, hitDirection, pvp, ref playSound, ref genDust, ref damageSource);
        }
        public override void UpdateLifeRegen()
        {
            base.UpdateLifeRegen();
            #region Recovery Speed
            Player.lifeRegenCount += RecoverySpeed;
            Player.lifeRegenTime += RecoverySpeed;
            #endregion
            #region Hasten Recovery
            if (Player.HasBuff(ModContent.BuffType<HastenRecovery>()))
            {
                Player.lifeRegen += HastenRec * 5;
                Player.lifeRegenTime += HastenRec * 2;
            }
            #endregion
        }
        public override void UpdateBadLifeRegen()
        {
            base.UpdateBadLifeRegen();
            #region Frenzy Fail
            if (Player.HasBuff(ModContent.BuffType<FrenzyFail>()))
            {
                Player.lifeRegen -= 3;
                Player.lifeRegenTime += 10;
                Player.lifeRegenCount -= 20;
            }
            #endregion
            #region BlightProof
            if (BlightSpeedup || Defiance >= 3)
            {
                for (int l = 0; l < Player.MaxBuffs; ++l)
                {
                    int buffID = Player.buffType[l];
                    if (Player.buffTime[l] <= 2)
                        continue;
                    bool shouldHalveDuration = MHLists.debuffList.Contains(buffID);
                    if (shouldHalveDuration)
                        --Player.buffTime[l];
                }
            }
            #endregion
            #region Berserk
            if (Berserk)
            {
                if (Player.lifeRegen >= -1)
                    Player.lifeRegen = BerserkRegen - BerserkDot;

                Player.lifeRegenTime = 0;

                if (Player.lifeRegenCount > 0)
                    Player.lifeRegenCount = -100;
            }
            #endregion
        }
        public override float UseSpeedMultiplier(Item item)

        {
            #region Speed Eating
            if (SpeedEating > 0 && item.consumable)
            {
                return 1 + SpeedEating;
            }
            #endregion
            #region Quick Gather
            if (QuickGather > 0 && (item.axe > 0 || item.pick > 0 || item.hammer > 0))
            {
                return 1 + QuickGather;
            }
            #endregion
            #region Speed Setup
            if (SpeedSetup >= 2)
            {
                if (item.consumable && item.useStyle == ItemUseStyleID.Swing)
                {
                    return 1.5f;
                }
            }
            #endregion
            #region Speed Sharpening
            if (SpeedSharpening > 1f && item.type == ModContent.ItemType<WhetStone>())
            {
                return SpeedSharpening;
            }
            #endregion


            return base.UseSpeedMultiplier(item);
        }

        #region Honey Hunter
        public override void PostUpdate()
        {
            // Check if the player is near honey
            if (IsPlayerNearHoney())
            {
                HoneyActive();
            }
        }
        private bool IsPlayerNearHoney()
        {
            // Define the radius for detecting honey (adjust as needed)
            int radius = 13;

            // Get the player's position
            int playerX = (int)(Player.position.X / 16);
            int playerY = (int)(Player.position.Y / 16);

            // Check if honey is present within the specified radius
            for (int x = playerX - radius; x <= playerX + radius; x++)
            {
                for (int y = playerY - radius; y <= playerY + radius; y++)
                {
                    Tile tile = Main.tile[x, y];
                    if (tile != null && tile.LiquidType == 3)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void HoneyActive()
        {
            Player.moveSpeed += HoneyHunter / 100f;
            Player.AddBuff(ModContent.BuffType<HoneyHunter>(), 2);
        }
        #endregion
        public override void ModifyDrawInfo(ref PlayerDrawSet drawInfo)
        {
            #region Shield Animation
            if (GuardRaised)
            {
                Player.bodyFrame.Y = Player.bodyFrame.Height * 10;
            }
            #endregion
        }
        public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            #region Bubble Blight
            if (BubbleBlight && Main.netMode != NetmodeID.Server && drawInfo.shadow == 0f)
            {
                if (Main.rand.NextBool(4))
                {
                    Vector2 velocity = Main.rand.NextVector2Unit();
                    velocity.X *= 0.66f;
                    velocity *= Main.rand.NextFloat(1f, 2f);

                    int bubble = Gore.NewGore(Player.GetSource_FromThis(), drawInfo.Position + new Vector2(Main.rand.Next(Player.width + 1), Main.rand.Next(Player.height + 1)), velocity, 411, Main.rand.NextFloat(0.4f, 1.2f));
                    Main.gore[bubble].sticky = false;
                    Main.gore[bubble].velocity *= 0.4f;
                    Main.gore[bubble].velocity.Y -= 0.6f;
                    drawInfo.GoreCache.Add(bubble);
                }
            }
            #endregion

        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            #region Crit Boost
            if (CritBoost >= 1)
            {
                modifiers.CritDamage += (CritBoost / 100);
            }
            #endregion
            #region Tenderizer
            if (Tenderizer > 0)
            {
                int Tenderized = 0;
                if (target.ichor)
                {
                    Tenderized += 15;
                }
                if (target.betsysCurse)
                {
                    Tenderized += 40;
                }
                if (target.defense >= (10 + Tenderized))
                {
                    modifiers.FinalDamage *= (float)Tenderizer + 1;
                }
            }
            #endregion
            #region Foray
            if (target.buffType.Any(MHLists.debuffList.Contains))
            {
                modifiers.FinalDamage *= (float)(1 + (Foray / 100));
            }
            #endregion
            #region Sneak Attack
            if (SneakAttack >= 1)
            {
                Vector2 relativePosition = target.Center - Player.Center;

                // Check if the player is behind the target
                if (relativePosition.Y > 0)
                {
                    // The player is attacking from the back
                    modifiers.FinalDamage *= SneakAttack; // Increase the damage by 50%
                }
            }
            #endregion
            #region Crit Element
            if (CritELeTrue)
            {
                modifiers.CritDamage += CritEle;
                CritELeTrue = false;
            }
            #endregion
        }
    }
}