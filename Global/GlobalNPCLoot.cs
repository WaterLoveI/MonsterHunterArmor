using MHArmorSkills.Buffs;
using MHArmorSkills.Items.Accessories.Decorations;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
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
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<AffinitySliding1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<BubbleDance1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Fortified1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Gathering1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<QuickSheath1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Scholar1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<SpeedSetUp1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Health1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<SpiritBirdsCall1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<FishingExpert2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Gathering2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Poison2>(), 215, 1, 1));
            #endregion
            #region Snow
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<AutoReload1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<ColdRes1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<FreeMeal1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<Guard1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceAttack1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceAttack2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceRes1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<PolarHunter1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<DeadEye1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<SpareShot1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<ColdRes2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceRes2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<KushalaBless1>(), 215, 1, 1));
            #endregion
            #region Desert
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<AquaticMobility1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<Sneak1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<BladehoneScale1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<FreeMeal1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<Defense1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ProtectivePolish1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<SpeedEating1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderAttack1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderAttack2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderRes1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Defiance1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<MastersTouch1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Gluttony2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<LastingPower2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<TeostraBless1>(), 215, 1, 1));

            #endregion
            #region Evil Biome
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Carving1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<CritDraw1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Gluttony1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Heroics1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<OffensiveGuard1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<RecoverySpd1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Windproof1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Atk1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Resentment1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Bloodlust1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Handicraft1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<StatusTrigger1>(), 215, 1, 1));

            #endregion
            #region Jungle
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<AutoTracker1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Cliffhanger1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Diversion1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Foray1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<HoneyHunter1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<RazorSharp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<TropicsHunter1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Coalescence1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<IntrepidHeart1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Resusitate1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<HoneyHunter2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<ChameleosBless1>(), 215, 1, 1));

            #endregion
            #region Dungeon
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Artillery1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Defense2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Grinder1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<HeroShield1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<PoisonCoating1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<StaminaRecovery1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<BloodRite1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<NormalUp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<PelletUp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<PierceUp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<AdrenalineRush1>(), 215, 1, 1));

            #endregion
            #region Ocean
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<AffinitySliding1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<AquaticMobility1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<Evasion1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<FishingExpert1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<Protection1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<RecUp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterAttack1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterAttack2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterRes1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<SneakAttack1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Counterstrike1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<AquaticMobility2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Scholar2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterRes2>(), 215, 1, 1));

            #endregion
            #region Glushroom
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<AffinitySliding1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<Constitution1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<EvadeDistance1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<JumpMaster1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<LatentPower1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<Mushroomancer1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<CritEye1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Unscathed1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Cliffhanger2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<JumpMaster2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Windproof2>(), 215, 1, 1));

            #endregion

            #region Hallowed
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<Blightproof1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<BubbleDance2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<CritElement1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<CloseRangePlus1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<HastenRecovery1>(), 215, 1, 1));
            #endregion

            #region Underground
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<AutoTracker1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Fate1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Geologist1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<GuardUp1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<LastingPower1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Poison1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<SpeedSharpening1>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Fencing1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Tenderizer1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<AutoTracker2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Mushroomancer2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<NegativeCrit1>(), 215, 1, 1));

            #endregion
            #region Cavern
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Artillery1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Bleeding1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<BombBoost1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<FireRes1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Geologist1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<PunishDraw1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<TremorRes1>(), 215, 1, 1));


            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Embolden1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Strife1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<FreeMeal2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Geologist2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<TremorRes2>(), 215, 1, 1));

            #endregion
            #region Underworld
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<ChallengeSheath1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<Elemental1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireAttack1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireAttack2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireRes1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<SpeedEating2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<SpeedSetUp2>(), 215, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Vault1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Spirit1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<RockSteady1>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<HeatRes2>(), 215, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireRes2>(), 215, 1, 1));
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
                        int[] GThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
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
                        int[] EoLThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
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
                        int[] FThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
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
                        int[] BThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, BThreeSlotArray));
                    }

                    break;
                case NPCID.CultistBoss:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 1, 5, 10));
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 5, ModContent.ItemType<RathalosRuby>(), ModContent.ItemType<GammothIceOrb>(), ModContent.ItemType<ZinogreJasper>(), ModContent.ItemType<MizutsuneWaterOrb>()));
                        int[] CThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, CThreeSlotArray));
                    }

                        break;
                case NPCID.MoonLordCore:
                    if (!Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode || !Main.GameModeInfo.IsExpertMode && !Main.GameModeInfo.IsMasterMode && !Main.GameModeInfo.IsJourneyMode)
                    {
                        npcLoot.Add(new CommonDrop(ModContent.ItemType<TrueArmorSphere>(), 1, 10, 15));
                        int[] MLThreeSlotArray = MHLists.ThreeSlotDecorations.ToArray();
                        npcLoot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, MLThreeSlotArray));
                    }

                    break;

                    #endregion
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
        }
    }
}