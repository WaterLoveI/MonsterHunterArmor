using MHArmorSkills.Items;
using MHArmorSkills.Items.Crafting_Materials.MonsterMaterial;
using MHArmorSkills.MHPlayer;
using MHArmorSkills.Projectiles;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace MHArmorSkills.NPCs.TownNPCs
{
    [AutoloadHead]
    public class Handler : ModNPC
    {
        private static Profiles.StackedNPCProfile NPCProfile;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 23; // The total amount of frames the NPC has

            NPCID.Sets.ExtraFramesCount[Type] = 9; // Generally for Town NPCs, but this is how the NPC does extra things such as sitting in a chair and talking to other NPCs. This is the remaining frames after the walking frames.
            NPCID.Sets.AttackFrameCount[Type] = 4; // The amount of frames in the attacking animation.
            NPCID.Sets.DangerDetectRange[Type] = 240; // The amount of pixels away from the center of the NPC that it tries to attack enemies.
            NPCID.Sets.AttackType[Type] = 0; // The type of attack the Town NPC performs. 0 = throwing, 1 = shooting, 2 = magic, 3 = melee
            NPCID.Sets.AttackTime[Type] = 90; // The amount of time it takes for the NPC's attack animation to be over once it starts.
            NPCID.Sets.AttackAverageChance[Type] = 30; // The denominator for the chance for a Town NPC to attack. Lower numbers make the Town NPC appear more aggressive.
            NPCID.Sets.HatOffsetY[Type] = 8; // For when a party is active, the party hat spawns at a Y offset.
            NPCID.Sets.ShimmerTownTransform[Type] = false;
            NPC.Happiness
                .SetBiomeAffection<OceanBiome>(AffectionLevel.Like)
                .SetBiomeAffection<DesertBiome>(AffectionLevel.Like)
                .SetBiomeAffection<UndergroundBiome>(AffectionLevel.Like)
                .SetNPCAffection(NPCID.Guide, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Merchant, AffectionLevel.Like)
                .SetNPCAffection(NPCID.ArmsDealer, AffectionLevel.Like);
            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(NPC.type, drawModifiers);
        }
        public override void SetDefaults()
        {
            NPC.townNPC = true; // Sets NPC to be a Town NPC
            NPC.friendly = true; // NPC Will not attack player
            NPC.width = 26;
            NPC.height = 46;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 15;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;

            AnimationType = NPCID.Nurse;

            NPCProfile = new Profiles.StackedNPCProfile(
                new Profiles.DefaultNPCProfile(Texture, NPCHeadLoader.GetHeadSlot(HeadTexture), Texture + "_Party")
            );
        }
        public override ITownNPCProfile TownNPCProfile()
        {
            return NPCProfile;
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            // Sets the description of this NPC that is listed in the bestiary

            bestiaryEntry.Info.AddRange(new List<IBestiaryInfoElement>
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("Said to be part of a guild from another world. She needs someone to help her with her monster fascination.")
            });
        }
        public override void HitEffect(NPC.HitInfo hit)
        {
            for (int k = 0; k < 5; k++)
            {
                Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hit.HitDirection, -1f, 0, default, 1f);
            }
            if (NPC.life <= 0)
            {
                for (int k = 0; k < 20; k++)
                {
                    Dust.NewDust(NPC.position, NPC.width, NPC.height, DustID.Blood, hit.HitDirection, -1f, 0, default, 1f);
                }
                if (Main.netMode != NetmodeID.Server)
                {
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Handler1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Handler2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Handler3").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Handler3").Type, 1f);
                }
            }
        }
        public override List<string> SetNPCNameList()
        {
            return new List<string>() {
                "Sophia",
            };
        }
        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();

            int BestiaryGirl = NPC.FindFirstNPC(NPCID.BestiaryGirl);
            int Angler = NPC.FindFirstNPC(NPCID.Angler);
            if (BestiaryGirl >= 0 && Main.rand.NextBool(4))
            {
                chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.BestiaryGirlDialogue", Main.npc[BestiaryGirl].GivenName));
            }
            if (Angler >= 0 && Main.rand.NextBool(4))
            {
                chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.AnglerDialogue", Main.npc[Angler].GivenName));
            }
            chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.StandardDialogue1"));
            chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.StandardDialogue2"));
            chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.StandardDialogue3"));
            chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.StandardDialogue4"));
            chat.Add(Language.GetTextValue("Mods.MHArmorSkills.Dialogue.Handler.StandardDialogue5"));
            string chosenChat = chat;
            return chosenChat;
        }

        public override void SetChatButtons(ref string button, ref string button2)
        { // What the chat buttons are when you open up the chat UI
            button = "Quests";
            button2 = "Rewards";
        }

        public override void OnChatButtonClicked(bool firstButton, ref string shop)
        {
            Player player = Main.player[Main.myPlayer];
            if (firstButton)
            {
                if (player.GetModPlayer<QuestPlayer>().QuestNumber == 0)
                {
                    Main.npcChatText = "Oh hey, doodle. What am I up to? Well that's the problem. What's the point of a guildmarm if there's no one to give quests to? The guide certainly isn't interested. Will you play along with me? I'll give you a guide book to get you started!";
                    Main.npcChatCornerItem = ModContent.ItemType<GuideBook>();
                    var entitySource = NPC.GetSource_GiftOrReward();
                    Main.LocalPlayer.QuickSpawnItem(entitySource, ModContent.ItemType<GuideBook>());
                    player.GetModPlayer<QuestPlayer>().QuestNumber += 1;
                    return;
                }
                #region Mushroom Quest
                if (player.GetModPlayer<QuestPlayer>().QuestNumber == 1)
                {
                    Main.npcChatText = "Oh! you're ready for your first quest? I wasn't expecting this so fast! Hmmm, one second... one second... Oh I got one! This one is actually a classic. Collect 5 mushrooms for me.";
                    Main.npcChatCornerItem = ItemID.Mushroom;
                    return;
                }
                else
                {
                    Main.npcChatText = "Don't have anything for you yet, come back a little later.";
                }
                #endregion

            }
            else
            {
                #region Mushroom Quest
                if (player.GetModPlayer<QuestPlayer>().QuestNumber == 1)
                {
                    if (Main.LocalPlayer.CountItem(ItemID.Mushroom, 5) >= 5)
                    {
                        int Mushy = Main.LocalPlayer.FindItem(ItemID.Mushroom);
                        for (int i = 0; i < 5; i++)
                        {
                            Main.LocalPlayer.inventory[Mushy].stack -= 1;
                        }
                        Main.npcChatText = "Congratulations, you've completed your first quest! And your reward is... gimme a second here.... Tada! I learnt this from the guide, made with extra love. Let me know how it tastes.";
                        var entitySource = NPC.GetSource_GiftOrReward();
                        Main.LocalPlayer.QuickSpawnItem(entitySource, ItemID.LesserHealingPotion, 3);
                        player.GetModPlayer<QuestPlayer>().QuestNumber += 1;
                        return;
                    }
                }
                #endregion

                return;
            }
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GuideBook>()));
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 14;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ModContent.ProjectileType<GuideBookProj>();
            attackDelay = 1;
        }
        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 9f;
            randomOffset = 1f;
            gravityCorrection = 1f;
        }
    }
}

