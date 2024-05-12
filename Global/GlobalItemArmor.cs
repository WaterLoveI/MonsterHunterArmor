using Terraria;
using Terraria.ModLoader;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.Buffs.ArmorBuffs;
using Terraria.ID;
using MHArmorSkills.Buffs;
using Terraria.Audio;


namespace MHArmorSkills.Global
{
    public class GlobalItemArmors : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            // credits to calamity for this code
            
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();
            DecorationSlots DecorPlayer = player.GetModPlayer<DecorationSlots>();
            switch (item.type)
            {
                #region Pre HM
                #region Preboss
                case ItemID.MiningHelmet:
                    modPlayer.Geologist += 1;
                    modPlayer.AutoTracker += 1;
                    break;
                case ItemID.MiningShirt:
                    modPlayer.Geologist += 1;
                    modPlayer.CliffHanger += 1;
                    break;
                case ItemID.MiningPants:
                    modPlayer.CliffHanger += 1;
                    modPlayer.QuickGather += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.WoodHelmet:
                case ItemID.EbonwoodHelmet:
                case ItemID.PearlwoodHelmet:
                case ItemID.PalmWoodHelmet:
                case ItemID.AshWoodHelmet:
                case ItemID.BorealWoodHelmet:
                case ItemID.RichMahoganyHelmet:
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.WoodBreastplate:
                case ItemID.EbonwoodBreastplate:
                case ItemID.PearlwoodBreastplate:
                case ItemID.PalmWoodBreastplate:
                case ItemID.AshWoodBreastplate:
                case ItemID.BorealWoodBreastplate:
                case ItemID.RichMahoganyBreastplate:
                    modPlayer.Protection += 1;
                    break;
                case ItemID.WoodGreaves:
                case ItemID.EbonwoodGreaves:
                case ItemID.PearlwoodGreaves:
                case ItemID.PalmWoodGreaves:
                case ItemID.AshWoodGreaves:
                case ItemID.BorealWoodGreaves:
                case ItemID.RichMahoganyGreaves:
                    modPlayer.Gathering += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.AnglerHat:
                    modPlayer.AutoTracker += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.AnglerVest:
                    modPlayer.FreeMeal += 1;
                    break;
                case ItemID.AnglerPants:
                    modPlayer.AMobility += 1;
                    break;
                case ItemID.CactusHelmet:
                    modPlayer.Sneak += 1;
                    break;
                case ItemID.CactusBreastplate:
                    modPlayer.RecSpeed += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.CactusLeggings:
                    modPlayer.StamRec += 1;
                    break;
                case ItemID.CopperHelmet:
                    modPlayer.SpeedEating += 1;
                    break;
                case ItemID.CopperChainmail:
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.CopperGreaves:
                    modPlayer.AntiPoison += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.TinHelmet:
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.TinChainmail:
                    modPlayer.StamRec += 1;
                    break;
                case ItemID.TinGreaves:
                    modPlayer.CliffHanger += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.PumpkinHelmet:
                    modPlayer.FreeMeal += 1;
                    break;
                case ItemID.PumpkinBreastplate:
                    modPlayer.Gluttony += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.PumpkinLeggings:
                    modPlayer.SpeedEating += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.IronHelmet:
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.AncientIronHelmet:
                    modPlayer.RazorSharp += 1;
                    break;
                case ItemID.IronChainmail:
                    modPlayer.Diversion += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.IronGreaves:
                    modPlayer.RecSpeed += 1;
                    break;
                case ItemID.LeadHelmet:
                    modPlayer.AntiPoison += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.LeadChainmail:
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.LeadGreaves:
                    modPlayer.DefenseBoost += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.SilverHelmet:
                    modPlayer.StamRec += 1;
                    break;
                case ItemID.SilverChainmail:
                    modPlayer.Attack += 2;
                    break;
                case ItemID.SilverGreaves:
                    modPlayer.FreeMeal += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.TungstenHelmet:
                    modPlayer.RecSpeed += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.TungstenChainmail:
                    modPlayer.CritEye += 1;
                    break;
                case ItemID.TungstenGreaves:
                    modPlayer.Diversion += 1;
                    break;
                case ItemID.GoldHelmet:
                    modPlayer.Diversion += 1;
                    break;
                case ItemID.AncientGoldHelmet:
                    modPlayer.Fate += 1;
                    break;
                case ItemID.GoldChainmail:
                    modPlayer.AutoTracker += 1;
                    modPlayer.QuickSharpening += 1;
                    break;
                case ItemID.GoldGreaves:
                    modPlayer.Fate += 1;
                    modPlayer.QuickSharpening += 1;
                    break;
                case ItemID.PlatinumHelmet:
                    modPlayer.Fortified = true;
                    break;
                case ItemID.PlatinumChainmail:
                    modPlayer.Protection += 1;
                    modPlayer.RazorSharp += 1;
                    break;
                case ItemID.PlatinumGreaves:
                    modPlayer.RazorSharp += 1;
                    modPlayer.Diversion += 1;
                    break;
                case ItemID.FossilHelm:
                    modPlayer.JumpMaster += 1;
                    break;
                case ItemID.FossilShirt:
                    modPlayer.CounterStrike += 1;
                    modPlayer.FireRes += 1;
                    break;
                case ItemID.FossilPants:
                    modPlayer.Fortified = true;
                    modPlayer.FireRes += 1;
                    break;
                case ItemID.GladiatorHelmet:
                    modPlayer.CritEye += 1;
                    break;
                case ItemID.GladiatorBreastplate:
                    modPlayer.SpeedSetup += 1;
                    modPlayer.IceRes += 1;
                    break;
                case ItemID.GladiatorLeggings:
                    modPlayer.Attack += 1;
                    modPlayer.IceRes += 1;
                    break;
                #endregion
                #region Post Boss
                case ItemID.NinjaHood:
                    modPlayer.Sneak += 1;
                    modPlayer.CritEye += 1;
                    break;
                case ItemID.NinjaShirt:
                    modPlayer.CritEye += 1;
                    modPlayer.SpeedSetup += 1;
                    break;
                case ItemID.NinjaPants:
                    modPlayer.CritEye += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.BeeHeadgear:
                    modPlayer.Resentment += 1;
                    modPlayer.LastingPower += 1;
                    break;
                case ItemID.BeeBreastplate:
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.HoneyHunter += 1;
                    modPlayer.AutoTracker += 1;
                    break;
                case ItemID.BeeGreaves:
                    modPlayer.Resentment += 1;
                    modPlayer.HoneyHunter += 1;
                    break;
                case ItemID.ObsidianHelm:
                    modPlayer.Attack += 2;
                    modPlayer.AutoTracker += 1;
                    break;
                case ItemID.ObsidianShirt:
                    modPlayer.CounterStrike += 1;
                    modPlayer.PunishDraw += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.ObsidianPants:
                    modPlayer.Attack += 2;
                    modPlayer.QuickSheath += 1;
                    break;
                case ItemID.MeteorHelmet:
                    modPlayer.LatentPower += 1;
                    modPlayer.FireAttack += 2;
                    break;
                case ItemID.MeteorSuit:
                    modPlayer.LatentPower += 1;
                    modPlayer.FireAttack += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.MeteorLeggings:
                    modPlayer.StamRec += 1;
                    modPlayer.HeatRes += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.JungleHat:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.LastingPower += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.JungleShirt:
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.Mushroomancer += 1;
                    modPlayer.WaterRes += 1;
                    break;
                case ItemID.JunglePants:
                    modPlayer.FreeMeal += 1;
                    modPlayer.Mushroomancer += 1;
                    modPlayer.CliffHanger += 1;
                    break;
                case ItemID.AncientCobaltHelmet:
                    modPlayer.StamRec += 1;
                    modPlayer.AntiPoison += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.AncientCobaltBreastplate:
                    modPlayer.Foray += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.AncientCobaltLeggings:
                    modPlayer.Foray += 1;
                    modPlayer.Mushroomancer += 1;
                    break;
                case ItemID.NecroHelmet:
                    modPlayer.Unscathed += 1;
                    modPlayer.AntiBleeding = true;
                    break;
                case ItemID.NecroBreastplate:
                    modPlayer.Unscathed += 1;
                    modPlayer.LastingPower += 1;
                    modPlayer.ColdRes += 1;
                    break;
                case ItemID.NecroGreaves:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.AMobility += 2;
                    break;
                case ItemID.ShadowHelmet:
                    modPlayer.Evasion += 1;
                    modPlayer.RazorSharp += 1;
                    break;
                case ItemID.ShadowScalemail:
                    modPlayer.Evasion += 1;
                    modPlayer.CritEye += 1;
                    modPlayer.QuickSheath += 1;
                    break;
                case ItemID.ShadowGreaves:
                    modPlayer.CritEye += 1;
                    modPlayer.RazorSharp += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.AncientShadowHelmet:
                    modPlayer.Evasion += 1;
                    modPlayer.CritEye += 1;
                    break;
                case ItemID.AncientShadowScalemail:
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.EvadeDistance += 1;
                    modPlayer.Constitution += 1;
                    break;
                case ItemID.AncientShadowGreaves:
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.CritEye += 1;
                    break;
                case ItemID.CrimsonHelmet:
                    modPlayer.HastenRecovery += 1;
                    modPlayer.QuickSharpening += 1;
                    break;
                case ItemID.CrimsonScalemail:
                    modPlayer.HastenRecovery += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.RecoveryUp += 1;
                    break;
                case ItemID.CrimsonGreaves:
                    modPlayer.Attack += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.MoltenHelmet:
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.HeatRes += 2;
                    break;
                case ItemID.MoltenBreastplate:
                    modPlayer.Guard += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.MoltenGreaves:
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.Guard += 1;
                    modPlayer.HeatRes += 1;
                    break;
                #endregion
                #endregion
                #region Hard Mode
                #region Pre Mech
                case ItemID.SpiderMask:
                    modPlayer.Attack += 1;
                    modPlayer.CliffHanger += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.SpiderBreastplate:
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.AntiPoison += 2;
                    modPlayer.Foray += 1;
                    break;
                case ItemID.SpiderGreaves:
                    modPlayer.Evasion += 1;
                    modPlayer.Constitution += 1;
                    modPlayer.Foray += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.CobaltHelmet:
                    modPlayer.Attack += 2;
                    modPlayer.CritEye += 2;
                    modPlayer.RazorSharp += 1;
                    break;
                case ItemID.CobaltHat:
                    modPlayer.Attack += 2;
                    modPlayer.CritEye += 2;
                    modPlayer.StamRec += 1;
                    break;
                case ItemID.CobaltMask:
                    modPlayer.Attack += 2;
                    modPlayer.CritEye += 2;
                    modPlayer.NormalUp += 1;
                    break;
                case ItemID.CobaltBreastplate:
                    modPlayer.CritEye += 1;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.CobaltLeggings:
                    modPlayer.Attack += 1;
                    modPlayer.Fencing += 1;
                    modPlayer.ThunderRes += 3;
                    break;
                case ItemID.PalladiumHelmet:
                    modPlayer.Protection += 2;
                    modPlayer.RecSpeed += 1;
                    modPlayer.NormalUp += 1;
                    break;
                case ItemID.PalladiumMask:
                    modPlayer.Protection += 2;
                    modPlayer.RecSpeed += 1;
                    modPlayer.ProtectivePolish += 1;
                    break;
                case ItemID.PalladiumHeadgear:
                    modPlayer.Protection += 2;
                    modPlayer.RecSpeed += 1;
                    modPlayer.LastingPower += 1;
                    break;
                case ItemID.PalladiumBreastplate:
                    modPlayer.Resentment += 1;
                    modPlayer.Guard += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.PalladiumLeggings:
                    modPlayer.Attack += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.FireRes += 2;
                    break;
                case ItemID.MythrilHat:
                    modPlayer.SpeedEating += 2;
                    modPlayer.FreeMeal += 2;
                    modPlayer.PierceUp += 1;
                    break;
                case ItemID.MythrilHood:
                    modPlayer.SpeedEating += 2;
                    modPlayer.FreeMeal += 2;
                    modPlayer.RecoveryUp += 1;
                    break;
                case ItemID.MythrilHelmet:
                    modPlayer.SpeedEating += 2;
                    modPlayer.FreeMeal += 2;
                    modPlayer.RazorSharp += 2;
                    break;
                case ItemID.MythrilChainmail:
                    modPlayer.Protection += 1;
                    modPlayer.FreeMeal += 1;
                    modPlayer.RecoveryUp += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.MythrilGreaves:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.LastingPower += 1;
                    modPlayer.Constitution += 2;
                    break;
                case ItemID.OrichalcumHelmet:
                    modPlayer.Fencing += 1;
                    modPlayer.CritEye += 2;
                    modPlayer.PierceUp += 1;
                    break;
                case ItemID.OrichalcumHeadgear:
                    modPlayer.Fencing += 1;
                    modPlayer.CritEye += 3;
                    break;
                case ItemID.OrichalcumMask:
                    modPlayer.Fencing += 1;
                    modPlayer.CritEye += 2;
                    modPlayer.ProtectivePolish += 2;
                    break;
                case ItemID.OrichalcumBreastplate:
                    modPlayer.CritEye += 1;
                    modPlayer.LastingPower += 1;
                    modPlayer.IceRes += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.OrichalcumLeggings:
                    DecorPlayer.DecorationTwoSlots += 2;
                    modPlayer.LastingPower += 2;
                    
                    break;
                case ItemID.AdamantiteHeadgear:
                    modPlayer.Guard += 2;
                    modPlayer.Tenderizer += 2;
                    modPlayer.DefenseBoost += 1;
                    break;
                case ItemID.AdamantiteHelmet:
                    modPlayer.Guard += 2;
                    modPlayer.Tenderizer += 1;
                    modPlayer.DefenseBoost += 1;
                    modPlayer.ProtectivePolish += 1;
                    break;
                case ItemID.AdamantiteMask:
                    modPlayer.Guard += 2;
                    modPlayer.Tenderizer += 1;
                    modPlayer.DefenseBoost += 1;
                    modPlayer.PelletUp += 1;
                    break;
                case ItemID.AdamantiteBreastplate:
                    modPlayer.Guard += 2;
                    modPlayer.Spirit += 1;
                    modPlayer.DefLock += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.AdamantiteLeggings:
                    modPlayer.Guard += 1;
                    modPlayer.RazorSharp += 1;
                    modPlayer.DefenseBoost += 2;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.TitaniumHeadgear:
                    modPlayer.Diversion += 2;
                    modPlayer.LatentPower += 1;
                    modPlayer.Protection += 1;
                    break;
                case ItemID.TitaniumHelmet:
                    modPlayer.Diversion += 2;
                    modPlayer.LatentPower += 1;
                    modPlayer.PelletUp += 1;
                    break;
                case ItemID.TitaniumMask:
                    modPlayer.Diversion += 2;
                    modPlayer.LatentPower += 1;
                    modPlayer.RazorSharp += 2;
                    break;
                case ItemID.TitaniumBreastplate:
                    modPlayer.Guard += 1;
                    modPlayer.LatentPower += 1;
                    modPlayer.RockSteady = true;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.TitaniumLeggings:
                    modPlayer.IceAttack += 1;
                    modPlayer.Diversion += 1;
                    modPlayer.Evasion += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.CrystalNinjaHelmet:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.JumpMaster += 1;
                    modPlayer.SpeedSetup += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.CrystalNinjaChestplate:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.BubbleDance += 2;
                    modPlayer.Attack += 2;
                    break;
                case ItemID.CrystalNinjaLeggings:
                    modPlayer.SpeedSetup += 1;
                    modPlayer.AffinitySliding += 1;
                    modPlayer.BubbleDance += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.FrostHelmet:
                    modPlayer.PolarHunter += 1;
                    modPlayer.HastenRecovery += 1;
                    modPlayer.ColdRes += 3;
                    break;
                case ItemID.FrostBreastplate:
                    modPlayer.PolarHunter += 1;
                    modPlayer.Protection += 1;
                    modPlayer.IceAttack += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.FrostLeggings:
                    modPlayer.PolarHunter += 1;
                    modPlayer.AMobility += 2;
                    modPlayer.IceAttack += 2;
                    break;
                case ItemID.AncientBattleArmorHat:
                    modPlayer.TropicHunter += 1;
                    modPlayer.HeatRes += 3;
                    modPlayer.Guts += 1;
                    break;
                case ItemID.AncientBattleArmorShirt:
                    modPlayer.TropicHunter += 1;
                    modPlayer.LatentPower += 1;
                    modPlayer.Unscathed += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.AncientBattleArmorPants:
                    modPlayer.TropicHunter += 1;
                    modPlayer.Fate += 1;
                    modPlayer.Evasion += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.SquireGreatHelm:
                    modPlayer.Guard += 1;
                    modPlayer.GuardUp += 1;
                    modPlayer.Diversion += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.SquirePlating:
                    modPlayer.Guard += 1;
                    modPlayer.Slugger += 1;
                    modPlayer.Diversion += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.SquireGreaves:
                    modPlayer.Constitution += 1;
                    modPlayer.HastenRecovery += 1;
                    modPlayer.CritDraw += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.MonkBrows:
                    modPlayer.Attack += 2;
                    modPlayer.DefenseBoost += 2;
                    modPlayer.RazorSharp += 1;
                    break;
                case ItemID.MonkShirt:
                    modPlayer.Attack += 1;
                    modPlayer.SpeedEating += 1;
                    modPlayer.Focus += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.MonkPants:
                    DecorPlayer.DecorationTwoSlots += 2;
                    modPlayer.Health += 1;
                    
                    break;
                case ItemID.HuntressWig:
                    modPlayer.SpareShot += 1;
                    modPlayer.Foray += 1;
                    modPlayer.EvadeDistance += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.HuntressJerkin:
                    modPlayer.TropicHunter += 1;
                    modPlayer.Foray += 1;
                    modPlayer.EvadeDistance += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.HuntressPants:
                    modPlayer.SpareShot += 1;
                    modPlayer.PierceUp += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ApprenticeHat:
                    modPlayer.Unscathed += 2;
                    modPlayer.HastenRecovery += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ApprenticeRobe:
                    modPlayer.LatentPower += 2;
                    modPlayer.HastenRecovery += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ApprenticeTrousers:
                    modPlayer.LatentPower += 2;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                #endregion
                #region Pre Plantera
                case ItemID.HallowedMask:
                    modPlayer.Attack += 1;
                    modPlayer.Spirit += 1;
                    modPlayer.QuickSharpening += 2;
                    break;
                case ItemID.HallowedHelmet:
                    modPlayer.Attack += 1;
                    modPlayer.Spirit += 1;
                    modPlayer.SpareShot += 2;
                    break;
                case ItemID.HallowedHeadgear:
                    modPlayer.Attack += 1;
                    modPlayer.Spirit += 1;
                    modPlayer.LatentPower += 2;
                    break;
                case ItemID.HallowedHood:
                    modPlayer.Attack += 1;
                    modPlayer.Spirit += 1;
                    modPlayer.Unscathed += 2;
                    break;
                case ItemID.HallowedPlateMail:
                    modPlayer.RecSpeed += 1;
                    modPlayer.CriticalBoost += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.HallowedGreaves:
                    modPlayer.AffinitySliding += 1;
                    DecorPlayer.DecorationThreeSlots += 2;
                    break;
                case ItemID.AncientHallowedHelmet:
                    modPlayer.Attack += 1;
                    modPlayer.CritEye += 1;
                    modPlayer.Artillery += 1;
                    break;
                case ItemID.AncientHallowedHeadgear:
                    modPlayer.Attack += 1;
                    modPlayer.CritEye += 1;
                    modPlayer.AffinitySliding += 1;
                    break;
                case ItemID.AncientHallowedHood:
                    modPlayer.Attack += 1;
                    modPlayer.CritEye += 1;
                    modPlayer.HastenRecovery += 1;
                    break;
                case ItemID.AncientHallowedMask:
                    modPlayer.Attack += 1;
                    modPlayer.CritEye += 1;
                    modPlayer.RazorSharp += 1;
                    modPlayer.ProtectivePolish += 1;
                    break;
                case ItemID.AncientHallowedPlateMail:
                    modPlayer.RecSpeed += 2;
                    DecorPlayer.DecorationThreeSlots += 2;
                    break;
                case ItemID.AncientHallowedGreaves:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.Handicraft += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ChlorophyteHeadgear:
                case ItemID.ChlorophyteHelmet:
                case ItemID.ChlorophyteMask:
                    modPlayer.TropicHunter += 2;
                    modPlayer.Health += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.ChlorophytePlateMail:
                    modPlayer.QuickBreath += 2;
                    modPlayer.Health += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ChlorophyteGreaves:
                    modPlayer.Protection += 2;
                    modPlayer.WaterRes += 2;
                    DecorPlayer.DecorationOneSlots += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.TurtleHelmet:
                    modPlayer.Defiance += 1;
                    modPlayer.Guard += 1;
                    modPlayer.DefenseBoost += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.TurtleScaleMail:
                    modPlayer.Defiance += 2;
                    modPlayer.Resentment += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.TurtleLeggings:
                    modPlayer.Defiance += 2;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.TikiMask:
                    modPlayer.Foray += 2;
                    modPlayer.Sneak += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.TikiShirt:
                    modPlayer.RecoveryUp += 1;
                    modPlayer.WaterRes += 2;
                    DecorPlayer.DecorationThreeSlots += 2;
                    break;
                case ItemID.TikiPants:
                    modPlayer.Attack += 1;
                    modPlayer.Fencing += 1;
                    modPlayer.RecoveryUp += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                #endregion
                #region Pre Golem
                case ItemID.BeetleHelmet:
                    modPlayer.Guard += 2;
                    modPlayer.Spirit += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.BeetleScaleMail:
                    modPlayer.Guard += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.OffensiveGuard += 2;
                    break;
                case ItemID.BeetleShell:
                    modPlayer.Guard += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.GuardUp += 2;
                    break;
                case ItemID.BeetleLeggings:
                    modPlayer.AffinitySliding += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    modPlayer.Constitution += 1;
                    break;
                case ItemID.ShroomiteHeadgear:
                case ItemID.ShroomiteMask:
                case ItemID.ShroomiteHelmet:
                    modPlayer.Sneak += 1;
                    modPlayer.DeadEye += 1;
                    modPlayer.Mushroomancer += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.ShroomiteBreastplate:
                    modPlayer.Unscathed += 1;
                    DecorPlayer.DecorationTwoSlots += 2;
                    modPlayer.DeadEye += 1;
                    break;
                case ItemID.ShroomiteLeggings:
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.SpareShot += 1;
                    modPlayer.RapidFire += 1;
                    break;
                case ItemID.SpectreMask:
                case ItemID.SpectreHood:
                    modPlayer.BlightProof += 2;
                    modPlayer.Guts += 1;
                    modPlayer.Heroics += 1;
                    break;
                case ItemID.SpectreRobe:
                    modPlayer.LatentPower += 1;
                    modPlayer.CriticalBoost += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.SpectrePants:
                    modPlayer.Heroics += 2;
                    modPlayer.ThunderAttack += 2;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.SpookyHelmet:
                    modPlayer.Tenderizer += 1;
                    modPlayer.SpiritBirdsCall = true;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.SpookyBreastplate:
                    modPlayer.Resentment += 1;
                    modPlayer.Protection += 2;
                    DecorPlayer.DecorationOneSlots += 3;
                    break;
                case ItemID.SpookyLeggings:
                    modPlayer.Tenderizer += 1;
                    modPlayer.RecoveryUp += 2;
                    modPlayer.FireAttack += 3;
                    break;
                case ItemID.SquireAltHead:
                    modPlayer.Embolden += 2;
                    modPlayer.GuardUp += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.SquireAltShirt:
                    modPlayer.Embolden += 2;
                    DecorPlayer.DecorationThreeSlots += 2;
                    break;
                case ItemID.SquireAltPants:
                    modPlayer.Embolden += 1;
                    modPlayer.Constitution += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.MonkAltHead:
                    modPlayer.AffinitySliding += 1;
                    modPlayer.Evasion += 1;
                    modPlayer.Sneak += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.MonkAltShirt:
                    modPlayer.Evasion += 3;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.MonkAltPants:
                    modPlayer.Resentment += 1;
                    modPlayer.CriticalBoost += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.HuntressAltHead:
                    modPlayer.SpareShot += 1;
                    modPlayer.CriticalBoost += 1;
                    modPlayer.SpiritBirdsCall = true;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.HuntressAltShirt:
                    DecorPlayer.DecorationTwoSlots += 1;
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.Evasion += 1;
                    modPlayer.QuickBreath += 1;
                    modPlayer.Fate += 1;
                    break;
                case ItemID.HuntressAltPants:
                    modPlayer.JumpMaster += 1;
                    modPlayer.DeadEye += 1;
                    modPlayer.Unscathed += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.ApprenticeAltHead:
                    modPlayer.CritElement += 1;
                    modPlayer.Strife += 1;
                    modPlayer.Resentment += 1;
                    modPlayer.CounterStrike += 1;
                    break;
                case ItemID.ApprenticeAltShirt:
                    modPlayer.CritElement += 1;
                    modPlayer.Strife += 1;
                    modPlayer.Resentment += 2;
                    DecorPlayer.DecorationOneSlots += 1;
                    break;
                case ItemID.ApprenticeAltPants:
                    modPlayer.Protection += 2;
                    modPlayer.StamRec += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                #endregion
                #region Post Moonlord
                case ItemID.SolarFlareHelmet:
                    modPlayer.Spirit += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.CriticalBoost += 1;
                    modPlayer.MastersTouch += 1;
                    break;
                case ItemID.SolarFlareBreastplate:
                    modPlayer.Spirit += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    modPlayer.CriticalBoost += 1;
                    modPlayer.MastersTouch += 1;
                    break;
                case ItemID.SolarFlareLeggings:
                    modPlayer.Spirit += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    modPlayer.CriticalBoost += 1;
                    modPlayer.MastersTouch += 1;
                    break;
                case ItemID.VortexHelmet:
                    modPlayer.RapidFire += 1;
                    modPlayer.DeadEye += 1;
                    modPlayer.EvadeDistance += 1;
                    DecorPlayer.DecorationTwoSlots += 1;
                    break;
                case ItemID.VortexBreastplate:
                    modPlayer.RapidFire += 2;
                    modPlayer.EvadeDistance += 2;
                    DecorPlayer.DecorationThreeSlots += 1;
                    break;
                case ItemID.VortexLeggings:
                    modPlayer.CriticalBoost += 2;
                    DecorPlayer.DecorationThreeSlots += 2;
                    break;
                case ItemID.NebulaHelmet:
                    DecorPlayer.DecorationThreeSlots += 1;
                    modPlayer.EvadeDistance += 1;
                    modPlayer.CriticalBoost += 1;
                    modPlayer.Guts += 1;
                    break;
                case ItemID.NebulaBreastplate:
                    DecorPlayer.DecorationOneSlots += 1;
                    modPlayer.MailofHellfire += 2;
                    DecorPlayer.DecorationTwoSlots += 1;
                    modPlayer.Guts += 1;
                    break;
                case ItemID.NebulaLeggings:
                    modPlayer.MailofHellfire += 1;
                    modPlayer.EvadeDistance += 2;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.StardustHelmet:
                    DecorPlayer.DecorationThreeSlots += 1;
                    modPlayer.Evasion += 2;
                    modPlayer.Health += 2;
                    break;
                case ItemID.StardustBreastplate:
                    DecorPlayer.DecorationThreeSlots += 2;
                    modPlayer.BloodRite += 2;
                    break;
                case ItemID.StardustLeggings:
                    DecorPlayer.DecorationTwoSlots += 1;
                    DecorPlayer.DecorationThreeSlots += 1;
                    modPlayer.BloodRite += 1;
                    modPlayer.RecoveryUp += 2;
                    break;
                #endregion
                #endregion
                #region Misc

                case ItemID.MagicHat:
                    modPlayer.Scholar += 1;
                    DecorPlayer.DecorationOneSlots += 2;
                    break;
                case ItemID.WizardHat:
                    modPlayer.Scholar += 2;
                    DecorPlayer.DecorationTwoSlots += 2;
                    break;
                case ItemID.FlinxFurCoat:
                    modPlayer.IceAttack += 3;
                    break;
                case ItemID.AmberRobe:
                case ItemID.AmethystRobe:
                case ItemID.SapphireRobe:
                case ItemID.EmeraldRobe:
                case ItemID.RubyRobe:
                case ItemID.DiamondRobe:
                case ItemID.GypsyRobe:
                    modPlayer.StamRec += 2;
                    break;
                case ItemID.DivingHelmet:
                    modPlayer.AMobility += 2;
                    break;
                case ItemID.Gi:
                    modPlayer.EvadeDistance += 2;
                    break;
                    #endregion
            }
        }
    }
}
