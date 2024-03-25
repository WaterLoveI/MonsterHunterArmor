using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public partial class ArmorSkills : ModPlayer
    {
        #region SKills
        public int AffinitySliding;
        public int AMobility;
        public bool AntiBleeding;
        public int AntiPoison;
        public int Artillery;
        public int Attack;
        public bool Autoreload;
        public int AutoTracker;
        public int Berserk;
        public int BladeScaleHone;
        public int BlightProof;
        public int Bloodlust;
        public int BloodRite;
        public int BombBoost;
        public int BubbleDance;
        public bool CRangePlus;
        public int Carving;
        public int CliffHanger;
        public int Coalescence;
        public int ColdRes;
        public int Constitution;
        public int CounterStrike;
        public int CritEye;
        public int CriticalBoost;
        public int CritDraw;
        public int DeadEye;
        public int DefenseBoost;
        public int Defiance;
        public int Diversion;
        public int DefLock;
        public int DragonSpirit;
        public int EdgeLore;
        public int ElementalAtk;
        public int ElementalRes;
        public int Embolden;
        public int EvadeDistance;
        public int Evasion;
        public int Fate;
        public int Fencing;
        public int FireAttack;
        public int FireRes;
        public int FishingExpert;
        public int FleetFeet;
        public int Focus;
        public int Foray;
        public bool Fortified;
        public int FreeElement;
        public int FreeMeal;
        public int FrostCraft;
        public int Fury;
        public int Gathering;
        public int Geologist;
        public int Gluttony;
        public int Guard;
        public int GuardUp;
        public int Guts;
        public int HastenRecovery;
        public int Handicraft;
        public int Health;
        public int HeatRes;
        public int HeroShield;
        public bool HeavenSent;
        public int Heroics;
        public int HonedBlade;
        public int HoneyHunter;
        public int IceAttack;
        public int IceRes;
        public bool IntrepidHeart;
        public int JumpMaster;
        public int LastingPower;
        public int LatentPower;
        public int MailofHellfire;
        public int MastersTouch;
        public int Mushroomancer;
        public int NormalUp;
        public int OffensiveGuard;
        public int PelletUp;
        public int PierceUp;
        public int PolarHunter;
        public int PowderMantle;
        public int Protection;
        public int ProtectivePolish;
        public int QuickBreath;
        public int QuickSharpening;
        public int QuickSheath;
        public int RapidFire;
        public int RazorSharp;
        public int RecoveryUp;
        public int RecSpeed;
        public int Resentment;
        public int Resusitate;
        public bool RockSteady;
        public int Scholar;
        public int SilverBullet;
        public int Sneak;
        public int SneakAttack;
        public int SpareShot;
        public int SpeedEating;
        public int SpeedSetup;
        public int Spirit;
        public bool SpiritBirdsCall;
        public int StamRec;
        public int Strife;
        public int TeamLeader;
        public int Tenderizer;
        public int ThunderAttack;
        public int ThunderRes;
        public int TropicHunter;
        public int Unscathed;
        public int Vault;
        public int WaterAttack;
        public int WaterRes;
        public int WindMantle;
        public int Elemental;
        public int Slugger;
        public bool PoisonCPlus;
        public int QuickGather;
        public int CritElement;
        public int PunishDraw;
        public int ChallengeSheathe;
        public int Grinder;
        #endregion
        public override void ResetEffects()
        {
            #region Skills
            AffinitySliding = 0;
            AMobility = 0;
            AntiBleeding = false;
            AntiPoison = 0;
            Artillery = 0;
            Attack = 0;
            Autoreload = false;
            AutoTracker = 0;
            Berserk = 0;
            BladeScaleHone = 0;
            BlightProof = 0;
            Bloodlust = 0;
            BloodRite = 0;
            BombBoost = 0;
            BubbleDance = 0;
            Carving = 0;
            ChallengeSheathe = 0;
            CliffHanger = 0;
            Coalescence = 0;
            ColdRes = 0;
            Constitution = 0;
            CounterStrike = 0;
            CRangePlus = false;
            CritDraw = 0;
            CritElement = 0;
            CritEye = 0;
            CriticalBoost = 0;
            DeadEye = 0;
            DefenseBoost = 0;
            Defiance = 0;
            DefLock = 0;
            Diversion = 0;
            DragonSpirit = 0;
            EdgeLore = 0;
            Elemental = 0;
            ElementalRes = 0;
            Embolden = 0;
            EvadeDistance = 0;
            Evasion = 0;
            Fate = 0;
            Fencing = 0;
            FireAttack = 0;
            FireRes = 0;
            FishingExpert = 0;
            FleetFeet = 0;
            Foray = 0;
            Fortified = false;
            FreeElement = 0;
            FreeMeal = 0;
            FrostCraft = 0;
            Fury = 0;
            Gathering = 0;
            Geologist = 0;
            Gluttony = 0;
            Grinder = 0;
            Guard = 0;
            GuardUp = 0;
            Guts = 0;
            Handicraft = 0;
            HastenRecovery = 0;
            Health = 0;
            HeavenSent = false;
            Heroics = 0;
            HonedBlade = 0;
            HoneyHunter = 0;
            IceAttack = 0;
            IceRes = 0;
            IntrepidHeart = false;
            JumpMaster = 0;
            LastingPower = 0;
            LatentPower = 0;
            MailofHellfire = 0;
            Mushroomancer = 0;
            NormalUp = 0;
            OffensiveGuard = 0;
            PelletUp = 0;
            PierceUp = 0;
            PoisonCPlus = false;
            PolarHunter = 0;
            PowderMantle = 0;
            Protection = 0;
            ProtectivePolish = 0;
            PunishDraw = 0;
            QuickBreath = 0;
            QuickGather = 0;
            QuickSharpening = 0;
            QuickSheath = 0;
            RapidFire = 0;
            RazorSharp = 0;
            RecoveryUp = 0;
            RecSpeed = 0;
            Resentment = 0;
            Resusitate = 0;
            RockSteady = false;
            Scholar = 0;
            SilverBullet = 0;
            Slugger = 0;
            Sneak = 0;
            SneakAttack = 0;
            SpareShot = 0;
            SpeedEating = 0;
            SpeedSetup = 0;
            Spirit = 0;
            SpiritBirdsCall = false;
            StamRec = 0;
            Strife = 0;
            TeamLeader = 0;
            Tenderizer = 0;
            ThunderAttack = 0;
            ThunderRes = 0;
            TropicHunter = 0;
            Unscathed = 0;
            Vault = 0;
            WaterAttack = 0;
            WaterRes = 0;
            WindMantle = 0;
            #endregion
        }

        public override void UpdateEquips()
        {
            MHPlayerArmorSkill modPlayer = Player.GetModPlayer<MHPlayerArmorSkill>();
            #region Affinity Sliding
            if (AffinitySliding >= 1)
            {

                if (AffinitySliding >= 1)
                {
                    modPlayer.aSlidingCrit += 5;
                }
                if (AffinitySliding >= 2)
                {
                    modPlayer.aSlidingCrit += 5;
                }
                if (AffinitySliding >= 3)
                {
                    modPlayer.aSlidingCrit += 10;
                }
            }
            #endregion
            #region Aquatic Mobility
            if (AMobility >= 1)
            {
                if (AMobility >= 1)
                {
                    modPlayer.AquaMobility = true;
                }
                if (AMobility >= 2 && Player.wet)
                {
                    Player.moveSpeed += 10 / 100f;
                }
                if (AMobility >= 3)
                {
                    if (Player.wet && Evasion < 2)
                    {
                        Evasion = 2;
                    }
                }
            }
            #endregion
            #region AntiBleed
            if (AntiBleeding == true)
            {
                Player.buffImmune[BuffID.Bleeding] = true;
            }
            #endregion
            #region Anti Poison
            if (AntiPoison >= 1)
            {
                if (AntiPoison >= 1)
                {
                    Player.buffImmune[BuffID.Poisoned] = true;
                }
                if (AntiPoison >= 2)
                {
                    Player.buffImmune[BuffID.Venom] = true;
                }
            }
            #endregion
            #region Artillery
            if (Artillery >= 1)
            {
                Player.AddBuff(ModContent.BuffType<Artillery>(), 2);

                if (Artillery >= 1)
                {
                    modPlayer.ArtilleryBuff += 5;
                }
                if (Artillery >= 2)
                {
                    modPlayer.ArtilleryBuff += 5;
                }
                if (Artillery >= 3)
                {
                    modPlayer.ArtilleryBuff += 5;
                }
            }
            #endregion
            #region Attack
            if (Attack >= 1)
            {
                Player.AddBuff(ModContent.BuffType<Attack>(), 2);
                if (Attack >= 1)
                {
                    Player.GetDamage(DamageClass.Generic).Base += 1;
                }
                if (Attack >= 2)
                {
                    Player.GetDamage(DamageClass.Generic).Base += 1;
                }
                if (Attack >= 3)
                {
                    Player.GetDamage(DamageClass.Generic).Base += 2;
                }
                if (Attack >= 4)
                {
                    Player.GetDamage(DamageClass.Generic).Base += 2;
                }
                if (Attack >= 5)
                {
                    Player.GetDamage(DamageClass.Generic) += 3 / 100f;
                }
                if (Attack >= 6)
                {
                    Player.GetDamage(DamageClass.Generic) += 4 / 100f;
                    Player.GetDamage(DamageClass.Generic).Base += 1;
                }
                if (Attack >= 7)
                {
                    Player.GetDamage(DamageClass.Generic) += 5 / 100f;
                    Player.GetDamage(DamageClass.Generic).Base += 2;
                }
            }
            #endregion
            #region AutoTracker
            if (AutoTracker >= 1)
            {
                if (AutoTracker >= 1)
                {
                    Player.detectCreature = true;
                    Player.dangerSense = true;
                }
                if (AutoTracker >= 2)
                {
                    Player.findTreasure = true;
                }
            }
            #endregion
            #region Berserk
            if (Berserk >= 1)
            {
                Player.AddBuff(ModContent.BuffType<Beserk>(), 2);
                if (Berserk >= 1)
                {
                    modPlayer.Berserk = true;
                    modPlayer.BerserkRegen = -3;

                }
                if (Berserk >= 2)
                {
                    modPlayer.BerserkRegen = 0;
                }
            }
            #endregion
            #region Bladescale Hone
            if (BladeScaleHone >= 1)
            {
                if (BladeScaleHone >= 1)
                {
                    modPlayer.BladeHoneScale += 1;

                }
                if (BladeScaleHone >= 2)
                {
                    modPlayer.BladeHoneScale += 1;
                }
                if (BladeScaleHone >= 3)
                {
                    modPlayer.BladeHoneScale += 1;
                }
            }
            #endregion
            #region Bloodlust
            if (Bloodlust >= 1)
            {
                if (Bloodlust >= 1)
                {
                    modPlayer.Bloodlust += 1;
                    if (Player.HasBuff(ModContent.BuffType<Frenzy>()) && Evasion <= Bloodlust)
                    {
                        Evasion = Bloodlust;
                    }
                }
                if (Bloodlust >= 2)
                {
                    modPlayer.Bloodlust += 1;
                }
                if (Bloodlust >= 3)
                {
                    modPlayer.Bloodlust += 1;
                }
            }
            #endregion
            #region Blood Rite
            if (BloodRite >= 1)
            {
                modPlayer.BloodRite += 1;

                if (BloodRite >= 2)
                {
                    modPlayer.BloodRite += 1;
                }
                if (BloodRite >= 3)
                {
                    modPlayer.BloodRite += 1;
                }
            }
            #endregion
            #region Blightproof
            if (BlightProof >= 1)
            {
                if (BlightProof >= 1)
                {
                    modPlayer.BlightSpeedup = true;

                }
                if (BlightProof >= 2)
                {
                    modPlayer.BlightImmune = true;
                }
            }
            #endregion
            #region Bomb Boost
            if (BombBoost >= 1)
            {
                Player.AddBuff(ModContent.BuffType<BombBoost>(), 2);
                if (BombBoost >= 1)
                {
                    modPlayer.BombBoostBuff += 10;
                }
                if (BombBoost >= 2)
                {
                    modPlayer.BombBoostBuff += 10;
                }
                if (BombBoost >= 3)
                {
                    modPlayer.BombBoostBuff += 10;
                }
            }
            #endregion
            #region Bubble Dance
            if (BubbleDance >= 1)
            {
                modPlayer.BubbleDance += 1;

                if (BubbleDance >= 2)
                {
                    modPlayer.BubbleDance += 1;
                    if (modPlayer.BubbleBlight && Evasion < BubbleDance)
                    {
                        Evasion = BubbleDance;
                    }
                }
                if (BubbleDance >= 3)
                {
                    modPlayer.BubbleDance += 1;
                }
            }
            #endregion
            #region Close Range Up
            if (CRangePlus)
            {
                modPlayer.CRangePlus = true;
            }
            #endregion
            #region Carving
            if (Carving >= 1)
            {
                if (Carving >= 1)
                {
                    modPlayer.CarvingChance += 3;
                }
                if (Carving >= 2)
                {
                    modPlayer.CarvingChance -= 1;
                }
                if (Carving >= 3)
                {
                    modPlayer.CarvingChance -= 1;
                }
            }
            #endregion
            #region CliffHanger
            if (CliffHanger >= 1)
            {
                if (CliffHanger >= 1)
                {
                    Player.spikedBoots += 1;
                }
                if (CliffHanger >= 2)
                {
                    Player.spikedBoots += 1;
                }
            }
            #endregion
            #region Challenge Sheath
            if (ChallengeSheathe >= 1)
            {
                if (ChallengeSheathe >= 1)
                {
                    modPlayer.ChallengeSheathe += 1;
                }
                if (ChallengeSheathe >= 2)
                {
                    modPlayer.ChallengeSheathe += 1;
                }
                if (ChallengeSheathe >= 3)
                {
                    modPlayer.ChallengeSheathe += 1;
                }
            }
            #endregion
            #region Coalescence
            if (Coalescence >= 1)
            {
                if (Coalescence >= 1)
                {
                    modPlayer.Coalescence += 5;
                }
                if (Coalescence >= 2)
                {
                    modPlayer.Coalescence += 5;
                }
                if (Coalescence >= 3)
                {
                    modPlayer.Coalescence += 5;
                }
            }
            #endregion
            #region Cold Res
            if (ColdRes >= 1)
            {
                if (ColdRes >= 1)
                {
                    Player.buffImmune[BuffID.Chilled] = true;
                }
                if (ColdRes >= 2)
                {
                    Player.buffImmune[BuffID.Frostburn] = true;
                    Player.buffImmune[BuffID.Frostburn2] = true;
                }
                if (ColdRes >= 3)
                {
                    Player.buffImmune[BuffID.Frozen] = true;
                }
            }
            #endregion
            #region Constitution
            if (Constitution >= 1)
            {
                if (Constitution >= 1)
                {
                    modPlayer.Constitution += 1;
                }
                if (Constitution >= 2)
                {
                    modPlayer.Constitution += 1;
                }
                if (Constitution >= 3)
                {
                    modPlayer.Constitution += 1;
                }
            }
            #endregion
            #region CounterStrike
            if (CounterStrike >= 1)
            {
                if (Coalescence >= 1)
                {
                    modPlayer.CounterStrike += 5;
                }
                if (Coalescence >= 2)
                {
                    modPlayer.CounterStrike += 5;
                }
                if (Coalescence >= 3)
                {
                    modPlayer.CounterStrike += 5;
                }
            }
            #endregion
            #region Crit Draw
            if (CritDraw >= 1)
            {
                if (CritDraw >= 1)
                {
                    modPlayer.CritDraw += 1;
                }
                if (CritDraw >= 2)
                {
                    modPlayer.CritDraw += 1;
                }
                if (CritDraw >= 3)
                {
                    modPlayer.CritDraw += 1;
                }
            }
            #endregion
            #region Crit Element
            if (CritElement >= 1)
            {
                if (CritElement >= 1)
                {
                    modPlayer.CritEle += 0.5f;
                }
                if (CritElement >= 2)
                {
                    modPlayer.CritEle += 0.5f;
                }
                if (CritElement >= 3)
                {
                    modPlayer.CritEle += 0.5f;
                }
            }
            #endregion
            #region Crit Eye
            if (CritEye >= 1)
            {
                Player.AddBuff(ModContent.BuffType<CritEye>(), 2);
                if (CritEye >= 1)
                {
                    Player.GetCritChance(DamageClass.Generic) += 2;
                }
                if (CritEye >= 2)
                {
                    Player.GetCritChance(DamageClass.Generic) += 2;
                }
                if (CritEye >= 3)
                {
                    Player.GetCritChance(DamageClass.Generic) += 3;
                }
                if (CritEye >= 4)
                {
                    Player.GetCritChance(DamageClass.Generic) += 3;
                }
                if (CritEye >= 5)
                {
                    Player.GetCritChance(DamageClass.Generic) += 3;
                }
                if (CritEye >= 6)
                {
                    Player.GetCritChance(DamageClass.Generic) += 3;
                    Player.GetCritChance(DamageClass.Generic) *= 1.05f;
                }
                if (CritEye >= 7)
                {
                    Player.GetCritChance(DamageClass.Generic) += 3;
                    Player.GetCritChance(DamageClass.Generic) *= 1.05f;
                }
            }
            #endregion
            #region Critial Boost
            if (CriticalBoost >= 1)
            {
                if (CriticalBoost >= 1)
                {
                    modPlayer.CritBoost += 5;
                }
                if (CriticalBoost >= 2)
                {
                    modPlayer.CritBoost += 5;
                }
                if (CriticalBoost >= 3)
                {
                    modPlayer.CritBoost += 5;
                }
            }
            #endregion
            #region Dead Eye
            if (DeadEye >= 1)
            {
                if (DeadEye >= 1)
                {
                    modPlayer.DeadEye += 0.5f;
                }
                if (DeadEye >= 2)
                {
                    modPlayer.DeadEye += 0.5f;
                }
                if (DeadEye >= 3)
                {
                    modPlayer.DeadEye += 0.5f;
                }
            }
            #endregion
            #region Defense Boost
            if (DefenseBoost >= 1)
            {
                Player.AddBuff(ModContent.BuffType<DefenseBoost>(), 2);
                if (DefenseBoost >= 1)
                {
                    Player.statDefense += 2;
                }
                if (DefenseBoost >= 2)
                {
                    Player.statDefense += 2;
                }
                if (DefenseBoost >= 3)
                {
                    Player.statDefense += 3;
                }
                if (DefenseBoost >= 4)
                {
                    Player.statDefense += 3;
                }
                if (DefenseBoost >= 5)
                {
                    Player.statDefense += 5;
                }
                if (DefenseBoost >= 6)
                {
                    Player.statDefense += 3;
                    Player.statDefense *= 1.1f;
                    Player.endurance += 2 / 100f;
                }
                if (DefenseBoost >= 7)
                {
                    Player.statDefense += 3;
                    Player.statDefense *= 1.1f;
                    Player.endurance += 2 / 100f;
                }
            }
            #endregion
            #region Defiance
            if (Defiance >= 1)
            {
                if (Defiance >= 1)
                {
                    modPlayer.Defiance += 1;
                }
                if (Defiance >= 2)
                {
                    modPlayer.Defiance += 1;
                }
                if (Defiance >= 3)
                {
                    modPlayer.Defiance += 1;
                }
                if (Defiance >= 4)
                {
                    modPlayer.Defiance += 1;
                }
                if (Defiance >= 5)
                {
                    modPlayer.Defiance += 1;
                }
            }
            #endregion
            #region Def lock
            if (DefLock >= 1)
            {
                if (DefLock >= 1)
                {
                    Player.buffImmune[BuffID.BrokenArmor] = true;
                }
                if (DefLock >= 2)
                {
                    Player.buffImmune[BuffID.Ichor] = true;
                }
                if (DefLock >= 3)
                {
                    Player.buffImmune[BuffID.WitheredArmor] = true;
                }
            }
            #endregion
            #region Diversion
            if (Diversion >= 1)
            {
                if (Diversion >= 1)
                {
                    Player.aggro += 100;
                }
                if (Diversion >= 2)
                {
                    Player.aggro += 100;
                }
                if (Diversion >= 3)
                {
                    Player.aggro += 100;
                }
            }
            #endregion
            #region Elemental
            if (ElementalAtk >= 1)
            {
                if (ElementalAtk >= 1)
                {
                    modPlayer.Elemental += 1;
                }
                if (ElementalAtk >= 2)
                {
                    modPlayer.Elemental += 1;
                }
                if (ElementalAtk >= 3)
                {
                    modPlayer.Elemental += 1;
                }
            }
            #endregion
            #region Elemental Res
            if (ElementalRes >= 1)
            {
                if (ElementalRes >= 1)
                {
                    modPlayer.ElementalRes += 0.5f;
                    Player.statDefense += 2;
                }
                if (ElementalRes >= 2)
                {
                    modPlayer.ElementalRes += 0.5f;
                    Player.statDefense += 3;
                }
                if (ElementalRes >= 3)
                {
                    modPlayer.ElementalRes += 0.5f;
                    Player.statDefense += 4;
                }
            }
            #endregion
            #region Embolden
            if (Embolden >= 1)
            {
                if (Embolden >= 1)
                {
                    modPlayer.Embolden += 1;
                    modPlayer.EmboldenAggro += 500;
                    modPlayer.EmboldenDef += 5;

                }
                if (Embolden >= 2)
                {
                    modPlayer.Embolden += 2;
                    modPlayer.EmboldenAggro += 500;
                    modPlayer.EmboldenDef += 5;
                }
                if (Embolden >= 3)
                {
                    modPlayer.Embolden += 2;
                    modPlayer.EmboldenAggro += 500;
                    modPlayer.EmboldenDef += 5;
                }
            }
            #endregion
            #region Evade Distance
            if (EvadeDistance >= 1)
            {
                if (EvadeDistance >= 1)
                {
                    modPlayer.EvadeDistance += 30;
                }
                if (EvadeDistance >= 2)
                {
                    modPlayer.EvadeDistance += 30;
                }
                if (EvadeDistance >= 3)
                {
                    modPlayer.EvadeDistance += 40;
                }
            }
            #endregion
            #region Evasion
            if (Evasion >= 1)
            {
                if (Evasion >= 1)
                {
                    modPlayer.Evasion += 10;
                }
                if (Evasion >= 2)
                {
                    modPlayer.Evasion += 6;
                }
                if (Evasion >= 3)
                {
                    modPlayer.Evasion += 6;
                }
                if (Evasion >= 4)
                {
                    modPlayer.Evasion += 6;
                }
                if (Evasion >= 5)
                {
                    modPlayer.Evasion += 6;
                }
            }
            #endregion
            #region Fate
            if (Fate >= 1)
            {
                Player.AddBuff(ModContent.BuffType<Fate>(), 2);
                if (Fencing >= 1)
                {
                    Player.luck += 0.1f;
                }
                if (Fencing >= 2)
                {
                    Player.luck += 0.2f;
                }
                if (Fencing >= 3)
                {
                    Player.luck += 0.3f;
                }
            }
            #endregion
            #region Fencing
            if (Fencing >= 1)
            {
                if (Fencing >= 1)
                {
                    Player.GetArmorPenetration(DamageClass.Generic) += 3;
                }
                if (Fencing >= 2)
                {
                    Player.GetArmorPenetration(DamageClass.Generic) += 4;
                }
                if (Fencing >= 3)
                {
                    Player.GetArmorPenetration(DamageClass.Generic) += 5;
                }
            }
            #endregion
            #region Fire Attack
            if (FireAttack >= 1)
            {
                modPlayer.FireAttack += 1;

                if (FireAttack >= 2)
                {
                    modPlayer.FireAttack += 1;
                }
                if (FireAttack >= 3)
                {
                    modPlayer.FireAttack += 1;
                }
                if (FireAttack >= 4)
                {
                    modPlayer.FireAttack += 1;
                }
                if (FireAttack >= 5)
                {
                    modPlayer.FireAttack += 1;
                }
            }
            #endregion
            #region Fire Res
            if (FireRes >= 1)
            {
                if (FireRes >= 1)
                {
                    modPlayer.FireRes += 0.5f;
                    Player.statDefense += 1;
                }
                if (FireRes >= 2)
                {
                    modPlayer.FireRes += 0.5f;
                    Player.statDefense += 2;
                }
                if (FireRes >= 3)
                {
                    modPlayer.FireRes += 0.5f;
                    Player.statDefense += 3;
                }
            }
            #endregion
            #region Fishing Expert
            if (FishingExpert >= 1)
            {

                if (FishingExpert >= 1)
                {
                    Player.accTackleBox = true;
                    Player.fishingSkill += 5;
                }
                if (FishingExpert >= 2)
                {
                    Player.fishingSkill += 10;
                    Player.accFishingLine = true;
                }
                if (FishingExpert >= 3)
                {
                    Player.fishingSkill += 15;
                    Player.accLavaFishing = true;
                    Player.sonarPotion = true;
                }
            }
            #endregion
            #region Focus
            if (Focus >= 1)
            {
                if (Focus >= 1)
                {
                    Player.GetAttackSpeed<MeleeDamageClass>() += 0.05f;
                }
                if (Focus >= 2)
                {
                    Player.magicQuiver = true;
                    Player.GetAttackSpeed<MeleeDamageClass>() += 0.05f;
                }
                if (Focus >= 3)
                {
                    Player.GetAttackSpeed<MeleeDamageClass>() += 0.05f;
                }
            }
            #endregion
            #region Foray
            if (Foray >= 1)
            {
                if (Fencing >= 1)
                {
                    modPlayer.Foray += 3;
                }
                if (Fencing >= 2)
                {
                    modPlayer.Foray += 3;
                }
                if (Fencing >= 3)
                {
                    modPlayer.Foray += 4;
                }
            }
            #endregion
            #region Fortified
            if (Fortified)
            {
                Player.AddBuff(ModContent.BuffType<Fortified>(), 2);
            }
            #endregion
            #region Free Element
            if (FreeElement >= 1)
            {
                if (FreeElement >= 1)
                {
                    modPlayer.FreeElement += 1;
                }
                if (FreeElement >= 2)
                {
                    modPlayer.FreeElement += 1;
                }
                if (FreeElement >= 3)
                {
                    modPlayer.FreeElement += 1;
                }
            }
            #endregion
            #region Free Meal
            if (FreeMeal >= 1)
            {
                if (FreeMeal >= 1)
                {
                    modPlayer.FreeMeal += 4;
                }
                if (FreeMeal >= 2)
                {
                    modPlayer.FreeMeal -= 1;
                }
                if (FreeMeal >= 3)
                {
                    modPlayer.FreeMeal -= 1;
                }
            }
            #endregion
            #region Gathering
            if (Gathering >= 1)
            {
            }
            #endregion
            // Geologist needs to work off the variable, not the buff
            #region Geologist 
            if (Geologist >= 1)
            {
                if (Geologist >= 1)
                {
                    modPlayer.Geologist += 1;
                }
                if (Geologist >= 2)
                {
                    modPlayer.Geologist += 1;
                }
                if (Geologist >= 3)
                {
                    modPlayer.Geologist += 1;
                }
            }
            #endregion
            // Gluttony code already in GlobalItemBuffSkills
            #region Gluttony
            if (Gluttony >= 1)
            {
            }
            #endregion
            #region Grinder
            if (Grinder >= 1)
            {
                if (Grinder >= 1)
                {
                    modPlayer.Grinder += 5;
                }
                if (Grinder >= 2)
                {
                    modPlayer.Grinder += 5;
                }
                if (Grinder >= 3)
                {
                    modPlayer.Grinder += 5;
                }
            }
            #endregion
            #region Guard
            if (Guard >= 1)
            {

                if (Guard >= 1)
                {
                    modPlayer.Guard = true;
                }
                if (Guard >= 2)
                {
                    modPlayer.GuardMovement += 15;
                }
                if (Guard >= 3)
                {
                    modPlayer.GuardReduction += 85;
                }
                if (Guard >= 4)
                {
                    modPlayer.GuardMovement += 15;
                }
                if (Guard >= 5)
                {
                    modPlayer.GuardReduction -= 15;
                }
            }
            #endregion
            #region Guard Up
            if (GuardUp >= 1)
            {

                if (GuardUp >= 1)
                {
                    modPlayer.Guardup += 1;
                }
                if (GuardUp >= 2)
                {
                    modPlayer.Guardup += 1;
                }
                if (GuardUp >= 3)
                {
                    modPlayer.Guardup += 1;
                }
            }
            #endregion
            #region Guts
            if (Guts >= 1)
            {
                if (Guts >= 1)
                {
                    modPlayer.Guts += 1;
                }
                if (Guts >= 2)
                {
                    modPlayer.Guts += 1;
                }
                if (Guts >= 3)
                {
                    modPlayer.Guts += 1;
                }
            }
            #endregion
            #region Handicraft
            if (Handicraft >= 1)
            {
                if (Handicraft >= 1)
                {
                    modPlayer.Handicraft += 1;
                }
                if (Handicraft >= 2)
                {
                    modPlayer.Handicraft += 1;
                }
            }
            #endregion
            #region Hasten Recovery
            if (HastenRecovery >= 1)
            {
                if (HastenRecovery >= 1)
                {
                    modPlayer.HastenRec += 1;
                }
                if (HastenRecovery >= 2)
                {
                    modPlayer.HastenRec += 1;
                }
                if (HastenRecovery >= 3)
                {
                    modPlayer.HastenRec += 1;
                }
            }
            #endregion
            #region Health
            if (Health >= 1)
            {
                Player.AddBuff(ModContent.BuffType<Health>(), 2);
                if (Health >= 1)
                {
                    Player.statLifeMax2 += 20;
                }
                if (Health >= 2)
                {
                    Player.statLifeMax2 += 20;
                }
                if (Health >= 3)
                {
                    Player.statLifeMax2 += 20;
                }
            }
            #endregion
            #region Heat Res
            if (HeatRes >= 1)
            {
                if (HeatRes >= 1)
                {
                    Player.fireWalk = true;
                }
                if (HeatRes >= 2)
                {
                    Player.buffImmune[BuffID.OnFire] = true;
                    Player.buffImmune[BuffID.OnFire3] = true;
                }
                if (HeatRes >= 3)
                {
                    Player.lavaMax += 420;
                }
            }
            #endregion
            #region Heroic
            if (Heroics >= 1)
            {

                if (Heroics >= 1)
                {
                    modPlayer.HeroicsDefence += 5;
                }
                if (Heroics >= 2)
                {
                    modPlayer.HeroicsAttack += 5;
                }
                if (Heroics >= 3)
                {
                    modPlayer.HeroicsDefence += 5;
                }
                if (Heroics >= 4)
                {
                    modPlayer.HeroicsAttack += 5;
                }
                if (Heroics >= 5)
                {
                    modPlayer.HeroicsAttack += 5;
                    modPlayer.HeroicsDefence += 5;
                }
            }
            #endregion
            #region Hero Shield
            if (HeroShield >= 1)
            {

                if (HeroShield >= 1)
                {
                    Player.npcTypeNoAggro[1] = true;
                    Player.npcTypeNoAggro[16] = true;
                    Player.npcTypeNoAggro[59] = true;
                    Player.npcTypeNoAggro[71] = true;
                    Player.npcTypeNoAggro[81] = true;
                    Player.npcTypeNoAggro[138] = true;
                    Player.npcTypeNoAggro[121] = true;
                    Player.npcTypeNoAggro[122] = true;
                    Player.npcTypeNoAggro[141] = true;
                    Player.npcTypeNoAggro[147] = true;
                    Player.npcTypeNoAggro[183] = true;
                    Player.npcTypeNoAggro[184] = true;
                    Player.npcTypeNoAggro[204] = true;
                    Player.npcTypeNoAggro[225] = true;
                    Player.npcTypeNoAggro[244] = true;
                    Player.npcTypeNoAggro[302] = true;
                    Player.npcTypeNoAggro[333] = true;
                    Player.npcTypeNoAggro[335] = true;
                    Player.npcTypeNoAggro[334] = true;
                    Player.npcTypeNoAggro[336] = true;
                    Player.npcTypeNoAggro[537] = true;
                    Player.npcTypeNoAggro[676] = true;
                    Player.npcTypeNoAggro[667] = true;
                }
                if (HeroShield >= 2)
                {
                    Player.npcTypeNoAggro[49] = true;
                    Player.npcTypeNoAggro[634] = true;
                    Player.npcTypeNoAggro[51] = true;
                    Player.npcTypeNoAggro[60] = true;
                    Player.npcTypeNoAggro[150] = true;
                }
                if (HeroShield >= 3)
                {
                    Player.npcTypeNoAggro[210] = true;
                    Player.npcTypeNoAggro[211] = true;
                }

            }
            #endregion
            #region Ice Attack
            if (IceAttack >= 1)
            {
                modPlayer.IceAttack += 1;

                if (IceAttack >= 2)
                {
                    modPlayer.IceAttack += 1;
                }
                if (IceAttack >= 3)
                {
                    modPlayer.IceAttack += 1;
                }
                if (IceAttack >= 4)
                {
                    modPlayer.IceAttack += 1;
                }
                if (IceAttack >= 5)
                {
                    modPlayer.IceAttack += 1;
                }
            }
            #endregion
            #region Ice Res
            if (IceRes >= 1)
            {
                if (IceRes >= 1)
                {
                    modPlayer.IceRes += 0.5f;
                    Player.statDefense += 1;
                }
                if (IceRes >= 2)
                {
                    modPlayer.IceRes += 0.5f;
                    Player.statDefense += 2;
                }
                if (IceRes >= 3)
                {
                    modPlayer.IceRes += 0.5f;
                    Player.statDefense += 3;
                }
            }
            #endregion
            #region Intrepid Heart
            if (IntrepidHeart == true)
            {
                modPlayer.IntrepidHeart = true;
            }
            #endregion
            #region Jump Master
            if (JumpMaster >= 1)
            {
                if (JumpMaster >= 1)
                {
                    Player.jumpSpeedBoost += 0.5f;
                }
                if (JumpMaster >= 2)
                {

                    Player.jumpSpeedBoost += 0.5f;
                    Player.autoJump = true;
                }
                if (JumpMaster >= 3)
                {
                    Player.jumpSpeedBoost += 0.5f;
                    Player.jumpBoost = true;
                }
            }
            #endregion
            #region Lasting Power
            if (LastingPower >= 1)
            {
                if (LastingPower >= 1)
                {
                    modPlayer.LastingPower = 4;
                }
                if (LastingPower >= 2)
                {
                    modPlayer.LastingPower -= 1;
                }
                if (LastingPower >= 3)
                {
                    modPlayer.LastingPower -= 1;
                }
            }
            #endregion
            #region Honey Hunter
            if (HoneyHunter >= 1)
            {

                if (HoneyHunter >= 1)
                {
                    modPlayer.HoneyHunter += 5;
                }
                if (HoneyHunter >= 2)
                {
                    modPlayer.HoneyHunter += 5;
                }
            }
            #endregion
            #region Latent Power
            if (LatentPower >= 1)
            {
                if (LatentPower >= 1)
                {
                    modPlayer.LatentPower = true; 
                   modPlayer.LatentPowerAffinity += 3;
                    modPlayer.LatentPowerManaCost += 95;
                }
                if (LatentPower >= 2)
                {
                    modPlayer.LatentPowerAffinity += 3;
                }
                if (LatentPower >= 3)
                {
                    modPlayer.LatentPowerAffinity += 3;
                    modPlayer.LatentPowerManaCost -= 5;
                }
                if (LatentPower >= 4)
                {
                    modPlayer.LatentPowerAffinity += 3;
                }
                if (LatentPower >= 5)
                {
                    modPlayer.LatentPowerAffinity += 3;
                    modPlayer.LatentPowerManaCost -= 5;
                }
            }
            #endregion
            #region Mail of Hellfire
            if (MailofHellfire >= 1)
            {
                if (MailofHellfire >= 1)
                {
                    modPlayer.MailofHellfire += 2;
                }
                if (MailofHellfire >= 2)
                {
                    modPlayer.MailofHellfire += 1;
                }
                if (MailofHellfire >= 3)
                {
                    modPlayer.MailofHellfire += 1;
                }
            }
            #endregion
            #region Masters Touch
            if (MastersTouch >= 1)
            {
                modPlayer.MastersTouch += 4;
                if (MastersTouch >= 2)
                {
                    modPlayer.MastersTouch -= 2;
                }
                if (MastersTouch >= 3)
                {
                    modPlayer.MastersTouch -= 1;
                }
            }
            #endregion
            #region Mushroomaner
            if (Mushroomancer >= 1)
            {

                if (Mushroomancer >= 1)
                {
                    modPlayer.Mushroomancer += 1;
                }
                if (Mushroomancer >= 2)
                {
                    modPlayer.Mushroomancer += 1;
                }
            }
            #endregion
            #region Normal Up
            if (NormalUp >= 1)
            {
                if (NormalUp >= 1)
                {
                    modPlayer.NormalBuff += 10;
                }
                if (NormalUp >= 2)
                {
                    modPlayer.NormalBuff += 10;
                }
                if (NormalUp >= 3)
                {
                    modPlayer.NormalBuff += 10;
                }
            }
            #endregion
            #region Offensive Guard
            if (OffensiveGuard >= 1)
            {
                if (OffensiveGuard >= 1)
                {
                    modPlayer.OffensiveGuardBoost += 5;
                }
                if (OffensiveGuard >= 2)
                {
                    modPlayer.OffensiveGuardBoost += 5;
                }
                if (OffensiveGuard >= 3)
                {
                    modPlayer.OffensiveGuardBoost += 5;
                }
            }
            #endregion
            #region Pellet Up
            if (PelletUp >= 1)
            {
                if (PelletUp >= 1)
                {
                    modPlayer.PelletBuff += 5;
                }
                if (PelletUp >= 2)
                {
                    modPlayer.PelletBuff += 5;
                }
                if (PelletUp >= 3)
                {
                    modPlayer.PelletBuff += 5;
                }
            }
            #endregion
            #region Pierce Up
            if (PierceUp >= 1)
            {
                if (PierceUp >= 1)
                {
                    modPlayer.PieceBuff += 5;
                }
                if (PierceUp >= 2)
                {
                    modPlayer.PieceBuff += 5;
                }
                if (PierceUp >= 3)
                {
                    modPlayer.PieceBuff += 5;
                }
            }
            #endregion
            #region Poison Coating Up
            if (PoisonCPlus)
            {
                modPlayer.PCoatingUp = true;
            }
            #endregion
            #region Polar Hunter
            if (PolarHunter >= 1)
            {
                if (PolarHunter >= 1)
                {
                    modPlayer.PolarHunterDef += 5;
                }
                if (PolarHunter >= 2)
                {
                    modPlayer.PolarHunterMovement += 5;
                }
                if (PolarHunter >= 3)
                {
                    modPlayer.PolarHunterAtk += 5;
                }
            }
            #endregion
            #region Protection
            if (Protection >= 1)
            {
                if (Protection >= 1)
                {
                    modPlayer.Protection += 5;
                }
                if (Protection >= 2)
                {
                    modPlayer.Protection -= 1;
                }
                if (Protection >= 3)
                {
                    modPlayer.Protection -= 1;
                }
            }
            #endregion
            #region Protective Polish
            if (ProtectivePolish >= 1)
            {
                if (ProtectivePolish >= 1)
                {
                    modPlayer.ProtectivePolish = 4;
                }
                if (ProtectivePolish >= 2)
                {
                    modPlayer.ProtectivePolish -= 1;
                }
                if (ProtectivePolish >= 3)
                {
                    modPlayer.ProtectivePolish -= 1;
                }
            }
            #endregion
            #region Powder Mantle
            if (PowderMantle >= 1)
            {
                if (PowderMantle >= 1)
                {
                    modPlayer.PowderMantle = true;
                    modPlayer.PowderMantleCount = 50;
                }
                if (PowderMantle >= 2)
                {

                    modPlayer.PowderMantleCount -= 10;
                }
                if (PowderMantle >= 3)
                {

                    modPlayer.PowderMantleCount -= 10;
                }
            }
            #endregion
            #region Punish Draw
            if (PunishDraw >= 1)
            {
                if (PunishDraw >= 1)
                {
                    modPlayer.PunishDraw += 1;
                }
                if (PunishDraw >= 2)
                {
                    modPlayer.PunishDraw += 1;
                }
                if (PunishDraw >= 3)
                {
                    modPlayer.PunishDraw += 1;
                }
            }
            #endregion
            #region Quick Breath
            if (QuickBreath >= 1)
            {
                if (QuickBreath >= 1)
                {
                    modPlayer.qBreathClear = true;
                }
                if (QuickBreath >= 2)
                {
                    modPlayer.qBreathHeal = true;
                }
            }
            #endregion
            #region Quick Gather
            if (QuickGather >= 1)
            {
                if (QuickGather >= 1)
                {
                    modPlayer.QuickGather += 0.1f;
                }
                if (QuickGather >= 2)
                {
                    modPlayer.QuickGather += 0.1f;
                }
                if (QuickGather >= 3)
                {
                    modPlayer.QuickGather += 0.2f;
                }
            }
            #endregion
            #region Quick Sheathe
            if (QuickSheath >= 1)
            {
                if (QuickSheath >= 1)
                {
                    modPlayer.QuickSheath += 1;
                }
                if (QuickSheath >= 2)
                {
                    modPlayer.QuickSheath += 1;
                }
                if (QuickSheath >= 3)
                {
                    modPlayer.QuickSheath += 2;
                }
            }
            #endregion
            #region Rapid Fire
            if (RapidFire >= 1)
            {
                if (RapidFire >= 1)
                {
                    modPlayer.RapidFire = true;
                }
                if (RapidFire >= 1)
                {
                    modPlayer.RapidFireReuse -= 10;
                }
                if (RapidFire >= 1)
                {
                    modPlayer.RapidFireDamage = 0.2f;
                    modPlayer.RapidFireReuse -= 5;
                }

            }
            #endregion
            #region Razor Sharp
            if (RazorSharp >= 1)
            {
                if (RazorSharp >= 1)
                {
                    modPlayer.RazorSharp += 2;
                }
                if (RazorSharp >= 2)
                {
                    modPlayer.RazorSharp += 3;
                }
                if (RazorSharp >= 3)
                {
                    modPlayer.RazorSharp += 4;
                }
            }
            #endregion
            #region Recovery Up
            if (RecoveryUp >= 1)
            {
                if (RecoveryUp == 1)
                {
                    modPlayer.RecoveryUp += 0.25f;
                }
                if (RecoveryUp == 2)
                {
                    modPlayer.RecoveryUp += 0.5f;
                }
                if (RecoveryUp >= 3)
                {
                    modPlayer.RecoveryUp += 0.75f;
                }
            }
            #endregion
            #region Recovery Speed
            if (RecSpeed >= 1)
            {
                if (RecSpeed >= 1)
                {
                    modPlayer.RecoverySpeed += 1;
                }
                if (RecSpeed >= 2)
                {
                    modPlayer.RecoverySpeed += 1;
                }
                if (RecSpeed >= 3)
                {
                    modPlayer.RecoverySpeed += 1;
                }
            }
            #endregion
            #region Resentment
            if (Resentment >= 1)
            {
                if (Resentment >= 1)
                {
                    modPlayer.ResentmentBuff += 3;
                }
                if (Resentment >= 2)
                {
                    modPlayer.ResentmentBuff += 3;
                }
                if (Resentment >= 3)
                {
                    modPlayer.ResentmentBuff += 4;
                }
            }
            #endregion
            #region Resusitate
            if (Resusitate >= 1)
            {
                if (Resusitate >= 1)
                {
                    modPlayer.ResusitateBuff += 3;
                }
                if (Resusitate >= 2)
                {
                    modPlayer.ResusitateBuff += 3;
                }
                if (Resusitate >= 3)
                {
                    modPlayer.ResusitateBuff += 4;
                }
            }
            #endregion
            #region Rock Steady
            if (RockSteady)
            {
                Player.noKnockback = true;
            }
            #endregion
            #region Scholar
            if (Scholar >= 1)
            {
                modPlayer.Scholar += 1;

                if (Scholar >= 2)
                {
                    modPlayer.Scholar += 3;
                }
                if (Scholar >= 3)
                {
                    modPlayer.Scholar += 5;
                }
            }
            #endregion
            #region Slugger
            if (Slugger >= 1)
            {
                Player.GetKnockback(DamageClass.Generic) += 10 / 100f;

                if (Slugger >= 2)
                {
                    Player.GetKnockback(DamageClass.Generic) += 10 / 100f;
                }
                if (Slugger >= 3)
                {
                    Player.GetKnockback(DamageClass.Generic) += 10 / 100f;
                }
            }
            #endregion
            #region Sneak
            if (Sneak >= 1)
            {
                if (Sneak >= 1)
                {
                    Player.aggro -= 100;
                }
                if (Sneak >= 2)
                {
                    Player.aggro -= 150;
                }
                if (Sneak >= 3)
                {
                    Player.aggro -= 200;
                }
            }
            #endregion
            #region Sneak Attack
            if (SneakAttack >= 1)
            {
                if (SneakAttack >= 1)
                {
                    modPlayer.SneakAttack += 0.1f;
                }
                if (SneakAttack >= 2)
                {
                    modPlayer.SneakAttack += 0.05f;
                }
                if (SneakAttack >= 3)
                {
                    modPlayer.SneakAttack += 0.05f;
                }
            }
            #endregion
            #region Spare Shot
            if (SpareShot >= 1)
            {
                if (SpareShot >= 1)
                {
                    modPlayer.SpareShot += 6;
                }
                if (SpareShot >= 2)
                {
                    modPlayer.SpareShot -= 1;
                }
                if (SpareShot >= 3)
                {
                    modPlayer.SpareShot -= 1;
                }
            }
            #endregion
            #region Speed Eating
            if (SpeedEating >= 1)
            {
                if (SpeedEating >= 1)
                {
                    modPlayer.SpeedEating += 0.1f;
                }
                if (SpeedEating >= 2)
                {
                    modPlayer.SpeedEating += 0.1f;
                }
                if (SpeedEating >= 3)
                {
                    modPlayer.SpeedEating += 0.2f;
                }
            }
            #endregion
            #region Speed Setup
            if (SpeedSetup >= 1)
            {
                modPlayer.SpeedSetup += 1;
                if (SpeedSetup >= 2)
                {
                    modPlayer.SpeedSetup += 1;
                }
            }
            #endregion
            #region Speed Sharpening
            if (QuickSharpening >= 1)
            {
                modPlayer.SpeedSharpening += 1f;

                if (QuickSharpening >= 2)
                {
                    modPlayer.SpeedSharpening += 1.5f;
                }
                if (QuickSharpening >= 3)
                {
                    modPlayer.SpeedSharpening += 2f;
                }
            }
            #endregion
            #region Spirit
            if (Spirit >= 1)
            {
                if (Spirit >= 1)
                {
                    modPlayer.SpiritAttack += 3;
                }
                if (Spirit >= 2)
                {
                    modPlayer.SpiritCrit += 3;
                }
                if (Spirit >= 3)
                {
                    modPlayer.SpiritAttack += 3;
                    modPlayer.SpiritCrit += 3;
                }
                if (Spirit >= 4)
                {
                    modPlayer.SpiritAttack += 3;
                    modPlayer.SpiritCrit += 3;
                }
                if (Spirit >= 5)
                {
                    modPlayer.SpiritAttack += 3;
                    modPlayer.SpiritCrit += 3;
                }
            }
            #endregion
            #region Spiritbird's Call
            if (SpiritBirdsCall)
            {
                modPlayer.SpiritBirdCall = true;
            }
            #endregion
            #region Stamina Recovery
            if (StamRec >= 1)
            {
                if (StamRec >= 1)
                {
                    Player.manaRegenDelay -= 5;
                }
                if (StamRec >= 2)
                {
                    Player.manaRegenDelay -= 10;
                }
                if (StamRec >= 3)
                {
                    Player.manaRegenDelay -= 15;
                }
            }
            #endregion
            #region Strife
            if (Strife >= 1)
            {
                if (Strife >= 1)
                {
                    modPlayer.StrifeCrit += 3;
                }
                if (Strife >= 2)
                {
                    modPlayer.StrifeCrit += 3;
                }
                if (Strife >= 3)
                {
                    modPlayer.StrifeCrit += 4;
                }
            }
            #endregion
            #region Tenderizer
            if (Tenderizer >= 1)
            {
                if (Tenderizer >= 1)
                {
                    modPlayer.Tenderizer += 0.03f;
                }
                if (Tenderizer >= 2)
                {
                    modPlayer.Tenderizer += 0.04f;
                }
                if (Tenderizer >= 3)
                {
                    modPlayer.Tenderizer += 0.05f;
                }
            }
            #endregion
            #region Thunder Attack
            if (ThunderAttack >= 1)
            {
                modPlayer.ThunderAttack += 1;

                if (ThunderAttack >= 2)
                {
                    modPlayer.ThunderAttack += 1;
                }
                if (ThunderAttack >= 3)
                {
                    modPlayer.ThunderAttack += 1;
                }
                if (ThunderAttack >= 4)
                {
                    modPlayer.ThunderAttack += 1;
                }
                if (ThunderAttack >= 5)
                {
                    modPlayer.ThunderAttack += 1;
                }
            }
            #endregion
            #region Thunder Res
            if (ThunderRes >= 1)
            {
                if (ThunderRes >= 1)
                {
                    modPlayer.ThunderRes += 0.5f;
                    Player.statDefense += 1;
                }
                if (ThunderRes >= 2)
                {
                    modPlayer.ThunderRes += 0.5f;
                    Player.statDefense += 2;
                }
                if (ThunderRes >= 3)
                {
                    modPlayer.ThunderRes += 0.5f;
                    Player.statDefense += 3;
                }
            }
            #endregion
            #region Tropic Hunter
            if (TropicHunter >= 1)
            {
                if (TropicHunter >= 1)
                {
                    modPlayer.TropicHunterDef += 5;
                }
                if (TropicHunter >= 2)
                {
                    modPlayer.TropicHunterMovement += 5;
                }
                if (TropicHunter >= 3)
                {
                    modPlayer.TropicHunterAtk += 5;
                }
            }
            #endregion
            #region Unscathed
            if (Unscathed >= 1)
            {
                if (Unscathed >= 1)
                {
                    modPlayer.Unscathed += 3;
                }
                if (Unscathed >= 2)
                {
                    modPlayer.Unscathed += 4;
                }
                if (Unscathed >= 3)
                {
                    modPlayer.Unscathed += 5;
                }
            }
            #endregion
            #region Vault
            if (Vault >= 1)
            {

                if (Vault >= 1)
                {
                    modPlayer.Vault += 2;
                }
                if (Vault >= 2)
                {
                    modPlayer.Vault += 3;
                }
                if (Vault >= 3)
                {
                    modPlayer.Vault += 4;
                }
            }
            #endregion
            #region Water Attack
            if (WaterAttack >= 1)
            {
                modPlayer.WaterAttack += 1;

                if (WaterAttack >= 2)
                {
                    modPlayer.WaterAttack += 1;
                }
                if (WaterAttack >= 3)
                {
                    modPlayer.WaterAttack += 1;
                }
                if (WaterAttack >= 4)
                {
                    modPlayer.WaterAttack += 1;
                }
                if (WaterAttack >= 5)
                {
                    modPlayer.WaterAttack += 1;
                }
            }
            #endregion
            #region Water Res
            if (WaterRes >= 1)
            {
                if (WaterRes >= 1)
                {
                    modPlayer.WaterRes += 0.5f;
                    Player.statDefense += 1;
                }
                if (WaterRes >= 2)
                {
                    modPlayer.WaterRes += 0.5f;
                    Player.statDefense += 2;
                }
                if (WaterRes >= 3)
                {
                    modPlayer.WaterRes += 0.5f;
                    Player.statDefense += 3;
                }
            }
            #endregion
        }
    }
}
