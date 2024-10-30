using System.IO;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MHArmorSkills.MHSystem
{
    public class DownedBossSystem : ModSystem
    {
        public static bool downedSeltas = false;


        public override void ClearWorld()
        {
            downedSeltas = false;

        }


        public override void SaveWorldData(TagCompound tag)
        {
            if (downedSeltas)
            {
                tag["downedSeltas"] = true;
            }


        }

        public override void LoadWorldData(TagCompound tag)
        {
            downedSeltas = tag.ContainsKey("downedSeltas");

        }

        public override void NetSend(BinaryWriter writer)
        {

            var flags = new BitsByte();
            flags[0] = downedSeltas;

            writer.Write(flags);


        }

        public override void NetReceive(BinaryReader reader)
        {

            BitsByte flags = reader.ReadByte();
            downedSeltas = flags[0];

        }
    }
}
