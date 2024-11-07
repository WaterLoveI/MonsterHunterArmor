﻿using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Items.Accessories.Decorations;
using MHArmorSkills.Items.Weapons;
using MHArmorSkills.NPCs.NormalNPC;
using MHArmorSkills.NPCs.NormalNPC.Bugs;
using MHArmorSkills.Projectiles.Enemy;
using System.Collections.Generic;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace MHArmorSkills
{
    public class MHLists
    {
        public static List<int> debuffList;
        public static List<int> buffList;
        public static List<int> fireelementList;
        public static List<int> waterelementList;
        public static List<int> thunderelementList;
        public static List<int> iceelementList;
        public static List<int> fireresList;
        public static List<int> waterresList;
        public static List<int> thunderresList;
        public static List<int> iceresList;
        public static List<int> fireresprojList;
        public static List<int> waterresprojList;
        public static List<int> thunderresprojList;
        public static List<int> iceresprojList;
        public static List<int> ArmorDecorations;
        public static List<int> OneSlotDecorations;
        public static List<int> TwoSlotDecorations;
        public static List<int> ThreeSlotDecorations;
        public static List<int> OutdoorsmanList;
        public static void LoadLists()
        {
            debuffList = new List<int>()
            {
                BuffID.Poisoned,
                BuffID.Darkness,
                BuffID.Cursed,
                BuffID.OnFire,
                BuffID.Bleeding,
                BuffID.Confused,
                BuffID.Slow,
                BuffID.Weak,
                BuffID.Silenced,
                BuffID.BrokenArmor,
                BuffID.CursedInferno,
                BuffID.Frostburn,
                BuffID.Chilled,
                BuffID.Frozen,
                BuffID.Burning,
                BuffID.Suffocation,
                BuffID.Ichor,
                BuffID.Venom,
                BuffID.Blackout,
                BuffID.Electrified,
                BuffID.Rabies,
                BuffID.Webbed,
                BuffID.Stoned,
                BuffID.Dazed,
                BuffID.VortexDebuff,
                BuffID.WitheredArmor,
                BuffID.WitheredWeapon,
                BuffID.OgreSpit,
                BuffID.BetsysCurse,
                BuffType<FrenzyFail>(),
                BuffType<BubbleBlight>(),
                BuffType<BlastBlight>(),
                BuffType<FireBlight>(),
                BuffType<WaterBlight>(),
                BuffType<IceBlight>(),
                BuffType<ThunderBlight>(),
            };
            buffList = new List<int>()
            {
                BuffID.AmmoReservation,
                BuffID.Archery,
                BuffID.Battle,
                BuffID.Builder,
                BuffID.BiomeSight,
                BuffID.Calm,
                BuffID.Crate,
                BuffID.Dangersense,
                BuffID.Endurance,
                BuffID.WellFed,
                BuffID.WellFed2,
                BuffID.WellFed3,
                BuffID.Featherfall,
                BuffID.Fishing,
                BuffID.Flipper,
                BuffID.Gills,
                BuffID.Gravitation,
                BuffID.Heartreach,
                BuffID.Hunter,
                BuffID.Inferno,
                BuffID.Invisibility,
                BuffID.Ironskin,
                BuffID.Lifeforce,
                BuffID.Lucky,
                BuffID.MagicPower,
                BuffID.ManaRegeneration,
                BuffID.Mining,
                BuffID.NightOwl,
                BuffID.ObsidianSkin,
                BuffID.Rage,
                BuffID.Regeneration,
                BuffID.Shine,
                BuffID.Sonar,
                BuffID.Spelunker,
                BuffID.Summoning,
                BuffID.Swiftness,
                BuffID.Thorns,
                BuffID.Titan,
                BuffID.Warmth,
                BuffID.WaterWalking,
                BuffID.Wrath,

            };
            fireelementList = new List<int>()
            {
                ItemID.FieryGreatsword,
                3823, // Brand of Inferno
                3827, // Flying Dragon
                ItemID.HelFire,
                ItemID.Flamarang,
                ItemID.FlamingMace,
                ItemID.Sunfury,
                ItemID.MoltenPickaxe,
                ItemID.MoltenHamaxe,
                ItemID.Cascade,
                ItemID.WaffleIron,
                ItemID.ButchersChainsaw,
                3858, // Sky Dragon's Fury
                ItemID.DayBreak,
                ItemID.SolarEruption,
                ItemID.FlamingArrow,
                ItemID.HellwingBow,
                ItemID.MoltenFury,
                3854, // Phantom Phoenix
                3859, // Aerial Bane
                ItemID.PhoenixBlaster,
                ItemID.Flamethrower,
                ItemID.WandofSparking,
                ItemID.Flamelash,
                ItemID.FlowerofFire,
                ItemID.InfernoFork,
                3870, // Betsy's Wrath
                ItemID.HeatRay,
                ItemID.CursedFlames,
                ItemID.ImpStaff,
                ItemID.DD2FlameburstTowerT1Popper,
                ItemID.DD2FlameburstTowerT2Popper,
                ItemID.DD2FlameburstTowerT3Popper,
                ItemID.FireWhip,
                ItemID.TheHorsemansBlade,
                ItemID.ShadowFlameBow,
                ItemID.ShadowFlameHexDoll,
                ItemID.ElfMelter,
                ItemID.LunarFlareBook,
                ItemID.SpiritFlame,
                ItemID.ObsidianSwordfish,
                3836, // Ghastly Glaive
            };
            waterelementList = new List<int>()
            {
                ItemID.Swordfish,
                ItemID.Trident,
                ItemID.ObsidianSwordfish,
                ItemID.DripplerFlail,
                ItemID.Flairon,
                ItemID.BombFish,
                ItemID.BloodRainBow,
                ItemID.PulseBow,
                ItemID.Tsunami,
                ItemID.Minishark,
                ItemID.Gatligator,
                ItemID.Megashark,
                ItemID.SDMG,
                ItemID.Xenopopper,
                ItemID.Toxikarp,
                ItemID.PiranhaGun,
                ItemID.Harpoon,
                ItemID.AquaScepter,
                ItemID.CrystalSerpent,
                ItemID.BubbleGun,
                ItemID.WaterBolt,
                ItemID.RazorbladeTyphoon,
                ItemID.VampireFrogStaff,
                ItemID.TempestStaff,
                ItemID.TentacleSpike,
                ItemID.TragicUmbrella,
                ItemID.WaterBolt,
                ItemID.HolyWater,
                ItemID.UnholyWater,
                ItemID.BloodWater,
                ItemID.TitaniumTrident,
                ItemID.Xenopopper,
                ItemID.PirateStaff,
                ItemID.GoldenShower,

            };
            thunderelementList = new List<int>()
            {
                ItemID.BluePhasesaber,
                ItemID.RedPhasesaber,
                ItemID.GreenPhasesaber,
                ItemID.YellowPhasesaber,
                ItemID.PurplePhasesaber,
                ItemID.WhitePhasesaber,
                ItemID.BluePhaseblade,
                ItemID.RedPhaseblade,
                ItemID.GreenPhaseblade,
                ItemID.YellowPhaseblade,
                ItemID.PurplePhaseblade,
                ItemID.WhitePhaseblade,
                ItemID.InfluxWaver,
                ItemID.ElectrosphereLauncher,
                ItemID.Phantasm,
                ItemID.VortexBeater,
                ItemID.VortexAxe,
                ItemID.VortexHammer,
                ItemID.VortexPickaxe,
                ItemID.ThunderSpear,
                ItemID.ThunderStaff,
                ItemID.ZapinatorGray,
                ItemID.ZapinatorOrange,
                ItemID.LaserMachinegun,
                ItemID.ChargedBlasterCannon,
                ItemID.MagnetSphere,
                ItemID.NimbusRod,
                ItemID.DeadlySphereStaff,
                ItemID.XenoStaff,
                ItemID.DD2LightningAuraT1Popper,
                ItemID.DD2LightningAuraT2Popper,
                ItemID.DD2LightningAuraT3Popper,
                ItemID.LightDisc,
                ItemID.StarCannon,
                ItemID.SuperStarCannon,
                ItemID.StardustCellStaff,
                ItemID.StardustDragonStaff,
                ItemID.LaserRifle,
                ItemID.SpaceGun,
            };
            iceelementList = new List<int>()
            {
                ItemID.IceBlade,
                ItemID.IceSickle,
                ItemID.Frostbrand,
                ItemID.ChristmasTreeSword,
                ItemID.NorthPole,
                ItemID.IceBoomerang,
                ItemID.IceBow,
                ItemID.FrostDaggerfish,
                ItemID.SnowballCannon,
                ItemID.Snowball,
                ItemID.FrostburnArrow,
                ItemID.SnowmanCannon,
                ItemID.WandofFrosting,
                ItemID.FrostStaff,
                ItemID.BlizzardStaff,
                ItemID.IceRod,
                ItemID.FlowerofFrost,
                ItemID.FlinxStaff,
                ItemID.StaffoftheFrostHydra,
                ItemID.CoolWhip,
                ItemID.SnowmanCannon,
                ItemID.Amarok,
                ItemID.ElfMelter,
                ItemType<FrozenSpearTuna>(),
            };
            fireresList = new List<int>()
            {
                NPCID.BurningSphere,
                NPCID.FireImp,
                NPCID.Hellbat,
                NPCID.LavaSlime,
                NPCID.MeteorHead,
                NPCID.VoodooDemon,
                NPCID.DesertDjinn,
                NPCID.HellArmoredBonesMace,
                NPCID.HellArmoredBonesSpikeShield,
                NPCID.HellArmoredBonesSword,
                NPCID.Lavabat,
                NPCID.RedDevil,
                NPCID.ShadowFlameApparition,
                NPCID.SolarCorite,
                NPCID.SolarCrawltipedeHead,
                NPCID.SolarDrakomire,
                NPCID.SolarDrakomireRider,
                NPCID.SolarSolenian,
                NPCID.SolarSroller,
                NPCID.DD2Betsy,
            };
            waterresList = new List<int>()
            {
                NPCID.WaterSphere,
                NPCID.GiantShelly,
                NPCID.GiantShelly2,
                NPCID.PinkJellyfish,
                NPCID.Piranha,
                NPCID.SeaSnail,
                NPCID.Shark,
                NPCID.Squid,
                NPCID.BlueJellyfish,
                NPCID.Arapaima,
                NPCID.BloodJelly,
                NPCID.FungoFish,
                NPCID.Gastropod,
                NPCID.GiantTortoise,
                NPCID.GreenJellyfish,
                NPCID.BloodEelHead,
                NPCID.BloodSquid,
                NPCID.BloodNautilus,
                NPCID.Drippler,
                NPCID.GoblinShark,
                NPCID.CorruptGoldfish,
                NPCID.CrimsonGoldfish,
                NPCID.ZombieMerman,
                NPCID.EyeballFlyingFish,
                NPCID.FlyingFish,
                NPCID.ZombieRaincoat,
                NPCID.UmbrellaSlime,
                NPCID.CreatureFromTheDeep,
                NPCID.SwampThing,
                NPCID.DukeFishron,
                NPCType<BubblesNPC>(),
                NPCType<Hermitaur>(),
            };
            thunderresList = new List<int>()
            {
                NPCID.BlueJellyfish,
                NPCID.GreenJellyfish,
                NPCID.PinkJellyfish,
                NPCID.ChaosElemental,
                NPCID.CrimsonAxe,
                NPCID.EnchantedSword,
                NPCID.CursedHammer,
                NPCID.DungeonSpirit,
                NPCID.MartianProbe,
                NPCID.Pixie,
                NPCID.AngryNimbus,
                NPCID.DD2LightningBugT3,
                NPCID.DeadlySphere,
                NPCID.BrainScrambler,
                NPCID.GigaZapper,
                NPCID.MartianDrone,
                NPCID.MartianEngineer,
                NPCID.MartianOfficer,
                NPCID.MartianWalker,
                NPCID.RayGunner,
                NPCID.ScutlixRider,
                NPCID.MartianTurret,
                NPCID.MartianSaucer,
                NPCType<ThunderBugs>(),
            };
            iceresList = new List<int>()
            {
                NPCID.ZombieEskimo,
                NPCID.IceBat,
                NPCID.IceSlime,
                NPCID.SnowFlinx,
                NPCID.SpikedIceSlime,
                NPCID.UndeadViking,
                NPCID.IceElemental,
                NPCID.IceMimic,
                NPCID.IceTortoise,
                NPCID.IcyMerman,
                NPCID.CorruptPenguin,
                NPCID.CrimsonPenguin,
                NPCID.IceGolem,
                NPCID.MisterStabby,
                NPCID.SnowBalla,
                NPCID.SnowmanGangsta,
                NPCID.Flocko,
                NPCID.Yeti,
                NPCID.IceQueen,
            };
            fireresprojList = new List<int>()
            {
                ProjectileID.CursedFlameHostile,
                ProjectileID.FlamingArrow,
                ProjectileID.EyeLaser,
                ProjectileID.FlamethrowerTrap,
                ProjectileID.CursedFlameHostile,
                ProjectileID.FlamesTrap,
                ProjectileID.InfernoHostileBlast,
                ProjectileID.InfernoHostileBolt,
                ProjectileID.GreekFire1,
                ProjectileID.GreekFire2,
                ProjectileID.GreekFire3,
                ProjectileID.FlamingScythe,
                ProjectileID.ImpFireball,
                ProjectileID.CultistBossFireBall,
                ProjectileID.CultistBossFireBallClone,
                ProjectileID.DesertDjinnCurse,
                ProjectileID.DD2BetsyFireball,
            };
            waterresprojList = new List<int>()
            {
                ProjectileID.RainNimbus,
                ProjectileID.GoldenShowerHostile,
                ProjectileID.Sharknado,
                ProjectileID.SharknadoBolt,
                ProjectileID.BloodShot,
                ProjectileID.BloodNautilusShot,
                ProjectileType<SeltasGoop>(),
            };
            thunderresprojList = new List<int>()
            {
                ProjectileID.EyeBeam,
                ProjectileID.EyeLaser,
                ProjectileID.DeathLaser,
                ProjectileID.PinkLaser,
                ProjectileID.MartianTurretBolt,
                ProjectileID.BrainScramblerBolt,
                ProjectileID.GigaZapperSpear,
                ProjectileID.RayGunnerLaser,
                ProjectileID.PhantasmalDeathray,
                ProjectileID.DD2LightningBugZap,
                ProjectileID.StardustSoldierLaser,
                ProjectileID.Twinkle,
                ProjectileID.NebulaLaser,
                ProjectileID.VortexLaser,
                ProjectileID.VortexVortexLightning,
                ProjectileType<DesertSeltasGoop>(),
            };
            iceresprojList = new List<int>()
            {
                ProjectileID.SnowBallHostile,
                ProjectileID.FrostBeam,
                ProjectileID.FrostWave,
                ProjectileID.FrostShard,
                ProjectileID.CultistBossIceMist,
                ProjectileID.DeerclopsIceSpike,
            };
            ArmorDecorations = new List<int>()
            {
                ItemType<AdrenalineRush1>(),
                ItemType<AdrenalineRush2>(),
                ItemType<AffinitySliding1>(),
                ItemType<AffinitySliding2>(),
                ItemType<AquaticMobility1>(),
                ItemType<AquaticMobility2>(),
                ItemType<AquaticMobility3>(),
                ItemType<Artillery1>(),
                ItemType<Artillery2>(),
                ItemType<Atk1>(),
                ItemType<Atk2>(),
                ItemType<AutoGuard1>(),
                ItemType<AutoReload1>(),
                ItemType<AutoTracker1>(),
                ItemType<AutoTracker2>(),
                ItemType<BBQExpert1>(),
                ItemType<BBQExpert2>(),
                ItemType<Berserk1>(),
                ItemType<BladehoneScale1>(),
                ItemType<BladehoneScale2>(),
                ItemType<Bleeding1>(),
                ItemType<Blightproof1>(),
                ItemType<Blightproof2>(),
                ItemType<Bloodlust1>(),
                ItemType<Bloodlust2>(),
                ItemType<BloodRite1>(),
                ItemType<BloodRite2>(),
                ItemType<BubbleDance1>(),
                ItemType<BubbleDance2>(),
                ItemType<BubbleDance3>(),
                ItemType<Carving1>(),
                ItemType<ChallengeSheath1>(),
                ItemType<ChallengeSheath2>(),
                ItemType<ChameleosBless1>(),
                ItemType<Cliffhanger1>(),
                ItemType<Cliffhanger2>(),
                ItemType<Coalescence1>(),
                ItemType<Coalescence2>(),
                ItemType<ColdRes1>(),
                ItemType<ColdRes2>(),
                ItemType<Constitution1>(),
                ItemType<Constitution2>(),
                ItemType<Counterstrike1>(),
                ItemType<Counterstrike2>(),
                ItemType<CritBoost1>(),
                ItemType<CritBoost2>(),
                ItemType<CritDraw1>(),
                ItemType<CritDraw2>(),
                ItemType<CritElement1>(),
                ItemType<CritElement2>(),
                ItemType<CritEye1>(),
                ItemType<CritEye2>(),
                ItemType<Defense1>(),
                ItemType<Defense2>(),
                ItemType<Defense3>(),
                ItemType<Defiance1>(),
                ItemType<Defiance3>(),
                ItemType<DefLock1>(),
                ItemType<Dereliction1>(),
                ItemType<Diversion1>(),
                ItemType<Diversion3>(),
                ItemType<Elemental1>(),
                ItemType<Elemental2>(),
                ItemType<Embolden1>(),
                ItemType<Embolden2>(),
                ItemType<EvadeDistance1>(),
                ItemType<EvadeDistance2>(),
                ItemType<Evasion1>(),
                ItemType<Evasion2>(),
                ItemType<Fate1>(),
                ItemType<Fate2>(),
                ItemType<Fencing1>(),
                ItemType<Fencing2>(),
                ItemType<FireAttack1>(),
                ItemType<FireAttack2>(),
                ItemType<FireAttack3>(),
                ItemType<FireRes1>(),
                ItemType<FireRes2>(),
                ItemType<FishingExpert1>(),
                ItemType<FishingExpert2>(),
                ItemType<Focus1>(),
                ItemType<Focus2>(),
                ItemType<Foray1>(),
                ItemType<Foray2>(),
                ItemType<Fortified1>(),
                ItemType<FreeMeal1>(),
                ItemType<FreeMeal2>(),
                ItemType<FreeMeal3>(),
                ItemType<Furious1>(),
                ItemType<Gathering1>(),
                ItemType<Gathering2>(),
                ItemType<Geologist1>(),
                ItemType<Geologist2>(),
                ItemType<Gluttony1>(),
                ItemType<Gluttony2>(),
                ItemType<Gluttony3>(),
                ItemType<Grinder1>(),
                ItemType<Grinder2>(),
                ItemType<Guard1>(),
                ItemType<Guard2>(),
                ItemType<GuardUp1>(),
                ItemType<GuardUp2>(),
                ItemType<Handicraft1>(),
                ItemType<Handicraft2>(),
                ItemType<HastenRecovery1>(),
                ItemType<HastenRecovery2>(),
                ItemType<Health1>(),
                ItemType<Health2>(),
                ItemType<HeatRes1>(),
                ItemType<HeatRes2>(),
                ItemType<Heroics1>(),
                ItemType<Heroics2>(),
                ItemType<HeroShield1>(),
                ItemType<HeroShield2>(),
                ItemType<HoneyHunter1>(),
                ItemType<HoneyHunter2>(),
                ItemType<IceAttack1>(),
                ItemType<IceAttack2>(),
                ItemType<IceAttack3>(),
                ItemType<IceRes1>(),
                ItemType<IceRes2>(),
                ItemType<IntrepidHeart1>(),
                ItemType<JumpMaster1>(),
                ItemType<JumpMaster2>(),
                ItemType<JumpMaster3>(),
                ItemType<KushalaBless1>(),
                ItemType<LastingPower1>(),
                ItemType<LastingPower2>(),
                ItemType<LastingPower3>(),
                ItemType<LatentPower1>(),
                ItemType<LatentPower2>(),
                ItemType<MailofHellfire1>(),
                ItemType<MastersTouch1>(),
                ItemType<MastersTouch2>(),
                ItemType<MaximumMight1>(),
                ItemType<MaximumMight2>(),
                ItemType<Mushroomancer1>(),
                ItemType<Mushroomancer2>(),
                ItemType<NegativeCrit1>(),
                ItemType<NegativeCrit2>(),
                ItemType<OffensiveGuard1>(),
                ItemType<OffensiveGuard2>(),
                ItemType<Outdoorsman1>(),
                ItemType<Outdoorsman3>(),
                ItemType<Poison1>(),
                ItemType<Poison2>(),
                ItemType<PoisonCoating1>(),
                ItemType<PolarHunter1>(),
                ItemType<PolarHunter2>(),
                ItemType<PowerProlonger1>(),
                ItemType<Protection1>(),
                ItemType<Protection2>(),
                ItemType<ProtectivePolish1>(),
                ItemType<ProtectivePolish3>(),
                ItemType<PunishDraw1>(),
                ItemType<PunishDraw2>(),
                ItemType<QuickSheath1>(),
                ItemType<QuickBreath1>(),
                ItemType<QuickSheath3>(),
                ItemType<RazorSharp1>(),
                ItemType<RazorSharp3>(),
                ItemType<RecoverySpd1>(),
                ItemType<RecoverySpd3>(),
                ItemType<RecUp1>(),
                ItemType<RecUp3>(),
                ItemType<Redirection1>(),
                ItemType<Redirection2>(),
                ItemType<Resentment1>(),
                ItemType<Resentment2>(),
                ItemType<Resuscitate1>(),
                ItemType<Resuscitate2>(),
                ItemType<RockSteady1>(),
                ItemType<Scholar1>(),
                ItemType<Scholar2>(),
                ItemType<Sneak1>(),
                ItemType<Sneak3>(),
                ItemType<SneakAttack1>(),
                ItemType<SneakAttack2>(),
                ItemType<SpeedEating1>(),
                ItemType<SpeedEating2>(),
                ItemType<SpeedSetUp1>(),
                ItemType<SpeedSetUp2>(),
                ItemType<SpeedSharpening1>(),
                ItemType<SpeedSharpening3>(),
                ItemType<Spirit1>(),
                ItemType<Spirit2>(),
                ItemType<SpiritBirdsCall1>(),
                ItemType<SpiritBirdsCall1>(),
                ItemType<StaminaRecovery1>(),
                ItemType<StaminaRecovery3>(),
                ItemType<StatusTrigger1>(),
                ItemType<StatusTrigger2>(),
                ItemType<Strife1>(),
                ItemType<Strife2>(),
                ItemType<StunResist1>(),
                ItemType<StunResist2>(),
                ItemType<SurvivalExpert1>(),
                ItemType<SurvivalExpert2>(),
                ItemType<Tenderizer1>(),
                ItemType<Tenderizer2>(),
                ItemType<TeostraBless1>(),
                ItemType<ThunderAttack1>(),
                ItemType<ThunderAttack2>(),
                ItemType<ThunderAttack3>(),
                ItemType<ThunderRes1>(),
                ItemType<ThunderRes2>(),
                ItemType<TropicsHunter1>(),
                ItemType<TropicsHunter2>(),
                ItemType<TremorRes1>(),
                ItemType<TremorRes2>(),
                ItemType<TremorRes3>(),
                ItemType<Unscathed1>(),
                ItemType<Unscathed2>(),
                ItemType<Vault1>(),
                ItemType<Vault2>(),
                ItemType<WaterAttack1>(),
                ItemType<WaterAttack2>(),
                ItemType<WaterAttack3>(),
                ItemType<WaterRes1>(),
                ItemType<WaterRes2>(),
                ItemType<Windproof1>(),
                ItemType<Windproof2>(),
                ItemType<Windproof3>(),
            };
            OneSlotDecorations = new List<int>()
            {
                ItemType<AquaticMobility1>(),
                ItemType<AutoReload1>(),
                ItemType<AutoTracker1>(),
                ItemType<BBQExpert1>(),
                ItemType<Bleeding1>(),
                ItemType<BubbleDance1>(),
                ItemType<Cliffhanger1>(),
                ItemType<ChameleosBless1>(),
                ItemType<ColdRes1>(),
                ItemType<Defense1>(),
                ItemType<Defiance1>(),
                ItemType<DefLock1>(),
                ItemType<Diversion1>(),
                ItemType<FireAttack1>(),
                ItemType<FireRes1>(),
                ItemType<FishingExpert1>(),
                ItemType<Fortified1>(),
                ItemType<FreeMeal1>(),
                ItemType<Gathering1>(),
                ItemType<Geologist1>(),
                ItemType<Gluttony1>(),
                ItemType<HeatRes1>(),
                ItemType<HoneyHunter1>(),
                ItemType<IceAttack1>(),
                ItemType<IceRes1>(),
                ItemType<IntrepidHeart1>(),
                ItemType<JumpMaster1>(),
                ItemType<KushalaBless1>(),
                ItemType<LastingPower1>(),
                ItemType<Mushroomancer1>(),
                ItemType<Outdoorsman1>(),
                ItemType<Poison1>(),
                ItemType<PoisonCoating1>(),
                ItemType<ProtectivePolish1>(),
                ItemType<QuickSheath1>(),
                ItemType<RazorSharp1>(),
                ItemType<RecoverySpd1>(),
                ItemType<RecUp1>(),
                ItemType<RockSteady1>(),
                ItemType<Scholar1>(),
                ItemType<Sneak1>(),
                ItemType<SpeedEating1>(),
                ItemType<SpeedSetUp1>(),
                ItemType<SpeedSharpening1>(),
                ItemType<SpiritBirdsCall1>(),
                ItemType<StaminaRecovery1>(),
                ItemType<StunResist1>(),
                ItemType<TeostraBless1>(),
                ItemType<ThunderAttack1>(),
                ItemType<ThunderRes1>(),
                ItemType<TremorRes1>(),
                ItemType<WaterAttack1>(),
                ItemType<WaterRes1>(),
                ItemType<Windproof1>(),
            };
            TwoSlotDecorations = new List<int>()
            {
                ItemType<AdrenalineRush1>(),
                ItemType<AffinitySliding1>(),
                ItemType<AquaticMobility2>(),
                ItemType<Artillery1>(),
                ItemType<Atk1>(),
                ItemType<AutoGuard1>(),
                ItemType<AutoTracker2>(),
                ItemType<BBQExpert2>(),
                ItemType<BladehoneScale1>(),
                ItemType<Blightproof1>(),
                ItemType<Bloodlust1>(),
                ItemType<BloodRite1>(),
                ItemType<BubbleDance2>(),
                ItemType<Carving1>(),
                ItemType<ChallengeSheath1>(),
                ItemType<Cliffhanger2>(),
                ItemType<Coalescence1>(),
                ItemType<ColdRes2>(),
                ItemType<Constitution1>(),
                ItemType<Counterstrike1>(),
                ItemType<CritBoost1>(),
                ItemType<CritDraw1>(),
                ItemType<CritElement1>(),
                ItemType<CritEye1>(),
                ItemType<Defense2>(),
                ItemType<Elemental1>(),
                ItemType<Embolden1>(),
                ItemType<EvadeDistance1>(),
                ItemType<Evasion1>(),
                ItemType<Fate1>(),
                ItemType<Fencing1>(),
                ItemType<FireAttack2>(),
                ItemType<FireRes2>(),
                ItemType<FishingExpert2>(),
                ItemType<Focus1>(),
                ItemType<Foray1>(),
                ItemType<FreeMeal2>(),
                ItemType<Gathering2>(),
                ItemType<Geologist2>(),
                ItemType<Gluttony2>(),
                ItemType<Grinder1>(),
                ItemType<Guard1>(),
                ItemType<GuardUp1>(),
                ItemType<Handicraft1>(),
                ItemType<HastenRecovery1>(),
                ItemType<Health1>(),
                ItemType<HeatRes2>(),
                ItemType<Heroics1>(),
                ItemType<HeroShield1>(),
                ItemType<HoneyHunter2>(),
                ItemType<IceAttack2>(),
                ItemType<IceRes2>(),
                ItemType<JumpMaster2>(),
                ItemType<LastingPower2>(),
                ItemType<LatentPower1>(),
                ItemType<LatentPower2>(),
                ItemType<MastersTouch1>(),
                ItemType<MaximumMight1>(),
                ItemType<Mushroomancer2>(),
                ItemType<NegativeCrit1>(),
                ItemType<OffensiveGuard1>(),
                ItemType<Poison2>(),
                ItemType<PolarHunter1>(),
                ItemType<PolarHunter2>(),
                ItemType<Protection1>(),
                ItemType<PunishDraw1>(),
                ItemType<Redirection1>(),
                ItemType<Resentment1>(),
                ItemType<Resuscitate1>(),
                ItemType<Scholar2>(),
                ItemType<SneakAttack1>(),
                ItemType<SpeedEating2>(),
                ItemType<SpeedSetUp2>(),
                ItemType<Spirit1>(),
                ItemType<StatusTrigger1>(),
                ItemType<Strife1>(),
                ItemType<StunResist2>(),
                ItemType<SurvivalExpert1>(),
                ItemType<Tenderizer1>(),
                ItemType<ThunderAttack2>(),
                ItemType<ThunderRes2>(),
                ItemType<TremorRes2>(),
                ItemType<TropicsHunter1>(),
                ItemType<Unscathed1>(),
                ItemType<Vault1>(),
                ItemType<WaterAttack2>(),
                ItemType<WaterRes2>(),
                ItemType<Windproof2>(),
            };
            ThreeSlotDecorations = new List<int>()
            {
                ItemType<AdrenalineRush2>(),
                ItemType<AffinitySliding2>(),
                ItemType<AquaticMobility3>(),
                ItemType<Artillery2>(),
                ItemType<Atk2>(),
                ItemType<Berserk1>(),
                ItemType<BladehoneScale2>(),
                ItemType<Blightproof2>(),
                ItemType<Bloodlust2>(),
                ItemType<BloodRite2>(),
                ItemType<BubbleDance3>(),
                ItemType<ChallengeSheath2>(),
                ItemType<Coalescence2>(),
                ItemType<Constitution2>(),
                ItemType<Counterstrike2>(),
                ItemType<CritBoost2>(),
                ItemType<CritDraw2>(),
                ItemType<CritElement2>(),
                ItemType<CritEye2>(),
                ItemType<Defense3>(),
                ItemType<Defiance3>(),
                ItemType<Dereliction1>(),
                ItemType<Diversion3>(),
                ItemType<Elemental2>(),
                ItemType<Embolden2>(),
                ItemType<EvadeDistance2>(),
                ItemType<Evasion2>(),
                ItemType<Fate2>(),
                ItemType<Fencing2>(),
                ItemType<FireAttack3>(),
                ItemType<Focus2>(),
                ItemType<Foray2>(),
                ItemType<FreeMeal3>(),
                ItemType<Furious1>(),
                ItemType<Gluttony3>(),
                ItemType<Grinder2>(),
                ItemType<Guard2>(),
                ItemType<GuardUp2>(),
                ItemType<Handicraft2>(),
                ItemType<HastenRecovery2>(),
                ItemType<Health2>(),
                ItemType<Heroics2>(),
                ItemType<HeroShield2>(),
                ItemType<IceAttack3>(),
                ItemType<JumpMaster3>(),
                ItemType<LastingPower3>(),
                ItemType<LatentPower2>(),
                ItemType<MailofHellfire1>(),
                ItemType<MastersTouch2>(),
                ItemType<MaximumMight2>(),
                ItemType<NegativeCrit2>(),
                ItemType<OffensiveGuard2>(),
                ItemType<Outdoorsman3>(),
                ItemType<PolarHunter2>(),
                ItemType<Protection2>(),
                ItemType<ProtectivePolish3>(),
                ItemType<PunishDraw2>(),
                ItemType<QuickSheath1>(),
                ItemType<QuickBreath1>(),
                ItemType<QuickSheath3>(),
                ItemType<RazorSharp3>(),
                ItemType<RecoverySpd3>(),
                ItemType<RecUp3>(),
                ItemType<Redirection2>(),
                ItemType<Resentment2>(),
                ItemType<Resuscitate2>(),
                ItemType<Sneak3>(),
                ItemType<SneakAttack2>(),
                ItemType<SpeedSharpening3>(),
                ItemType<Spirit2>(),
                ItemType<StaminaRecovery3>(),
                ItemType<StatusTrigger2>(),
                ItemType<Strife2>(),
                ItemType<SurvivalExpert2>(),
                ItemType<Tenderizer2>(),
                ItemType<ThunderAttack3>(),
                ItemType<TremorRes3>(),
                ItemType<TropicsHunter2>(),
                ItemType<Unscathed2>(),
                ItemType<Vault2>(),
                ItemType<WaterAttack3>(),
                ItemType<Windproof3>(),
            };
            OutdoorsmanList = new List<int>()
            {
                // wood
                ItemID.Wood,
                ItemID.RichMahogany,
                ItemID.Ebonwood,
                ItemID.Shadewood,
                ItemID.Pearlwood,
                ItemID.BorealWood,
                ItemID.PalmWood,
                ItemID.SpookyWood,
                ItemID.AshWood,
                ItemID.Cactus, //idk
                ItemID.BambooBlock,
                ItemID.Pumpkin,
                //misc
                ItemID.Cobweb,
                ItemID.Vine,
                ItemID.Sunflower,
                ItemID.LifeFruit,
                //moss
                ItemID.GreenMoss,
                ItemID.BrownMoss,
                ItemID.RedMoss,
                ItemID.BlueMoss,
                ItemID.PurpleMoss,
                ItemID.LavaMoss,
                ItemID.KryptonMoss,
                ItemID.XenonMoss,
                ItemID.ArgonMoss,
                ItemID.RainbowMoss,
                ItemID.VioletMoss,
                //herbs
                ItemID.Blinkroot,
                ItemID.Daybloom,
                ItemID.Deathweed,
                ItemID.Fireblossom,
                ItemID.Moonglow,
                ItemID.Shiverthorn,
                ItemID.Waterleaf,
                //mushrooms
                ItemID.Mushroom,
                ItemID.GlowingMushroom,
                ItemID.VileMushroom,
                ItemID.ViciousMushroom,
                ItemID.GreenMushroom,
                ItemID.TealMushroom,
                // dye flower
                ItemID.SkyBlueFlower,
                ItemID.BlueBerries,
                ItemID.LimeKelp,
                ItemID.YellowMarigold,
                ItemID.PinkPricklyPear,
                ItemID.OrangeBloodroot,
                ItemID.StrangePlant1,
                ItemID.StrangePlant2,
                ItemID.StrangePlant3,
                ItemID.StrangePlant4,
            };
        }
        public static void UnloadLists()
        {
            debuffList = null;
            fireelementList = null;
            waterelementList = null;
            thunderelementList = null;
            iceelementList = null;
            fireresList = null;
            waterresList = null;
            thunderresList = null;
            iceresList = null;
            waterresprojList = null;
            thunderresprojList = null;
            iceresprojList = null;
            ArmorDecorations = null;
            OneSlotDecorations = null;
            TwoSlotDecorations = null;
            ThreeSlotDecorations = null;
            OutdoorsmanList = null;
        }
    }

}

