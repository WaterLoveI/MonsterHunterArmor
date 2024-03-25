using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;


namespace MHArmorSkills.Buffs.ArmorBuffs
{
    public class Attack : ModBuff
    {
        public static readonly int AttackIncrease = 3;
        public override LocalizedText Description => base.Description.WithFormatArgs(AttackIncrease);
        public override void SetStaticDefaults()
        {

            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            
        }
    }
}


