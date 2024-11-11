using MHArmorSkills.Items;
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

                int defenseIndex = 0;
                for (int i = 0; i < tooltips.Count; ++i)
                    if (tooltips[i].Name == "Defense")
                    {
                        defenseIndex = i;
                        break;
                    }
                tooltips.Insert(defenseIndex + 1, new TooltipLine(MHArmorSkills.Instance, "Tooltip2", text));
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
            if (item.type == ItemID.Mushroom)
            {
                if (player.GetModPlayer<MHPlayerArmorSkill>().Mushroomancer >= 1)
                {
                    int healAmt = (int)(player.statLifeMax2 * 0.33f);
                    EditTooltipByName("HealLife", (line) => line.Text = $"Restores {healAmt} life");
                }

            }
            DecorationSlots modPlayer = player.GetModPlayer<DecorationSlots>();
            if (MHLists.OneSlotDecorations.Contains(item.type))
            {
                if (modPlayer.DecorationOneSlots > 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently {modPlayer.DecorationOneSlots - 1} [○] slots available.");
                }
                if (modPlayer.DecorationOneSlots <= 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently have no [○] slots available.\n" +
                "Use armors with decoration slots to equip.");
                }
            }
            if (MHLists.TwoSlotDecorations.Contains(item.type))
            {
                if (modPlayer.DecorationTwoSlots > 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently {modPlayer.DecorationTwoSlots - 1} [○][○] slots available.");
                }
                if (modPlayer.DecorationTwoSlots <= 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently have no [○][○] slots available.\n" +
                "Use armors with decoration slots to equip.");
                }
            }
            if (MHLists.ThreeSlotDecorations.Contains(item.type))
            {
                if (modPlayer.DecorationThreeSlots > 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently {modPlayer.DecorationThreeSlots - 1} [○][○][○] slots available.");
                }
                if (modPlayer.DecorationThreeSlots <= 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently have no [○][○][○] slots available.\n" +
                "Use armors with decoration slots to equip.");
                }
            }
            if (MHLists.MixedSlotDecorations.Contains(item.type))
            {
                if (modPlayer.DecorationThreeSlots > 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently {modPlayer.DecorationThreeSlots - 1} [○][○][○] slots available.");
                }
                if (modPlayer.DecorationThreeSlots <= 1)
                {
                    EditTooltipByNum(2, (line) => line.Text = $"Currently have no [○][○][○] slots available.\n" +
                "Use armors with decoration slots to equip.");
                }
            }
            if (item.type == ModContent.ItemType<GuideBook>())
            {
                bool SkillsActive = false;

                if (player.GetModPlayer<ArmorSkills>().Windproof >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Windproof == 1)
                    {
                        AddTooltip($"Windproof Level {player.GetModPlayer<ArmorSkills>().Windproof} / 3: \n" +
                "Grant immunity to the Mighty wind debuff and increase defense by 2 while in the air.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Windproof == 2)
                    {
                        AddTooltip($"Windproof Level {player.GetModPlayer<ArmorSkills>().Windproof} / 3: \n" +
                "Grant immunity to the Mighty wind debuff and knockback. Increase defense by 5 while in the air.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Windproof >= 3)
                    {
                        AddTooltip($"Windproof Level {player.GetModPlayer<ArmorSkills>().Windproof} / 3: \n" +
                "Grant immunity to the Mighty wind debuff and knockback. Increase movement speed by 5% and defense by 5 while in the air.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().WaterRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().WaterRes == 1)
                    {
                        AddTooltip($"Water Res Level {player.GetModPlayer<ArmorSkills>().WaterRes} / 3: \n" +
                "Reduce damage from water projectiles and increase defense by 1");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterRes == 2)
                    {
                        AddTooltip($"Water Res Level {player.GetModPlayer<ArmorSkills>().WaterRes} / 3: \n" +
                "Reduce damage from water projectiles and increase defense by 2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterRes >= 3)
                    {
                        AddTooltip($"Water Res Level {player.GetModPlayer<ArmorSkills>().WaterRes} / 3: \n" +
                "Reduce damage from water projectiles and increase defense by 3");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().WaterAttack >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().WaterAttack == 1)
                    {
                        AddTooltip($"Water Attack Level {player.GetModPlayer<ArmorSkills>().WaterAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().WaterAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterAttack == 2)
                    {
                        AddTooltip($"Water Attack Level {player.GetModPlayer<ArmorSkills>().WaterAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().WaterAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterAttack == 3)
                    {
                        AddTooltip($"Water Attack Level {player.GetModPlayer<ArmorSkills>().WaterAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().WaterAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().WaterAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterAttack == 4)
                    {
                        AddTooltip($"Water Attack Level {player.GetModPlayer<ArmorSkills>().WaterAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().WaterAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().WaterAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().WaterAttack >= 5)
                    {
                        AddTooltip($"Water Attack Level {player.GetModPlayer<ArmorSkills>().WaterAttack} / 5: \n" +
                $"Increase base damage by 10% and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().WaterAttack + 2} and allows autofire");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Vault >= 1)
                {
                    AddTooltip($"Vault Level {player.GetModPlayer<ArmorSkills>().Vault} / 3: \n" +
                $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().Vault}% when in the air");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Unscathed >= 1)
                {
                    AddTooltip($"Unscathed Level {player.GetModPlayer<ArmorSkills>().Unscathed} / 3: \n" +
                $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().Unscathed}% when health is full");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().TropicsHunter >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().TropicsHunter == 1)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().TropicsHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterDef}% when in the jungle/desert or underworld biome");
                    }
                    if (player.GetModPlayer<ArmorSkills>().TropicsHunter == 2)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().TropicsHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterDef}% and movement speed by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterMovement}% when in the jungle/desert or underworld biome");
                        SkillsActive = true;
                    }
                    if (player.GetModPlayer<ArmorSkills>().TropicsHunter >= 3)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().TropicsHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterDef}%, movement speed by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterMovement}% and damage by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterAtk}% \n" +
                    $"when in the jungle,desert or underworld biome");
                        SkillsActive = true;
                    }
                }
                if (player.GetModPlayer<ArmorSkills>().TremorRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().TremorRes == 1)
                    {
                        AddTooltip($"Tremor Res Level {player.GetModPlayer<ArmorSkills>().TremorRes} / 3: \n" +
                "Increase defense by 2 while on the ground.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().TremorRes == 2)
                    {
                        AddTooltip($"Tremor Res Level {player.GetModPlayer<ArmorSkills>().TremorRes} / 3: \n" +
                "Grant immunity to knockback. Increase defense by 5 while on the ground.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().TremorRes >= 3)
                    {
                        AddTooltip($"Tremor Res Level {player.GetModPlayer<ArmorSkills>().TremorRes} / 3: \n" +
                "Grant immunity to knockback. Increase movement speed by 5% and defense by 5 on the ground..");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ThunderRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().ThunderRes == 1)
                    {
                        AddTooltip($"Thunder Res Level {player.GetModPlayer<ArmorSkills>().ThunderRes} / 3: \n" +
                "Reduce damage from thunder projectiles and increase defense by 1");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderRes == 2)
                    {
                        AddTooltip($"Thunder Res Level {player.GetModPlayer<ArmorSkills>().ThunderRes} / 3: \n" +
                "Reduce damage from thunder projectiles and increase defense by 2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderRes >= 3)
                    {
                        AddTooltip($"Thunder Res Level {player.GetModPlayer<ArmorSkills>().ThunderRes} / 3: \n" +
                "Reduce damage from thunder projectiles and increase defense by 3");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ThunderAttack >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().ThunderAttack == 1)
                    {
                        AddTooltip($"Thunder Attack Level {player.GetModPlayer<ArmorSkills>().ThunderAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().ThunderAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderAttack == 2)
                    {
                        AddTooltip($"Thunder Attack Level {player.GetModPlayer<ArmorSkills>().ThunderAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().ThunderAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderAttack == 3)
                    {
                        AddTooltip($"Thunder Attack Level {player.GetModPlayer<ArmorSkills>().ThunderAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().ThunderAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().ThunderAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderAttack == 4)
                    {
                        AddTooltip($"Thunder Attack Level {player.GetModPlayer<ArmorSkills>().ThunderAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().ThunderAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().ThunderAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ThunderAttack >= 5)
                    {
                        AddTooltip($"Thunder Attack Level {player.GetModPlayer<ArmorSkills>().ThunderAttack} / 5: \n" +
                $"Increase base damage by 10% and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().ThunderAttack + 2} and allows autofire");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().TeostraBlessing >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().TeostraBlessing == 1)
                    {
                        AddTooltip($"Teostra Blessing Level {player.GetModPlayer<ArmorSkills>().TeostraBlessing} / 3: \n" +
                "Increase damage for fire and thunder weapons by 5%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().TeostraBlessing == 2)
                    {
                        AddTooltip($"Teostra Blessing Level {player.GetModPlayer<ArmorSkills>().TeostraBlessing} / 3: \n" +
                "Increase damage for fire and thunder weapons by 10%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().TeostraBlessing >= 3)
                    {
                        AddTooltip($"Teostra Blessing Level {player.GetModPlayer<ArmorSkills>().TeostraBlessing} / 3: \n" +
                "Increase damage for fire and thunder weapons by 10% and critical strike chance by 5%");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Tenderizer >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Tenderizer == 1)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Tenderizer == 2)
                    {
                        Variable = 15;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Tenderizer >= 3)
                    {
                        Variable = 20;
                    }
                    AddTooltip($"Tenderizer Level {player.GetModPlayer<ArmorSkills>().Tenderizer} / 3: \n" +
                $"Increase damage by {Variable}% when the target has less than 25 defense.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().SurvivalExpert >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().SurvivalExpert == 1)
                    {
                        AddTooltip($"Survival Expert Level {player.GetModPlayer<ArmorSkills>().SurvivalExpert} / 2: \n" +
                    $"Hearts heals an extra 5 HP.");

                    }
                    if (player.GetModPlayer<ArmorSkills>().SurvivalExpert >= 2)
                    {
                        AddTooltip($"Survival Expert Level {player.GetModPlayer<ArmorSkills>().SurvivalExpert} / 2: \n" +
                    $"Hearts heals an extra 10 HP.");

                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Stunresist >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Stunresist == 1)
                    {
                        AddTooltip($"Stun resist Level {player.GetModPlayer<ArmorSkills>().Stunresist} / 2: \n" +
                    $"Increase defense by 10 when stunned.");

                    }
                    if (player.GetModPlayer<ArmorSkills>().Stunresist >= 2)
                    {
                        AddTooltip($"Stun resist Level {player.GetModPlayer<ArmorSkills>().Stunresist} / 2: \n" +
                    $"Immune to being stunned.");

                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Strife >= 1)
                {
                    AddTooltip($"Strife Level {player.GetModPlayer<ArmorSkills>().Strife} / 3: \n" +
                $"Increase critical strike chance by {player.GetModPlayer<MHPlayerArmorSkill>().StrifeCrit}% when life regen is below 0.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().StatusTrigger >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().StatusTrigger == 1)
                    {
                        AddTooltip($"Status Trigger Level {player.GetModPlayer<ArmorSkills>().StatusTrigger} / 2: \n" +
                    $"I-framing through a target to inflict poison on them.");

                    }
                    if (player.GetModPlayer<ArmorSkills>().StatusTrigger >= 2)
                    {
                        AddTooltip($"Status Trigger Level {player.GetModPlayer<ArmorSkills>().StatusTrigger} / 2: \n" +
                    $"I-framing through a target to inflict acid venom on them.");

                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().StamRec >= 1)
                {
                    AddTooltip($"Stamina Recovery Level {player.GetModPlayer<ArmorSkills>().StamRec} / 3: \n" +
                $"Mana regenerates even when using weapons");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().SpiritBirdsCall)
                {
                    AddTooltip($"Spiritbird's Call Level 1 / 1: \n" +
                $"Grants a random spiritbird buff every 3 minutes.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Spirit >= 1)
                {
                    AddTooltip($"Spirit Level {player.GetModPlayer<ArmorSkills>().Spirit} / 5: \n" +
                $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().SpiritAttack}% and critical strike chance {player.GetModPlayer<MHPlayerArmorSkill>().SpiritCrit}% by when a boss is nearby.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().SpeedSetup >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().SpeedSetup == 1)
                    {
                        AddTooltip($"Speed Setup Level {player.GetModPlayer<ArmorSkills>().SpeedSetup} / 3: \n" +
                    $"Allow auto reuse on consumable items.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().SpeedSetup == 2)
                    {
                        AddTooltip($"Speed Setup Level {player.GetModPlayer<ArmorSkills>().SpeedSetup} / 3: \n" +
                    $"Allow auto reuse on consumable items. 20% to not consume consumable weapons.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().SpeedSetup >= 3)
                    {
                        AddTooltip($"Speed Setup Level {player.GetModPlayer<ArmorSkills>().SpeedSetup} / 3: \n" +
                    $"Allow auto reuse on consumable items. 20% to not consume consumable weapons and increase critical strike chance by 5%.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().SpeedEating >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().SpeedEating == 1)
                    {
                        AddTooltip($"Speed Eating Level {player.GetModPlayer<ArmorSkills>().SpeedEating} / 3: \n" +
                    $"Decrease usetime of potions, 50% to not consume buff potions if you have the wellfed buff");
                    }
                    if (player.GetModPlayer<ArmorSkills>().SpeedEating == 2)
                    {
                        AddTooltip($"Speed Eating Level {player.GetModPlayer<ArmorSkills>().SpeedEating} / 3: \n" +
                    $"Decrease usetime of potions, 50% to not consume buff and mana potions if you have the wellfed buff");
                    }
                    if (player.GetModPlayer<ArmorSkills>().SpeedEating >= 3)
                    {
                        AddTooltip($"Speed Eating Level {player.GetModPlayer<ArmorSkills>().SpeedEating} / 3: \n" +
                    $"Decrease usetime of potions, 50% to not consume any potions if you have the wellfed buff");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot == 1)
                    {
                        AddTooltip($"Spare Shot Level {player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot} / 3: \n" +
                    $"16% chance to not consume ammo");
                    }
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot == 2)
                    {
                        AddTooltip($"Spare Shot Level {player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot} / 3: \n" +
                    $"20% chance to not consume ammo");
                    }
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot >= 3)
                    {
                        AddTooltip($"Spare Shot Level {player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot} / 3: \n" +
                    $"25% chance to not consume ammo");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().SneakAttack >= 1)
                {
                    AddTooltip($"Sneak Attack Level {player.GetModPlayer<ArmorSkills>().SneakAttack} / 3: \n" +
                $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().SneakAttack * 100}% when strike the target from behind.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Sneak >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Sneak == 1)
                    {
                        AddTooltip($"Sneak Level {player.GetModPlayer<ArmorSkills>().Sneak} / 3: \n" +
                    $"Decrease aggro by 100.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Sneak == 2)
                    {
                        AddTooltip($"Sneak Level {player.GetModPlayer<ArmorSkills>().Sneak} / 3: \n" +
                    $"Decrease aggro by 250, striking from behind will inflict confusion.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Sneak >= 3)
                    {
                        AddTooltip($"Sneak Level {player.GetModPlayer<ArmorSkills>().Sneak} / 3: \n" +
                    $"Increase critical strike chance by 5%, decrease aggro by 450, striking from behind will inflict confusion.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Scholar >= 1)
                {
                    AddTooltip($"Scholar Level {player.GetModPlayer<ArmorSkills>().Scholar} / 3: \n" +
                     $"Increase bestiary fill rate.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().RockSteady)
                {
                    AddTooltip($"Rock Steady Level 1 / 1: \n" +
                     $"Grant immunity to knockback and the mighty wind debuff.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Resuscitate >= 1)
                {
                    AddTooltip($"Resuscitate Level {player.GetModPlayer<ArmorSkills>().Resuscitate} / 3: \n" +
                     $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().resuscitateBuff}% when suffering from a debuff.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Resentment >= 1)
                {
                    AddTooltip($"Resuscitate Level {player.GetModPlayer<ArmorSkills>().Resentment} / 3: \n" +
                     $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().ResentmentBuff}% when life regen is less than 0.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Redirection >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Redirection == 1)
                    {
                        AddTooltip($"Redirection Level {player.GetModPlayer<ArmorSkills>().Redirection} / 2: \n" +
                         $"While scroll changing, immune to knockback and reduce damage by 50%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Redirection >= 2)
                    {
                        AddTooltip($"Redirection Level {player.GetModPlayer<ArmorSkills>().Redirection} / 2: \n" +
                         $"While scroll changing, immune to damage and if you intersect with an NPC, you can click to teleport to your cursor.");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().RecSpeed >= 1)
                {
                    AddTooltip($"Recovery Speed Level {player.GetModPlayer<ArmorSkills>().RecSpeed} / 3: \n" +
                     $"Increase life regen and life regen time by {player.GetModPlayer<ArmorSkills>().RecSpeed}.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().RecoveryUp >= 1)
                {
                    AddTooltip($"Recovery Up Level {player.GetModPlayer<ArmorSkills>().RecoveryUp} / 3: \n" +
                     $"Increase healing potency by {player.GetModPlayer<ArmorSkills>().RecoveryUp * 25}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot >= 1)
                {
                    int sharpness = 0;
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot == 1)
                    {
                        sharpness = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot == 2)
                    {
                        sharpness = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot >= 3)
                    {
                        sharpness = 50;
                    }
                    AddTooltip($"Razor Sharp Level {player.GetModPlayer<ArmorSkills>().RazorSharpSpareShot} / 3: \n" +
                     $"{sharpness}% to not lose sharpness.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire < 3)
                    {
                        AddTooltip($"Rapid Fire Level {player.GetModPlayer<ArmorSkills>().HandicraftRapidFire} / 3: \n" +
                     $"Requires at least 3 levels for an effect.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 3)
                    {
                        AddTooltip($"Rapid Fire Level {player.GetModPlayer<ArmorSkills>().HandicraftRapidFire} / 3: \n" +
                     $"Shoot an additional projectile per use.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp >= 1)
                {
                    int Usetime = 0;
                    if (player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp == 1)
                    {
                        Usetime = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp == 2)
                    {
                        Usetime = 30;
                    }
                    if (player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp >= 3)
                    {
                        Usetime = 50;
                    }
                    AddTooltip($"Quick Sheath Level {player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp} / 3: \n" +
                     $"Increase usetime for true melee weapons and whips by {Usetime}%. Can combo with challenge sheath for a bigger boost.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().QuickSharpening >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().QuickSharpening >= 1 && player.GetModPlayer<ArmorSkills>().QuickSharpening < 3)
                    {
                        AddTooltip($"Quick Sharpening Level {player.GetModPlayer<ArmorSkills>().QuickSharpening} / 3: \n" +
                         $"Increase usetime for whetstones.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().QuickSharpening >= 3)
                    {
                        AddTooltip($"Quick Sharpening Level {player.GetModPlayer<ArmorSkills>().QuickSharpening} / 3: \n" +
                         $"Restores sharpness as soon as you hold the whetstone.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().QuickGather >= 1)
                {
                    int Usetime = 0;
                    if (player.GetModPlayer<ArmorSkills>().QuickGather == 1)
                    {
                        Usetime = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().QuickGather == 2)
                    {
                        Usetime = 30;
                    }
                    if (player.GetModPlayer<ArmorSkills>().QuickGather >= 3)
                    {
                        Usetime = 50;
                    }
                    AddTooltip($"Quick Gathering Level {player.GetModPlayer<ArmorSkills>().QuickGather} / 3: \n" +
                     $"Increase usetime for tools by {Usetime}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().QuickBreath >= 1)
                {
                    AddTooltip($"Quick Breath Level 1 / 1: \n" +
                     $"Scroll swapping while you have a debuff, cleanses it and heals you.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().PunishDrawPelletUp >= 1)
                {
                    AddTooltip($"Punish Draw Level {player.GetModPlayer<ArmorSkills>().PunishDrawPelletUp} / 3: \n" +
                     $"Increase true melee damage by {player.GetModPlayer<SharpnessPlayer>().PunishDrawDmg * 100}% and knockback by {player.GetModPlayer<SharpnessPlayer>().PunishDrawKB * 100}%");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ProtectivePolish >= 1)
                {
                    int Usetime = 0;
                    if (player.GetModPlayer<ArmorSkills>().ProtectivePolish == 1)
                    {
                        Usetime = 15;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ProtectivePolish == 2)
                    {
                        Usetime = 30;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ProtectivePolish >= 3)
                    {
                        Usetime = 45;
                    }
                    AddTooltip($"Protective Polish Level {player.GetModPlayer<ArmorSkills>().ProtectivePolish} / 3: \n" +
                     $"Prevents sharpness from decreasing after using a whetstone, buff lasts for {Usetime} seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Protection >= 1)
                {
                    int Usetime = 0;
                    if (player.GetModPlayer<ArmorSkills>().Protection == 1)
                    {
                        Usetime = 20;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Protection == 2)
                    {
                        Usetime = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Protection >= 3)
                    {
                        Usetime = 33;
                    }
                    AddTooltip($"Protection Level {player.GetModPlayer<ArmorSkills>().Protection} / 3: \n" +
                     $"{Usetime}% chance to reduce damage by 30%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().PowerProlonger >= 1)
                {
                    AddTooltip($"Power Prolonger Level 1 / 1: \n" +
                     $"Increase armor skill buffs by 20%");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().PolarHunter >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().PolarHunter == 1)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().PolarHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().PolarHunterDef}% when in the snow biome");
                    }
                    if (player.GetModPlayer<ArmorSkills>().PolarHunter == 2)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().PolarHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().PolarHunterDef}% and movement speed by {player.GetModPlayer<MHPlayerArmorSkill>().PolarHunterMovement}% when in the snow biome");
                        SkillsActive = true;
                    }
                    if (player.GetModPlayer<ArmorSkills>().PolarHunter >= 3)
                    {
                        AddTooltip($"Tropics Hunter Level {player.GetModPlayer<ArmorSkills>().PolarHunter} / 3: \n" +
                    $"Increase defense by {player.GetModPlayer<MHPlayerArmorSkill>().PolarHunterDef}%, movement speed by {player.GetModPlayer<MHPlayerArmorSkill>().PolarHunterMovement}% and damage by {player.GetModPlayer<MHPlayerArmorSkill>().TropicHunterAtk}% \n" +
                    $"when in the snow biome");
                        SkillsActive = true;
                    }
                }
                if (player.GetModPlayer<ArmorSkills>().PoisonCPlus)
                {
                    AddTooltip($"Poison Coating+ Level 1 / 1: \n" +
                     $"Ranged projectiles inflict poison.");
                    SkillsActive = true;
                }

                if (player.GetModPlayer<ArmorSkills>().CritDrawPierceUp >= 1)
                {
                    AddTooltip($"Pierce Up Level {player.GetModPlayer<ArmorSkills>().CritDrawPierceUp} / 3:: \n" +
                         $"Increase piercing ammo damage by {player.GetModPlayer<MHPlayerArmorSkill>().PieceBuff}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().PunishDrawPelletUp >= 1)
                {
                    AddTooltip($"Pellet Up Level {player.GetModPlayer<ArmorSkills>().PunishDrawPelletUp} / 3:: \n" +
                         $"Increase crystal bullet and holy arrow damage by {player.GetModPlayer<MHPlayerArmorSkill>().PelletBuff}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().OutdoorsMan >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().OutdoorsMan == 1)
                    {
                        AddTooltip($"Outdoorsman Level {player.GetModPlayer<ArmorSkills>().OutdoorsMan} / 3:: \n" +
                             $"Sometimes get extra items from shaking trees.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().OutdoorsMan == 2)
                    {
                        AddTooltip($"Outdoorsman Level {player.GetModPlayer<ArmorSkills>().OutdoorsMan} / 3:: \n" +
                             $"Sometimes get extra items from shaking trees and catching creatures.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().OutdoorsMan == 2)
                    {
                        AddTooltip($"Outdoorsman Level {player.GetModPlayer<ArmorSkills>().OutdoorsMan} / 3:: \n" +
                             $"Sometimes get extra items from shaking trees,catching creatures and gathering.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().OffensiveGuard >= 1)
                {
                    AddTooltip($"Offensive Guard Level {player.GetModPlayer<ArmorSkills>().OffensiveGuard} / 3:: \n" +
                         $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().OffensiveGuardBoost}% after guarding a hit for 12 seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp >= 1)
                {
                    AddTooltip($"Normal Up Level {player.GetModPlayer<ArmorSkills>().QuickSheathNormalUp} / 3:: \n" +
                         $"Increase musket bullet and wooden arrow damage by {player.GetModPlayer<MHPlayerArmorSkill>().NormalBuff}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().NegativeCrit >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().NegativeCrit == 1)
                    {
                        Variable = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().NegativeCrit == 2)
                    {
                        Variable = 33;
                    }
                    if (player.GetModPlayer<ArmorSkills>().NegativeCrit >= 3)
                    {
                        Variable = 50;
                    }
                    AddTooltip($"Negative Crit Level {player.GetModPlayer<ArmorSkills>().NegativeCrit} / 3: \n" +
                     $"{Variable}% chance increase non critical hits by 50%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Mushroomancer >= 1)
                {
                    AddTooltip($"Mushroomancer Level {player.GetModPlayer<ArmorSkills>().Mushroomancer} / 3:: \n" +
                         $"Having different mushrooms in the inventory grants different buffs and also increase mushroom's healing.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().MaximumMight >= 1)
                {
                    AddTooltip($"Maximum Might Level {player.GetModPlayer<ArmorSkills>().MaximumMight} / 3:: \n" +
                         $"No movement inputs for 2 seconds increases critical strike chance by {player.GetModPlayer<MHPlayerArmorSkill>().MaxMightCrit}%");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye == 1)
                    {
                        Variable = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye == 2)
                    {
                        Variable = 50;
                    }
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye >= 3)
                    {
                        Variable = 75;
                    }
                    AddTooltip($"Masters Touch Level {player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye} / 3: \n" +
                     $"{Variable}% chance to not lose sharpness if the attack crits.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().MailofHellfire >= 1)
                {
                    AddTooltip($"Mail of Hellfire Level {player.GetModPlayer<ArmorSkills>().MailofHellfire} / 3:: \n" +
                         $"Red Scroll: Increase true melee damage and size by {player.GetModPlayer<ScrollSwapPlayer>().MailofHellfireMelee * 100}% and lowers defense by {player.GetModPlayer<ScrollSwapPlayer>().MailofHellfireDefDrop}.\n" +
                         $"Blue Scroll: Increase projectile damage by {player.GetModPlayer<ScrollSwapPlayer>().MailofHellfireShoot * 100}% and lowers endurance by {player.GetModPlayer<ScrollSwapPlayer>().MailofHellfireEndurance * 100}%");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().LatentPower >= 1)
                {
                    AddTooltip($"Latent Power Level {player.GetModPlayer<ArmorSkills>().LatentPower} / 5: \n" +
                         $"Start a timer when a boss is nearby, after 30 seconds, grant the latent power buff which increases critical strike chance and lowers mana cost.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().LastingPower >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().LastingPower == 1)
                    {
                        Variable = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().LastingPower == 2)
                    {
                        Variable = 33;
                    }
                    if (player.GetModPlayer<ArmorSkills>().LastingPower >= 3)
                    {
                        Variable = 50;
                    }
                    AddTooltip($"Lasting Power Level {player.GetModPlayer<ArmorSkills>().LastingPower} / 3: \n" +
                         $"Potion buffs lasts {Variable}% longer.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().KushalaBlessing >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().KushalaBlessing == 1)
                    {
                        AddTooltip($"Kushala Blessing Level {player.GetModPlayer<ArmorSkills>().KushalaBlessing} / 3:: \n" +
                             $"Increase water and ice weapon damage by 5%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().KushalaBlessing == 2)
                    {
                        AddTooltip($"Kushala Blessing Level {player.GetModPlayer<ArmorSkills>().KushalaBlessing} / 3:: \n" +
                             $"Increase water and ice weapon damage by 10%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().KushalaBlessing >= 3)
                    {
                        AddTooltip($"Kushala Blessing Level {player.GetModPlayer<ArmorSkills>().KushalaBlessing} / 3:: \n" +
                             $"Increase water and ice weapon damage by 10% and increase health regen is afflicted with potion sickness.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().JumpMaster >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().JumpMaster == 1)
                    {
                        AddTooltip($"Jump Master Level {player.GetModPlayer<ArmorSkills>().JumpMaster} / 3:: \n" +
                             $"Increase jump speed by 50%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().JumpMaster == 2)
                    {
                        AddTooltip($"Jump Master Level {player.GetModPlayer<ArmorSkills>().JumpMaster} / 3:: \n" +
                             $"Increase jump speed by 100% and allows for auto jump");
                    }
                    if (player.GetModPlayer<ArmorSkills>().JumpMaster >= 3)
                    {
                        AddTooltip($"Jump Master Level {player.GetModPlayer<ArmorSkills>().JumpMaster} / 3:: \n" +
                             $"Increase jump speed by 150%, allows auto jump and jump hight is boosted.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().IntrepidHeart)
                {
                    AddTooltip($"Intrepid Heart Level 1 / 1: \n" +
                         $"Hitting enemies grants the intrepid hearts buff that reduce damage taken when hit.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().IceRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().IceRes == 1)
                    {
                        AddTooltip($"Ice Res Level {player.GetModPlayer<ArmorSkills>().IceRes} / 3: \n" +
                "Reduce damage from ice projectiles and increase defense by 1");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceRes == 2)
                    {
                        AddTooltip($"Ice Res Level {player.GetModPlayer<ArmorSkills>().IceRes} / 3: \n" +
                "Reduce damage from ice projectiles and increase defense by 2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceRes >= 3)
                    {
                        AddTooltip($"Ice Res Level {player.GetModPlayer<ArmorSkills>().IceRes} / 3: \n" +
                "Reduce damage from ice projectiles and increase defense by 3");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().IceAttack >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().IceAttack == 1)
                    {
                        AddTooltip($"Ice Attack Level {player.GetModPlayer<ArmorSkills>().IceAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().IceAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceAttack == 2)
                    {
                        AddTooltip($"Ice Attack Level {player.GetModPlayer<ArmorSkills>().IceAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().IceAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceAttack == 3)
                    {
                        AddTooltip($"Ice Attack Level {player.GetModPlayer<ArmorSkills>().IceAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().IceAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().IceAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceAttack == 4)
                    {
                        AddTooltip($"Ice Attack Level {player.GetModPlayer<ArmorSkills>().IceAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().IceAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().IceAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceAttack >= 5)
                    {
                        AddTooltip($"Ice Attack Level {player.GetModPlayer<ArmorSkills>().IceAttack} / 5: \n" +
                $"Increase base damage by 10% and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().IceAttack + 2} and allows autofire");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HoneyHunter >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().HoneyHunter == 1)
                    {
                        AddTooltip($"Honey Hunter Level {player.GetModPlayer<ArmorSkills>().HoneyHunter} / 2: \n" +
                "Increase movement speed by 5% when near honey.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().IceRes >= 2)
                    {
                        AddTooltip($"Honey Hunter Level {player.GetModPlayer<ArmorSkills>().HoneyHunter} / 2: \n" +
                "Increase movement speed by 10% when near honey and getting hit gives the honey buff for 7 seconds.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HeroShield >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().HeroShield == 1)
                    {
                        AddTooltip($"Hero Shield Level {player.GetModPlayer<ArmorSkills>().HeroShield} / 3: \n" +
                "Slimes becomes friendly.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeroShield == 2)
                    {
                        AddTooltip($"Hero Shield Level {player.GetModPlayer<ArmorSkills>().HeroShield} / 3: \n" +
                "Slimes and pre-hardmode bats becomes friendly.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeroShield >= 3)
                    {
                        AddTooltip($"Hero Shield Level {player.GetModPlayer<ArmorSkills>().HeroShield} / 3: \n" +
                "Slimes, pre-hardmode bats and bees becomes friendly.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Heroics >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Heroics == 1)
                    {
                        AddTooltip($"Heroics Level {player.GetModPlayer<ArmorSkills>().Heroics} / 5: \n" +
                $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().HeroicsAttack}% when health falls below 35%.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Heroics == 2)
                    {
                        AddTooltip($"Heroics Level {player.GetModPlayer<ArmorSkills>().Heroics} / 5: \n" +
                $"Increase damage by % {player.GetModPlayer<MHPlayerArmorSkill>().HeroicsAttack}% and defense by {player.GetModPlayer<MHPlayerArmorSkill>().HeroicsDefence} when health falls below 35%.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Heroics >= 3)
                    {
                        AddTooltip($"Heroics Level {player.GetModPlayer<ArmorSkills>().Heroics} / 5: \n" +
                $"Increase damage by % {player.GetModPlayer<MHPlayerArmorSkill>().HeroicsAttack}%, defense by {player.GetModPlayer<MHPlayerArmorSkill>().HeroicsDefence} and stops health regen when health falls below 35%.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HeavenSent >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().HeavenSent == 1)
                    {
                        AddTooltip($"Heaven-Sent Level {player.GetModPlayer<ArmorSkills>().HeavenSent} / 3: \n" +
                         $"When an boss is nearby, not getting hit for 20 seconds grants the Heaven-Sent buff. \n" +
                         $"The buff increases movement speed by 5%, prevents sharpness loss and stops ammo/mana consumption. \n" +
                         $"Reduce the next hit's damage by 10% but removes the Heaven-Sent buff.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeavenSent == 2)
                    {
                        AddTooltip($"Heaven-Sent Level {player.GetModPlayer<ArmorSkills>().HeavenSent} / 3: \n" +
                         $"When an boss is nearby, not getting hit for 15 seconds grants the Heaven-Sent buff. \n" +
                         $"The buff increases movement speed by 10%, prevents sharpness loss and stops ammo/mana consumption. \n" +
                         $"Reduce the next hit's damage by 20% but removes the Heaven-Sent buff.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeavenSent >= 3)
                    {
                        AddTooltip($"Heaven-Sent Level {player.GetModPlayer<ArmorSkills>().HeavenSent} / 3: \n" +
                         $"When an boss is nearby, not getting hit for 15 seconds grants the Heaven-Sent buff. \n" +
                         $"The buff increases movement speed by 15%, grants infinite flight, prevents sharpness loss and stops ammo/mana consumption. \n" +
                         $"Reduce the next hit's damage by 30% but removes the Heaven-Sent buff.");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HeatRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().HeatRes == 1)
                    {
                        AddTooltip($"Heat Res Level {player.GetModPlayer<ArmorSkills>().HeatRes} / 3: \n" +
                         $"Grant immunity to fire blocks.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeatRes == 2)
                    {
                        AddTooltip($"Heat Res Level {player.GetModPlayer<ArmorSkills>().HeatRes} / 3: \n" +
                         $"Grant immunity to on fire,hell fire and fire blocks.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().HeatRes >= 3)
                    {
                        AddTooltip($"Heat Res Level {player.GetModPlayer<ArmorSkills>().HeatRes} / 3: \n" +
                         $"Grant immunity to on fire,hell fire and fire blocks. Immunity to lava for 7 seconds. Grant recovery speed skill +1 when in the jungle,desert or the underworld biome.");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Health >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Health == 1)
                    {
                        Variable = 20;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Health == 2)
                    {
                        Variable = 40;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Health >= 3)
                    {
                        Variable = 60;
                    }
                    AddTooltip($"Health Level {player.GetModPlayer<ArmorSkills>().Health} / 3: \n" +
                         $"Increase maximum health by {Variable}.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HastenRecovery >= 1)
                {
                    AddTooltip($"Hasten Recovery Level {player.GetModPlayer<ArmorSkills>().HastenRecovery} / 3: \n" +
                         $"Increase life regen as you hit enemies.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire == 1)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire == 2)
                    {
                        Variable = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 3)
                    {
                        Variable = 40;
                    }
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 4)
                    {
                        Variable = 60;
                    }
                    if (player.GetModPlayer<ArmorSkills>().HandicraftRapidFire >= 5)
                    {
                        Variable = 80;
                    }
                    AddTooltip($"Handicraft Level {player.GetModPlayer<ArmorSkills>().HandicraftRapidFire} / 5: \n" +
                         $"Increase maximum sharpness by {Variable}.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Guts >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Guts == 1)
                    {
                        Variable = 50;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Guts == 2)
                    {
                        Variable = 40;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Guts >= 3)
                    {
                        Variable = 30;
                    }
                    AddTooltip($"Guts Level {player.GetModPlayer<ArmorSkills>().Guts} / 3: \n" +
                         $"If health is above {Variable}% and a hit brings to death, revive with 30% Health. 3 minute cooldown.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().GuardUp >= 1)
                {
                    AddTooltip($"Guard Up Level {player.GetModPlayer<ArmorSkills>().GuardUp} / 3: \n" +
                         $"Requires guard to work. Reduce front facing projectile damage.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Guard >= 1)
                {
                    AddTooltip($"Guard Level {player.GetModPlayer<ArmorSkills>().Guard} / 5: \n" +
                         $"Allows the ability to guard if you have a shield. Press guard hotkey to activate. Increase guarding capabilities as skill level increase.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Grinder >= 1)
                {
                    AddTooltip($"Grinder Level {player.GetModPlayer<ArmorSkills>().Grinder} / 3: \n" +
                         $"After using a whetstone, increase damage by {player.GetModPlayer<SharpnessPlayer>().GrinderDmg}% for {player.GetModPlayer<SharpnessPlayer>().GrinderTime} seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Gluttony >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Gluttony == 1)
                    {
                        AddTooltip($"Gluttony Level {player.GetModPlayer<ArmorSkills>().Gluttony} / 3:: \n" +
                         $"Health Potions restore mana equal to 50% of the heal value.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Gluttony == 2)
                    {
                        AddTooltip($"Gluttony Level {player.GetModPlayer<ArmorSkills>().Gluttony} / 3:: \n" +
                         $"Health Potions restore mana equal to 100% of the heal value.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Gluttony >= 3)
                    {
                        AddTooltip($"Gluttony Level {player.GetModPlayer<ArmorSkills>().Gluttony} / 3:: \n" +
                         $"Health Potions restore mana equal to 150% of the heal value and also grants well fed for 30 seconds.");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Geologist >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Geologist == 1)
                    {
                        Variable = 33;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Geologist == 2)
                    {
                        Variable = 50;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Geologist >= 3)
                    {
                        Variable = 100;
                    }
                    AddTooltip($"Geologist Level {player.GetModPlayer<ArmorSkills>().Geologist} / 3: \n" +
                         $"{Variable}% to yield more ores.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Gathering >= 1)
                {
                    AddTooltip($"Gathering Level {player.GetModPlayer<ArmorSkills>().Gathering} / 2: \n" +
                         $"NPC may drop herb bags upon death.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Furious >= 1)
                {
                    AddTooltip($"Furious Level {player.GetModPlayer<ArmorSkills>().Furious} / 3: \n" +
                         $"In the red scroll, increase defense by {player.GetModPlayer<ScrollSwapPlayer>().FuriousDef}, build up charges by damaging npcs and switch to the blue scroll for unlimited mana and wingtime for {player.GetModPlayer<ScrollSwapPlayer>().FuriousDef * 60 * 3} seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().FreeMeal >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().FreeMeal == 1)
                    {
                        Variable = 33;
                    }
                    if (player.GetModPlayer<ArmorSkills>().FreeMeal == 2)
                    {
                        Variable = 50;
                    }
                    if (player.GetModPlayer<ArmorSkills>().FreeMeal >= 3)
                    {
                        Variable = 100;
                    }
                    AddTooltip($"Free Meal Level {player.GetModPlayer<ArmorSkills>().FreeMeal} / 3: \n" +
                         $"{Variable}% to not consume potions.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Fortified >= 1)
                {
                    AddTooltip($"Fortified Level {player.GetModPlayer<ArmorSkills>().Fortified} / 3: \n" +
                         $"Respawn with full health and grant the fortified buff.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Foray >= 1)
                {
                    AddTooltip($"Foray Level {player.GetModPlayer<ArmorSkills>().Foray} / 3: \n" +
                         $"Increase damage by {player.GetModPlayer<ArmorSkills>().Foray * 100 - 100}% if the target is afflicted with a debuff.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Focus >= 1)
                {
                    AddTooltip($"Focus Level {player.GetModPlayer<ArmorSkills>().Focus} / 3: \n" +
                         $"If the weapon is able to channel, increase attack speed by {5 + (player.GetModPlayer<ArmorSkills>().Focus * 5)}% and +{player.GetModPlayer<ArmorSkills>().Focus} armor penetration. ");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().FishingExpert >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().FishingExpert == 1)
                    {
                        AddTooltip($"Fishing Expert Level {player.GetModPlayer<ArmorSkills>().FishingExpert} / 3:: \n" +
                         $"Increase Fishing power by 5 and chance to not consume bait..");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FishingExpert == 2)
                    {
                        AddTooltip($"Fishing Expert Level {player.GetModPlayer<ArmorSkills>().FishingExpert} / 3:: \n" +
                         $"Increase Fishing power by 15, chance to not consume bait and line will not break..");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FishingExpert >= 3)
                    {
                        AddTooltip($"Fishing Expert Level {player.GetModPlayer<ArmorSkills>().FishingExpert} / 3:: \n" +
                         $"Increase Fishing power by 25, chance to not consume bait, line will not break, allows fishing in lava and sonar potion effect..");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().FireRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().FireRes == 1)
                    {
                        AddTooltip($"Fire Res Level {player.GetModPlayer<ArmorSkills>().FireRes} / 3: \n" +
                "Reduce damage from Fire projectiles and increase defense by 1");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireRes == 2)
                    {
                        AddTooltip($"Fire Res Level {player.GetModPlayer<ArmorSkills>().FireRes} / 3: \n" +
                "Reduce damage from Fire projectiles and increase defense by 2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireRes >= 3)
                    {
                        AddTooltip($"Fire Res Level {player.GetModPlayer<ArmorSkills>().FireRes} / 3: \n" +
                "Reduce damage from Fire projectiles and increase defense by 3");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().FireAttack >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().FireAttack == 1)
                    {
                        AddTooltip($"Fire Attack Level {player.GetModPlayer<ArmorSkills>().FireAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().FireAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireAttack == 2)
                    {
                        AddTooltip($"Fire Attack Level {player.GetModPlayer<ArmorSkills>().FireAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().FireAttack} and slighty increase knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireAttack == 3)
                    {
                        AddTooltip($"Fire Attack Level {player.GetModPlayer<ArmorSkills>().FireAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().FireAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().FireAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireAttack == 4)
                    {
                        AddTooltip($"Fire Attack Level {player.GetModPlayer<ArmorSkills>().FireAttack} / 5: \n" +
                $"Increase base damage by {player.GetModPlayer<ArmorSkills>().FireAttack} and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().FireAttack + 2} and allows autofire");
                    }
                    if (player.GetModPlayer<ArmorSkills>().FireAttack >= 5)
                    {
                        AddTooltip($"Fire Attack Level {player.GetModPlayer<ArmorSkills>().FireAttack} / 5: \n" +
                $"Increase base damage by 10% and increase knockback.\n" +
                $"Increase critical strike chance by {player.GetModPlayer<ArmorSkills>().FireAttack + 2} and allows autofire");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Fencing >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Fencing == 1)
                    {
                        Variable = 3;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Fencing == 2)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Fencing >= 3)
                    {
                        Variable = 7;
                    }
                    AddTooltip($"Fencing Level {player.GetModPlayer<ArmorSkills>().Fencing} / 3: \n" +
                         $"Increase armor penetration by {Variable}.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Fate >= 1)
                {
                    float Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Fate == 1)
                    {
                        Variable = 0.2f;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Fate == 2)
                    {
                        Variable = 0.4f;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Fate >= 3)
                    {
                        Variable = 0.6f;
                    }
                    AddTooltip($"Fate Level {player.GetModPlayer<ArmorSkills>().Fate} / 3: \n" +
                         $"Increase luck by {Variable}.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Evasion >= 1)
                {
                    AddTooltip($"Evasion Level {player.GetModPlayer<ArmorSkills>().Evasion} / 5: \n" +
                         $"Grant iframes when dashing, grant more iframes as level increases.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().EvadeDistance >= 1)
                {
                    AddTooltip($"Evade Distance Level {player.GetModPlayer<ArmorSkills>().EvadeDistance} / 3: \n" +
                         $"Increase dashing distance, distance increase as level increases.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Embolden >= 1)
                {
                    AddTooltip($"Embolden Level {player.GetModPlayer<ArmorSkills>().Embolden} / 3: \n" +
                         $"If there's a boss nearby. Increase aggro {player.GetModPlayer<MHPlayerArmorSkill>().EmboldenAggro} by ,defense by {player.GetModPlayer<MHPlayerArmorSkill>().EmboldenDef}and Guard/Evasion by {player.GetModPlayer<ArmorSkills>().Embolden + 2}");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ElementalRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().ElementalRes == 1)
                    {
                        AddTooltip($"Elemental Res Level {player.GetModPlayer<ArmorSkills>().ElementalRes} / 3: \n" +
                "Reduce damage from Elemental projectiles and increase defense by 2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ElementalRes == 2)
                    {
                        AddTooltip($"Elemental Res Level {player.GetModPlayer<ArmorSkills>().ElementalRes} / 3: \n" +
                "Reduce damage from Elemental projectiles and increase defense by 5");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ElementalRes >= 3)
                    {
                        AddTooltip($"Elemental Res Level {player.GetModPlayer<ArmorSkills>().ElementalRes} / 3: \n" +
                "Reduce damage from Elemental projectiles and increase defense by 9");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Elemental >= 1)
                {

                    AddTooltip($"Elemental Level {player.GetModPlayer<ArmorSkills>().Elemental} / 3: \n" +
                         $"Increase elemental damage by {player.GetModPlayer<ArmorSkills>().Elemental * 4}");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().DragonConversion >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().DragonConversion == 1)
                    {
                        AddTooltip($"Dragon Conversion Level {player.GetModPlayer<ArmorSkills>().DragonConversion} / 3: \n" +
                "Increase critical strike chance by 3%. In the blue scroll, critical hits count will be stored. \n" +
                "After 100 hits and switching to the red scroll, 30% of the critical hit counts will be converted to extra damage.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DragonConversion == 2)
                    {
                        AddTooltip($"Dragon Conversion Level {player.GetModPlayer<ArmorSkills>().DragonConversion} / 3: \n" +
                "Increase critical strike chance by 6%. In the blue scroll, critical hits count will be stored. \n" +
                "After 100 hits and switching to the red scroll, 35% of the critical hit counts will be converted to extra damage.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DragonConversion >= 3)
                    {
                        AddTooltip($"Dragon Conversion Level {player.GetModPlayer<ArmorSkills>().DragonConversion} / 3: \n" +
                "Increase critical strike chance by 10%. In the blue scroll, critical hits count will be stored. \n" +
                "After 100 hits and switching to the red scroll, 40% of the critical hit counts will be converted to extra damage.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Diversion >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Diversion == 1)
                    {
                        AddTooltip($"Diversion Level {player.GetModPlayer<ArmorSkills>().Diversion} / 3: \n" +
                "Increase aggro by 100.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Diversion == 2)
                    {
                        AddTooltip($"Diversion Level {player.GetModPlayer<ArmorSkills>().Diversion} / 3: \n" +
                "Increase aggro by 200, increase melee speed by 10% if there's an enemy within 15 tiles.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Diversion >= 3)
                    {
                        AddTooltip($"Diversion Level {player.GetModPlayer<ArmorSkills>().Diversion} / 3: \n" +
                "Increase aggro by 300, increase melee damage by 5% and melee speed by 10% if there's an enemy within 15 tiles.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Dereliction >= 1)
                {

                    AddTooltip($"Dereliction Level {player.GetModPlayer<ArmorSkills>().Dereliction} / 3: \n" +
                         $"Red scroll increases crit by {player.GetModPlayer<ScrollSwapPlayer>().DerelictionBoost}%, blue scroll increases damage by {player.GetModPlayer<ScrollSwapPlayer>().DerelictionBoost}%.\n" +
                         $"You get a new stack every minute, capping out at 3 stacks. Scroll swapping consume the stacks and recovers health.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().DefLock >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().DefLock == 1)
                    {
                        AddTooltip($"Def Lock Level {player.GetModPlayer<ArmorSkills>().DefLock} / 3: \n" +
                "Grant immunity to broken armor.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefLock == 2)
                    {
                        AddTooltip($"Def Lock Level {player.GetModPlayer<ArmorSkills>().DefLock} / 3: \n" +
                "Grant immunity to broken armor and ichor.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefLock >= 3)
                    {
                        AddTooltip($"Def Lock Level {player.GetModPlayer<ArmorSkills>().DefLock} / 3: \n" +
                "Grant immunity to broken armor, ichor and withered armor.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Defiance >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Defiance == 1)
                    {
                        AddTooltip($"Defiance Level {player.GetModPlayer<ArmorSkills>().Defiance} / 5: \n" +
                $"If there's an boss nearby, increase defense {player.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} by and grant immunity to knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Defiance == 2)
                    {
                        AddTooltip($"Defiance Level {player.GetModPlayer<ArmorSkills>().Defiance} / 5: \n" +
                $"If there's an boss nearby, increase defense {player.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} by and grant immunity to knockback.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Defiance == 3)
                    {
                        AddTooltip($"Defiance Level {player.GetModPlayer<ArmorSkills>().Defiance} / 5: \n" +
                $"If there's an boss nearby, increase defense {player.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} by and grant immunity to knockback. \n" +
                        $"Debuffs lasts half as long.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Defiance == 4)
                    {
                        AddTooltip($"Defiance Level {player.GetModPlayer<ArmorSkills>().Defiance} / 5: \n" +
                $"If there's an boss nearby, increase defense {player.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} by and grant immunity to knockback. \n" +
                        $"Debuffs lasts half as long.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Defiance >= 5)
                    {
                        AddTooltip($"Defiance Level {player.GetModPlayer<ArmorSkills>().Defiance} / 5: \n" +
                $"If there's an boss nearby, increase defense {player.GetModPlayer<MHPlayerArmorSkill>().DefianceDef} by and grant immunity to knockback. \n" +
                        $"Debuffs lasts half as long and enemies my drop life boosters when hit");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().DefenseBoost >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 1)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 2.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 2)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 4.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 3)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 7.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 4)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 10.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 5)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 10 and a further 5%.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost == 6)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 10 and a further 10%. +2% Endurance.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().DefenseBoost >= 7)
                    {
                        AddTooltip($"Defense Boost Level {player.GetModPlayer<ArmorSkills>().DefenseBoost} / 7: \n" +
                $"Increase defense by 10 and a further 15%. +5% Endurance");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Deadeye Level {player.GetModPlayer<ArmorSkills>().MastersTouchDeadeye} / 3: \n" +
                         $"Increase range damage by {Variable}% if target is within 50 tiles.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CriticalBoost >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().CriticalBoost == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().CriticalBoost == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().CriticalBoost >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Critical Boost Level {player.GetModPlayer<ArmorSkills>().CriticalBoost} / 3: \n" +
                         $"Increase critical damage by {Variable}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CritEye >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 1)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 2.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 2)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 4.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 3)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 7.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 4)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 10.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 5)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 13.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye == 6)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                $"Increase critical strike chance by 16 and a further 5%.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritEye >= 7)
                    {
                        AddTooltip($"Critical Eye Level {player.GetModPlayer<ArmorSkills>().CritEye} / 7: \n" +
                 $"Increase critical strike chance by 19 and a further 10%.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CritElement >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().CritElement == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritElement == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritElement >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Critical Element Level {player.GetModPlayer<ArmorSkills>().CritElement} / 3: \n" +
                         $"Increase critical damage of elemental weapons by {Variable}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CritDrawPierceUp >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().CritDrawPierceUp == 1)
                    {
                        AddTooltip($"Crit Draw Level {player.GetModPlayer<ArmorSkills>().CritDrawPierceUp} / 3: \n" +
                "Increase critical strike chance of true melee weapons by 10%.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritDrawPierceUp == 2)
                    {
                        AddTooltip($"Crit Draw Level {player.GetModPlayer<ArmorSkills>().CritDrawPierceUp} / 3: \n" +
                "Increase critical strike chance of true melee weapons by 20%..");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CritDrawPierceUp >= 3)
                    {
                        AddTooltip($"Crit Draw Level {player.GetModPlayer<ArmorSkills>().CritDrawPierceUp} / 3: \n" +
                "Increase critical strike chance of true melee weapons by 20% and critical damage by 10%");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Close Range Up Level {player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp} / 3: \n" +
                         $"Increase range damage by {Variable}% if target is within 15 tiles.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CounterStrike >= 1)
                {
                    AddTooltip($"Counterstrike Level {player.GetModPlayer<ArmorSkills>().CounterStrike} / 3: \n" +
                         $"Increase damage by {player.GetModPlayer<MHPlayerArmorSkill>().CounterStrike}% for 10 seconds after getting knocked back.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Constitution >= 1)
                {
                    AddTooltip($"Constitution Level {player.GetModPlayer<ArmorSkills>().Constitution} / 3: \n" +
                         $"Decrease cooldown of dashes and also reduce guard cooldown by 1 second per level.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ColdRes >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().ColdRes == 1)
                    {
                        AddTooltip($"Cold Res Level {player.GetModPlayer<ArmorSkills>().ColdRes} / 3: \n" +
                         $"Grant immunity to the chilled debuff.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ColdRes == 2)
                    {
                        AddTooltip($"Cold Res Level {player.GetModPlayer<ArmorSkills>().ColdRes} / 3: \n" +
                         $"Grant immunity to the chilled, frostburn and frostbite debuff.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ColdRes >= 3)
                    {
                        AddTooltip($"Cold Res Level {player.GetModPlayer<ArmorSkills>().ColdRes} / 3: \n" +
                         $"Grant immunity to the chilled, frostburn, frostbite  and frozen debuff. Grant Constitution skill +1 when in the snow biome.");
                    }

                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Coalescence >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().Coalescence == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Coalescence == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().Coalescence >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Coalescence Level {player.GetModPlayer<ArmorSkills>().Coalescence} / 3: \n" +
                         $"Increase damage by {Variable}% for 10 seconds when a debuff wears off.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().CliffHanger >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().CliffHanger == 1)
                    {
                        AddTooltip($"Cliffhanger Level {player.GetModPlayer<ArmorSkills>().AntiPoison} / 2: \n" +
                         $"Allows for wall climbing.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().CliffHanger >= 2)
                    {
                        AddTooltip($"Cliffhanger Level {player.GetModPlayer<ArmorSkills>().AntiPoison} / 2: \n" +
                         $"Allows for clinging onto walls and wall climbing.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ChameleosBlessing >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().ChameleosBlessing == 1)
                    {
                        AddTooltip($"Chameleos Blessing Level {player.GetModPlayer<ArmorSkills>().ChameleosBlessing} / 3: \n" +
                         $"Increased effectiveness of the Spiritbird's call skill.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChameleosBlessing == 2)
                    {
                        AddTooltip($"Chameleos Blessing Level {player.GetModPlayer<ArmorSkills>().ChameleosBlessing} / 3: \n" +
                         $"Increased effectiveness of the Spiritbird's call skill and grant windproof +2");
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChameleosBlessing >= 3)
                    {
                        AddTooltip($"Chameleos Blessing Level {player.GetModPlayer<ArmorSkills>().ChameleosBlessing} / 3: \n" +
                         $"Increased effectiveness of the Spiritbird's call skill, grants windproof +2 and extend debuff timers on enemies.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp == 1)
                    {
                        Variable = 5;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp == 2)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp >= 3)
                    {
                        Variable = 15;
                    }
                    AddTooltip($"Challenge Sheath Level {player.GetModPlayer<ArmorSkills>().ChallengeSheatheCloseRangeUp} / 3: \n" +
                         $"If there's an boss nearby, switching weapons restores {Variable} sharpness, cooldown 5 seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Carving >= 1)
                {
                    AddTooltip($"Carving Level 1 / 1: \n" +
                         $"Enemies may drop 2x loot.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().BubbleDance >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().BubbleDance == 1)
                    {
                        AddTooltip($"Bubble Dance Level {player.GetModPlayer<ArmorSkills>().BubbleDance} / 3: \n" +
                         $"Dashing inflicts bubbleblight for 15 seconds.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().BubbleDance == 2)
                    {
                        AddTooltip($"Bubble Dance Blessing Level {player.GetModPlayer<ArmorSkills>().BubbleDance} / 3: \n" +
                         $"Dashing inflicts bubbleblight for 15 seconds, when afflicted with bubbleblight, grant evasion level equal to this skill.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().BubbleDance >= 3)
                    {
                        AddTooltip($"Bubble Dance Blessing Level {player.GetModPlayer<ArmorSkills>().BubbleDance} / 3: \n" +
                         $"Dashing inflicts bubbleblight for 15 seconds, when afflicted with bubbleblight, increase max movement speed and grant evasion level equal to this skill.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost == 1)
                    {
                        Variable = 10;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost == 2)
                    {
                        Variable = 20;
                    }
                    if (player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost >= 3)
                    {
                        Variable = 30;
                    }
                    AddTooltip($"Bomb Boost Level {player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost} / 3: \n" +
                         $"Increase bomb damage by {Variable}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().BloodRite >= 1)
                {
                    int Variable = 0;
                    if (player.GetModPlayer<ArmorSkills>().BloodRite == 1)
                    {
                        Variable = 25;
                    }
                    if (player.GetModPlayer<ArmorSkills>().BloodRite == 2)
                    {
                        Variable = 50;
                    }
                    if (player.GetModPlayer<ArmorSkills>().BloodRite >= 3)
                    {
                        Variable = 75;
                    }
                    AddTooltip($"Bloodrite Level {player.GetModPlayer<ArmorSkills>().BloodRite} / 3: \n" +
                         $"Hitting an enemy below {Variable}% health may drop a heart.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Bloodlust >= 1)
                {
                    AddTooltip($"Bloodlust Level {player.GetModPlayer<ArmorSkills>().Bloodlust} / 3: \n" +
                         $"If there's an boss nearby, inflict the frenzy debuff. Hit enemies to cure it and get a boost.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Blightproof >= 1)
                {

                    if (player.GetModPlayer<ArmorSkills>().Blightproof == 1)
                    {
                        AddTooltip($"Blightproof Level {player.GetModPlayer<ArmorSkills>().Blightproof} / 2: \n" +
                         $"Blight debuffs lasts halve as long.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Blightproof >= 2)
                    {
                        AddTooltip($"Blightproof Level {player.GetModPlayer<ArmorSkills>().Blightproof} / 2: \n" +
                         $"Grant immunity to blights.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().BladeScaleHone >= 1)
                {

                    AddTooltip($"Bladescale Hone Level {player.GetModPlayer<ArmorSkills>().BladeScaleHone} / 3: \n" +
                         $"Dashing grants the bladescale hone buff for 7 seconds, evading through enemies grants the buff for 45 seconds.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Berserk >= 1)
                {

                    AddTooltip($"Bladescale Hone Level {player.GetModPlayer<ArmorSkills>().Berserk} / 2: \n" +
                         $"While in the blue scroll, inflict berserk which reduces life regen but reduces damage by 75%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().BBQExpert >= 1)
                {

                    if (player.GetModPlayer<ArmorSkills>().BBQExpert == 1)
                    {
                        AddTooltip($"BBQ Expert Level {player.GetModPlayer<ArmorSkills>().BBQExpert} / 2: \n" +
                         $"Increase the amount of food crafted.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().BBQExpert >= 2)
                    {
                        AddTooltip($"BBQ Expert Level {player.GetModPlayer<ArmorSkills>().BBQExpert} / 2: \n" +
                         $"Increase the amount of food crafted and increase maximum health if you have the wellfed buff and it's variations.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Autoreload)
                {
                    AddTooltip($"Auto-Reload Level 1 / 1: \n" +
                         $"Allow ranged weapons to autofire.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AutoTracker >= 1)
                {

                    if (player.GetModPlayer<ArmorSkills>().AutoTracker == 1)
                    {
                        AddTooltip($"Anti-Poison Level {player.GetModPlayer<ArmorSkills>().AutoTracker} / 2: \n" +
                         $"Highlight hostile NPCs and traps.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().AutoTracker >= 2)
                    {
                        AddTooltip($"Anti-Poison Level {player.GetModPlayer<ArmorSkills>().AutoTracker} / 2: \n" +
                         $"Highlight hostile NPCs and traps along with treasure.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AutoGuard)
                {
                    AddTooltip($"Auto-Guard Level 1 / 1: \n" +
                         $"Automatically guard attacks as long as you're not inputting movement or attacking. Requires the Guard skill and a shield.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().Attack >= 1)
                {
                    if (player.GetModPlayer<ArmorSkills>().Attack == 1)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 1.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack == 2)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 2.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack == 3)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 4.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack == 4)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 6.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack == 5)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 6 and a further 3%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack == 6)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                $"Increase flat damage by 7 and a further 7%");
                    }
                    if (player.GetModPlayer<ArmorSkills>().Attack >= 7)
                    {
                        AddTooltip($"Attack Boost Level {player.GetModPlayer<ArmorSkills>().Attack} / 7: \n" +
                 $"Increase flat damage by 9 and a further 12%");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost >= 1)
                {

                    AddTooltip($"Artillery Level {player.GetModPlayer<ArmorSkills>().ArtilleryBombBoost} / 3: \n" +
                         $"Increase rocket and sentry damage by {player.GetModPlayer<MHPlayerArmorSkill>().ArtilleryBuff}%.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AMobility >= 1)
                {

                    if (player.GetModPlayer<ArmorSkills>().AMobility == 1)
                    {
                        AddTooltip($"Aquatic Mobility Level {player.GetModPlayer<ArmorSkills>().AMobility} / 3: \n" +
                         $"Free movement on ice and in water.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().AMobility == 2)
                    {
                        AddTooltip($"Aquatic Mobility Level {player.GetModPlayer<ArmorSkills>().AMobility} / 3: \n" +
                         $"Free movement on ice and can swim in water.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().AMobility >= 3)
                    {
                        AddTooltip($"Aquatic Mobility Level {player.GetModPlayer<ArmorSkills>().AMobility} / 3: \n" +
                         $"Free movement on ice and can swim in water. Grant evasion +3 when wet.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AntiPoison >= 1)
                {

                    if (player.GetModPlayer<ArmorSkills>().AntiPoison == 1)
                    {
                        AddTooltip($"Anti-Poison Level {player.GetModPlayer<ArmorSkills>().AntiPoison} / 2: \n" +
                         $"Grant immunity to poison.");
                    }
                    if (player.GetModPlayer<ArmorSkills>().AntiPoison >= 2)
                    {
                        AddTooltip($"Anti-Poison Level {player.GetModPlayer<ArmorSkills>().AntiPoison} / 2: \n" +
                         $"Grant immunity to poison and acid venom.");
                    }
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AntiBleeding)
                {

                    AddTooltip($"Anti-Bleed Level 1 / 1: \n" +
                         $"Grant immunity to bleeding.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AffinitySliding >= 1)
                {

                    AddTooltip($"Affinity Sliding Level {player.GetModPlayer<ArmorSkills>().AffinitySliding} / 3: \n" +
                         $"Increase critical strike chance by {player.GetModPlayer<MHPlayerArmorSkill>().aSlidingCrit}% after dashing. 7 seconds cooldown.");
                    SkillsActive = true;
                }
                if (player.GetModPlayer<ArmorSkills>().AdrenalineRush >= 1)
                {

                    AddTooltip($"Adrenaline Rush Level {player.GetModPlayer<ArmorSkills>().AdrenalineRush} / 3: \n" +
                         $"Increase damage and critical strike chance by {player.GetModPlayer<MHPlayerArmorSkill>().AdrenalineRush}% after evading through enemies.");
                    SkillsActive = true;
                }

                if (!SkillsActive)
                {
                    AddTooltip($"Currently no skills active.");
                }
                AddTooltip($"Displays armor skills currently active:");
            }
        }
    }
}

