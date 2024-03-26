using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using MHArmorSkills.Items.Crafting_Materials.ArmorSphere;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.Items.Accessories.Decorations;

namespace MHArmorSkills.Global
{
    public class GlobalBossBags : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot loot)
        {
            switch (item.type)
            {
                #region Boss Treasure Bags
                case ItemID.KingSlimeBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 1 ,1 , 3));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<BirdWyvernGem>(), ModContent.ItemType<WyvernGem>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<BeastGem>(), ModContent.ItemType<InsectShell>(), ModContent.ItemType<CrabPearl>()));
                    break;
                case ItemID.EyeOfCthulhuBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 2, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 1, 1, 3));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<BirdWyvernGem>(), ModContent.ItemType<WyvernGem>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<BeastGem>(), ModContent.ItemType<InsectShell>(), ModContent.ItemType<CrabPearl>()));
                    break;
                case ItemID.EaterOfWorldsBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 3, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 1, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 3, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<FlameSac>(), 1, 1, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<FlamingScale>(), 1, 1, 4));
                    break;
                case ItemID.BrainOfCthulhuBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSphere>(), 3, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 1, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 3, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<FlameSac>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<FlamingScale>(), 1, 2, 4));
                    break;
                case ItemID.DeerclopsBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 2, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<FrostSac>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<SnowClod>(), 1, 2, 4));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<EbonShell>(), ModContent.ItemType<AmberTusk>()));

                    break;
                case ItemID.QueenBeeBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<ArmorSpherePlus>(), 2, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<AquaSac>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<DroneSubstance>(), 1, 2, 4));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<FulgurBug>(), ModContent.ItemType<Bubblefoam>()));
                    break;
                case ItemID.SkeletronBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 2, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<ElectroSac>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<ElectroShocker>(), 1, 2, 4));
                    loot.Add(new CommonDrop(ModContent.ItemType<MysteriousSlime>(), 1, 2, 4));
                    break;
                case ItemID.WallOfFleshBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HardArmorSphere>(), 1, 3, 6));
                    loot.Add(new CommonDrop(ModContent.ItemType<ElderDragonGem>(), 4, 1, 1));
                    loot.Add(new CommonDrop(ModContent.ItemType<ElderDragonGem>(), 10, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FlameSac>(), ModContent.ItemType<AquaSac>(), ModContent.ItemType<ElectroSac>(), ModContent.ItemType<FrostSac>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FlameSac>(), ModContent.ItemType<AquaSac>(), ModContent.ItemType<ElectroSac>(), ModContent.ItemType<FrostSac>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<FlamingScale>(), ModContent.ItemType<AmberTusk>(), ModContent.ItemType<EbonShell>(), ModContent.ItemType<ElectroSac>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<FlamingScale>(), ModContent.ItemType<AmberTusk>(), ModContent.ItemType<EbonShell>(), ModContent.ItemType<ElectroSac>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<SnowClod>(), ModContent.ItemType<Bubblefoam>(), ModContent.ItemType<FulgurBug>(), ModContent.ItemType<GlowingSlime>(), ModContent.ItemType<DroneSubstance>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<SnowClod>(), ModContent.ItemType<Bubblefoam>(), ModContent.ItemType<FulgurBug>(), ModContent.ItemType<GlowingSlime>(), ModContent.ItemType<DroneSubstance>()));

                    break;

                case ItemID.QueenSlimeBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<InsectCarapace>(), 1, 1, 3));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(),  ModContent.ItemType<FineBlackPearl>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(),  ModContent.ItemType<FineBlackPearl>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 3, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(),  ModContent.ItemType<FineBlackPearl>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 4, ModContent.ItemType<LrgBeastGem>(), ModContent.ItemType<FeyWyvernGem>(), ModContent.ItemType<FineBlackPearl>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));

                    break;
                case ItemID.TwinsBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<FineBlackPearl>(), 2, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.DestroyerBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<FreezerSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<LrgBeastGem>(), 2, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.SkeletronPrimeBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<ThunderSac>(), 1, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<FeyWyvernGem>(), 2, 1, 1));
                    loot.Add(new CommonDrop(ModContent.ItemType<LrgWyvernGem>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.PlanteraBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<HeavyArmorSphere>(), 2, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 1, 2, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<QueenSubstance>(), 1, 2, 3));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.GolemBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<GlowingSlime>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<DeathlyShocker>(), 3, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<EbonShell>(), 3, 2, 3));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.FairyQueenBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<ThunderSac>(), 2, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<BoltScale>(), 2, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<GammothIceOrb>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.FishronBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<TorrentSac>(), 2, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<DistilledBubblefoam>(), 2, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<MizutsuneWaterOrb>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.BossBagBetsy:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<InfernoSac>(), 2, 3, 5));
                    loot.Add(new CommonDrop(ModContent.ItemType<FlamingShard>(), 2, 1, 3));
                    loot.Add(new CommonDrop(ModContent.ItemType<RathalosRuby>(), 5, 1, 1));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;
                case ItemID.CultistBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 5, ModContent.ItemType<RathalosRuby>(), ModContent.ItemType<GammothIceOrb>(), ModContent.ItemType<ZinogreJasper>(), ModContent.ItemType<MizutsuneWaterOrb>()));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 2, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;

                case ItemID.MoonLordBossBag:
                    loot.Add(new CommonDrop(ModContent.ItemType<KingArmorSphere>(), 1, 3, 5));
                    loot.Add(new OneFromOptionsNotScaledWithLuckDropRule(1, 1, ModContent.ItemType<Atk2>(), ModContent.ItemType<BladehoneScale2>(), ModContent.ItemType<ChallengeSheath2>(), ModContent.ItemType<Coalescence2>(), ModContent.ItemType<Constitution2>()
                        , ModContent.ItemType<Counterstrike2>(), ModContent.ItemType<CritElement2>(), ModContent.ItemType<CritDraw2>(), ModContent.ItemType<CritEye2>(), ModContent.ItemType<Defense3>(), ModContent.ItemType<Defiance3>(), ModContent.ItemType<Embolden2>()
                        , ModContent.ItemType<EvadeDistance2>(), ModContent.ItemType<Evasion2>(), ModContent.ItemType<FireAttack3>(), ModContent.ItemType<Foray2>(), ModContent.ItemType<Guard2>(), ModContent.ItemType<GuardUp2>(), ModContent.ItemType<HastenRecovery2>()
                        , ModContent.ItemType<Health2>(), ModContent.ItemType<IceAttack3>(), ModContent.ItemType<LatentPower2>(), ModContent.ItemType<MastersTouch2>(), ModContent.ItemType<PolarHunter2>(), ModContent.ItemType<Protection2>(), ModContent.ItemType<ProtectivePolish3>()
                        , ModContent.ItemType<PunishDraw2>(), ModContent.ItemType<SpeedSharpening3>(), ModContent.ItemType<QuickSheath3>(), ModContent.ItemType<RazorSharp3>(), ModContent.ItemType<RecUp3>(), ModContent.ItemType<RecoverySpd3>(), ModContent.ItemType<Resentment2>()
                        , ModContent.ItemType<Resusitate2>(), ModContent.ItemType<Sneak3>(), ModContent.ItemType<Diversion3>(), ModContent.ItemType<SpareShot3>(), ModContent.ItemType<Spirit2>(), ModContent.ItemType<StaminaRecovery3>(), ModContent.ItemType<ThunderAttack3>()
                        , ModContent.ItemType<Unscathed2>(), ModContent.ItemType<WaterAttack3>()));
                    break;

                    #endregion
            }
        }
    }
}
