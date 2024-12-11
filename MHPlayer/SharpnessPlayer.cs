using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Buffs.SharpnessBuff;
using MHArmorSkills.Utilities;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public class SharpnessPlayer : ModPlayer
    {
        public int CurrentSharpness = 80;
        public int MaxSharpness = 80;

        public bool SharpnessLossAnimation;


        public bool TrueMelee;
        public bool TrueWhip;
        public bool EitherTrue;

        public int RazorSharp;

        public int MastersTouch;

        public int ChallengeSheath;
        public int ChallengeSheathCD;
        public int lastWeaponType = -1;

        public int CritDrawCrit;
        public int CritDrawCritDmg;

        public float QuickSheath;

        public int GrinderSharpness;
        public int GrinderTime;
        public int GrinderDmg;

        public float PunishDrawDmg;
        public float PunishDrawKB;

        public int Handicraft;


        public override void ResetEffects()
        {
            RazorSharp = 0;

            ChallengeSheath = 0;
            CritDrawCrit = 0;
            CritDrawCritDmg = 0;

            QuickSheath = 1f;

            PunishDrawDmg = 0f;
            PunishDrawKB = 0f;

            Handicraft = 0;

            GrinderTime = 0;
            GrinderDmg = 0;

            SharpnessLossAnimation = false;


        }
        public override void PreUpdate()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            MHPlayerArmorSkill SkillPlayer = Player.GetModPlayer<MHPlayerArmorSkill>();
            if (CurrentSharpness > MaxSharpness)
            {
                CurrentSharpness = MaxSharpness;
            }
            if (CurrentSharpness < 0)
            {
                CurrentSharpness = 0;
            }
            int MiscSharpness = 0;
            if (Main.hardMode) { MiscSharpness = 10; }
            if (NPC.downedMoonlord) { MiscSharpness = 20; }
            MaxSharpness = 80 + Handicraft + MiscSharpness;

            TrueMelee = false;
            if (Player.HeldItem != null && !Player.HeldItem.noMelee)
            {
                if (Player.HeldItem.shoot == ProjectileID.None && Player.HeldItem.useStyle == ItemUseStyleID.Swing)
                {
                    if (Player.HeldItem.shootSpeed == 0f)
                    {
                        if (Player.HeldItem.DamageType == DamageClass.Melee)
                        {
                            TrueMelee = true;
                        }
                        else
                        {
                            TrueMelee = false;
                        }

                    }

                }

            }
            int TrueMeleeMisc = Player.HeldItem.type;
            if (MHLists.TrueMeleeList.Contains(TrueMeleeMisc))
            {
                TrueMelee = true;
            }
            TrueWhip = false;
            if (Player.HeldItem != null)
            {
                if (Player.HeldItem.IsWhip())
                {
                    TrueWhip = true;
                }
                else
                {
                    TrueWhip = false;
                }

            }
            EitherTrue = false;
            if (TrueMelee || TrueWhip)
            {
                EitherTrue = true;
            }

            if (EitherTrue)
            {
                #region Challenge Sheath
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
                if (hostileNPCs >= 1)
                {
                    int currentWeaponType = Player.HeldItem.type;

                    if (currentWeaponType != lastWeaponType)
                    {
                        if (ChallengeSheathCD == 0)
                        {
                            if (modPlayer.ChallengeSheatheCloseRangeUp >= 1 && CurrentSharpness < MaxSharpness)
                            {
                                int Restored = 5 * ChallengeSheath;
                                ChallengeSheathCD = 5 * 60;
                                CurrentSharpness += Restored;
                                SoundEngine.PlaySound(SoundID.Item37, Player.Center);
                                if (QuickSheath > 0f && !Player.HasBuff(ModContent.BuffType<AttackSpeedUp>()))
                                {
                                    int Duration = (int)(12 * 60 * SkillPlayer.ProlongerTime);
                                    Player.AddBuff(ModContent.BuffType<AttackSpeedUp>(), Duration);
                                }
                            }
                        }
                    }


                    if (ChallengeSheathCD > 0)
                    {
                        ChallengeSheathCD--;
                    }

                    lastWeaponType = currentWeaponType;
                }


                #endregion



                if (GrinderSharpness < CurrentSharpness && modPlayer.Grinder >= 1 && !Player.HasBuff(ModContent.BuffType<Grinder>()))
                {
                    int Duration = (int)(GrinderTime * 60 * SkillPlayer.ProlongerTime);
                    Player.AddBuff(ModContent.BuffType<Grinder>(), Duration);
                }

                GrinderSharpness = CurrentSharpness;
            }

        }




        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (TrueMelee)
            {
                SharpnessDecrease(target, damageDone, hit.Crit);
            }

        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (TrueWhip && ProjectileID.Sets.IsAWhip[proj.type])
            {
                SharpnessDecrease(target, damageDone, hit.Crit);
            }
            int TrueMeleeMisc = Player.HeldItem.type;
            if (TrueMelee && MHLists.TrueMeleeList.Contains(TrueMeleeMisc))
            {
                SharpnessDecrease(target, damageDone, hit.Crit);
            }
        }
        #region Sharpness Loss
        public void SharpnessDecrease(NPC target, int damage, bool crit)
        {
            bool LoseSharpness = true;

            #region Razor Sharp
            if (RazorSharp >= 1)
            {
                if (Main.rand.NextBool(RazorSharp))
                {
                    LoseSharpness = false;
                }
            }


            #endregion

            #region Masters Touch
            if (MastersTouch >= 1)
            {
                bool Chance = Main.rand.NextBool(4);
                if (MastersTouch == 2)
                {
                    Chance = Main.rand.NextBool(2);
                }
                if (MastersTouch >= 3)
                {
                    Chance = !Main.rand.NextBool(4);
                }
                if (crit && Chance)
                {
                    LoseSharpness = false;
                }
            }


            #endregion

            #region Protective Polish

            if (Player.HasBuff(ModContent.BuffType<ProtectivePolish>()))
            {
                LoseSharpness = false;
            }

            #endregion

            if (Player.HasBuff(ModContent.BuffType<HeavenSent>()))
            {
                LoseSharpness = false;
            }
            if (LoseSharpness && CurrentSharpness > 0)
            {
                CurrentSharpness -= 1;
                SharpnessLossAnimation = true;
            }
        }
        #endregion



        public override void PostUpdateMiscEffects()
        {
            ElementsPlayer elementsPlayer = Player.GetModPlayer<ElementsPlayer>();
            if (EitherTrue)
            {
                #region Sharpness Colour
                if (CurrentSharpness == 0)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessRed>(), 2);
                    if (TrueMelee)
                    {
                        Player.GetDamage(DamageClass.Melee) -= 0.25f;
                    }
                    if (TrueWhip)
                    {
                        Player.GetDamage(DamageClass.SummonMeleeSpeed) -= 0.25f;
                    }

                }
                if (CurrentSharpness > 0 && CurrentSharpness <= 50)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessYellow>(), 2);
                }
                if (CurrentSharpness > 50 && CurrentSharpness <= 100)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessGreen>(), 2);
                    if (TrueMelee)
                    {
                        Player.GetDamage(DamageClass.Melee) += 0.05f;
                    }
                    if (TrueWhip)
                    {
                        Player.GetDamage(DamageClass.SummonMeleeSpeed) += 0.05f;
                    }
                }
                if (CurrentSharpness > 100 && CurrentSharpness <= 135)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessBlue>(), 2);
                    if (TrueMelee)
                    {
                        Player.GetDamage(DamageClass.Melee) += 0.2f;
                    }
                    if (TrueWhip)
                    {
                        Player.GetDamage(DamageClass.SummonMeleeSpeed) += 0.2f;
                        Player.whipRangeMultiplier *= 1.15f;
                    }
                    elementsPlayer.SharpnessBuff += 0.06f;
                }
                if (CurrentSharpness > 135 && CurrentSharpness <= 160)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessWhite>(), 2);
                    if (TrueMelee)
                    {
                        Player.GetDamage(DamageClass.Melee) += 0.32f;
                    }
                    if (TrueWhip)
                    {
                        Player.GetDamage(DamageClass.SummonMeleeSpeed) += 0.32f;
                    }
                    elementsPlayer.SharpnessBuff += 0.15f;
                }
                if (CurrentSharpness > 160)
                {
                    Player.AddBuff(ModContent.BuffType<SharpnessPurple>(), 2);
                    if (TrueMelee)
                    {
                        Player.GetDamage(DamageClass.Melee) += 0.45f; ;
                    }
                    if (TrueWhip)
                    {
                        Player.GetDamage(DamageClass.SummonMeleeSpeed) += 0.45f;
                        Player.whipRangeMultiplier *= 1.3f;
                    }
                    elementsPlayer.SharpnessBuff += 0.25f;
                }
                #endregion

                Player.GetCritChance(DamageClass.Melee) += CritDrawCrit;
                Player.GetDamage(DamageClass.Melee) += PunishDrawDmg;
                Player.GetKnockback(DamageClass.Melee) += PunishDrawKB;
                if (Player.HasBuff(ModContent.BuffType<Grinder>()))
                {
                    Player.GetDamage(DamageClass.Melee) += GrinderDmg / 100f;
                    Player.GetDamage(DamageClass.SummonMeleeSpeed) += GrinderDmg / 100f;
                }
                if (Player.HasBuff(ModContent.BuffType<AttackSpeedUp>()) && QuickSheath > 0)
                {
                    QuickSheath += 0.25f;
                }
            }

        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            #region Crit Boost
            if (CritDrawCritDmg >= 1)
            {
                modifiers.CritDamage *= 1 + (CritDrawCritDmg / 100);
            }
            #endregion
        }
        public override float UseSpeedMultiplier(Item item)

        {
            if (EitherTrue)
            {
                return QuickSheath;
            }
            return base.UseSpeedMultiplier(item);
        }
    }
}
