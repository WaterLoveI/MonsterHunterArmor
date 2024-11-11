using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Items.Armor.MonsterHunter.HighRank;
using MHArmorSkills.Items.Consumables;
using MHArmorSkills.Projectiles.Weapon;
using MHArmorSkills.Utilities;
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
        public float CRangePlus;
        public bool CritELeTrue;
        public bool Fortified;
        public bool Guard;
        public bool GuardRaised;
        public bool GutsActive;
        public bool IntrepidHeart;
        public bool LatentPower;
        public bool LatentPowerHostile;
        public bool PCoatingUp;
        public bool PowderMantle;
        public bool RapidFire;
        // public bool Sharpness;
        public bool SpiritBirdCall;
        public double Tenderizer;
        public float CritEle;
        public float DeadEye;
        public float ElementalRes;
        public float FireRes;
        public float Foray;
        public float FocusSpd;
        public float IceRes;
        public float LatentPowerManaCost;
        public float QuickGather;
        public float RapidFireDamage;
        public float RecoveryUp;
        public float SneakAttack;
        public float SpeedEating;
        public float SpeedSharpening;
        public float ThunderRes;
        public float WaterRes;
        public int AdrenalineRush;
        public int ArtilleryBuff;
        public int ArtilleryCooldown;
        public int aSlidingCrit;
        public int aSlidingTimer;
        public int BladeHoneScale;
        public int DashCount;
        public int Shoottimer;
        public int Bloodlust;
        public int BloodlustCount;
        public int BloodlustHeal;
        public int BloodlustCD;
        public int BloodRite;
        public int BloodRiteTimer;
        public int BombBoostBuff;
        public int BubbleDance;
        public int CarvingChance;
        //  public int ChallengeSheathe;
        public int ChamBlessing;
        public int CliffHanger;
        public int Coalescence;
        public int CoalescenceCount;
        public int Constitution;
        public int CounterStrike;
        public int CritBoost;
        // public int CritDraw;
        public int Defiance;
        public int DefianceDef;
        public int DefianceCooldown;
        public int Diversion;
        public float DeadeyeDamage;
        public int Elemental;
        public int Embolden;
        public int EmboldenAggro;
        public int EmboldenDef;
        public int EvadeDistance;
        public int EvadeDodgeCD;
        public int EvadeTimer;
        public int Evasion;
        public int EvasionChance;
        public int FireAttack;
        public int FortifedAtk;
        public int FortifedDef;
        public int FortifedTimer;
        public int FreeElement;
        public int FreeMeal;
        public int Geologist;
        //    public int Grinder;
        public int GuardCooldown;
        public int GuardMovement;
        public int GuardReduction;
        public int Guardup;
        public int Guts;
        public int GutsTimer;
        //     public int Handicraft;
        public int HastenRec;
        public int HeroicsAttack;
        public int HeroicsDefence;
        public int HoneyHunter;
        public int IceAttack;
        public int IHeartCountdown;
        public int KushBless;
        public int LastingPower;
        public int LatentPowerAffinity;
        public int LatentPowerCounter;
        //      public int MastersTouch;
        //     public int MastersTouchCooldown;
        public int MaxMightTimer;
        public int MaxMightCrit;
        public int Mushroomancer;
        public int NegCrit;
        public int NormalBuff;
        public int OffensiveGuardBoost;
        public int PelletBuff;
        public int PieceBuff;
        public int PolarHunterAtk;
        public int PolarHunterDef;
        public int PolarHunterMovement;
        public int PowderMantleCount;
        public float ProlongerTime;
        public int Protection;
        //       public int ProtectivePolish;
        //       public int PunishDraw;
        //       public int QuickSheath;
        public int RapidFireReuse;
        //       public int RazorSharp;
        public int RecoverySpeed;
        public int ResentmentBuff;
        public int resuscitateBuff;
        public int Scholar;
        public int Sneak;
        public int SpareShot;
        public int SpeedSetup;
        public int SpiritAttack;
        public int SpiritCrit;
        public int StaminaRec;
        public int StatusTrigger;
        public int StrifeCrit;
        public int TeosBless;
        public int ThunderAttack;
        public int TropicHunterAtk;
        public int TropicHunterDef;
        public int TropicHunterMovement;
        public int Unscathed;
        public int Vault;
        public int WaterAttack;
        #endregion

        public bool ZinogreEssence;

        private int lastWeaponType = -1;
        private float cooldownTimer = 0;
        public int AutoGuardCD;

        public int ControlledAttack;
        public int ControlledCrit;

        public override void ResetEffects()
        {
            #region Skills
            AdrenalineRush = 0;
            AquaMobility = false;
            ArtilleryBuff = 0;
            DeadeyeDamage = 0f;
            aSlidingCrit = 0;
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
            //           ChallengeSheathe = 0;
            ChamBlessing = 0;
            CliffHanger = 0;
            Coalescence = 0;
            Constitution = 0;
            CounterStrike = 0;
            CRangePlus = 0f;
            CritBoost = 0;
            //            CritDraw = 0;
            CritEle = 0f;
            CritELeTrue = false;
            DeadEye = 0;
            Defiance = 0;
            DefianceDef = 0;
            Diversion = 0;
            Elemental = 0;
            ElementalRes = 0;
            Embolden = 0;
            EmboldenAggro = 0;
            EmboldenDef = 0;
            EvadeDistance = 0;
            Evasion = 0;
            EvasionChance = 0;
            FireAttack = 0;
            FireRes = 0;
            Foray = 0;
            FocusSpd = 0f;
            FortifedAtk = 0;
            FortifedDef = 0;
            FortifedTimer = 0;
            Fortified = false;
            FreeElement = 0;
            FreeMeal = 0;
            Geologist = 0;
            //            Grinder = 0;
            Guard = false;
            GuardMovement = 0;
            GuardReduction = 0;
            Guardup = 0;
            Guts = 0;
            GutsActive = false;
            GutsTimer = 0;
            //            Handicraft = 0;
            HastenRec = 0;
            HeroicsAttack = 0;
            HeroicsDefence = 0;
            HoneyHunter = 0;
            IceAttack = 0;
            IceRes = 0;
            IntrepidHeart = false;
            KushBless = 0;
            LastingPower = 0;
            LatentPower = false;
            LatentPowerAffinity = 0;
            LatentPowerHostile = false;
            LatentPowerManaCost = 0;
            MaxMightCrit = 0;
            //            MastersTouch = 0;
            Mushroomancer = 0;
            NegCrit = 0;
            NormalBuff = 0;
            OffensiveGuardBoost = 0;
            PCoatingUp = false;
            PelletBuff = 0;
            PieceBuff = 0;
            PolarHunterAtk = 0;
            PolarHunterDef = 0;
            PolarHunterMovement = 0;
            Protection = 0;
            //           ProtectivePolish = 0;
            ProlongerTime = 1f;
            //            PunishDraw = 0;
            QuickGather = 0;
            //            QuickSheath = 0;
            RapidFire = false;
            RapidFireDamage = 0.25f;
            RapidFireReuse = 35;
            //           RazorSharp = 0;
            RecoverySpeed = 0;
            RecoveryUp = 1f;
            ResentmentBuff = 0;
            resuscitateBuff = 0;
            Scholar = 0;
            //            Sharpness = false;
            Sneak = 0;
            SneakAttack = 1f;
            SpareShot = 0;
            SpeedEating = 0;
            SpeedSetup = 0;
            SpeedSharpening = 1f;
            SpiritAttack = 0;
            SpiritBirdCall = false;
            SpiritCrit = 0;
            StaminaRec = 0;
            StatusTrigger = 0;
            StrifeCrit = 0;
            Tenderizer = 0;
            TeosBless = 0;
            ThunderAttack = 0;
            ThunderRes = 0;
            TropicHunterAtk = 0;
            TropicHunterDef = 0;
            TropicHunterMovement = 0;
            Unscathed = 0;
            Vault = 0;
            WaterAttack = 0;
            WaterRes = 0;
            #endregion

            ZinogreEssence = false;

            ControlledAttack = 0;
            ControlledCrit = 0;
        }


        public override void PreUpdate()
        {
            int Debuffcount = Player.buffType.Count(MHLists.debuffList.Contains);
            #region Latent Power
            if (LatentPowerHostile && LatentPowerCounter == 0)
            {
                LatentPowerCounter++;
            }
            if (LatentPowerCounter >= 1 && !Player.dead)
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
            if (GuardCooldown < 0)
            {
                GuardCooldown = 0;
            }
            #endregion
            #region Coalescence
            if (Coalescence >= 1)
            {
                CoalescenceCount = Debuffcount;
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
            #region Masters Touch
            /*            if (MastersTouchCooldown > 0)
                        {
                            MastersTouchCooldown--;
                        }
            */
            #endregion
            #region Guts
            if (GutsTimer > 0)
            {
                GutsTimer--;
            }
            if (Guts >= 1 && GutsTimer == 0)
            {
                float HPThresh = (3 - Guts) / 10;
                int GutsHP = (int)(Player.statLifeMax2 * HPThresh);
                if (Player.statLife >= GutsHP)
                {
                    GutsActive = true;
                }
            }
            #endregion
            #region Sheath
            /*int currentWeaponType = Player.HeldItem.type;

            if (currentWeaponType != lastWeaponType)
            {
                int Chance = 4 - QuickSheath;
                int rand = Main.rand.Next(1, Chance);
                if (rand <= 1 && cooldownTimer == 0)
                {
                    if (PunishDraw >= 1 && !Player.HasBuff(ModContent.BuffType<PunishDraw>()))
                    {
                        int Duration = (int)(15 * 60 * ProlongerTime);
                        Player.AddBuff(ModContent.BuffType<PunishDraw>(), Duration);
                    }
                    if (CritDraw >= 1 && !Player.HasBuff(ModContent.BuffType<CritDraw>()))
                    {
                        int Duration = (int)(7 * 60 * ProlongerTime);
                        Player.AddBuff(ModContent.BuffType<CritDraw>(), Duration);
                    }
                    if (ChallengeSheathe >= 1)
                    {
                        int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));
                        int CSheath = 3 + (ChallengeSheathe * 5);
                        // Check if the player has the Sharpness buff
                        if (SharpnessBuffIndex != -1)
                        {
                            // extend the sharpness bufftime
                            Player.buffTime[SharpnessBuffIndex] += CSheath * 60;
                            cooldownTimer = 6 * 60;
                        }
                        if (SharpnessBuffIndex == -1)
                        {
                            // gives the player the sharpness buff
                            Player.AddBuff(ModContent.BuffType<Sharpness>(), CSheath * 60);
                            cooldownTimer = 6 * 60;
                        }
                    }
                }

                if (rand > 1 && cooldownTimer == 0)
                {
                    cooldownTimer = 45;
                }
            }
            if (cooldownTimer > 0)
            {
                cooldownTimer--;
            }

            lastWeaponType = currentWeaponType;*/
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
            #region Kushala Blessing
            if (Player.HasBuff(BuffID.PotionSickness))
            {
                if (Main.rand.NextBool(15))
                {
                    if (Player.statLifeMax2 > Player.statLife)
                    {
                        Player.statLife++;
                    }
                }
            }
            #endregion
            #region Evade Dodge CD
            if (EvadeDodgeCD > 0)
            {
                EvadeDodgeCD--;
            }
            #endregion
            #region Maximum Might
            if (!Player.controlDown && !Player.controlLeft && !Player.controlRight && !Player.controlUp && MaxMightCrit > 0)
            {
                MaxMightTimer++;
            }
            else
            {
                MaxMightTimer = 0;
            }
            #endregion
            #region Bloodlust
            if (BloodlustCD > 0)
            {
                BloodlustCD--;
            }
            #endregion
            if (Shoottimer > 0)
            {
                Shoottimer--;
            }
            if (AutoGuardCD > 0)
            {
                AutoGuardCD--;
            }
            if (ArtilleryCooldown > 0)
            {
                ArtilleryCooldown--;
            }
        }

        public override void PostUpdateMiscEffects()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            SharpnessPlayer SharpPlayer = Player.GetModPlayer<SharpnessPlayer>();

            #region Grinder
            /*if (Grinder >= 1 && Player.HasBuff(ModContent.BuffType<Sharpness>()))
            {
                ControlledAttack += Grinder;
            }*/
            #endregion
            #region Affinity Sliding
            if (Player.HasBuff(ModContent.BuffType<AffinitySliding>()))
            {
                ControlledCrit += aSlidingCrit;
            }
            #endregion
            #region Bubble Blight/Dance
            if (BubbleDance >= 1 && Player.HasBuff(ModContent.BuffType<BubbleBlight>()))
            {
                Player.accRunSpeed *= 2.25f; // 1.125% increase to counter the decrease bubbleblight gives
                Player.maxRunSpeed *= 2.25f; // 1.125% increase to counter the decrease bubbleblight gives

                if (BubbleDance >= 3)
                {
                    Player.maxRunSpeed *= 1.2f;
                }
            }
            #endregion
            #region Speed Sharpening
            if (SpeedSharpening >= 3)
            {
                if (Player.ActiveItem().type == ModContent.ItemType<WhetStone>() && SharpPlayer.CurrentSharpness < SharpPlayer.MaxSharpness)
                {
                    /*int Timer = 45;
                    if (RazorSharp >= 1)
                    {
                        Timer += 45 * RazorSharp;
                    }*/
                    SharpPlayer.CurrentSharpness += 50;
                    SoundEngine.PlaySound(SoundID.Item37);
                    if (modPlayer.ProtectivePolish >= 1)
                    {
                        int Duration = (int)(modPlayer.ProtectivePolish * 15 * 60 * ProlongerTime);
                        Player.AddBuff(ModContent.BuffType<ProtectivePolish>(), Duration);
                    }
                }
            }
            #endregion
            #region Protective Polish
            /*            if (ProtectivePolish >= 1)
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
            */
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
                ControlledAttack += CounterStrike;
            }
            #endregion
            #region Resuscitate
            if (resuscitateBuff >= 1)
            {
                for (int l = 0; l < Player.MaxBuffs; ++l)
                {
                    int buffID = Player.buffType[l];
                    if (Player.buffTime[l] <= 2)
                        continue;
                    bool Statused = MHLists.debuffList.Contains(buffID);
                    if (Statused)
                    {
                        ControlledAttack += resuscitateBuff;
                    }
                }
            }
            #endregion
            #region Crit Draw
            /*            if (Player.HasBuff(ModContent.BuffType<CritDraw>()))
                        {
                            int CDraw = CritDraw * 7;
                            ControlledCrit += CDraw;
                        }
            */
            #endregion
            #region BBQ Expert
            if (modPlayer.BBQExpert >= 2)
            {
                if (Player.HasBuff(BuffID.WellFed))
                {
                    Player.statLifeMax2 += 10;
                }
                if (Player.HasBuff(BuffID.WellFed2))
                {
                    Player.statLifeMax2 += 20;
                }
                if (Player.HasBuff(BuffID.WellFed3))
                {
                    Player.statLifeMax2 += 30;
                }
            }
            #endregion
            #region Fortified
            if (Player.HasBuff(ModContent.BuffType<Fortified>()))
            {
                ControlledAttack += FortifedAtk;
                Player.statDefense += FortifedDef;
            }
            #endregion
            #region Punish Draw
            /*            if (Player.HasBuff(ModContent.BuffType<PunishDraw>()))
                        {
                            int pDraw = PunishDraw * 10;
                            Player.GetKnockback(DamageClass.Generic) += pDraw / 100f;
                            Player.GetDamage(DamageClass.Melee) += PunishDraw / 100f;
                        }
            */
            #endregion
            #region Intrepid Heart
            if (IHeartCountdown >= 100 && !Player.HasBuff(ModContent.BuffType<IntrepidHeart>()))
            {
                Player.AddBuff(ModContent.BuffType<IntrepidHeart>(), 2);
                SoundEngine.PlaySound(SoundID.NPCDeath7);
                Player.noKnockback = true;
            }
            #endregion
            #region Latent Power
            if (LatentPowerCounter >= 30 * 60)
            {
                int Duration = (int)(30 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<LatentPower>(), Duration);
                SoundEngine.PlaySound(SoundID.Item4);
            }

            if (Player.HasBuff(ModContent.BuffType<LatentPower>()))
            {
                ControlledCrit += LatentPowerAffinity;
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
                ControlledAttack += Unscathed;
            }
            #endregion
            #region Vault
            if (Vault >= 1 && (Player.velocity.Y != 0f || Player.wingTime > 0))
            {
                ControlledAttack += Vault;
            }
            #endregion
            #region Offensive Guard
            if (Player.HasBuff(ModContent.BuffType<OffensiveGuard>()))
            {
                ControlledAttack += OffensiveGuardBoost;
            }
            #endregion
            #region Adrenaline Rush
            if (Player.HasBuff(ModContent.BuffType<AdrenalineRush>()))
            {
                ControlledAttack += AdrenalineRush;
                ControlledCrit += AdrenalineRush;
            }
            #endregion
            #region Polar Hunter
            if (PolarHunterDef >= 1 && Player.ZoneSnow)
            {
                ControlledAttack += PolarHunterAtk;
                Player.moveSpeed += PolarHunterMovement / 100f;
                Player.statDefense += PolarHunterDef;
            }
            #endregion
            #region Tropic Hunter
            if (TropicHunterDef >= 1 && (Player.ZoneDesert || Player.ZoneJungle || Player.ZoneUnderworldHeight))
            {
                ControlledAttack += TropicHunterAtk;
                Player.moveSpeed += TropicHunterMovement / 100f;
                Player.statDefense += TropicHunterDef;
            }
            #endregion
            #region Guard

            #endregion
            #region Aqua Mobility
            if (AquaMobility)
            {
                Player.iceSkate = true;
                Player.accFlipper = true;

            }
            #endregion
            #region Coalescence
            int postUpdateDebuffCount = Player.buffType.Count(MHLists.debuffList.Contains);

            if (postUpdateDebuffCount < CoalescenceCount)
            {
                int Duration = (int)(10 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<Coalescence>(), Duration);
                SoundEngine.PlaySound(SoundID.Item8);
                for (int i = 0; i < 7; i++)
                {
                    int d = Dust.NewDust(Player.position, Player.width + 2, Player.height + 3, DustID.Electric, 0, 0, 100, Color.Purple, 0.5f);
                    Main.dust[d].noGravity = true;
                    Main.dust[d].noLight = false;
                    Main.dust[d].fadeIn = 1f;
                    Main.dust[d].velocity *= 1.1f;
                }
            }
            if (Player.HasBuff(ModContent.BuffType<Coalescence>()))
            {
                ControlledAttack += Coalescence;
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
                int effectIndex = random.Next(0, 5);

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
            if (Player.HasBuff(ModContent.BuffType<SpiritBirdBlue>()))
            {
                int Speed = 5;
                if (ChamBlessing >= 1)
                {
                    Speed = 10;
                }
                Player.moveSpeed += Speed / 100f;
            }
            if (Player.HasBuff(ModContent.BuffType<SpiritBirdGreen>()))
            {
                int Health = 20;
                if (ChamBlessing >= 1)
                {
                    Health = 40;
                }
                Player.statLifeMax2 += Health;
            }
            if (Player.HasBuff(ModContent.BuffType<SpiritBirdOrange>()))
            {
                int Damage = 5;
                if (ChamBlessing >= 1)
                {
                    Damage = 10;
                }
                ControlledAttack += Damage;
            }
            if (Player.HasBuff(ModContent.BuffType<SpiritBirdPrism>()))
            {
                int Speed = 5;
                int Defense = 5;
                int Damage = 5;
                int Health = 20;
                if (ChamBlessing >= 1)
                {
                    Speed = 10;
                    Defense = 10;
                    Damage = 10;
                    Health = 40;
                }
                Player.moveSpeed += Speed / 100f;
                Player.statDefense += Defense;
                ControlledAttack += Damage;
                Player.statLifeMax2 += Health;
            }
            if (Player.HasBuff(ModContent.BuffType<SpiritBirdYellow>()))
            {
                int Defense = 5;
                if (ChamBlessing >= 1)
                {
                    Defense = 10;
                }
                Player.statDefense += Defense;
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
            #region Maximum Might
            if (MaxMightTimer >= 120)
            {

                if (!Player.HasBuff(ModContent.BuffType<MaximumMight>()))
                {
                    int Duration = (int)(15 * 60 * ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<MaximumMight>(), Duration);
                    for (int i = 0; i < 5; i++)
                    {
                        int d = Dust.NewDust(Player.position, Player.width, Player.height, DustID.SpookyWood, 0, 0, 100, Color.Blue, 0.7f);
                        Main.dust[d].noGravity = true;
                        Main.dust[d].noLight = false;
                        Main.dust[d].fadeIn = 1f;
                        Main.dust[d].velocity *= 0.6f;
                    }
                }


            }
            if (Player.HasBuff(ModContent.BuffType<MaximumMight>()))
            {
                ControlledCrit += MaxMightCrit;
                Player.manaSickTime = 150;
                Player.manaSickTimeMax = 300;

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
                    if (npc.Distance(Player.Center) < 1200f)
                    {
                        hostileNPCs++;
                    }
                    if (npc.Distance(Player.Center) < 240f && Diversion >= 1)
                    {
                        DiversionEffect();
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
                    int Duration = (int)(5 * 60 * ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<AffinitySliding>(), Duration);
                    aSlidingTimer = 7 * 60;
                }
                #endregion
                #region Bladehone Scale
                DashCount += 1;
                if (BladeHoneScale >= 1 && aSlidingTimer == 0 && DashCount >= 3)
                {
                    int Duration = (int)(7 * 60 * ProlongerTime);
                    DashCount = 0;
                    Player.AddBuff(ModContent.BuffType<BladeHoneScale>(), Duration);
                    aSlidingTimer = 10 * 60;
                    if (Player.HasBuff(ModContent.BuffType<BladeHoneScale>()))
                    {
                        Player.manaCost *= (100 - BladeHoneScale * 3) / 100;

                        /*                        if (Player.HasBuff(ModContent.BuffType<Sharpness>()))
                                                {
                                                    int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));
                                                    Player.buffTime[SharpnessBuffIndex] += 60;
                                                }

                                                if (!Player.HasBuff(ModContent.BuffType<Sharpness>()))
                                                {
                                                    Player.AddBuff(ModContent.BuffType<Sharpness>(), 7 * 60);
                                                }
                        */
                        if (SharpPlayer.CurrentSharpness < SharpPlayer.MaxSharpness)
                        {
                            SharpPlayer.CurrentSharpness += 3;
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
            #region Evade Buffs
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];


                if (npc.active && !npc.friendly)
                {
                    float distance = Vector2.Distance(Player.Center, npc.Center);

                    if (distance < Player.Hitbox.Width / 2 + npc.Hitbox.Width / 2)
                    {
                        if (Player.immune && EvadeDodgeCD == 0)
                        {
                            if (AdrenalineRush > 0 && !Player.HasBuff(ModContent.BuffType<AdrenalineRush>()))
                            {
                                int Duration = (int)(7 * 60 * ProlongerTime);
                                Player.AddBuff(ModContent.BuffType<AdrenalineRush>(), Duration);
                                EvadeDodgeCD = 60;
                            }
                            if (BladeHoneScale >= 1)
                            {
                                int Duration = (int)(45 * 60 * ProlongerTime);
                                Player.AddBuff(ModContent.BuffType<BladeHoneScale>(), Duration);
                            }
                            if (StatusTrigger == 1)
                            {
                                npc.AddBuff(BuffID.Poisoned, 5 * 60);
                                EvadeDodgeCD = 60;
                            }
                            if (StatusTrigger > 1)
                            {
                                npc.AddBuff(BuffID.Venom, 7 * 60);
                                EvadeDodgeCD = 60;
                            }
                        }

                    }
                    if (distance < Player.Hitbox.Width + npc.Hitbox.Width)
                    {
                        if (modPlayer.AutoGuard && Player.itemAnimation == 0)
                        {
                            if (!Player.controlDown && !Player.controlLeft && !Player.controlRight && !Player.controlUp)
                            {
                                Player.shieldRaised = true;
                                AutoGuardCD = 3 * 60;
                            }

                        }

                    }
                }
            }

            for (int i = 0; i < Main.projectile.Length; i++)
            {
                Projectile proj = Main.projectile[i];


                if (proj.active && !proj.friendly)
                {
                    float distance = Vector2.Distance(Player.Center, proj.Center);

                    if (distance < Player.Hitbox.Width / 2 + proj.Hitbox.Width / 2)
                    {
                        if (Player.immune && EvadeDodgeCD == 0)
                        {
                            if (AdrenalineRush > 0 && !Player.HasBuff(ModContent.BuffType<AdrenalineRush>()))
                            {
                                int Duration = (int)(7 * 60 * ProlongerTime);
                                Player.AddBuff(ModContent.BuffType<AdrenalineRush>(), Duration);
                                EvadeDodgeCD = 60;
                            }
                            if (BladeHoneScale >= 1)
                            {
                                int Duration = (int)(45 * 60 * ProlongerTime);
                                Player.AddBuff(ModContent.BuffType<BladeHoneScale>(), Duration);
                            }

                        }

                    }
                    if (distance < Player.Hitbox.Width + proj.Hitbox.Width)
                    {
                        if (modPlayer.AutoGuard && Player.itemAnimation == 0 && Guardup > 0)
                        {
                            if (!Player.controlDown && !Player.controlLeft && !Player.controlRight && !Player.controlUp)
                            {
                                Player.shieldRaised = true;
                                AutoGuardCD = 3 * 60;
                            }

                        }

                    }
                }
            }
            #endregion
            #region Attack/Crit Mitigation
            Player.GetCritChance(DamageClass.Generic) += ControlledCrit;
            Player.GetDamage(DamageClass.Generic) += ControlledAttack / 100f;
            if (ControlledCrit >= 21)
            {
                int newcrit = (ControlledCrit - 20) / 2;
                if (newcrit >= 30)
                {
                    newcrit = 30;
                }
                Player.GetCritChance(DamageClass.Generic) += newcrit + 20;
            }
            if (ControlledAttack >= 21)
            {
                int newattack = (ControlledAttack - 20) / 2;
                if (newattack >= 30)
                {
                    newattack = 30;
                }
                Player.GetDamage(DamageClass.Generic) += (newattack + 20) / 100f;
            }
            #endregion

        }
        #region Guard
        public override void ProcessTriggers(TriggersSet triggersSet)
        {

            if (Guard)
            {
                GuardRaised = false;
                if (Player.inventory[Player.selectedItem].type == ItemID.DD2SquireDemonSword || Player.inventory[Player.selectedItem].type == ItemID.BouncingShield)
                {
                    return;
                }
                Player.shieldRaised = Player.selectedItem != 58 &&
                    Player.itemAnimation == 0 && Player.itemTime == 0 && Player.reuseDelay == 0 && MHArmorSkills.GuardButton.Current && Player.hasRaisableShield && GuardCooldown == 0;

                if (Player.shieldRaised)
                {
                    GuardRaised = true;
                    Player.shieldRaised = true;
                    Player.moveSpeed += GuardMovement / 100f;

                    ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
                    int GDef = 5 + modPlayer.Guard + (Guardup * 3);

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
            if (Player.HasBuff(ModContent.BuffType<Frenzy>()) && BloodlustCount >= 60)
            {
                Player.ClearBuff(ModContent.BuffType<Frenzy>());
                BloodlustCount = 0;
                if (BloodlustHeal == 0)
                {
                    int healamt = (int)(Bloodlust * 5 * RecoveryUp);
                    Player.Heal(healamt);
                    BloodlustHeal += 1;
                }
                if (Bloodlust >= 3)
                {
                    int Duration = (int)(90 * 60 * ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<FrenzyCure>(), Duration);
                }
                else
                {
                    Player.AddBuff(ModContent.BuffType<FrenzyCure>(), 60 * 60);
                }

            }
            if (Player.HasBuff(ModContent.BuffType<Frenzy>()))
            {
                Player.manaCost *= ((100 - (Bloodlust * 3))) / 100f;
                ControlledAttack += (Bloodlust * 4);
                Player.lifeRegen = 0;

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
                ControlledCrit += Bloodlust * 5;

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
                ControlledAttack += HeroicsAttack;
            }
        }
        #endregion
        #region Spirit
        public void SpiritEffect()
        {
            ControlledAttack += SpiritAttack;
            ControlledCrit += SpiritCrit;
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
                Player.statDefense += DefianceDef;
                Player.noKnockback = true;
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
            Player.AddBuff(ModContent.BuffType<Embolden>(), 2);



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

            Guard = true;
        }
        #endregion
        #region Masters Touch
        /*        public void MastersTouchEffect(NPC target, int damage, bool crit)
                {
                    if (crit && MastersTouch >= 1 && Main.rand.NextBool(MastersTouch) && MastersTouchCooldown == 0 && Player.HasBuff(ModContent.BuffType<Sharpness>()))
                    {
                        MastersTouchCooldown = 60;
                        int SharpnessBuffIndex = Player.FindBuffIndex((ModContent.BuffType<Sharpness>()));

                        if (SharpnessBuffIndex != -1)
                        {
                            Player.buffTime[SharpnessBuffIndex] += 60;
                        }
                    }
                }
        */
        #endregion
        #region Diversion
        public void DiversionEffect()
        {
            Player.AddBuff(ModContent.BuffType<Diversion>(), 2);
            if (Diversion >= 2)
            {
                Player.GetAttackSpeed(DamageClass.Melee) += 0.1f;
            }

            if (Diversion >= 3)
            {
                Player.GetDamage(DamageClass.Melee) += 5 / 100f;
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
            if (Bloodlust >= 1 && Player.HasBuff(ModContent.BuffType<Frenzy>()) && BloodlustCD == 0)
            {
                BloodlustCount += 1;
                BloodlustCD = 30;
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
            if (HastenRec >= 1 && !Player.HasBuff(ModContent.BuffType<HastenRecovery>()) && Main.rand.NextBool(3))
            {
                int Duration = (int)(5 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<HastenRecovery>(), Duration);
            }
            #endregion
            #region Sneak 
            if (Sneak >= 1)
            {
                Vector2 relativePosition = target.Center - Player.Center;


                if ((relativePosition.X > 0 && target.direction == 1) || (relativePosition.X < 0 && target.direction == -1))
                {

                    target.AddBuff(BuffID.Confused, 5 * 60);
                }
            }
            #endregion
            //           MastersTouchEffect(target, damageDone, hit.Crit);
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
            if (Bloodlust >= 1 && Player.HasBuff(ModContent.BuffType<Frenzy>()) && BloodlustCD == 0)
            {
                BloodlustCount += 1;
                BloodlustCD = 30;
            }
            #endregion
            #region Hasten Recovery
            if (HastenRec >= 1 && !Player.HasBuff(ModContent.BuffType<HastenRecovery>()) && Main.rand.NextBool(5))
            {
                int Duration = (int)(3 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<HastenRecovery>(), Duration);
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
            if (PCoatingUp && proj.DamageType == DamageClass.Ranged)
            {
                int Timer = Main.rand.Next(360, 600);
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(BuffID.Poisoned, Timer);
                }
            }

            #endregion
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
                SoundEngine.PlaySound(SoundID.NPCHit5);
                IHeartCountdown = 0;
            }
            #endregion
            #region Guard
            if (Guard && Player.shieldRaised && GuardCooldown == 0)
            {
                modifiers.SourceDamage *= GuardReduction / 100;
                SoundEngine.PlaySound(SoundID.NPCHit4);
                int ConstCD = 0;
                if (Constitution >= 1)
                {
                    ConstCD = 60 * Constitution;
                }
                GuardCooldown = 3 * 60 - ConstCD;
                Player.AddBuff(ModContent.BuffType<GuardCooldown>(), GuardCooldown);
                if (OffensiveGuardBoost > 0)
                {
                    int Duration = (int)(12 * 60 * ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<OffensiveGuard>(), Duration);
                }

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
            if (ThunderRes >= 1 && MHLists.thunderresprojList.Contains(proj.type))
            {
                float Res = 1 - ThunderRes;
                modifiers.FinalDamage *= Res;
            }
            #endregion
            #region Intrepid Heart
            if (Player.HasBuff(ModContent.BuffType<IntrepidHeart>()))
            {
                modifiers.FinalDamage *= 0.5f;
                SoundEngine.PlaySound(SoundID.NPCDeath7);
                IHeartCountdown = 0;
            }
            #endregion
            #region Guard
            if (Guard && Player.shieldRaised && GuardCooldown == 0)
            {
                modifiers.SourceDamage *= GuardReduction / 100;
                SoundEngine.PlaySound(SoundID.NPCHit4);
                int ConstCD = 0;
                if (Constitution >= 1)
                {
                    ConstCD = 60 * Constitution;
                }
                GuardCooldown = 3 * 60 - ConstCD;
                Player.AddBuff(ModContent.BuffType<GuardCooldown>(), GuardCooldown);
                if (OffensiveGuardBoost > 0)
                {
                    int Duration = (int)(7 * 60 * ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<OffensiveGuard>(), Duration);
                }

            }
            #endregion
            #region Guard Up
            if (Guardup >= 1)
            {
                bool projectileRight = (Player.Center.X - proj.Center.X) < 0f;
                bool projectileLeft = (Player.Center.X - proj.Center.X) > 0f;
                int GUMitigation = 100 - (Guardup * 5);
                if (Player.direction == 1)
                {
                    if (projectileRight)
                        modifiers.SourceDamage *= GUMitigation / 100;
                }
                else
                {
                    if (projectileLeft)
                        modifiers.SourceDamage *= GUMitigation / 100;
                }
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
                    proj.damage *= 1 + (ArtilleryBuff / 100);
                }
            }
            #endregion
            #region Bomb Boost
            if (BombBoostBuff >= 1)
            {
                if (proj.type >= ProjectileID.Bomb && proj.type <= ProjectileID.Grenade || proj.type == ProjectileID.StickyBomb || proj.type == ProjectileID.Beenade || proj.type == ProjectileID.StickyGrenade || proj.type == ProjectileID.StickyDynamite || proj.type == ProjectileID.BouncyBomb || proj.type == ProjectileID.BouncyDynamite ||
                    proj.type == ProjectileID.BouncyGrenade || proj.type == ProjectileID.ScarabBomb || proj.type >= ProjectileID.WetBomb && proj.type <= ProjectileID.DryBomb || proj.type == ProjectileID.DirtBomb || proj.type == ProjectileID.DirtStickyBomb || proj.type == ProjectileID.ExplosiveBullet || proj.type == ProjectileID.HellfireArrow || proj.type == ProjectileID.ExplosiveBunny)
                {
                    proj.damage *= BombBoostBuff + 100 / 100;
                    if (BombBoostBuff >= 3)
                    {
                        proj.ArmorPenetration += 10;
                    }
                }
            }
            #endregion
            #region Normal Up
            if (NormalBuff >= 1)
            {
                if (proj.type == ProjectileID.Bullet || proj.type == ProjectileID.WoodenArrowFriendly || proj.type == ProjectileID.SilverBullet)
                {
                    proj.damage *= 1 + (NormalBuff / 100);
                }
            }
            #endregion
            #region Pellet Up
            if (PelletBuff >= 1)
            {
                if (proj.type == ProjectileID.CrystalBullet || proj.type == ProjectileID.HolyArrow)
                {
                    proj.damage *= 1 + (PelletBuff / 100);
                }
            }
            #endregion
            #region Pierce Up
            if (PieceBuff >= 1)
            {
                if (proj.type == ProjectileID.MeteorShot || proj.type == ProjectileID.BulletHighVelocity || proj.type == ProjectileID.MoonlordBullet || proj.type == ProjectileID.JestersArrow || proj.type == ProjectileID.UnholyArrow || proj.type == ProjectileID.BoneArrow || proj.penetrate > 1)
                {
                    proj.damage *= 1 + (PieceBuff / 100);
                }
            }
            #endregion
            #region Ranged Arrow
            if (proj.DamageType == DamageClass.Ranged)
            {
                #region Close Range
                if (CRangePlus > 0)
                {
                    float DistanceInterpolant = Utils.GetLerpValue(240f, 1f, target.Distance(Main.player[Main.myPlayer].Center), true);
                    float rangedBoost = MathHelper.Lerp(0f, CRangePlus, DistanceInterpolant);
                    modifiers.SourceDamage += rangedBoost;
                }

                #endregion
            }
            #endregion
            #region Dead Eye
            if (DeadEye > 0)
            {
                float DistanceInterpolant = Utils.GetLerpValue(300f, 800f, target.Distance(Main.player[Main.myPlayer].Center), true);
                float rangedBoost = MathHelper.Lerp(0f, DeadEye, DistanceInterpolant);
                DeadeyeDamage = rangedBoost;
                if (rangedBoost > 0f)
                {
                    Player.AddBuff(ModContent.BuffType<DeadEye>(), 60);
                }
                if (rangedBoost < 0f)
                {
                    Player.ClearBuff(ModContent.BuffType<DeadEye>());
                }
                if (proj.CountsAsClass<RangedDamageClass>())
                {
                    modifiers.SourceDamage += rangedBoost;
                }
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
                int CDTimer = 5 * 60;
                if (ZinogreEssence)
                {
                    CDTimer = 10 * 60;
                }
                LatentPowerCounter += CDTimer;
            }
            #endregion
            #region Counter Strike
            if (CounterStrike >= 1)
            {
                int Duration = (int)(10 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<CounterStrike>(), Duration);
            }
            #endregion
            #region Honey Hunter
            if (HoneyHunter >= 6)
            {
                Player.AddBuff(BuffID.Honey, 7 * 60);
            }
            #endregion
            #region Guard
            if (GuardRaised)
            {
                SoundEngine.PlaySound(SoundID.NPCHit4);
            }
            #endregion
        }
        public override void OnRespawn()
        {
            base.OnRespawn();
            #region Fortified
            if (Fortified)
            {
                int Duration = (int)(FortifedTimer * 60 * 60 * ProlongerTime);
                Player.AddBuff(ModContent.BuffType<Fortified>(), Duration);
                Player.statLife = Player.statLifeMax2;
            }
            #endregion
            BloodlustCount = 0;
            LatentPowerCounter = 0;
            Player.timeSinceLastDashStarted = 3;
            cooldownTimer = 30;
            Player.dashDelay = 2;
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
            #region Bladehone Scale
            if (Player.HasBuff(ModContent.BuffType<BladeHoneScale>()))
            {
                int AmmoChance = 4 - BladeHoneScale;
                if (Main.rand.NextBool(AmmoChance))
                {
                    return false;
                }
            }
            #endregion
            return base.CanConsumeAmmo(weapon, ammo);
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
            /*if (Sharpness && item.CountsAsClass<MeleeDamageClass>())
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
            }*/
            #endregion
            #region Kushalas Blessing
            if (KushBless >= 1 && (MHLists.iceelementList.Contains(item.type) || MHLists.waterelementList.Contains(item.type)))
            {
                damage += 0.05f;
            }
            if (KushBless >= 2 && (MHLists.iceelementList.Contains(item.type) || MHLists.waterelementList.Contains(item.type)))
            {
                damage += 0.05f;
            }
            #endregion
            #region Teostras Blessing
            if (TeosBless >= 1 && (MHLists.fireelementList.Contains(item.type) || MHLists.thunderelementList.Contains(item.type)))
            {
                damage += 0.05f;
            }
            if (TeosBless >= 2 && (MHLists.fireelementList.Contains(item.type) || MHLists.thunderelementList.Contains(item.type)))
            {
                damage += 0.05f;
            }
            #endregion
            #region Artillery
            if (item.sentry && ArtilleryBuff >= 1)
            {
                damage += (float)(ArtilleryBuff / 100f);
            }
            #endregion
            #region Rapid Fire
            /*if (RapidFire && item.CountsAsClass<RangedDamageClass>())
            {
                damage -= RapidFireDamage;
            }*/
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
            /*            if (Sharpness && item.CountsAsClass<MeleeDamageClass>() && item.rare >= ItemRarityID.LightPurple)
                        {
                            int Handicraftboost = item.rare + Handicraft;
                            if (Handicraftboost > 11)
                            {
                                Handicraftboost = 11;
                            }
                            int Sharpness = (Handicraftboost) / 2;
                            knockback.Flat += item.knockBack * (Sharpness / 10) + 1;
                        }
            */
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
            #region Teostras Blessing
            if (TeosBless >= 3 && (MHLists.fireelementList.Contains(item.type) || MHLists.thunderelementList.Contains(item.type)))
            {
                crit += 5;
            }
            #endregion
            #region Speed Setup
            if (SpeedSetup >= 3)
            {
                if (item.consumable && item.useStyle == ItemUseStyleID.Swing)
                {
                    crit += 5;
                }
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
            /*if (RapidFire && item.CountsAsClass<RangedDamageClass>())
            {
                if (item.useTime >= RapidFireReuse)
                {
                    return true;
                }
                return false;
            }*/
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
            /*#region Rapid Fire
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
            #endregion*/
            #region Bladehone Scale
            if (Player.HasBuff(ModContent.BuffType<BladeHoneScale>()) && Shoottimer == 0)
            {
                for (int index = 0; index < BladeHoneScale; ++index)
                {
                    switch (Main.rand.Next(4))
                    {
                        case 0:
                            type = ModContent.ProjectileType<BladeScale1>();
                            break;
                        case 1:
                            type = ModContent.ProjectileType<BladeScale2>();
                            break;
                        case 2:
                            type = ModContent.ProjectileType<BladeScale3>();
                            break;
                        case 3:
                            type = ModContent.ProjectileType<BladeScale4>();
                            break;
                    }
                    float SpeedX = velocity.X*2 + Main.rand.NextFloat(-3f, 3f);
                    float SpeedY = velocity.Y*2 + Main.rand.NextFloat(-3f, 3f);
                    Projectile.NewProjectile(source, position.X, position.Y, SpeedX, SpeedY, type, damage / 3, knockback, Player.whoAmI);
                    Shoottimer = 30;
                }
            }
            #endregion
            #region Artillery
            //if (ArtilleryBuff >= 15 && item.useAmmo == AmmoID.Rocket && ArtilleryCooldown == 0)
            //{
            //    Projectile.NewProjectile(source, position.X, position.Y, velocity.X, velocity.Y, type, damage / 2, knockback / 2, Player.whoAmI);
            //    ArtilleryCooldown = 90;
            //}
            #endregion
            return base.Shoot(item, source, position, velocity, type, damage, knockback);
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
            Player.lifeRegen += RecoverySpeed;
            #endregion
            #region Hasten Recovery
            if (Player.HasBuff(ModContent.BuffType<HastenRecovery>()))
            {
                Player.lifeRegen += HastenRec * 3;
                Player.lifeRegenTime += HastenRec * 2;
            }
            #endregion
        }
        public override void UpdateBadLifeRegen()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            #region Frenzy Fail
            if (Player.HasBuff(ModContent.BuffType<FrenzyFail>()))
            {
                Player.lifeRegen -= 3;
                Player.lifeRegenTime += 10;
                Player.lifeRegenCount -= 20;
            }

            if (Player.HasBuff(ModContent.BuffType<Frenzy>()))
            {
                Player.lifeRegen -= 1;
            }
            #endregion
            #region Blightproof
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
            #region Resentment/Strife
            if (Player.lifeRegen < 0)
            {
                if (StrifeCrit >= 1)
                {
                    if (Main.rand.NextBool(5))
                    {
                        for (int T = 0; T < 2; T++)
                        {
                            const int dustCount = 36; // Number of dust particles to spawn
                            const float radius = 32f; // Radius of the circle

                            for (int i = 0; i < dustCount; i++)
                            {
                                float angle = MathHelper.ToRadians(90 * 360f / dustCount); // Calculate angle for each particle

                                // Calculate position for each particle
                                float offsetX = radius * (float)Math.Cos(angle);
                                float offsetY = radius * (float)Math.Sin(angle);

                                Vector2 position = Player.position + new Vector2(offsetX, offsetY);

                                // Create dust particle
                                int dustIndex = Dust.NewDust(
                                    position,
                                    0, 0,
                                    DustID.BlueTorch,
                                    0f, -1f,
                                    100,
                                    default(Color),
                                    1.5f
                                );

                                // Set properties for the dust particle
                                Main.dust[dustIndex].noGravity = true;
                                Main.dust[dustIndex].noLight = false;
                                Main.dust[dustIndex].fadeIn = 0.2f;
                                Main.dust[dustIndex].velocity *= 0.3f;
                            }

                            // Optional: Add some random variation to the positions
                        }
                    }
                    ControlledCrit += StrifeCrit;
                }
                if (ResentmentBuff >= 1)
                {

                    if (Main.rand.NextBool(5))
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            const int dustCount = 36; // Number of dust particles to spawn
                            const float radius = 32f; // Radius of the circle

                            for (int d = 0; d < dustCount; d++)
                            {
                                float angle = MathHelper.ToRadians(180 * 360f / dustCount); // Calculate angle for each particle

                                // Calculate position for each particle
                                float offsetX = radius * (float)Math.Cos(angle);
                                float offsetY = radius * (float)Math.Sin(angle);

                                Vector2 position = Player.position + new Vector2(offsetX, offsetY);

                                // Create dust particle
                                int dustIndex = Dust.NewDust(
                                    position,
                                    0, 0,
                                    DustID.RedTorch,
                                    0f, -1f,
                                    100,
                                    default(Color),
                                    1.5f
                                );

                                // Set properties for the dust particle
                                Main.dust[dustIndex].noGravity = true;
                                Main.dust[dustIndex].noLight = false;
                                Main.dust[dustIndex].fadeIn = 0.2f;
                                Main.dust[dustIndex].velocity *= 0.3f;
                            }

                            // Optional: Add some random variation to the positions
                        }
                    }
                    ControlledAttack += ResentmentBuff;
                }
            }
            #endregion
            if (modPlayer.Heroics >= 3 && Player.HasBuff(ModContent.BuffType<Heroics>()) && Player.lifeRegen > 0)
            {
                Player.lifeRegen = 0;
            }
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
                    float basespeed = 1.5f;
                    if (SpeedSetup >= 2)
                    {
                        basespeed = 2f;
                    }
                    return basespeed;
                }
            }
            #endregion
            #region Speed Sharpening
            if (SpeedSharpening > 1f && item.type == ModContent.ItemType<WhetStone>())
            {
                return SpeedSharpening;
            }
            #endregion
            #region Focus
            if (Player.HeldItem != null && Player.HeldItem.channel && FocusSpd > 0)
            {
                return FocusSpd;
            }
            #endregion

            return base.UseSpeedMultiplier(item);
        }

        #region Honey Hunter
        public override void PostUpdate()
        {
            // Check if the player is near honey
            if (IsPlayerNearHoney() && HoneyHunter >= 1)
            {
                HoneyActive();
            }
        }

        private bool IsPlayerNearHoney()
        {
            int radius = 75;

            int playerX = (int)(Player.position.X / 16);
            int playerY = (int)(Player.position.Y / 16);

            for (int x = playerX - radius; x <= playerX + radius; x++)
            {
                for (int y = playerY - radius; y <= playerY + radius; y++)
                {
                    Tile tile = Main.tile[x, y];
                    if (tile != null && tile.LiquidType == LiquidID.Honey && tile.LiquidAmount > 0)
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
            #region Draw Hair
            if ((Player.armor[0].type == ModContent.ItemType<MizutsuneHelmX>()) && (Player.armor[10].headSlot == -1) || (Player.armor[10].type == ModContent.ItemType<MizutsuneHelmX>()))
            {
                drawInfo.fullHair = true;
            }
            if ((Player.armor[0].type == ModContent.ItemType<VangisHelmX>()) && (Player.armor[10].headSlot == -1) || (Player.armor[10].type == ModContent.ItemType<VangisHelmX>()))
            {
                drawInfo.fullHair = true;
            }
            #endregion
        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            #region Crit Boost
            if (CritBoost >= 1)
            {
                modifiers.CritDamage *= 1 + (CritBoost / 100);
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
            if (target.buffType.Any(MHLists.debuffList.Contains) && Foray >= 1)
            {
                modifiers.FinalDamage *= Foray;
            }
            #endregion
            #region Sneak Attack
            if (SneakAttack >= 1)
            {
                Vector2 relativePosition = target.Center - Player.Center;

                if ((relativePosition.X > 0 && target.direction == 1) || (relativePosition.X < 0 && target.direction == -1))
                {
                    modifiers.FinalDamage *= SneakAttack;
                }
            }
            #endregion
            #region Crit Element
            if ((MHLists.fireelementList.Contains(Player.HeldItem.type) ||
        MHLists.thunderelementList.Contains(Player.HeldItem.type) ||
        MHLists.iceelementList.Contains(Player.HeldItem.type) ||
        MHLists.waterelementList.Contains(Player.HeldItem.type)) &&
       CritEle > 0)
            {
                modifiers.CritDamage *= 1 + CritEle;
            }
            #endregion
            #region Negative Crit
            int NegCritChance = 5 - NegCrit;
            if (NegCrit >= 1 && Main.rand.NextBool(NegCritChance))
            {
                modifiers.NonCritDamage *= 1.5f;
            }

            #endregion
        }

    }
}