using MHArmorSkills.Buffs;
using MHArmorSkills.Buffs.ArmorBuffs;
using MHArmorSkills.Items.Accessories.Decorations;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MHArmorSkills.MHPlayer
{
    public class ElementsPlayer : ModPlayer
    {
        public int DefaultElement = 5;
        public int MiscElement;

        public int StrifeElement;
        public int DerelictionElement;
        public int CoalescenceElement;
        public int BloodlustElement;

        public float Elemental;
        public float DragonConversion;
        public float MailofHellfireElement;

        public int FireElement;
        public int IceElement;
        public int WaterElement;
        public int ThunderElement;

        public int FinalFireElement;
        public int FinalIceElement;
        public int FinalWaterElement;
        public int FinalThunderElement;

        public float FireElementBuff;
        public float IceElementBuff;
        public float WaterElementBuff;
        public float ThunderElementBuff;

        public float TeostraBuff;
        public float KushalaBuff;

        public float SharpnessBuff;

        public int FinalElement;

        public int FireElementDef;
        public int IceElementDef;
        public int WaterElementDef;
        public int ThunderElementDef;

        public int BlightTimer;

        public override void ResetEffects()
        {
            MiscElement = 0;

            StrifeElement = 0;
            DerelictionElement = 0;
            MailofHellfireElement = 1f;
            CoalescenceElement = 0;
            BloodlustElement = 0;

            Elemental = 1f;
            DragonConversion = 1f;

            

            FireElementBuff = 1f;
            WaterElementBuff = 1f;
            IceElementBuff = 1f;
            ThunderElementBuff = 1f;

            TeostraBuff = 1f;
            KushalaBuff = 1f;

            SharpnessBuff = 1f;

            FireElement = 0;
            WaterElement = 0;
            IceElement = 0;
            ThunderElement = 0;

            FireElementDef = 0;
            WaterElementDef = 0;
            IceElementDef = 0;
            ThunderElementDef = 0;
        }
       
        public override void PostUpdate()
        {
            ArmorSkills modPlayer = Player.GetModPlayer<ArmorSkills>();
            SharpnessPlayer SharpPlayer = Player.GetModPlayer<SharpnessPlayer>();
            #region Elemental Defense
            int TotalEleDef = FireElementDef + WaterElementDef + ThunderElementDef + IceElementDef;
            int DragConvBuff = (int)(TotalEleDef * DragonConversion);
            #endregion
            #region Base element
            if (NPC.downedBoss2)
            {
                MiscElement += 2;
            }
            if (NPC.downedBoss3)
            {
                MiscElement += 2;
            }
            if (Main.hardMode)
            {
                MiscElement += 3;
            }
            if (NPC.downedPlantBoss)
            {
                MiscElement += 3;
            }
            if (NPC.downedFishron)
            {
                MiscElement += 3;
            }
            if (NPC.downedMoonlord)
            {
                MiscElement += 12;
            }
            FinalElement = DefaultElement + MiscElement +StrifeElement + DerelictionElement + DragConvBuff + CoalescenceElement + BloodlustElement;
            #endregion





            #region Final Element
            FinalFireElement =  FireElement + (int)(FinalElement * FireElementBuff * MailofHellfireElement * TeostraBuff * Elemental * SharpnessBuff);
            FinalWaterElement = WaterElement+(int)(FinalElement * WaterElementBuff * MailofHellfireElement * KushalaBuff * Elemental * SharpnessBuff);
            FinalIceElement = IceElement+(int)(FinalElement * IceElementBuff * MailofHellfireElement * KushalaBuff * Elemental * SharpnessBuff);
            FinalThunderElement = ThunderElement+(int)(FinalElement * ThunderElementBuff * MailofHellfireElement * TeostraBuff * Elemental * SharpnessBuff);
            #endregion
        }

        
    }
}
