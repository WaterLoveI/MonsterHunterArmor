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

