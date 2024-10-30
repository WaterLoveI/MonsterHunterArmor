
using MHArmorSkills.Config;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.UI;

using static Terraria.ModLoader.ModContent;

namespace MHArmorSkills
{
    public static class TooltipChanges
    {
        class ReplacedTooltipLine
        {
            public ItemTooltip Line;
            public short ItemID;

            public ReplacedTooltipLine(ItemTooltip line, short itemID)
            {
                Line = line;
                ItemID = itemID;
            }
        }

        static List<ReplacedTooltipLine> ReplacedTooltips = new();

        static void ReplaceTooltip(ItemTooltip[] tooltipArray, string newTooltip, short itemID)
        {
            ReplacedTooltips.Add(new ReplacedTooltipLine(tooltipArray[itemID], itemID));
            if (newTooltip == null)
                tooltipArray[itemID] = ItemTooltip.None;
            else
                tooltipArray[itemID] = ItemTooltip.FromLanguageKey(newTooltip);
        }

        public static void EditTooltips()
        {
            var bindFlags = BindingFlags.Static | BindingFlags.NonPublic;
            var tooltipsField = typeof(Lang).GetField("_itemTooltipCache", bindFlags);
            var tooltips = (ItemTooltip[])tooltipsField.GetValue(null);
            if (GetInstance<VanillaArmorSkills>().VanillaArmorToggle)
            {
                #region pre boss
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MiningHelmet", ItemID.MiningHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MiningChest", ItemID.MiningShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MiningLeg", ItemID.MiningPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.WoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.EbonwoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.PearlwoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.PalmWoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.AshWoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.BorealWoodHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodHelmet", ItemID.RichMahoganyHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.WoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.EbonwoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.PearlwoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.PalmWoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.AshWoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.BorealWoodBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodChest", ItemID.RichMahoganyBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.WoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.EbonwoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.PearlwoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.PalmWoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.AshWoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.BorealWoodGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WoodLegs", ItemID.RichMahoganyGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AnglerHelmet", ItemID.AnglerHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AnglerChest", ItemID.AnglerVest);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AnglerLegs", ItemID.AnglerPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CactusHelmet", ItemID.CactusHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CactusChest", ItemID.CactusBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CactusLegs", ItemID.CactusLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CopperHelmet", ItemID.CopperHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CopperChest", ItemID.CopperChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CopperLegs", ItemID.CopperGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TinHelmet", ItemID.TinHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TinChest", ItemID.TinChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TinLegs", ItemID.TinGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PumpkinHelmet", ItemID.PumpkinHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PumpkinChest", ItemID.PumpkinBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PumpkinLegs", ItemID.PumpkinLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.IronHelmet", ItemID.IronHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientIronHelmet", ItemID.AncientIronHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.IronChest", ItemID.IronChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.IronLegs", ItemID.IronGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.LeadHelmet", ItemID.LeadHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.LeadChest", ItemID.LeadChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.LeadLegs", ItemID.LeadGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SilverHelmet", ItemID.SilverHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SilverChest", ItemID.SilverChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SilverLegs", ItemID.SilverGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TungstenHelmet", ItemID.TungstenHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TungstenChest", ItemID.TungstenChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TungstenLegs", ItemID.TungstenGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GoldHelmet", ItemID.GoldHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientGoldHelmet", ItemID.AncientGoldHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GoldChest", ItemID.GoldChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GoldLegs", ItemID.GoldGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PlatinumHelmet", ItemID.PlatinumHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PlatinumChest", ItemID.PlatinumChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PlatinumLegs", ItemID.PlatinumGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FossilHelmet", ItemID.FossilHelm);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FossilChest", ItemID.FossilShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FossilLegs", ItemID.FossilPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GladiatorHelmet", ItemID.GladiatorHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GladiatorChest", ItemID.GladiatorBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GladiatorLegs", ItemID.GladiatorLeggings);
                #endregion
                #region post boss
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NinjaHelmet", ItemID.NinjaHood);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NinjaChest", ItemID.NinjaShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NinjaLegs", ItemID.NinjaPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeeHelmet", ItemID.BeeHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeeChest", ItemID.BeeBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeeLegs", ItemID.BeeGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ObsidianHelmet", ItemID.ObsidianHelm);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ObsidianChest", ItemID.ObsidianShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ObsidianLegs", ItemID.ObsidianPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MeteorHelmet", ItemID.MeteorHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MeteorChest", ItemID.MeteorSuit);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MeteorLegs", ItemID.MeteorLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.JungleHelmet", ItemID.JungleHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.JungleChest", ItemID.JungleShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.JungleLegs", ItemID.JunglePants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientCobaltHelmet", ItemID.AncientCobaltHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientCobaltChest", ItemID.AncientCobaltBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientCobaltLegs", ItemID.AncientCobaltLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NecroHelmet", ItemID.NecroHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NecroChest", ItemID.NecroBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NecroLegs", ItemID.NecroGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShadowHelmet", ItemID.ShadowHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShadowChest", ItemID.ShadowScalemail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShadowLegs", ItemID.ShadowGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientShadowHelmet", ItemID.AncientShadowHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientShadowChest", ItemID.AncientShadowScalemail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientShadowLegs", ItemID.AncientShadowGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrimsonHelmet", ItemID.CrimsonHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrimsonChest", ItemID.CrimsonScalemail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrimsonLegs", ItemID.CrimsonGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MoltenHelmet", ItemID.MoltenHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MoltenChest", ItemID.MoltenBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MoltenLegs", ItemID.MoltenGreaves);
                #endregion
                #region pre mech
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpiderMask", ItemID.SpiderMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpiderBreastplate", ItemID.SpiderBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpiderGreaves", ItemID.SpiderGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CobaltHat", ItemID.CobaltHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CobaltHelmet", ItemID.CobaltHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CobaltMask", ItemID.CobaltMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CobaltBreastplate", ItemID.CobaltBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CobaltLeggings", ItemID.CobaltLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PalladiumMask", ItemID.PalladiumMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PalladiumHelmet", ItemID.PalladiumHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PalladiumHeadgear", ItemID.PalladiumHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PalladiumBreastplate", ItemID.PalladiumBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.PalladiumLeggings", ItemID.PalladiumLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MythrilHood", ItemID.MythrilHood);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MythrilHelmet", ItemID.MythrilHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MythrilHat", ItemID.MythrilHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MythrilChainmail", ItemID.MythrilChainmail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MythrilGreaves", ItemID.MythrilGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.OrichalcumMask", ItemID.OrichalcumMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.OrichalcumHelmet", ItemID.OrichalcumHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.OrichalcumHeadgear", ItemID.OrichalcumHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.OrichalcumBreastplate", ItemID.OrichalcumBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.OrichalcumLeggings", ItemID.OrichalcumLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AdamantiteMask", ItemID.AdamantiteMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AdamantiteHelmet", ItemID.AdamantiteHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AdamantiteHeadgear", ItemID.AdamantiteHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AdamantiteBreastplate", ItemID.AdamantiteBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AdamantiteLeggings", ItemID.AdamantiteLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TitaniumMask", ItemID.TitaniumMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TitaniumHelmet", ItemID.TitaniumHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TitaniumHeadgear", ItemID.TitaniumHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TitaniumBreastplate", ItemID.TitaniumBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TitaniumLeggings", ItemID.TitaniumLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrystalAssassinHood", ItemID.CrystalNinjaHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrystalAssassinShirt", ItemID.CrystalNinjaChestplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.CrystalAssassinPants", ItemID.CrystalNinjaLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FrostHelmet", ItemID.FrostHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FrostBreastplate", ItemID.FrostBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FrostLeggings", ItemID.FrostLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ForbiddenMask", ItemID.AncientBattleArmorHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ForbiddenRobes", ItemID.AncientBattleArmorShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ForbiddenTreads", ItemID.AncientBattleArmorPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquiresGreatHelm", ItemID.SquireGreatHelm);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquiresPlating", ItemID.SquirePlating);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquiresGreaves", ItemID.SquireGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkBrows", ItemID.MonkBrows);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkShirt", ItemID.MonkShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkPants", ItemID.MonkPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressWig", ItemID.HuntressWig);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressJerkin", ItemID.HuntressJerkin);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressPants", ItemID.HuntressPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeHat", ItemID.ApprenticeHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeRobe", ItemID.ApprenticeRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeTrousers", ItemID.ApprenticeTrousers);
                #endregion
                #region post mech
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedHelmet", ItemID.HallowedHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedMask", ItemID.HallowedMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedHeadgear", ItemID.HallowedHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedHood", ItemID.HallowedHood);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedPlateMail", ItemID.HallowedPlateMail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HallowedGreaves", ItemID.HallowedGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedHelmet", ItemID.AncientHallowedHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedMask", ItemID.AncientHallowedMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedHeadgear", ItemID.AncientHallowedHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedHood", ItemID.AncientHallowedHood);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedPlateMail", ItemID.AncientHallowedPlateMail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AncientHallowedGreaves", ItemID.AncientHallowedGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ChlorophyteMask", ItemID.ChlorophyteMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ChlorophyteHelmet", ItemID.ChlorophyteHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ChlorophyteHeadgear", ItemID.ChlorophyteHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ChlorophytePlateMail", ItemID.ChlorophytePlateMail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ChlorophyteGreaves", ItemID.ChlorophyteGreaves);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TurtleHelmet", ItemID.TurtleHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TurtleScaleMail", ItemID.TurtleScaleMail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TurtleLeggings", ItemID.TurtleLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TikiMask", ItemID.TikiMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TikiShirt", ItemID.TikiShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TikiPants", ItemID.TikiPants);
                #endregion
                #region post golem
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeetleHelmet", ItemID.BeetleHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeetleScaleMail", ItemID.BeetleScaleMail);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeetleShell", ItemID.BeetleShell);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.BeetleLeggings", ItemID.BeetleLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShroomiteHeadgear", ItemID.ShroomiteHeadgear);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShroomiteMask", ItemID.ShroomiteMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShroomiteHelmet", ItemID.ShroomiteHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShroomiteBreastplate", ItemID.ShroomiteBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ShroomiteLeggings", ItemID.ShroomiteLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpectreMask", ItemID.SpectreMask);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpectreHood", ItemID.SpectreHood);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpectreRobe", ItemID.SpectreRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpectrePants", ItemID.SpectrePants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpookyHelmet", ItemID.SpookyHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpookyBreastplate", ItemID.SpookyBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SpookyLeggings", ItemID.SpookyLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquireAltHead", ItemID.SquireAltHead);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquireAltShirt", ItemID.SquireAltShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SquireAltPants", ItemID.SquireAltPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkAltHead", ItemID.MonkAltHead);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkAltShirt", ItemID.MonkAltShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MonkAltPants", ItemID.MonkAltPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressAltHead", ItemID.HuntressAltHead);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressAltShirt", ItemID.HuntressAltShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.HuntressAltPants", ItemID.HuntressAltPants);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeAltHead", ItemID.ApprenticeAltHead);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeAltShirt", ItemID.ApprenticeAltShirt);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.ApprenticeAltPants", ItemID.ApprenticeAltPants);
                #endregion
                #region ml
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SolarFlareHelmet", ItemID.SolarFlareHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SolarFlareBreastplate", ItemID.SolarFlareBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SolarFlareLeggings", ItemID.SolarFlareLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.VortexHelmet", ItemID.VortexHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.VortexBreastplate", ItemID.VortexBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.VortexLeggings", ItemID.VortexLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NebulaHelmet", ItemID.NebulaHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NebulaBreastplate", ItemID.NebulaBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.NebulaLeggings", ItemID.NebulaLeggings);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.StardustHelmet", ItemID.StardustHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.StardustBreastplate", ItemID.StardustBreastplate);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.StardustLeggings", ItemID.StardustLeggings);
                #endregion

                #region misc
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.MagicHat", ItemID.MagicHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.WizardHat", ItemID.WizardHat);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AmethystRobe", ItemID.AmethystRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.TopazRobe", ItemID.TopazRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.SapphireRobe", ItemID.SapphireRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.EmeraldRobe", ItemID.EmeraldRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.RubyRobe", ItemID.RubyRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.DiamondRobe", ItemID.DiamondRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.AmberRobe", ItemID.AmberRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.GypsyRobe", ItemID.GypsyRobe);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.DivingHelmet", ItemID.DivingHelmet);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.Gi", ItemID.Gi);
                ReplaceTooltip(tooltips, "Mods.MHArmorSkills.VanillaChanges.FlinxFurCoat", ItemID.FlinxFurCoat);
                #endregion
            }


        }

        public static void ResetTooltips()
        {
            var bindFlags = BindingFlags.Static | BindingFlags.NonPublic;
            var tooltipsField = typeof(Lang).GetField("_itemTooltipCache", bindFlags);
            var tooltips = (ItemTooltip[])tooltipsField.GetValue(null);
            foreach (var tooltip in ReplacedTooltips)
            {
                tooltips[tooltip.ItemID] = tooltip.Line;
            }
            ReplacedTooltips.Clear();

        }
    }
}
