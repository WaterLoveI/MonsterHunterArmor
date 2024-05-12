using MHArmorSkills.MHPlayer;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace MHArmorSkills.Global
{
    public partial class MHGlobalToolTips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Modify all vanilla tooltips before appending mod mechanics (if any). thanks calamity
            ModifyVanillaTooltips(item, tooltips);
        }

        private static void ModifyVanillaTooltips(Item item, IList<TooltipLine> tooltips)
        {
            #region Modular Tooltip Editing Code
            // This is a modular tooltip editor which loops over all tooltip lines of an item,
            // selects all those which match an arbitrary function you provide,
            // then edits them using another arbitrary function you provide.
            void ApplyTooltipEdits(IList<TooltipLine> lines, Func<Item, TooltipLine, bool> predicate, Action<TooltipLine> action)
            {
                foreach (TooltipLine line in lines)
                    if (predicate.Invoke(item, line))
                        action.Invoke(line);
            }

            // This function produces simple predicates to match a specific line of a tooltip, by number/index.
            Func<Item, TooltipLine, bool> LineNum(int n) => (Item i, TooltipLine l) => l.Mod == "Terraria" && l.Name == $"Tooltip{n}";
            // This function produces simple predicates to match a specific line of a tooltip, by name.
            Func<Item, TooltipLine, bool> LineName(string s) => (Item i, TooltipLine l) => l.Mod == "Terraria" && l.Name == s;

            // These functions are shorthand to invoke ApplyTooltipEdits using the above predicates.
            void EditTooltipByNum(int lineNum, Action<TooltipLine> action) => ApplyTooltipEdits(tooltips, LineNum(lineNum), action);
            void EditTooltipByName(string lineName, Action<TooltipLine> action) => ApplyTooltipEdits(tooltips, LineName(lineName), action);

            // For items such as a Copper Helmet which literally have no tooltips at all, add a custom "Tooltip0" which mimics the vanilla Tooltip0.
            void AddTooltip(string text)
            {
                // Don't add the tooltip if the item is in a social slot
                if (item.social)
                    return;

                int defenseIndex = -1;
                for (int i = 0; i < tooltips.Count; ++i)
                    if (tooltips[i].Name == "Defense")
                    {
                        defenseIndex = i;
                        break;
                    }
                tooltips.Insert(defenseIndex + 1, new TooltipLine(MHArmorSkills.Instance, "Tooltip0", text));
            }
            #endregion

            Player player = Main.LocalPlayer;

            #region Armor skills
            #region Pre HM
            #region Pre Boss
            if (item.type == ItemID.MiningHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Autotracker Skill by 1.\n" +
                "Increase the Geologist Skill by 1.");
            if (item.type == ItemID.MiningShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Cliffhanger Skill by 1.\n" +
                "Increase the Geologist Skill by 1.");
            if (item.type == ItemID.MiningPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Cliffhanger Skill by 1.\n" +
                "Increase the Quick Gathering Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.WoodHelmet || item.type == ItemID.RichMahoganyHelmet || item.type == ItemID.BorealWoodHelmet || item.type == ItemID.PalmWoodHelmet || item.type == ItemID.EbonwoodHelmet || item.type == ItemID.ShadewoodHelmet || item.type == ItemID.AshWoodHelmet)
                AddTooltip("Increase the Defense Boost Skill by 1.");
            if (item.type == ItemID.WoodBreastplate || item.type == ItemID.RichMahoganyBreastplate || item.type == ItemID.BorealWoodBreastplate || item.type == ItemID.PalmWoodBreastplate || item.type == ItemID.EbonwoodBreastplate || item.type == ItemID.ShadewoodBreastplate || item.type == ItemID.AshWoodBreastplate)
                AddTooltip("Increase the Protection Skill by 1.");
            if (item.type == ItemID.WoodGreaves || item.type == ItemID.RichMahoganyGreaves || item.type == ItemID.BorealWoodGreaves || item.type == ItemID.PalmWoodGreaves || item.type == ItemID.EbonwoodGreaves || item.type == ItemID.ShadewoodGreaves || item.type == ItemID.AshWoodGreaves)
                AddTooltip("Increase the Gathering Skill by 1.");
            if (item.type == ItemID.AnglerHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Autotracker Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.AnglerVest)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Free Meal Skill by 1.");
            if (item.type == ItemID.AnglerPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Aquatic Mobility Skill by 1.");
            if (item.type == ItemID.CactusHelmet)
                AddTooltip("Increase the Sneak Skill by 1.");
            if (item.type == ItemID.CactusBreastplate)
                AddTooltip("Increase the Recovery Speed Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.CactusLeggings)
                AddTooltip("Increase the Stamina Recovery Skill by 1.");
            if (item.type == ItemID.CopperHelmet)
                AddTooltip("Increase the Speed Eating Skill by 1.");
            if (item.type == ItemID.CopperChainmail)
                AddTooltip("Increase the Defense Boost Skill by 1.");
            if (item.type == ItemID.CopperGreaves)
                AddTooltip("Increase the Anti-Poison Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.TinHelmet)
                AddTooltip("Increase the Defense Boost Skill by 1.");
            if (item.type == ItemID.TinChainmail)
                AddTooltip("Increase the Stamina Recovery Skill by 1.");
            if (item.type == ItemID.TinGreaves)
                AddTooltip("Increase the Cliffhanger Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.PumpkinHelmet)
                AddTooltip("Increase the Free Meal Skill by 1.");
            if (item.type == ItemID.PumpkinBreastplate)
                AddTooltip("Increase the Gluttony Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.PumpkinLeggings)
                AddTooltip("Increase the Speed Eating Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.IronHelmet)
                AddTooltip("Increase the Defense Boost Skill by 1.");
            if (item.type == ItemID.AncientIronHelmet)
                AddTooltip("Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.IronChainmail)
                AddTooltip("Increase the Diversion Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.IronGreaves)
                AddTooltip("Increase the Recovery Speed Skill by 1.");
            if (item.type == ItemID.LeadHelmet)
                AddTooltip("Increase the Anti-Poison Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.LeadChainmail)
                AddTooltip("Increase the Defense Boost Skill by 1.");
            if (item.type == ItemID.LeadGreaves)
                AddTooltip("Increase the Defense Boost Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.SilverHelmet)
                AddTooltip("Increase the Stamina Recovery Skill by 1.");
            if (item.type == ItemID.SilverChainmail)
                AddTooltip("Increase the Attack Boost Skill by 2.");
            if (item.type == ItemID.SilverGreaves)
                AddTooltip("Increase the Free Meal Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.TungstenHelmet)
                AddTooltip("Increase the Recovery Speed Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.TungstenChainmail)
                AddTooltip("Increase the Critical Eye Skill by 1.");
            if (item.type == ItemID.TungstenGreaves)
                AddTooltip("Increase the Diversion Skill by 1.");
            if (item.type == ItemID.GoldHelmet)
                AddTooltip("Increase the Diversion Skill by 1.");
            if (item.type == ItemID.AncientGoldHelmet)
                AddTooltip("Increase the Fate Skill by 1.");
            if (item.type == ItemID.GoldChainmail)
                AddTooltip("Increase the Protection Skill by 1.\n" +
                "Increase the Speed Sharpening Skill by 1.");
            if (item.type == ItemID.GoldGreaves)
                AddTooltip("Increase the Diversion Skill by 1.\n" +
                "Increase the Speed Sharpening Skill by 1.");
            if (item.type == ItemID.PlatinumHelmet)
                AddTooltip("Increase the Fortified Skill by 1.");
            if (item.type == ItemID.PlatinumChainmail)
                AddTooltip("Increase the Protection Skill by 1.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.PlatinumGreaves)
                AddTooltip("Increase the Diversion Skill by 1.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.FossilHelm)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Jump Master Skill by 1.");
            if (item.type == ItemID.FossilShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Counter-Strike Skill by 1.\n" +
                "Increase the Fire Res Skill by 1.");
            if (item.type == ItemID.FossilPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Fortified Skill by 1.\n" +
                "Increase the Fire Res Skill by 1.");
            if (item.type == ItemID.GladiatorHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 1.");
            if (item.type == ItemID.GladiatorBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Speed Setup Skill by 1.\n" +
                "Increase the Ice Res Skill by 1.");
            if (item.type == ItemID.GladiatorLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Ice Res Skill by 1.");
            #endregion
            #region Post Boss
            if (item.type == ItemID.NinjaHood)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Sneak Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.");
            if (item.type == ItemID.NinjaShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Speed Setup Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.");
            if (item.type == ItemID.NinjaPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critial Eye Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.BeeHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Resentment Skill by 1.\n" +
                "Increase the Lasting Power Skill by 1.");
            if (item.type == ItemID.BeeBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Autotracker Skill by 1.\n" +
                "Increase the Honey Hunter Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.BeeGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Resentment Skill by 1.\n" +
                "Increase the Honey Hunter Skill by 1.");
            if (item.type == ItemID.ObsidianHelm)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Autotracker Skill by 1.\n" +
                "Increase the Attack Boost Skill by 2.");
            if (item.type == ItemID.ObsidianShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Counter-Strike Skill by 1.\n" +
                "Increase the Punish Draw Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.ObsidianPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 2.\n" +
                "Increase the Quick Sheath Skill by 1.");
            if (item.type == ItemID.MeteorHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power Skill by 1.\n" +
                "Increase the Fire Attack Skill by 2.");
            if (item.type == ItemID.MeteorSuit)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power Skill by 1.\n" +
                "Increase the Fire Attack Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.MeteorLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Stamina Recovery Skill by 1.\n" +
                "Increase the Heat Res Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.JungleHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Lasting Power Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.JungleShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Mushroomancer Skill by 1.\n" +
                "Increase the Water Res Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.JunglePants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Cliffhanger Skill by 1.\n" +
                "Increase the Free Meal Skill by 1.\n" +
                "Increase the Tropic Hunter Skill by 1.");
            if (item.type == ItemID.AncientCobaltHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Stamina Recovery Skill by 1.\n" +
                "Increase the Anti-Poison Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.AncientCobaltBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Foray Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.AncientCobaltLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Foray Skill by 1.\n" +
                "Increase the Mushroomancer Skill by 1.");
            if (item.type == ItemID.NecroHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Unscathed Skill by 1.\n" +
                "Increase the Anti-Bleeding Skill by 1.");
            if (item.type == ItemID.NecroBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Cold Res Skill by 1.\n" +
                "Increase the Lasting Power Skill by 1.\n" +
                "Increase the Unscathed Skill by 1.");
            if (item.type == ItemID.NecroGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Aquatic Mobility Skill by 2.");
            if (item.type == ItemID.ShadowHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 1.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.ShadowScalemail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Quick Sheath Skill by 1.");
            if (item.type == ItemID.ShadowGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Razor Sharp Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.AncientShadowHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.");
            if (item.type == ItemID.AncientShadowScalemail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Constitution Skill by 1.\n" +
                "Increase the Evade Distance Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.AncientShadowGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.CrimsonHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Hasten Recovery Skill by 1.\n" +
                "Increase the Speed Sharpening Skill by 1.");
            if (item.type == ItemID.CrimsonScalemail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Hasten Recovery Skill by 1.\n" +
                "Increase the Recovery Up Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.CrimsonGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.MoltenHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Heat Res Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.MoltenBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.MoltenGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Heat Res Skill by 1.\n" +
                "[◯]x1");







            #endregion
            #endregion
            #region Hard Mode
            #region Pre Mech
            if (item.type == ItemID.SpiderMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Cliffhanger Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.SpiderBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Foray Skill by 1.\n" +
                "Increase the Anti-Poison Skill by 2.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.SpiderGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Constitution Skill by 1.\n" +
                "Increase the Evasion Skill by 1.\n" +
                "Increase the Foray Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.CobaltHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 2.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.CobaltMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 2.\n" +
                "Increase the Normal Up Skill by 1.");
            if (item.type == ItemID.CobaltHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 2.\n" +
                "Increase the Stamina Recovery Skill by 1.");
            if (item.type == ItemID.CobaltBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 1.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.CobaltLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Fencing Skill by 1.\n" +
                "Increase the Thunder Res Skill by 3.");
            if (item.type == ItemID.PalladiumHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 2.\n" +
                "Increase the Lasting Power Skill by 1.\n" +
                "Increase the Recovery Speed Skill by 1.");
            if (item.type == ItemID.PalladiumHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 2.\n" +
                "Increase the Normal Up Skill by 1.\n" +
                "Increase the Recovery Speed Skill by 1.");
            if (item.type == ItemID.PalladiumMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 2.\n" +
                "Increase the Recovery Speed by 1.\n" +
                "Increase the Protective Polish Skill by 1.");
            if (item.type == ItemID.PalladiumBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "Increase the Resentment by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.PalladiumLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 2.\n" +
                "Increase the Fire Res Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.MythrilHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Free Meal Skill by 2.\n" +
                "Increase the Speed Eating Skill by 2.\n" +
                "Increase the Pierce Up Skill by 1.");
            if (item.type == ItemID.MythrilHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Free Meal Skill by 2.\n" +
                "Increase the Razor Sharp Skill by 2.\n" +
                "Increase the Speed Eating Skill by 2.");
            if (item.type == ItemID.MythrilHood)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Free Meal Skill by 2.\n" +
                "Increase the Speed Eating Skill by 2.\n" +
                "Increase the Recovery Up Skill by 1.");
            if (item.type == ItemID.MythrilChainmail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 1.\n" +
                "Increase the Free Meal Skill by 1.\n" +
                "Increase the Recovery Up Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.MythrilGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Lasting Power Skill by 1.\n" +
                "Increase the Constitution Skill by 2.");
            if (item.type == ItemID.OrichalcumHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 3.\n" +
                "Increase the Fencing Skill by 1.");
            if (item.type == ItemID.OrichalcumHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 2.\n" +
                "Increase the Fencing Skill by 1.\n" +
                "Increase the Pierce Up Skill by 1.");
            if (item.type == ItemID.OrichalcumMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 2.\n" +
                "Increase the Fencing Skill by 1.\n" +
                "Increase the Protective Polish Skill by 1.");
            if (item.type == ItemID.OrichalcumBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Lasting Power Skill by 1.\n" +
                "Increase the Ice Res Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.OrichalcumLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Lasting Power Skill by 2.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.AdamantiteHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "Increase the Protective Polish Skill by 1.\n" +
                "Increase the Tenderizer Skill by 1.");
            if (item.type == ItemID.AdamantiteHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "Increase the Tenderizer Skill by 2.");
            if (item.type == ItemID.AdamantiteMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "Increase the Pellet Up Skill by 1.\n" +
                "Increase the Tenderizer Skill by 1.");
            if (item.type == ItemID.AdamantiteBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Spirit Skill by 1.\n" +
                "Increase the Guard Skill by 1.\n" +
                "Increase the Def Lock Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.AdamantiteLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Defense Boost Skill by 2.\n" +
                "Increase the Razor Sharp Skill by 1.\n" +
                "Increase the Guard Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.TitaniumHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Diversion Skill by 2.\n" +
                "Increase the Latent Power Skill by 1.\n" +
                "Increase the Protection Skill by 1.");
            if (item.type == ItemID.TitaniumHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Diversion Skill by 2.\n" +
                "Increase the Latent Power Skill by 2.\n" +
                "Increase the Pellet Up Skill by 1.");
            if (item.type == ItemID.TitaniumMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Diversion Skill by 2.\n" +
                "Increase the Razor Sharp Skill by 2.\n" +
                "Increase the Latent Power Skill by 1.");
            if (item.type == ItemID.TitaniumBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Latent Power Skill by 1.\n" +
                "Increase the Rock Steady Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.TitaniumLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Diversion Skill by 1.\n" +
                "Increase the Ice Attack Skill by 1.\n" +
                "Increase the Evasion Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.CrystalNinjaHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Jumping Master Skill by 1.\n" +
                "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Speed Setup Boost Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.CrystalNinjaChestplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 2.\n" +
                "Increase the Bubble Dance Skill by 2.\n" +
                "Increase the Affinity Sliding Skill by 1.");
            if (item.type == ItemID.CrystalNinjaLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Speed Setup Skill by 1.\n" +
                "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Bubble Dance Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.FrostHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Cold Res Skill by 3.\n" +
                "Increase the Hasten Recovery Skill by 1.\n" +
                "Increase the Polar Hunter Skill by 1.");
            if (item.type == ItemID.FrostBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Ice Attack Skill by 1.\n" +
                "Increase the Protection Skill by 1.\n" +
                "Increase the Polar Hunter Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.FrostLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Ice Attack Skill by 2.\n" +
                "Increase the Polar Hunter Skill by 1.\n" +
                "Increase the Aquatic Mobility Skill by 2.");
            if (item.type == ItemID.AncientBattleArmorHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Heat Res Skill by 3.\n" +
                "Increase the Guts Skill by 1.\n" +
                "Increase the Tropic Hunter Skill by 1.");
            if (item.type == ItemID.AncientBattleArmorShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power Skill by 1.\n" +
                "Increase the Unscathed Skill by 1.\n" +
                "Increase the Tropic Hunter Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.AncientBattleArmorPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 1.\n" +
                "Increase the Tropic Hunter Skill by 1.\n" +
                "Increase the Fate Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.SquireGreatHelm)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Guard Up Skill by 1.\n" +
                "Increase the Diversion Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.SquirePlating)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Slugger Skill by 1.\n" +
                "Increase the Diversion Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.SquireGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Crit Draw Skill by 1.\n" +
                "Increase the Constitution Skill by 1.\n" +
                "Increase the Hasten Recovery Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.MonkBrows)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 2.\n" +
                "Increase the Defense Boost Skill by 2.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.MonkShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Focus Skill by 1.\n" +
                "Increase the Speed Eating Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.MonkPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Health Skill by 1.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.HuntressWig)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evade Distance Skill by 1.\n" +
                "Increase the Foray Skill by 1.\n" +
                "Increase the Spare Shot Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.HuntressJerkin)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Foray Skill by 1.\n" +
                "Increase the Evade Distance Skill by 1.\n" +
                "Increase the Tropic Hunter Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.HuntressPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Spare Shot Skill by 1.\n" +
                "Increase the Pierce Up Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ApprenticeHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Unscathed Skill by 2.\n" +
                "Increase the Hasten Recovery Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ApprenticeRobe)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power Skill by 2.\n" +
                "Increase the Hasten Recovery Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ApprenticeTrousers)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power Skill by 2.\n" +
                "[◯][◯]x2");




            #endregion
            #region Pre Plantera
            if (item.type == ItemID.HallowedMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Speed Sharpening Skill by 2.\n" +
                "Increase the Spirit Skill by 1.");
            if (item.type == ItemID.HallowedHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Spare Shot Skill by 2.\n" +
                "Increase the Spirit Skill by 1.");
            if (item.type == ItemID.HallowedHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Latent Power Skill by 2.\n" +
                "Increase the Spirit Skill by 1.");
            if (item.type == ItemID.HallowedHood)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Spirit Skill by 1.\n" +
                "Increase the Unscathed Skill by 2.");
            if (item.type == ItemID.HallowedPlateMail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Recovery Speed Skill by 1.\n" +
                "Increase the Critical Boost Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.HallowedGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.AncientHallowedMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Protective Polish Skill by 1.\n" +
                "Increase the Razor Sharp Skill by 1.");
            if (item.type == ItemID.AncientHallowedHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Artillery Skill by 1.");
            if (item.type == ItemID.AncientHallowedHeadgear)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Affinity Sliding Skill by 1.");
            if (item.type == ItemID.AncientHallowedHood)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1.\n" +
                "Increase the Critical Eye Skill by 1.\n" +
                "Increase the Hasten Recovery Skill by 1.");
            if (item.type == ItemID.AncientHallowedPlateMail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Recovery Speed Skill by 2.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.AncientHallowedGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 2.\n" +
                "Increase the Handicraft Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ChlorophyteHelmet || item.type == ItemID.ChlorophyteHeadgear || item.type == ItemID.ChlorophyteMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Tropic Hunter Skill by 2.\n" +
                "Increase the Health Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.ChlorophytePlateMail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Health Skill by 2.\n" +
                "Increase the Quick Breath Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ChlorophyteGreaves)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 2.\n" +
                "Increase the Water Res Skill by 2.\n" +
                "[◯]x2\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.TurtleHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Defense Boost Skill by 1.\n" +
                "Increase the Guard Skill by 1.\n" +
                "Increase the Defiance Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.TurtleScaleMail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Defiance Skill by 2.\n" +
                "Increase the Resentment Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.TurtleLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Defiance Skill by 2.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.TikiMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Foray Skill by 2.\n" +
                "Increase the Sneak Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.TikiShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Water Res Skill by 2.\n" +
                "Increase the Recovery Up Skill by 1.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.TikiPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Attack Boost Skill by 1\n" +
                "Increase the Fencing Skill by 1.\n" +
                "Increase the Recovery Up Skill by 1.\n" +
                "[◯]x1");

            #endregion
            #region Pre Golem
            if (item.type == ItemID.BeetleHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 2.\n" +
                "Increase the Spirit Skill by 2.\n" +
                "[◯]x1");
            if (item.type == ItemID.BeetleScaleMail)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Offensive Guard Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.BeetleShell)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Guard Skill by 1.\n" +
                "Increase the Guard Up Skill by 2.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.BeetleLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Constitution Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.ShroomiteHeadgear || item.type == ItemID.ShroomiteHelmet || item.type == ItemID.ShroomiteMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Sneak Skill by 1.\n" +
                "Increase the Mushroomancer Skill by 1.\n" +
                "Increase the Deadeye Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.ShroomiteBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the DeadEye Skill by 1.\n" +
                "Increase the Unscathed Skill by 1.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.ShroomiteLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Spare Shot Skill by 1.\n" +
                "Increase the Rapidfire Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.SpectreHood)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Blightproof Skill by 2.\n" +
                "Increase the Heroic Skill by 1.\n" +
                "Increase the Guts Skill by 1.");
            if (item.type == ItemID.SpectreMask)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Blightproof Skill by 2.\n" +
                "Increase the Heroic Skill by 1.\n" +
                "Increase the Guts Skill by 1.");
            if (item.type == ItemID.SpectreRobe)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Latent Power by 1.\n" +
                "Increase the Critical Boost Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.SpectrePants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Heroic Skill by 2.\n" +
                "Increase the Thunder Attack Skill by 2.\n" +
                "[◯]x2");
            if (item.type == ItemID.SpookyHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Grant the Spiritbird's Call Skill.\n" +
                "Increase the Tenderizer Skill by 1.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.SpookyBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Resentment Skill by 1.\n" +
                "Increase the Protection Skill by 2.\n" +
                "[◯]x3");
            if (item.type == ItemID.SpookyLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Fire Attack Skill by 3.\n" +
                "Increase the Recovery Up Skill by 1.\n" +
                "Increase the Tenderizer Skill by 1.");
            if (item.type == ItemID.SquireAltHead)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Embolden Skill by 2.\n" +
                "Increase the Guard Up Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.SquireAltShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Embolden Skill by 2.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.SquireAltPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Constitution Skill by 2.\n" +
                "Increase the Embolden Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.MonkAltHead)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Affinity Sliding Skill by 1.\n" +
                "Increase the Evasion Skill by 1.\n" +
                "Increase the Sneak Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.MonkAltShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 3.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.MonkAltPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Boost Skill by 1.\n" +
                "Increase the Resentment Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.HuntressAltHead)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Spare Shot Skill by 1.\n" +
                "Increase the Critical Boost Skill by 1.\n" +
                "Grant the Spiritbird's Call Skill.\n" +
                "[◯]x1");
            if (item.type == ItemID.HuntressAltShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 1.\n" +
                "Increase the Quick Breath Skill by 1.\n" +
                "Increase the Fate Skill by 1.\n" +
                "[◯]x1\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.HuntressAltPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Jump Master Skill by 1.\n" +
                "Increase the Deadeye Skill by 1.\n" +
                "Increase the Unscathed Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.ApprenticeAltHead)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Crit Element Skill by 1.\n" +
                "Increase the Counter-Strike Skill by 1.\n" +
                "Increase the Resentment Skill by 1.\n" +
                "Increase the Strife Skill by 1.");
            if (item.type == ItemID.ApprenticeAltShirt)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Resentment Skill by 1.\n" +
                "Increase the Crit Element Skill by 1.\n" +
                "Increase the Strife Skill by 1.\n" +
                "[◯]x1");
            if (item.type == ItemID.ApprenticeAltPants)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Protection Skill by 2.\n" +
                "Increase the Stamina Recovery Skill by 1.\n" +
                "[◯][◯]x1");

            #endregion
            #region Post ML
            if (item.type == ItemID.SolarFlareHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Boost Skill by 1.\n" +
                "Increase the Masters Touch Skill by 1.\n" +
                "Increase the Spirit Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.SolarFlareBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Spirit Skill by 1.\n" +
                "Increase the Critical Boost Skill by 1.\n" +
                "Increase the Masters Touch Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.SolarFlareLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Boost Skill by 1.\n" +
                "Increase the Masters Touch Skill by 1.\n" +
                "Increase the Spirit Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.VortexHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Deadeye Skill by 1.\n" +
                "Increase the Evade Distance Skill by 1.\n" +
                "Increase the Rapidfire Skill by 1.\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.VortexBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evade Distance Skill by 2.\n" +
                "Increase the Rapidfire Skill by 2.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.VortexLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Boost Skill by 2.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.NebulaHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Critical Boost Skill by 1.\n" +
                "Increase the Evade Distance Skill by 1.\n" +
                "Increase the Guts Skill by 1.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.NebulaBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Mail of Hellfire Skill by 2.\n" +
                "Increase the Guts Skill by 1.\n" +
                "[◯]x1\n" +
                "[◯][◯]x1");
            if (item.type == ItemID.NebulaLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evade Distance Skill by 2.\n" +
                "Increase the Mail of Hellfire Skill by 1.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.StardustHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evasion Skill by 2.\n" +
                "Increase the Health Skill by 2.\n" +
                "[◯][◯][◯]x1");
            if (item.type == ItemID.StardustBreastplate)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Bloodrite Skill by 2.\n" +
                "[◯][◯][◯]x2");
            if (item.type == ItemID.StardustLeggings)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Recovery Up Skill by 2.\n" +
                "Increase the Blood Rite Skill by 1.\n" +
                "[◯][◯]x1\n" +
                "[◯][◯][◯]x1");

            #endregion

            #endregion
            #region Misc
            if (item.type == ItemID.MagicHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Scholar Skill by 1.\n" +
                "[◯]x2");
            if (item.type == ItemID.WizardHat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Scholar Skill by 2.\n" +
                "[◯][◯]x2");
            if (item.type == ItemID.AmberRobe || item.type == ItemID.AmethystRobe || item.type == ItemID.DiamondRobe || item.type == ItemID.EmeraldRobe || item.type == ItemID.GypsyRobe || item.type == ItemID.RubyRobe || item.type == ItemID.SapphireRobe || item.type == ItemID.TopazRobe)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Stamina Recovery Skill by 2.");
            if (item.type == ItemID.DivingHelmet)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Aquatic Mobility Skill by 2.");
            if (item.type == ItemID.Gi)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Evade Distance Skill by 2.");
            if (item.type == ItemID.FlinxFurCoat)
                EditTooltipByNum(0, (line) => line.Text = "Increase the Ice Attack Skill by 3.");

            #endregion


            #endregion
            #region Weapons
            if (MHLists.fireelementList.Contains(item.type))
            {
                EditTooltipByNum(0, (line) => line.Text = "Fire Element Weapon.");
            }
            if (MHLists.iceelementList.Contains(item.type))
            {
                EditTooltipByNum(0, (line) => line.Text = "Ice Element Weapon.");
            }
            if (MHLists.thunderelementList.Contains(item.type))
            {
                EditTooltipByNum(0, (line) => line.Text = "Thunder Element Weapon.");
            }
            if (MHLists.waterelementList.Contains(item.type))
            {
                EditTooltipByNum(0, (line) => line.Text = "Water Element Weapon.");
            }
            #endregion


            if (item.healLife > 0 && player.GetModPlayer<MHPlayerArmorSkill>().RecoveryUp >= 1)
            {
                // update the tooltip of healing item if recovery up is in effect.
                int healAmt = (int)(item.healLife * player.GetModPlayer<MHPlayerArmorSkill>().RecoveryUp);
                EditTooltipByName("HealLife", (line) => line.Text = $"Restores {healAmt} life");
            }


        }
    }
}

