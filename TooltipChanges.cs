
using MHArmorSkills.Config;
using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
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
