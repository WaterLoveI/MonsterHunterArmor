using MHArmorSkills.Buffs;
using MHArmorSkills.Items.Accessories.Decorations;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.BiomeBones;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.MHPlayer.MHItemDropRule;
using System;
using System.Linq;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.Global
{
    public class GlobalNPCLoot : GlobalNPC
    {
        
        public override void ModifyGlobalLoot(GlobalLoot globalLoot)
        {
            #region Gathering
            globalLoot.Add(ItemDropRule.ByCondition(new GatheringDropRule(), ItemID.HerbBag, 20, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new Gathering2DropRule(), ItemID.HerbBag, 15, 1, 2));
            #endregion
            #region Helmets
            ///globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<BoneHelmet>(), 105, 1, 1));
            /// globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<JaggiMask>(), 105, 1, 1));
            /// globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<KonchuHelm>(), 105, 1, 1));
            ///globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<MoofahHead>(), 105, 1, 1));
            ///globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<MossSwineHat>(), 105, 1, 1));
            ///globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<YukumoKasa>(), 105, 1, 1));
            #endregion
            #region Forest
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<AffinitySliding1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<BubbleDance1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Fortified1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Gathering1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<QuickSheath1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Scholar1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<SpeedSetUp1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Outdoorsman1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Health1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<SpiritBirdsCall1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<FishingExpert2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Gathering2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Poison2>(), 220, 1, 1));
            #endregion
            #region Snow
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<AutoReload1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<ColdRes1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<FreeMeal1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<Guard1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceAttack1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceAttack2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceRes1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<PolarHunter1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<ColdRes2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceRes2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<KushalaBless1>(), 220, 1, 1));
            #endregion
            #region Desert
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<AquaticMobility1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Sneak1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<BladehoneScale1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<FreeMeal1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Defense1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<ProtectivePolish1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<SpeedEating1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<ThunderAttack1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<ThunderAttack2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<ThunderRes1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Defiance1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<MastersTouch1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Gluttony2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<LastingPower2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<TeostraBless1>(), 220, 1, 1));

            #endregion
            #region Evil Biome
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Carving1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<CritDraw1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Gluttony1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Heroics1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<OffensiveGuard1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<RecoverySpd1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Windproof1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Atk1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Resentment1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Bloodlust1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Handicraft1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<StatusTrigger1>(), 220, 1, 1));

            #endregion
            #region Jungle
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<AutoTracker1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Cliffhanger1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Diversion1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Foray1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<HoneyHunter1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<RazorSharp1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<TropicsHunter1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Coalescence1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<IntrepidHeart1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Resuscitate1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<HoneyHunter2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<ChameleosBless1>(), 220, 1, 1));

            #endregion
            #region Dungeon
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<Artillery1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<Defense2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<Grinder1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<HeroShield1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<PoisonCoating1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<StaminaRecovery1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<SurvivalExpert1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<Focus1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<BloodRite1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<AdrenalineRush1>(), 220, 1, 1));

            #endregion
            #region Ocean
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<AffinitySliding1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<AquaticMobility1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Evasion1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<FishingExpert1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Protection1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<RecUp1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterAttack1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterAttack2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterRes1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<SneakAttack1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Counterstrike1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<AquaticMobility2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Scholar2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterRes2>(), 220, 1, 1));

            #endregion
            #region Glushroom
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<AffinitySliding1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Constitution1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<EvadeDistance1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<JumpMaster1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<LatentPower1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Mushroomancer1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<PowerProlonger1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<StunResist1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<CritEye1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Unscathed1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Cliffhanger2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<JumpMaster2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Windproof2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<MaximumMight1>(), 220, 1, 1));

            #endregion

            #region Hallowed
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<Blightproof1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<BubbleDance2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<CritElement1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<HastenRecovery1>(), 220, 1, 1));
            #endregion

            #region Underground
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<AutoTracker1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Fate1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Geologist1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<GuardUp1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<LastingPower1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Poison1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<SpeedSharpening1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<BBQExpert1>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Fencing1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Tenderizer1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<AutoTracker2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Mushroomancer2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<NegativeCrit1>(), 220, 1, 1));

            #endregion
            #region Cavern
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Artillery1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Bleeding1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<FireRes1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Geologist1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<PunishDraw1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<TremorRes1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<BBQExpert2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<StunResist2>(), 220, 1, 1));


            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Embolden1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Strife1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<FreeMeal2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Geologist2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<TremorRes2>(), 220, 1, 1));

            #endregion
            #region Underworld
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<ChallengeSheath1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Elemental1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireAttack1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireAttack2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireRes1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<SpeedEating2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<SpeedSetUp2>(), 220, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Vault1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Spirit1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<RockSteady1>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<HeatRes2>(), 220, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireRes2>(), 220, 1, 1));
            #endregion

            #region Biome Bones
            globalLoot.Add(ItemDropRule.ByCondition(new CoralBone1DropRule(), ModContent.ItemType<CoralBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CoralBone2DropRule(), ModContent.ItemType<CoralBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CoralBone3DropRule(), ModContent.ItemType<CoralBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CoralBone4DropRule(), ModContent.ItemType<CoralBone4>(), 50, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new ForestBone1DropRule(), ModContent.ItemType<ForestBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestBone2DropRule(), ModContent.ItemType<ForestBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestBone3DropRule(), ModContent.ItemType<ForestBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestBone4DropRule(), ModContent.ItemType<ForestBone4>(), 50, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new RottedBone1DropRule(), ModContent.ItemType<RottedBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new RottedBone2DropRule(), ModContent.ItemType<RottedBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new RottedBone3DropRule(), ModContent.ItemType<RottedBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new RottedBone4DropRule(), ModContent.ItemType<RottedBone4>(), 50, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new TundraBone1DropRule(), ModContent.ItemType<TundraBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new TundraBone2DropRule(), ModContent.ItemType<TundraBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new TundraBone3DropRule(), ModContent.ItemType<TundraBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new TundraBone4DropRule(), ModContent.ItemType<TundraBone4>(), 50, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new VolcanicBone1DropRule(), ModContent.ItemType<VolcanicBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new VolcanicBone2DropRule(), ModContent.ItemType<VolcanicBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new VolcanicBone3DropRule(), ModContent.ItemType<VolcanicBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new VolcanicBone4DropRule(), ModContent.ItemType<VolcanicBone4>(), 50, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new WildspireBone1DropRule(), ModContent.ItemType<WildspireBone1>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new WildspireBone2DropRule(), ModContent.ItemType<WildspireBone2>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new WildspireBone3DropRule(), ModContent.ItemType<WildspireBone3>(), 50, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new WildspireBone4DropRule(), ModContent.ItemType<WildspireBone4>(), 50, 1, 1));
            #endregion

        }
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                #region mini bosses
                case NPCID.Mothron:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FlamingShard>(), 1, 1, 3));

                    break;
                case NPCID.MartianSaucerCore:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ZinogreJasper>(), 5, 1, 1));

                    break;
                case NPCID.IceQueen:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LrgSnowClod>(), 1, 1, 2));
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DeathlyShocker>(), 1, 1, 2));
                    break;
                case NPCID.Pumpking:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FineEbonShell>(), 1, 1, 2));
                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AmberHardfang>(), 1, 1, 2));
                    break;
                #endregion
                #region bosses

                case NPCID.KingSlime:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 1, 1, 3));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<BirdWyvernGem>(), ModContent.ItemType<WyvernGem>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<BeastGem>(), ModContent.ItemType<CrabPearl>()));
                    }

                    break;
                case NPCID.EyeofCthulhu:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 2, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 1, 1, 3));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<BirdWyvernGem>(), ModContent.ItemType<WyvernGem>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<BeastGem>(), ModContent.ItemType<CrabPearl>()));
                    }

                    break;
                case NPCID.EaterofWorldsHead:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        if (System.Array.IndexOf(new int[] { NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail }, npc.type) > -1)
                        {
                            LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
                            npcLoot.Add(leadingConditionRule);
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 12, 1, 1));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 10, 1, 1));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 9, 1, 1));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<FlameSac>(), 5, 1, 1));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<FlamingScale>(), 5, 1, 1));
                        }
                    }

                    break;
                case NPCID.BrainofCthulhu:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 3, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 1, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 3, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FlameSac>(), 1, 1, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FlamingScale>(), 1, 1, 4));
                    }

                    break;
                case NPCID.Deerclops:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 2, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FrostSac>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<SnowClod>(), 1, 2, 4));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                    }

                    break;
                case NPCID.QueenBee:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 2, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<AquaSac>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<DroneSubstance>(), 1, 2, 4));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                    }

                    break;
                case NPCID.Skeleton:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ElectroSac>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ElectroShocker>(), 1, 2, 4));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<MysteriousSlime>(), 1, 2, 4));
                    }

                    break;
                case NPCID.WallofFlesh:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 3, 6));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ElderDragonGem>(), 4, 1, 1));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ElderDragonGem>(), 10, 1, 1));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FlameSac>(), ModContent.ItemType<AquaSac>(), ModContent.ItemType<ElectroSac>(), ModContent.ItemType<FrostSac>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FlameSac>(), ModContent.ItemType<AquaSac>(), ModContent.ItemType<ElectroSac>(), ModContent.ItemType<FrostSac>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FlamingScale>(), ModContent.ItemType<AmberTusk>(), ModContent.ItemType<EbonShell>(), ModContent.ItemType<ElectroSac>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FlamingScale>(), ModContent.ItemType<AmberTusk>(), ModContent.ItemType<EbonShell>(), ModContent.ItemType<ElectroSac>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<SnowClod>(), ModContent.ItemType<Bubblefoam>(), ModContent.ItemType<FulgurBug>(), ModContent.ItemType<GlowingSlime>(), ModContent.ItemType<DroneSubstance>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<SnowClod>(), ModContent.ItemType<Bubblefoam>(), ModContent.ItemType<FulgurBug>(), ModContent.ItemType<GlowingSlime>(), ModContent.ItemType<DroneSubstance>()));
                    }

                    break;
                case NPCID.QueenSlimeBoss:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(), ModContent.ItemType<FineBlackPearl>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(), ModContent.ItemType<FineBlackPearl>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(), ModContent.ItemType<FineBlackPearl>()));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(), ModContent.ItemType<FineBlackPearl>()));
                        int[] QSThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, QSThreeSlotArray));
                    }

                    break;
                case NPCID.Retinazer:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
                        {
                            LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
                            npcLoot.Add(leadingConditionRule);
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 2, 3, 5));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 2, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 2, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<FineBlackPearl>(), 3, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                            int[] TwinsThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                            npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(3, 1, TwinsThreeSlotArray));
                        }
                    }

                    break;
                case NPCID.Spazmatism:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
                        {
                            LeadingConditionRule leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 2, 3, 5));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 2, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 2, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<FineBlackPearl>(), 3, 1, 3));
                            npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                            int[] TwinsThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                            npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(3, 1, TwinsThreeSlotArray));
                        }
                    }

                    break;
                case NPCID.TheDestroyer:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 1, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FreezerSac>(), 1, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgBeastGem>(), 2, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                        int[] DThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, DThreeSlotArray));
                    }

                    break;
                case NPCID.SkeletronPrime:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 1, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ThunderSac>(), 1, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FeyWyvernGem>(), 2, 1, 1));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                        int[] SPThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, SPThreeSlotArray));
                    }

                    break;
                case NPCID.Plantera:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 1, 2, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<QueenSubstance>(), 1, 2, 3));
                        int[] PThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, PThreeSlotArray));
                    }

                    break;
                case NPCID.Golem:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<GlowingSlime>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<DeathlyShocker>(), 3, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<EbonShell>(), 3, 2, 3));
                        int[] GThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, GThreeSlotArray));
                    }

                    break;
                case NPCID.HallowBoss:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<ThunderSac>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<BoltScale>(), 2, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<GammothIceOrb>(), 5, 1, 1));
                        int[] EoLThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, EoLThreeSlotArray));
                    }

                    break;
                case NPCID.DukeFishron:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<DistilledBubblefoam>(), 2, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<MizutsuneWaterOrb>(), 5, 1, 1));
                        int[] FThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, FThreeSlotArray));
                    }

                    break;
                case NPCID.DD2Betsy:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 2, 3, 5));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<FlamingShard>(), 2, 1, 3));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<RathalosRuby>(), 5, 1, 1));
                        int[] BThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, BThreeSlotArray));
                    }

                    break;
                case NPCID.CultistBoss:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 1, 5, 10));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 5, ModContent.ItemType<RathalosRuby>(), ModContent.ItemType<GammothIceOrb>(), ModContent.ItemType<ZinogreJasper>(), ModContent.ItemType<MizutsuneWaterOrb>()));
                        int[] CThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, CThreeSlotArray));
                    }

                    break;
                case NPCID.MoonLordCore:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 1, 10, 15));
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<LrgElderDragonGem>(), 10, 1, 2));
                        int[] MLThreeSlotArray = MHLists.MixedSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, MLThreeSlotArray));
                    }

                    break;

                #endregion
                case NPCID.Shark:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LagiacrusHelm>(), 50, 1, 1));
                    break;
            }
        }
        private static int[] IllegalLootMultiplierNPCs => new int[] {
            NPCID.DD2Betsy,
            NPCID.EaterofWorldsBody,
            NPCID.EaterofWorldsHead,
            NPCID.EaterofWorldsTail
        };

        public override void OnKill(NPC npc)
        {
            Player player = Main.player[npc.lastInteraction];

            if (player.GetModPlayer<ArmorSkills>().Carving >= 1 && !npc.boss && !IllegalLootMultiplierNPCs.Contains(npc.type))
            {
                if (Main.rand.NextBool(player.GetModPlayer<MHPlayerArmorSkill>().CarvingChance))
                {
                    npc.NPCLoot();
                }
            }
        }
        public override bool CheckDead(NPC npc)
        {
            Player player = Main.player[npc.lastInteraction];
            if (player.GetModPlayer<MHPlayerArmorSkill>().Scholar >= 1)
            {
                if (npc.ExcludedFromDeathTally())
                    return true;
                int banner = Item.NPCtoBanner(npc.BannerID());
                if (banner <= 0)
                    return true;
                int addedKillBonus = player.GetModPlayer<MHPlayerArmorSkill>().Scholar;
                int bannerThreshold = ItemID.Sets.KillsToBanner[Item.BannerToItem(banner)];
                for (int i = 0; i < addedKillBonus; i++)
                {
                    if (NPC.killCount[banner] % bannerThreshold != bannerThreshold - 1)
                    {
                        NPC.killCount[banner]++;
                        Main.BestiaryTracker.Kills.RegisterKill(npc);
                    }
                }
            }
            return base.CheckDead(npc);
        }
        public override void OnHitPlayer(NPC npc, Player target, Player.HurtInfo hurtInfo)
        {
            base.OnHitPlayer(npc, target, hurtInfo);
            if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
            {
                switch (npc.type)
                {
                    case NPCID.Mothron:
                        if (hurtInfo.Damage > 0 && !Main.rand.NextBool(3))
                        {
                            target.AddBuff(ModContent.BuffType<BlastBlight>(), 18 * 60);
                        }
                        break;
                    case NPCID.MeteorHead:
                        if (hurtInfo.Damage > 0 && Main.rand.NextBool(3))
                        {
                            target.AddBuff(ModContent.BuffType<BlastBlight>(), 18 * 60);
                        }
                        break;
                    case NPCID.MothronSpawn:
                        if (hurtInfo.Damage > 0 && Main.rand.NextBool(3))
                        {
                            target.AddBuff(ModContent.BuffType<BlastBlight>(), 18 * 60);
                        }
                        break;
                    case NPCID.RedDevil:
                        if (hurtInfo.Damage > 0 && !Main.rand.NextBool(3))
                        {
                            target.AddBuff(ModContent.BuffType<BlastBlight>(), 18 * 60);
                        }
                        break;

                    case NPCID.QueenSlimeBoss:
                        if (hurtInfo.Damage > 0 && Main.rand.NextBool(5))
                        {
                            target.AddBuff(ModContent.BuffType<BubbleBlight>(), 5 * 60);
                        }
                        break;
                }
            }
            if (MHLists.fireresList.Contains(npc.type))
            {
                if (hurtInfo.Damage > 0 && Main.rand.NextBool(5))
                {
                    target.AddBuff(ModContent.BuffType<FireBlight>(), 15 * 60);
                }
            }
            if (MHLists.waterresList.Contains(npc.type))
            {
                if (hurtInfo.Damage > 0 && Main.rand.NextBool(5))
                {
                    target.AddBuff(ModContent.BuffType<WaterBlight>(), 15 * 60);
                }
            }
            if (MHLists.iceresList.Contains(npc.type))
            {
                if (hurtInfo.Damage > 0 && Main.rand.NextBool(5))
                {
                    target.AddBuff(ModContent.BuffType<IceBlight>(), 15 * 60);
                }
            }
            if (MHLists.thunderresList.Contains(npc.type))
            {
                if (hurtInfo.Damage > 0 && Main.rand.NextBool(5))
                {
                    target.AddBuff(ModContent.BuffType<ThunderBlight>(), 15 * 60);
                }
            }
        }
    }
}