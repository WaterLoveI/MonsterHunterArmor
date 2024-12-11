using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace MHArmorSkills.MHPlayer.MHItemDropRule
{
    public class CoralBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneBeach;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the ocean biome after Eye of Cthulu is defeated.";
        }
    }
    public class CoralBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneBeach;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the ocean biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class CoralBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneBeach;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the ocean biome after Wall of Flesh is defeated.";
        }
    }
    public class CoralBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneBeach;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the ocean biome after Golem is defeated.";
        }
    }
    public class ForestBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneForest;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the forest biome after Eye of Cthulu is defeated.";
        }
    }
    public class ForestBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneForest;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the forest biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class ForestBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneForest;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the forest biome after Wall of Flesh is defeated.";
        }
    }
    public class ForestBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneForest;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Forest biome after Golem is defeated.";
        }
    }
    public class RottedBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCrimson;
                }
                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCorrupt;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Crimson or Corruption biome after Eye of Cthulu is defeated.";
        }
    }
    public class RottedBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCorrupt;
                }
                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCrimson;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Crimson or Corruption biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class RottedBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCrimson;
                }
                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneCorrupt;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Crimson or Corruption biome after Wall of Flesh is defeated.";
        }
    }
    public class RottedBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneCorrupt;
                }
                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneCrimson;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Crimson or Corruption biome after Golem is defeated.";
        }
    }
    public class TundraBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneSnow;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Snow biome after Eye of Cthulu is defeated.";
        }
    }
    public class TundraBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneSnow;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Snow biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class TundraBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneSnow;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Snow biome after Wall of Flesh is defeated.";
        }
    }
    public class TundraBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneSnow;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Snow biome after Golem is defeated.";
        }
    }
    public class VolcanicBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneUnderworldHeight;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Underworld biome after Eye of Cthulu is defeated.";
        }
    }
    public class VolcanicBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneUnderworldHeight;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Volcanic biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class VolcanicBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneUnderworldHeight;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Underworld biome after Wall of Flesh is defeated.";
        }
    }
    public class VolcanicBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneUnderworldHeight;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Underworld biome after Golem is defeated.";
        }
    }
    public class WildspireBone1DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && !NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneDesert;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Desert biome after Eye of Cthulu is defeated.";
        }
    }
    public class WildspireBone2DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && !Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneDesert;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Desert biome after either Eater of Worlds or Brain of Cthulu is defeated.";
        }
    }
    public class WildspireBone3DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && !NPC.downedGolemBoss)
                {
                    return info.player.ZoneDesert;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Desert biome after Wall of Flesh is defeated.";
        }
    }
    public class WildspireBone4DropRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            if (!info.IsInSimulation)
            {
                NPC npc = info.npc;


                if (npc.lifeMax >= 5 && NPC.downedBoss1 && NPC.downedBoss2 && Main.hardMode && NPC.downedGolemBoss)
                {
                    return info.player.ZoneDesert;
                }

            }
            return false;
        }

        public bool CanShowItemDropInUI()
        {
            return true;
        }

        public string GetConditionDescription()
        {
            return "Obtained in the Desert biome after Golem is defeated.";
        }
    }
}
