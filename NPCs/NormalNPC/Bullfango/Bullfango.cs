using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using MHArmorSkills.Items.Armor.MonsterHunter.LowRank;

namespace MHArmorSkills.NPCs.NormalNPC.Bullfango
{
    public class Bullfango : ModNPC
    {
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[NPC.type] = 10;
        }

        public override void SetDefaults()
        {
            NPC.damage = 20;
            NPC.aiStyle = NPCAIStyleID.Unicorn;
            NPC.width = 50;
            NPC.height = 28;
            NPC.defense = 8;
            NPC.lifeMax = 80;
            NPC.knockBackResist = 0.3f;
            AnimationType = NPCID.Hellhound;
            NPC.value = Item.buyPrice(0, 0, 2, 0);
            NPC.HitSound = SoundID.NPCHit27;
            NPC.DeathSound = SoundID.NPCDeath30;
            Banner = NPC.type;
        }
        public override void AI()
        {
            if (Main.rand.NextBool(600))
            {

                int oinksound = Main.rand.Next(3);
                switch (oinksound)
                {
                    case 0:
                        SoundEngine.PlaySound(SoundID.Zombie39, NPC.Center);
                        break;
                    case 1:
                        SoundEngine.PlaySound(SoundID.Zombie40, NPC.Center);
                        break;
                    case 2:
                        SoundEngine.PlaySound(SoundID.Zombie38, NPC.Center);
                        break;
                }
            }
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
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango1").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango2").Type, 1f);
                    Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, Mod.Find<ModGore>("Bullfango3").Type, 1f);
                }
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.Player.ZoneSnow || spawnInfo.Player.ZoneForest || spawnInfo.Player.ZoneJungle &&
                (!spawnInfo.Player.ZoneTowerNebula && !spawnInfo.Player.ZoneTowerSolar && !spawnInfo.Player.ZoneTowerStardust &&
                !spawnInfo.Player.ZoneDungeon &&
                !spawnInfo.Player.ZoneTowerVortex &&
                !spawnInfo.PlayerInTown && !spawnInfo.Player.ZoneOldOneArmy && !Main.snowMoon && !Main.pumpkinMoon) ? 0.1f : 0f;
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BullfangoMask>(), 50));
        }
    }
}
