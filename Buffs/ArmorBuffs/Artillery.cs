using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Artillery : ModBuff
    {
        public static readonly int ArtilleryIncrease = 10;
        public override LocalizedText Description => base.Description.WithFormatArgs(ArtilleryIncrease);
        public override void SetStaticDefaults()
        {
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {

        }
    }
}


