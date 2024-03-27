using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Items.Accessories.Decorations;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.MHPlayer.PKMItemDropRule;
using Microsoft.Xna.Framework;
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
            globalLoot.Add(ItemDropRule.ByCondition(new GatheringDropRule(), ItemID.HerbBag, 12, 1, 2));
            #endregion
            #region Helmets
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<BoneHelmet>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<BullfangoMask>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<JaggiMask>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<KonchuHelm>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<MoofahHead>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<MossSwineHat>(), 100, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<YukumoKasa>(), 100, 1, 1));
            #endregion
            #region Forest
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<AffinitySliding1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<BubbleDance1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Fortified1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Gathering1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<QuickSheath1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<Scholar1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new ForestCondition(), ModContent.ItemType<SpeedSetUp1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Health1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<SpiritBirdsCall1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<FishingExpert2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Gathering2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMForestCondition(), ModContent.ItemType<Poison2>(), 190, 1, 1));
            #endregion
            #region Snow
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<AutoReload1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<ColdRes1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<FreeMeal1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<Guard1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceAttack1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceAttack2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<IceRes1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new SnowCondition(), ModContent.ItemType<PolarHunter1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<DeadEye1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<SpareShot1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<ColdRes2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMSnowCondition(), ModContent.ItemType<IceRes2>(), 190, 1, 1));
            #endregion
            #region Desert
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<AquaticMobility1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<Sneak1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<BladehoneScale1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<FreeMeal1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<Defense1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ProtectivePolish1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<SpeedEating1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderAttack1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderAttack2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DesertCondition(), ModContent.ItemType<ThunderRes1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Defiance1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<MastersTouch1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<Gluttony2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDesertCondition(), ModContent.ItemType<LastingPower2>(), 190, 1, 1));

            #endregion
            #region Evil Biome
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Carving1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<CritDraw1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Gluttony1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<Heroics1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<OffensiveGuard1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new EvilCondition(), ModContent.ItemType<RecoverySpd1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Atk1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Resentment1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Bloodlust1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMEvilCondition(), ModContent.ItemType<Handicraft1>(), 190, 1, 1));
            #endregion
            #region Jungle
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<AutoTracker1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Cliffhanger1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Diversion1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<Foray1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<HoneyHunter1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<RazorSharp1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new JungleCondition(), ModContent.ItemType<TropicsHunter1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Coalescence1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<IntrepidHeart1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<Resusitate1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMJungleCondition(), ModContent.ItemType<HoneyHunter2>(), 190, 1, 1));

            #endregion
            #region Dungeon
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Artillery1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Defense2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<Grinder1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<HeroShield1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<PoisonCoating1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new DungeonCondition(), ModContent.ItemType<StaminaRecovery1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<BloodRite1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<NormalUp1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<PelletUp1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMDungeonCondition(), ModContent.ItemType<PierceUp1>(), 190, 1, 1));
            #endregion
            #region Ocean
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<AffinitySliding1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<AquaticMobility1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<Evasion1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<FishingExpert1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<Protection1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<RecUp1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterAttack1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterAttack2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new OceanCondition(), ModContent.ItemType<WaterRes1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<SneakAttack1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Counterstrike1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<AquaticMobility2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<Scholar2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMOceanCondition(), ModContent.ItemType<WaterRes2>(), 190, 1, 1));

            #endregion
            #region Glushroom
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<AffinitySliding1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<Constitution1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<EvadeDistance1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<JumpMaster1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<LatentPower1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new GlowingMushroomCondition(), ModContent.ItemType<Mushroomancer1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<CritEye1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Unscathed1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<Cliffhanger2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMGlowingMushroomCondition(), ModContent.ItemType<JumpMaster2>(), 190, 1, 1));
            #endregion

            #region Hallowed
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<Blightproof1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<BubbleDance2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<CritElement1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<CloseRangePlus1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HallowedCondition(), ModContent.ItemType<HastenRecovery1>(), 190, 1, 1));
            #endregion

            #region Underground
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<AutoTracker1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Fate1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Geologist1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<GuardUp1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<LastingPower1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<Poison1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UndergroundCondition(), ModContent.ItemType<SpeedSharpening1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Fencing1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Tenderizer1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<AutoTracker2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUndergroundCondition(), ModContent.ItemType<Mushroomancer2>(), 190, 1, 1));
            #endregion
            #region Cavern
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Artillery1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Bleeding1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<BombBoost1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<FireRes1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<Geologist1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new CavernCondition(), ModContent.ItemType<PunishDraw1>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Embolden1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Strife1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<FreeMeal2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMCavernCondition(), ModContent.ItemType<Geologist2>(), 190, 1, 1));
            #endregion
            #region Underworld
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<ChallengeSheath1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<Elemental1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireAttack1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireAttack2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<FireRes1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<SpeedEating2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new UnderworldCondition(), ModContent.ItemType<SpeedSetUp2>(), 190, 1, 1));

            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Vault1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<Spirit1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<RockSteady1>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<HeatRes2>(), 190, 1, 1));
            globalLoot.Add(ItemDropRule.ByCondition(new HMUnderworldCondition(), ModContent.ItemType<FireRes2>(), 190, 1, 1));
            #endregion
        }
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            switch (npc.type)
            {
                
                case NPCID.Mothron:

                    npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FlamingShard>(), 1 ,1,3));

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
    }
}