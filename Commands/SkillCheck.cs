using MHArmorSkills.MHPlayer;
using Terraria;
using Terraria.ModLoader;

namespace MHArmorSkills.Commands
{
    public class SkillCheck : ModCommand
    {
        // CommandType.World means that command can be used in Chat in SP and MP, but executes on the Server in MP
        public override CommandType Type
            => CommandType.World;

        // The desired text to trigger this command
        public override string Command
            => "skills";

        // A short usage explanation for this command
        public override string Usage
            => "/skills" +
            "\n display the active skill the player has.";

        // A short description of this command
        public override string Description
            => "Display the active skill the player has.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            // Obtain the Player object
            Player player = Main.player[Main.myPlayer];

            // Get the mod-specific player state
            ArmorSkills modPlayer = player.GetModPlayer<ArmorSkills>();

            bool SkillActive = false;

            if (modPlayer.AffinitySliding >= 1)
            {
                caller.Reply($"Affinity Sliding Level: {modPlayer.AffinitySliding} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.AdrenalineRush >= 1)
            {
                caller.Reply($"Adrenaline Rush Level: {modPlayer.AdrenalineRush} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.AMobility >= 1)
            {
                caller.Reply($"Aqutaic Mobility Level: {modPlayer.AMobility} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Artillery >= 1)
            {
                caller.Reply($"Artillery Level: {modPlayer.Artillery} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Attack >= 1)
            {
                caller.Reply($"Attack Boost Level: {modPlayer.Attack} (Cap: 7)");
                SkillActive = true;
            }
            if (modPlayer.AutoTracker >= 1)
            {
                caller.Reply($"Auto-Tracker Level: {modPlayer.AutoTracker} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.Autoreload == true)
            {
                caller.Reply($"Auto-Reload Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.Berserk >= 1)
            {
                caller.Reply($"Berserk Level: {modPlayer.Berserk} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.BladeScaleHone >= 1)
            {
                caller.Reply($"Bladescale Hone Level: {modPlayer.BladeScaleHone} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.AntiBleeding == true)
            {
                caller.Reply($"Anti-Bleed Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.BlightProof >= 1)
            {
                caller.Reply($"Blightproof Level: {modPlayer.BlightProof} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.Bloodlust >= 1)
            {
                caller.Reply($"Bloodlust Level: {modPlayer.Bloodlust} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.BloodRite >= 1)
            {
                caller.Reply($"Blood Rite Level: {modPlayer.BloodRite} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.BombBoost >= 1)
            {
                caller.Reply($"Bomb Boost Level: {modPlayer.BombBoost} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.BubbleDance >= 1)
            {
                caller.Reply($"Bubble Dance Level: {modPlayer.BubbleDance} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Carving >= 1)
            {
                caller.Reply($"Carving Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.ChallengeSheathe >= 1)
            {
                caller.Reply($"Challenge Sheath Level: {modPlayer.ChallengeSheathe} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.ChameleosBlessing >= 1)
            {
                caller.Reply($"Chameleos Blessing Level: {modPlayer.ChameleosBlessing} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.CliffHanger >= 1)
            {
                caller.Reply($"Cliff Hanger Level: {modPlayer.CliffHanger} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.Coalescence >= 1)
            {
                caller.Reply($"Coalescence Level: {modPlayer.Coalescence} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.ColdRes >= 1)
            {
                caller.Reply($"Cold Res Level: {modPlayer.ColdRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Constitution >= 1)
            {
                caller.Reply($"Constitution Level: {modPlayer.Constitution} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.CounterStrike >= 1)
            {
                caller.Reply($"Counterstrike Level: {modPlayer.CounterStrike} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.CRangePlus == true)
            {
                caller.Reply($"Close-Range Plus Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.CritDraw >= 1)
            {
                caller.Reply($"Crit Draw Level: {modPlayer.CritDraw} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.CritElement >= 1)
            {
                caller.Reply($"Crit Element Level: {modPlayer.CritElement} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.CritEye >= 1)
            {
                caller.Reply($"Critical Eye Level: {modPlayer.CritEye} (Cap: 7)");
                SkillActive = true;
            }
            if (modPlayer.CriticalBoost >= 1)
            {
                caller.Reply($"Critical Boost Level: {modPlayer.CriticalBoost} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.DeadEye >= 1)
            {
                caller.Reply($"Dead-eye Level: {modPlayer.DeadEye} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.DefenseBoost >= 1)
            {
                caller.Reply($"Defense Boost Level: {modPlayer.DefenseBoost} (Cap: 7)");
                SkillActive = true;
            }
            if (modPlayer.Defiance >= 1)
            {
                caller.Reply($"Defiance Level: {modPlayer.Defiance} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.DefLock >= 1)
            {
                caller.Reply($"Def Lock Level: {modPlayer.DefLock} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Diversion >= 1)
            {
                caller.Reply($"Diversion Level: {modPlayer.Diversion} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Elemental >= 1)
            {
                caller.Reply($"Elemental Level: {modPlayer.Elemental} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Embolden >= 1)
            {
                caller.Reply($"Embolden Level: {modPlayer.Embolden} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.EvadeDistance >= 1)
            {
                caller.Reply($"Evade Distance Level: {modPlayer.EvadeDistance} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Evasion >= 1)
            {
                caller.Reply($"Evasion Level: {modPlayer.Evasion} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.Fate >= 1)
            {
                caller.Reply($"Fate Level: {modPlayer.Fate} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Fencing >= 1)
            {
                caller.Reply($"Fencing Level: {modPlayer.Fencing} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.FireAttack >= 1)
            {
                caller.Reply($"Fire Attack Level: {modPlayer.FireAttack} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.FireRes >= 1)
            {
                caller.Reply($"Fire Res Level: {modPlayer.FireRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.FishingExpert >= 1)
            {
                caller.Reply($"Fishing Expert Level: {modPlayer.FishingExpert} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Foray >= 1)
            {
                caller.Reply($"Foray Level: {modPlayer.Foray} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Fortified >= 1)
            {
                caller.Reply($"Fortified Level: {modPlayer.Fortified} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.FreeMeal >= 1)
            {
                caller.Reply($"Free Meal Level: {modPlayer.FreeMeal} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Gathering >= 1)
            {
                caller.Reply($"Gathering Level: {modPlayer.Gathering} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.Geologist >= 1)
            {
                caller.Reply($"Geologist Level: {modPlayer.Geologist} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Gluttony >= 1)
            {
                caller.Reply($"Gluttony Level: {modPlayer.Gluttony} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Grinder >= 1)
            {
                caller.Reply($"Grinder Level: {modPlayer.Grinder} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Guard >= 1)
            {
                caller.Reply($"Guard Level: {modPlayer.Guard} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.GuardUp >= 1)
            {
                caller.Reply($"Guard Up Level: {modPlayer.GuardUp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Guts >= 1)
            {
                caller.Reply($"Guts Level: {modPlayer.Guts} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Handicraft >= 1)
            {
                caller.Reply($"Handicraft Level: {modPlayer.Handicraft} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.HastenRecovery >= 1)
            {
                caller.Reply($"Hasten Recovery Level: {modPlayer.HastenRecovery} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Health >= 1)
            {
                caller.Reply($"Health Level: {modPlayer.Health} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.HeatRes >= 1)
            {
                caller.Reply($"Heat Res Level: {modPlayer.HeatRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Heroics >= 1)
            {
                caller.Reply($"Heroics Level: {modPlayer.Heroics} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.HeroShield >= 1)
            {
                caller.Reply($"Hero Shield Level: {modPlayer.HeroShield} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.HoneyHunter >= 1)
            {
                caller.Reply($"Honey Hunter Level: {modPlayer.HoneyHunter} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.IceAttack >= 1)
            {
                caller.Reply($"Ice Attack Level: {modPlayer.IceAttack} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.IceRes >= 1)
            {
                caller.Reply($"Ice Res Level: {modPlayer.IceRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.IntrepidHeart == true)
            {
                caller.Reply($"Intrepid Heart Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.JumpMaster >= 1)
            {
                caller.Reply($"Jump Master Level: {modPlayer.JumpMaster} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.KushalaBlessing >= 1)
            {
                caller.Reply($"Kushala Blessing Level: {modPlayer.KushalaBlessing} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.LastingPower >= 1)
            {
                caller.Reply($"Lasting Power Level: {modPlayer.LastingPower} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.LatentPower >= 1 && modPlayer.ZinogreEssence < 2)
            {
                caller.Reply($"Latent Power Level: {modPlayer.LatentPower} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.LatentPower >= 1 && modPlayer.ZinogreEssence >= 2)
            {
                caller.Reply($"Latent Power Level: {modPlayer.LatentPower} (Cap: 7)");
                SkillActive = true;
            }
            if (modPlayer.MailofHellfire >= 1)
            {
                caller.Reply($"Mail of Hellfire Level: {modPlayer.MailofHellfire} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.MastersTouch >= 1)
            {
                caller.Reply($"Masters Touch Level: {modPlayer.MastersTouch} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Mushroomancer >= 1)
            {
                caller.Reply($"Mushroomancer Level: {modPlayer.Mushroomancer} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.NegativeCrit >= 1)
            {
                caller.Reply($"Negative Crit Level: {modPlayer.NegativeCrit} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.NormalUp >= 1)
            {
                caller.Reply($"Normal Up Level: {modPlayer.NormalUp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.OffensiveGuard >= 1)
            {
                caller.Reply($"Offensive Guard Level: {modPlayer.OffensiveGuard} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.PelletUp >= 1)
            {
                caller.Reply($"Pellet Up Level: {modPlayer.PelletUp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.PierceUp >= 1)
            {
                caller.Reply($"Pierce Up Level: {modPlayer.PierceUp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.AntiPoison >= 1)
            {
                caller.Reply($"Anti-Poison Level: {modPlayer.AntiPoison} (Cap: 2)");
                SkillActive = true;
            }
            if (modPlayer.PoisonCPlus == true)
            {
                caller.Reply($"Poison Coating Plus Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.PolarHunter >= 1)
            {
                caller.Reply($"Polar Hunter Level: {modPlayer.PolarHunter} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Protection >= 1)
            {
                caller.Reply($"Protection Level: {modPlayer.Protection} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.ProtectivePolish >= 1)
            {
                caller.Reply($"Protective Polish Level: {modPlayer.ProtectivePolish} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.PunishDraw >= 1)
            {
                caller.Reply($"Punish Draw Level: {modPlayer.PunishDraw} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.QuickSharpening >= 1)
            {
                caller.Reply($"Quick Sharpening Level: {modPlayer.QuickSharpening} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.QuickSheath >= 1)
            {
                caller.Reply($"Quick Sheath Level: {modPlayer.QuickSheath} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.RapidFire >= 1)
            {
                caller.Reply($"Rapid Fire Level: {modPlayer.RapidFire} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.RazorSharp >= 1)
            {
                caller.Reply($"Razor Sharp Level: {modPlayer.RazorSharp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.RecoveryUp >= 1)
            {
                caller.Reply($"Recovery Up Level: {modPlayer.RecoveryUp} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.RecSpeed >= 1)
            {
                caller.Reply($"Recovery Speed Level: {modPlayer.RecSpeed} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Resentment >= 1)
            {
                caller.Reply($"Resentment Level: {modPlayer.Resentment} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Resusitate >= 1)
            {
                caller.Reply($"Resusitate Level: {modPlayer.Resusitate} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.RockSteady == true)
            {
                caller.Reply($"Rock Steady Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.Scholar >= 1)
            {
                caller.Reply($"Scholar Level: {modPlayer.Scholar} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Sneak >= 1)
            {
                caller.Reply($"Sneak Level: {modPlayer.Sneak} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.SneakAttack >= 1)
            {
                caller.Reply($"Sneak Attack Level: {modPlayer.SneakAttack} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.SpareShot >= 1)
            {
                caller.Reply($"Spare Shot Level: {modPlayer.SpareShot} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.SpeedEating >= 1)
            {
                caller.Reply($"Speed Eating Level: {modPlayer.SpeedEating} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.SpeedSetup >= 1)
            {
                caller.Reply($"Speed Set-up Level: {modPlayer.SpeedSetup} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Spirit >= 1)
            {
                caller.Reply($"Spirit Level: {modPlayer.Spirit} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.SpiritBirdsCall == true)
            {
                caller.Reply($"Spiritbird's Call Skill: Active");
                SkillActive = true;
            }
            if (modPlayer.StamRec >= 1)
            {
                caller.Reply($"Stamina Recovery Level: {modPlayer.StamRec} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.StatusTrigger >= 1)
            {
                caller.Reply($"Status Trigger Level: {modPlayer.StatusTrigger} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Strife >= 1)
            {
                caller.Reply($"Strife Level: {modPlayer.Strife} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Tenderizer >= 1)
            {
                caller.Reply($"Tenderizer Level: {modPlayer.Tenderizer} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.TeostraBlessing >= 1)
            {
                caller.Reply($"Teostra Blessing Level: {modPlayer.TeostraBlessing} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.ThunderAttack >= 1)
            {
                caller.Reply($"Thunder Attack Level: {modPlayer.ThunderAttack} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.ThunderRes >= 1)
            {
                caller.Reply($"Thunder Res Level: {modPlayer.ThunderRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.TremorRes >= 1)
            {
                caller.Reply($"Tremor Res Level: {modPlayer.TremorRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.TropicHunter >= 1)
            {
                caller.Reply($"Tropics Hunter Level: {modPlayer.TropicHunter} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Unscathed >= 1)
            {
                caller.Reply($"Unscathed Level: {modPlayer.Unscathed} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Vault >= 1)
            {
                caller.Reply($"Vault Level: {modPlayer.Vault} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.WaterAttack >= 1)
            {
                caller.Reply($"Water Attack Level: {modPlayer.WaterAttack} (Cap: 5)");
                SkillActive = true;
            }
            if (modPlayer.WaterRes >= 1)
            {
                caller.Reply($"Water Res Level: {modPlayer.WaterRes} (Cap: 3)");
                SkillActive = true;
            }
            if (modPlayer.Windproof >= 1)
            {
                caller.Reply($"Windproof Level: {modPlayer.Windproof} (Cap: 3)");
                SkillActive = true;
            }
            if (!SkillActive)
            {
                caller.Reply("No skills active.");
            }
        }
    }
}

