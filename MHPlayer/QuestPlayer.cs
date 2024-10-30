using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace MHArmorSkills.MHPlayer
{
    public class QuestPlayer : ModPlayer
    {
        public int QuestNumber = 0;

        public override void LoadData(TagCompound tag)
        {
            QuestNumber = tag.GetInt("questNumber");
        }

        public override void SaveData(TagCompound tag)
        {
            tag["questNumber"] = QuestNumber;
        }

    }
}
