using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMOD_API_crew_mod
{
    public class PathsFMOD
    {
        public static string soundsPath;
        public static string eventsPathHigh = "dialogs_crew_ground/high/";
        public static string eventsPathMed = "dialogs_crew_ground/med/";
        public static string eventsPathLow = "dialogs_crew_ground/low/";

        public Dictionary<string, string> pathsFMOD = new Dictionary<string, string>()
        {
            [soundsPath + "\\1 Start bjtcad\\1 L nazjoan"] = "01_battle_start/voice_message_chief_battle_start",
            [soundsPath + "\\1 Start bjtcad\\2 lpnaoejr dptpc"] = "01_battle_start/voice_message_commander_battle_start",
            [soundsPath + "\\1 Start bjtcad\\3 cpejtfmab dptpc"] = "01_battle_start/voice_message_driver_battle_ready",
            [soundsPath + "\\1 Start bjtcad\\4 oacpeyjl dptpc"] = "01_battle_start/voice_message_gunner_battle_ready",
            [soundsPath + "\\1 Start bjtcad\\5 iaraghaafaajk dptpc"] = "01_battle_start/voice_message_loader_battle_ready",

            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\1 L iacpelf qrjdptpcjtabsag"] = "02_movement_control/voice_message_commander_engine_prepare",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\2 Iacpej"] = "02_movement_control/voice_message_commander_engine_start",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\3 Dmuzj nptpr"] = "02_movement_control/voice_message_commander_engine_stop",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\4 Iaeojk wpe"] = "02_movement_control/voice_message_commander_move_backward",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\5 Badstrff"] = "02_movement_control/voice_message_commander_move_faster",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\6 Cqfrfe"] = "02_movement_control/voice_message_commander_move_forward",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\7 Pbprptad (qadtafnsag fwatab c dprlu)"] = "02_movement_control/voice_message_commander_move_revvs",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\8 Nfoabzf wpe"] = "02_movement_control/voice_message_commander_move_slower",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\9 Stpk"] = "02_movement_control/voice_message_commander_move_stop",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\10 Ecjdatfmab dptpc"] = "02_movement_control/voice_message_driver_engine_ready",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\11 Ptcft nfwcpea oa iacfstj ecjdatfmab"] = "02_movement_control/voice_message_driver_engine_yes",
            [soundsPath + "\\2 Lpotrpmab ecjhfojk\\12 Ptcft nfwcpea oa lpnaoeu cqfrfe"] = "02_movement_control/voice_message_driver_move_forward",

            [soundsPath + "\\3 Raimjyoadf qrjbprad\\1 Cadlmafyjtab opyopf cjefojf"] = "03_various_devices/voice_message_commander_night_vision_off",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\2 Clm opyopf cjefojf"] = "03_various_devices/voice_message_commander_night_vision_on",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\3 Ptcam ubratab"] = "03_various_devices/voice_message_commander_shovel_off",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\4 Ptcam cadqustjtab jmj cadtaaajtab wi lal)"] = "03_various_devices/voice_message_commander_shovel_on",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\5 Stabjmjiatpr cadlm"] = "03_various_devices/voice_message_commander_stabilizer_off",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\6 Stab clm"] = "03_various_devices/voice_message_commander_stabilizer_on",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\7 Iaqustjtab erpo"] = "03_various_devices/voice_message_commander_ucav_launch",
            [soundsPath + "\\3 Raimjyoadf qrjbprad\\8 Erpo dptpc"] = "03_various_devices/voice_message_commander_ucav_recover",

            [soundsPath + "\\4 Qfrfiaragela\\1 Brpofbpkoadk"] = "04_loading/voice_message_commander_load_AP",
            [soundsPath + "\\4 Qfrfiaragela\\1 Brpofbpkoadk dptpc"] = "04_loading/voice_message_loader_load_AP",
            [soundsPath + "\\4 Qfrfiaragela\\2 Zraqofmab"] = "04_loading/voice_message_commander_load_canister",
            [soundsPath + "\\4 Qfrfiaragela\\2 Zraqofmab dptpc"] = "04_loading/voice_message_loader_load_canister",
            [soundsPath + "\\4 Qfrfiaragela\\3 Pscftjtfmaboadk"] = "04_loading/voice_message_commander_load_flares",
            [soundsPath + "\\4 Qfrfiaragela\\3 Pscftjtfmaboadk dptpc"] = "04_loading/voice_message_loader_load_flares",
            [soundsPath + "\\4 Qfrfiaragela\\4 Pslpmpyoadk"] = "04_loading/voice_message_commander_load_frag",
            [soundsPath + "\\4 Qfrfiaragela\\4 Pslpmpyoadk dptpc"] = "04_loading/voice_message_loader_load_frag",
            [soundsPath + "\\4 Qfrfiaragela\\5 Vudasoadk"] = "04_loading/voice_message_commander_load_HE",
            [soundsPath + "\\4 Qfrfiaragela\\5 Vudasoadk dptpc"] = "04_loading/voice_message_loader_load_HE",
            [soundsPath + "\\4 Qfrfiaragela\\6 Lunumagtjcoadk"] = "04_loading/voice_message_commander_load_HEAT",
            [soundsPath + "\\4 Qfrfiaragela\\6 Lunumagtjcoadk dptpc"] = "04_loading/voice_message_loader_load_HEAT",
            [soundsPath + "\\4 Qfrfiaragela\\7 Brpofbpkop vudasoadk"] = "04_loading/voice_message_commander_load_HESH",
            [soundsPath + "\\4 Qfrfiaragela\\7 Brpofbpkop vudasoadk dptpc"] = "04_loading/voice_message_loader_load_HESH",
            [soundsPath + "\\4 Qfrfiaragela\\8 Uqracmagfnaag ralfta"] = "04_loading/voice_message_commander_load_missile",
            [soundsPath + "\\4 Qfrfiaragela\\8 Uqracmagfnaag ralfta dptpc"] = "04_loading/voice_message_loader_load_missile",
            [soundsPath + "\\4 Qfrfiaragela\\9 Qpelamjbfroadk"] = "04_loading/voice_message_commander_load_sabot",
            [soundsPath + "\\4 Qfrfiaragela\\9 Qpelamjbfroadk dptpc"] = "04_loading/voice_message_loader_load_sabot",
            [soundsPath + "\\4 Qfrfiaragela\\10 Eadnpcpk"] = "04_loading/voice_message_commander_load_smoke",
            [soundsPath + "\\4 Qfrfiaragela\\10 Eadnpcpk dptpc"] = "04_loading/voice_message_loader_load_smoke",
            [soundsPath + "\\4 Qfrfiaragela\\11 Qfrfiaraghak"] = "04_loading/voice_message_commander_reload",
            [soundsPath + "\\4 Qfrfiaragela\\12 Psfyla"] = "04_loading/voice_message_gunner_misfire",
            [soundsPath + "\\4 Qfrfiaragela\\13 Qumfnft dptpc"] = "04_loading/voice_message_loader_mg_ready",

            [soundsPath + "\\5 Xfmfulaiaojf\\1 Pdpoab"] = "05_targeting/voice_message_commander_shot/voice_message_commander_shot",
            [soundsPath + "\\5 Xfmfulaiaojf\\2 Xfmab"] = "05_targeting/voice_message_commander_target",
            [soundsPath + "\\5 Xfmfulaiaojf\\3 Yasad csf"] = "",
            [soundsPath + "\\5 Xfmfulaiaojf\\4 Ejstaoxjag"] = "05_targeting/voice_message_commander_target_distance",
            [soundsPath + "\\5 Xfmfulaiaojf\\4 Ejstaoxjag c uqpr"] = "05_targeting/voice_message_commander_target_near",
            [soundsPath + "\\5 Xfmfulaiaojf\\4 Ejstaoxjag xjvrad"] = "",
            [soundsPath + "\\5 Xfmfulaiaojf\\5 Pboaruhfojf tfwojlj lpnaoejrpn"] = "",
            [soundsPath + "\\5 Xfmfulaiaojf\\6 S wpeu"] = "05_targeting/voice_message_commander_target_on_the_move",
            [soundsPath + "\\5 Xfmfulaiaojf\\7 Qrfqagtstcjf"] = "05_targeting/voice_message_driver_obstacle",
            [soundsPath + "\\5 Xfmfulaiaojf\\8 Qpcprpt cmfcp"] = "05_targeting/voice_message_driver_turning_left",
            [soundsPath + "\\5 Xfmfulaiaojf\\9 Qpcprpt cqracp"] = "05_targeting/voice_message_driver_turning_right",
            [soundsPath + "\\5 Xfmfulaiaojf\\10 Bazoaf cmfcp"] = "05_targeting/voice_message_gunner_turret_left",
            [soundsPath + "\\5 Xfmfulaiaojf\\11 Bazoaf Cqracp"] = "05_targeting/voice_message_gunner_turret_right",

            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\1 Lprrfltjrpclj lpnaoejra"] = "",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\2 Mfcff"] = "06_shooting_results/voice_message_commander_correction_left",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\3 Qracff"] = "06_shooting_results/voice_message_commander_correction_right",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\4 Nfwcpe cfrop"] = "06_shooting_results/voice_message_driver_correction_bracketed",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\5 Qpqaeaojf"] = "06_shooting_results/voice_message_driver_correction_hit",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\6 Nfwcpe mfcff"] = "06_shooting_results/voice_message_driver_correction_left",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\7 Nfwcpe qracff"] = "06_shooting_results/voice_message_driver_correction_right",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\8 Qfrfmft"] = "06_shooting_results/voice_message_driver_correction_retreat",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\9 Xfmab uojytphfoa"] = "06_shooting_results/voice_message_driver_correction_target_hit",
            [soundsPath + "\\6 Rfiumabtatad strfmabbad\\10 Ofepmft"] = "06_shooting_results/voice_message_driver_correction_undershoot",

            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\1 Qpljoutab nazjou"] = "07_fighting_for_survivability/voice_message_commander_bail",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\2 AEljqah qptfrago"] = "07_fighting_for_survivability/voice_message_commander_crew_lost",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\3 Brpoaf qrpbjmj nfwcpe"] = "07_fighting_for_survivability/voice_message_driver_armor_breached",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\4 Qpcrfhefojag nfwcpe"] = "07_fighting_for_survivability/voice_message_driver_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\5 Tpqmjcoadk bal qptfl nfwcpe"] = "07_fighting_for_survivability/voice_message_driver_engine_fuel_leak",
            //
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\7 Ecjdatfmab qpyjojmj"] = "07_fighting_for_survivability/voice_message_driver_engine_repaired",
            //
            //
            //
            //
            //
            //
            //
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\14 Mfcaag dusfojxa"] = "07_fighting_for_survivability/voice_message_driver_left_track",
            //
            //
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\16 Nad oa wpeu nfwcpe"] = "07_fighting_for_survivability/voice_message_driver_on_the_move",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\17 Raejatpr qpcrfhefo"] = "07_fighting_for_survivability/voice_message_driver_radiator_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\18 Qracaag dusfojxa"] = "07_fighting_for_survivability/voice_message_driver_right_track",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\19 Wpepcuaf smpnamj"] = "07_fighting_for_survivability/voice_message_driver_running_gear_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\20 Nfwcpe bfrft lpnaoepcaojf"] = "07_fighting_for_survivability/voice_message_driver_taking_command",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\21 Dusmag smftfma"] = "07_fighting_for_survivability/voice_message_driver_track_lost",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\22 Dusfojxad qpyjojmj"] = "07_fighting_for_survivability/voice_message_driver_tracks_repaired",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\23 Traosnjssjaf smpnamj"] = "07_fighting_for_survivability/voice_message_driver_transmission_damaged",
            //
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\25 Lpmfsp qptfragmj"] = "07_fighting_for_survivability/voice_message_driver_wheel_lost",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\26 Lpmfsp qpyjojmj"] = "07_fighting_for_survivability/voice_message_driver_wheel_repaired",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\27 Stcpm qpcrfhefo"] = "07_fighting_for_survivability/voice_message_gunner_barrel_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\28 Qrjcpead pruejag qpyjojmj"] = "07_fighting_for_survivability/voice_message_gunner_cannon_drives_repaired",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\29 Quzla dptpca"] = "07_fighting_for_survivability/voice_message_gunner_cannon_ready",
            //
            //
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\31 Cfrtjlamaboadk qrjcpe qpcrfhefo"] = "07_fighting_for_survivability/voice_message_gunner_elevation_drive_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\31 Cfrtjlamaboadk qrjcpe qpyjojmj"] = "07_fighting_for_survivability/voice_message_gunner_elevation_drive_repaired",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\33 Smpnamj ifojtoadk qumfnft"] = "07_fighting_for_survivability/voice_message_gunner_mg_aa_lost",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\34 Smpnamj lurspcpk qumfnft"] = "07_fighting_for_survivability/voice_message_gunner_mg_directional_lost",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\35 Qumfnft qpyjojmj"] = "07_fighting_for_survivability/voice_message_gunner_mg_ready",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\36 Nfwaojin qpcprpta bazoj smpnao"] = "07_fighting_for_survivability/voice_message_gunner_rotation_drive_damaged",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\36 Qpyjojmj"] = "07_fighting_for_survivability/voice_message_gunner_rotation_drive_repaired",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\37 Oacpeyjl bfrft lpnaoepcaojf"] = "07_fighting_for_survivability/voice_message_gunner_taking_command",
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\38 Iaraghaafaajk bfrft lpnaoepcaojf"] = "07_fighting_for_survivability/voice_message_loader_taking_command",

            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\1 Lpprejoatad xjvrad"] = "",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\2 Qrjoagm"] = "08_artillery_support/voice_message_artillery_acknowledged",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\3 Lpprejoatad bulcad"] = "",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\4 Qrjcagilu ialpoyjm pdpoab"] = "08_artillery_support/voice_message_artillery_bracketed",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\5 Artjmmfrjag pdpoab"] = "08_artillery_support/voice_message_artillery_open_fire",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\6 Cas qpoagm"] = "08_artillery_support/voice_message_artillery_understood",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\7 Udrpia art ueara qp oan"] = "08_artillery_support/voice_message_chief_artillery_danger",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\8 Art iadraejtfmaboadk pdpoab lpnaoejr"] = "08_artillery_support/voice_message_commander_art_barrage",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\9 Xjvrad lpnaoejr"] = "",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\10 Bulcad lpnaoejr"] = "",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\11 Lpprejoatad lpnaoejr cadipc art"] = "08_artillery_support/voice_message_commander_art_coordinates",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\12 Lpnaoejr uojytphjtab"] = "08_artillery_support/voice_message_commander_art_destroy",
            [soundsPath + "\\8 Qpeefrhla artjmmfrjj\\13 Arta oa sfbag"] = "08_artillery_support/voice_message_commander_art_on_me",

            [soundsPath + "\\9 Qpeefrhla acjaxjj\\1 Acjaxjag oa qpemftf"] = "09_aviation_support/voice_message_aviation_on_the_way",
            [soundsPath + "\\9 Qpeefrhla acjaxjj\\2 Lpnaoejr iaqrps qpeefrhlj"] = "09_aviation_support/voice_message_commander_art_request",

            [soundsPath + "\\10 Qrptjcpcpieuzoaag pbprpoa\\1 Cpieuw"] = "10_air_defense/voice_message_chief_air_danger",

            [soundsPath + "\\11 Lpofx bjtcad\\1 Qprahfojf"] = "11_battle_end/voice_message_chief_battle_loose",
            [soundsPath + "\\11 Lpofx bjtcad\\2 Qpbfea"] = "11_battle_end/voice_message_chief_battle_win",
        };

        public Dictionary<string, string[]> pathsFMODmany = new Dictionary<string, string[]>()
        {
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\6 Ecjdatfmab cstam"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_engine_off",
                "07_fighting_for_survivability/voice_message_driver_engine_stalled"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\8 Qphar"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_fire",
                "07_fighting_for_survivability/voice_message_gunner_fire",
                "07_fighting_for_survivability/voice_message_loader_fire"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\9 Qphar ecjdatfmag"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_fire_engine",
                "07_fighting_for_survivability/voice_message_gunner_fire_engine",
                "07_fighting_for_survivability/voice_message_loader_fire_engine"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\10 Qphar qptuzfo"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_fire_extinguished",
                "07_fighting_for_survivability/voice_message_gunner_fire_extinguished",
                "07_fighting_for_survivability/voice_message_loader_fire_extinguished"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\11 Qphar c bpfcpn ptefmfojj"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_fire_fighting_compartment",
                "07_fighting_for_survivability/voice_message_gunner_fire_fighting_compartment",
                "07_fighting_for_survivability/voice_message_loader_fire_fighting_compartment"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\12 Bpfqrjqasad dpragt"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_fire_munition_compartment",
                "07_fighting_for_survivability/voice_message_gunner_fire_munition_compartment",
                "07_fighting_for_survivability/voice_message_loader_fire_munition_compartment"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\13 Oacpeyjl bfi spioaojag"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_gunner_unconscious",
                "07_fighting_for_survivability/voice_message_loader_gunner_unconscious"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\13 Oacpeyjl lpotuhfo"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_gunner_stunned",
                "07_fighting_for_survivability/voice_message_loader_gunner_stunned"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\15 Iaraghaafaajk bfi spioaojag"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_loader_unconscious",
                "07_fighting_for_survivability/voice_message_gunner_loader_unconscious"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\15 Iaraghaafaajk lpotuhfo"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_loader_stunned",
                "07_fighting_for_survivability/voice_message_gunner_loader_stunned"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\24 Qpqamj qp taolu"] = new[]
            {
                "07_fighting_for_survivability/voice_message_driver_weve_been_hit",
                "07_fighting_for_survivability/voice_message_gunner_weve_been_hit",
                "07_fighting_for_survivability/voice_message_loader_weve_been_hit"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\30 Cpejtfmab bfi spioaojag"] = new[]
            {
                "07_fighting_for_survivability/voice_message_gunner_driver_unconscious",
                "07_fighting_for_survivability/voice_message_loader_driver_unconscious"
            },
            [soundsPath + "\\7 Bprabba ia cadhjcaojf\\30 Cpejtfmab lpotuhfo"] = new[]
            {
                "07_fighting_for_survivability/voice_message_gunner_driver_stunned",
                "07_fighting_for_survivability/voice_message_loader_gunner_stunned"
            }

            //public Dictionary<string, string> pathsFMOD = new Dictionary<string, string>()
            //{
            //    [soundsPath + "\\1 Старт битвы\\1 К машинам"] = "01_battle_start/voice_message_chief_battle_start",
            //    [soundsPath + "\\1 Старт битвы\\2 командир готов"] = "01_battle_start/voice_message_commander_battle_start",
            //    [soundsPath + "\\1 Старт битвы\\3 водитель готов"] = "01_battle_start/voice_message_driver_battle_ready",
            //    [soundsPath + "\\1 Старт битвы\\4 наводчик готов"] = "01_battle_start/voice_message_gunner_battle_ready",
            //    [soundsPath + "\\1 Старт битвы\\5 заряжающий готов"] = "01_battle_start/voice_message_loader_battle_ready",

            //    [soundsPath + "\\2 Контроль движений\\1 К заводке приготовиться"] = "02_movement_control/voice_message_commander_engine_prepare",
            //    [soundsPath + "\\2 Контроль движений\\2 Заводи"] = "02_movement_control/voice_message_commander_engine_start",
            //    [soundsPath + "\\2 Контроль движений\\3 Глуши мотор"] = "02_movement_control/voice_message_commander_engine_stop",
            //    [soundsPath + "\\2 Контроль движений\\4 Задний ход"] = "02_movement_control/voice_message_commander_move_backward",
            //    [soundsPath + "\\2 Контроль движений\\5 Быстрее"] = "02_movement_control/voice_message_commander_move_faster",
            //    [soundsPath + "\\2 Контроль движений\\6 Вперед"] = "02_movement_control/voice_message_commander_move_forward",
            //    [soundsPath + "\\2 Контроль движений\\7 Обороты (пытаемся ехать в горку)"] = "02_movement_control/voice_message_commander_move_revvs",
            //    [soundsPath + "\\2 Контроль движений\\8 Меньше ход"] = "02_movement_control/voice_message_commander_move_slower",
            //    [soundsPath + "\\2 Контроль движений\\9 Стой"] = "02_movement_control/voice_message_commander_move_stop",
            //    [soundsPath + "\\2 Контроль движений\\10 Двигатель готов"] = "02_movement_control/voice_message_driver_engine_ready",
            //    [soundsPath + "\\2 Контроль движений\\11 Ответ мехвода на завести двигатель"] = "02_movement_control/voice_message_driver_engine_yes",
            //    [soundsPath + "\\2 Контроль движений\\12 Ответ мехвода на команду вперед"] = "02_movement_control/voice_message_driver_move_forward",

            //    [soundsPath + "\\3 Различные приборы\\1 Выключить ночное видение"] = "03_various_devices/voice_message_commander_night_vision_off",
            //    [soundsPath + "\\3 Различные приборы\\2 Вкл ночное видение"] = "03_various_devices/voice_message_commander_night_vision_on",
            //    [soundsPath + "\\3 Различные приборы\\3 Отвал убрать"] = "03_various_devices/voice_message_commander_shovel_off",
            //    [soundsPath + "\\3 Различные приборы\\4 Отвал выпустить или вытащить хз как)"] = "03_various_devices/voice_message_commander_shovel_on",
            //    [soundsPath + "\\3 Различные приборы\\5 Стабилизатор выкл"] = "03_various_devices/voice_message_commander_stabilizer_off",
            //    [soundsPath + "\\3 Различные приборы\\6 Стаб вкл"] = "03_various_devices/voice_message_commander_stabilizer_on",
            //    [soundsPath + "\\3 Различные приборы\\7 Запустить дрон"] = "03_various_devices/voice_message_commander_ucav_launch",
            //    [soundsPath + "\\3 Различные приборы\\8 Дрон готов"] = "03_various_devices/voice_message_commander_ucav_recover",

            //    [soundsPath + "\\4 Перезарядка\\1 Бронебойный"] = "04_loading/voice_message_commander_load_AP",
            //    [soundsPath + "\\4 Перезарядка\\1 Бронебойный готов"] = "04_loading/voice_message_loader_load_AP",
            //    [soundsPath + "\\4 Перезарядка\\2 Шрапнель"] = "04_loading/voice_message_commander_load_canister",
            //    [soundsPath + "\\4 Перезарядка\\2 Шрапнель готов"] = "04_loading/voice_message_loader_load_canister",
            //    [soundsPath + "\\4 Перезарядка\\3 Осветительный"] = "04_loading/voice_message_commander_load_flares",
            //    [soundsPath + "\\4 Перезарядка\\3 Осветительный готов"] = "04_loading/voice_message_loader_load_flares",
            //    [soundsPath + "\\4 Перезарядка\\4 Осколочный"] = "04_loading/voice_message_commander_load_frag",
            //    [soundsPath + "\\4 Перезарядка\\4 Осколочный готов"] = "04_loading/voice_message_loader_load_frag",
            //    [soundsPath + "\\4 Перезарядка\\5 Фугасный"] = "04_loading/voice_message_commander_load_HE",
            //    [soundsPath + "\\4 Перезарядка\\5 Фугасный готов"] = "04_loading/voice_message_loader_load_HE",
            //    [soundsPath + "\\4 Перезарядка\\6 Кумулятивный"] = "04_loading/voice_message_commander_load_HEAT",
            //    [soundsPath + "\\4 Перезарядка\\6 Кумулятивный готов"] = "04_loading/voice_message_loader_load_HEAT",
            //    [soundsPath + "\\4 Перезарядка\\7 Бронебойно фугасный"] = "04_loading/voice_message_commander_load_HESH",
            //    [soundsPath + "\\4 Перезарядка\\7 Бронебойно фугасный готов"] = "04_loading/voice_message_loader_load_HESH",
            //    [soundsPath + "\\4 Перезарядка\\8 Управляемая ракета"] = "04_loading/voice_message_commander_load_missile",
            //    [soundsPath + "\\4 Перезарядка\\8 Управляемая ракета готов"] = "04_loading/voice_message_loader_load_missile",
            //    [soundsPath + "\\4 Перезарядка\\9 Подкалиберный"] = "04_loading/voice_message_commander_load_sabot",
            //    [soundsPath + "\\4 Перезарядка\\9 Подкалиберный готов"] = "04_loading/voice_message_loader_load_sabot",
            //    [soundsPath + "\\4 Перезарядка\\10 Дымовой"] = "04_loading/voice_message_commander_load_smoke",
            //    [soundsPath + "\\4 Перезарядка\\10 Дымовой готов"] = "04_loading/voice_message_loader_load_smoke",
            //    [soundsPath + "\\4 Перезарядка\\11 Перезаряжай"] = "04_loading/voice_message_commander_reload",
            //    [soundsPath + "\\4 Перезарядка\\12 Осечка"] = "04_loading/voice_message_gunner_misfire",
            //    [soundsPath + "\\4 Перезарядка\\13 Пулемет готов"] = "04_loading/voice_message_loader_mg_ready",

            //    [soundsPath + "\\5 Целеуказание\\1 Огонь"] = "05_targeting/voice_message_commander_shot/voice_message_commander_shot",
            //    [soundsPath + "\\5 Целеуказание\\2 Цель"] = "05_targeting/voice_message_commander_target",
            //    [soundsPath + "\\5 Целеуказание\\3 Часы все"] = "",
            //    [soundsPath + "\\5 Целеуказание\\4 Дистанция"] = "05_targeting/voice_message_commander_target_distance",
            //    [soundsPath + "\\5 Целеуказание\\4 Дистанция в упор"] = "05_targeting/voice_message_commander_target_near",
            //    [soundsPath + "\\5 Целеуказание\\4 Дистанция цифры"] = "",
            //    [soundsPath + "\\5 Целеуказание\\5 Обнаружение техники командиром"] = "",
            //    [soundsPath + "\\5 Целеуказание\\6 С ходу"] = "05_targeting/voice_message_commander_target_on_the_move",
            //    [soundsPath + "\\5 Целеуказание\\7 Препятствие"] = "05_targeting/voice_message_driver_obstacle",
            //    [soundsPath + "\\5 Целеуказание\\8 Поворот влево"] = "05_targeting/voice_message_driver_turning_left",
            //    [soundsPath + "\\5 Целеуказание\\9 Поворот вправо"] = "05_targeting/voice_message_driver_turning_right",
            //    [soundsPath + "\\5 Целеуказание\\10 Башню влево"] = "05_targeting/voice_message_gunner_turret_left",
            //    [soundsPath + "\\5 Целеуказание\\11 Башню Вправо"] = "05_targeting/voice_message_gunner_turret_right",

            //    [soundsPath + "\\6 Результаты стрельбы\\1 Корректировки командира"] = "",
            //    [soundsPath + "\\6 Результаты стрельбы\\2 Левее"] = "06_shooting_results/voice_message_commander_correction_left",
            //    [soundsPath + "\\6 Результаты стрельбы\\3 Правее"] = "06_shooting_results/voice_message_commander_correction_right",
            //    [soundsPath + "\\6 Результаты стрельбы\\4 Мехвод верно"] = "06_shooting_results/voice_message_driver_correction_bracketed",
            //    [soundsPath + "\\6 Результаты стрельбы\\5 Попадание"] = "06_shooting_results/voice_message_driver_correction_hit",
            //    [soundsPath + "\\6 Результаты стрельбы\\6 Мехвод левее"] = "06_shooting_results/voice_message_driver_correction_left",
            //    [soundsPath + "\\6 Результаты стрельбы\\7 Мехвод правее"] = "06_shooting_results/voice_message_driver_correction_right",
            //    [soundsPath + "\\6 Результаты стрельбы\\8 Перелет"] = "06_shooting_results/voice_message_driver_correction_retreat",
            //    [soundsPath + "\\6 Результаты стрельбы\\9 Цель уничтожена"] = "06_shooting_results/voice_message_driver_correction_target_hit",
            //    [soundsPath + "\\6 Результаты стрельбы\\10 Недолет"] = "06_shooting_results/voice_message_driver_correction_undershoot",

            //    [soundsPath + "\\7 Борьба за выживание\\1 Покинуть машину"] = "07_fighting_for_survivability/voice_message_commander_bail",
            //    [soundsPath + "\\7 Борьба за выживание\\2 Экипаж потерян"] = "07_fighting_for_survivability/voice_message_commander_crew_lost",
            //    [soundsPath + "\\7 Борьба за выживание\\3 Броню пробили мехвод"] = "07_fighting_for_survivability/voice_message_driver_armor_breached",
            //    [soundsPath + "\\7 Борьба за выживание\\4 Повреждения мехвод"] = "07_fighting_for_survivability/voice_message_driver_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\5 Топливный бак потек мехвод"] = "07_fighting_for_survivability/voice_message_driver_engine_fuel_leak",
            //    //
            //    [soundsPath + "\\7 Борьба за выживание\\7 Двигатель починили"] = "07_fighting_for_survivability/voice_message_driver_engine_repaired",
            //    //
            //    //
            //    //
            //    //
            //    //
            //    //
            //    //
            //    [soundsPath + "\\7 Борьба за выживание\\14 Левая гусеница"] = "07_fighting_for_survivability/voice_message_driver_left_track",
            //    //
            //    //
            //    [soundsPath + "\\7 Борьба за выживание\\16 Мы на ходу мехвод"] = "07_fighting_for_survivability/voice_message_driver_on_the_move",
            //    [soundsPath + "\\7 Борьба за выживание\\17 Радиатор поврежден"] = "07_fighting_for_survivability/voice_message_driver_radiator_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\18 Правая гусеница"] = "07_fighting_for_survivability/voice_message_driver_right_track",
            //    [soundsPath + "\\7 Борьба за выживание\\19 Ходовую сломали"] = "07_fighting_for_survivability/voice_message_driver_running_gear_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\20 Мехвод берет командование"] = "07_fighting_for_survivability/voice_message_driver_taking_command",
            //    [soundsPath + "\\7 Борьба за выживание\\21 Гусля слетела"] = "07_fighting_for_survivability/voice_message_driver_track_lost",
            //    [soundsPath + "\\7 Борьба за выживание\\22 Гусеницы починили"] = "07_fighting_for_survivability/voice_message_driver_tracks_repaired",
            //    [soundsPath + "\\7 Борьба за выживание\\23 Трансмиссию сломали"] = "07_fighting_for_survivability/voice_message_driver_transmission_damaged",
            //    //
            //    [soundsPath + "\\7 Борьба за выживание\\25 Колесо потеряли"] = "07_fighting_for_survivability/voice_message_driver_wheel_lost",
            //    [soundsPath + "\\7 Борьба за выживание\\26 Колесо починили"] = "07_fighting_for_survivability/voice_message_driver_wheel_repaired",
            //    [soundsPath + "\\7 Борьба за выживание\\27 Ствол поврежден"] = "07_fighting_for_survivability/voice_message_gunner_barrel_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\28 Приводы орудия починили"] = "07_fighting_for_survivability/voice_message_gunner_cannon_drives_repaired",
            //    [soundsPath + "\\7 Борьба за выживание\\29 Пушка готова"] = "07_fighting_for_survivability/voice_message_gunner_cannon_ready",
            //    //
            //    //
            //    [soundsPath + "\\7 Борьба за выживание\\31 Вертикальный привод поврежден"] = "07_fighting_for_survivability/voice_message_gunner_elevation_drive_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\31 Вертикальный привод починили"] = "07_fighting_for_survivability/voice_message_gunner_elevation_drive_repaired",
            //    [soundsPath + "\\7 Борьба за выживание\\33 Сломали зенитный пулемет"] = "07_fighting_for_survivability/voice_message_gunner_mg_aa_lost",
            //    [soundsPath + "\\7 Борьба за выживание\\34 Сломали курсовой пулемет"] = "07_fighting_for_survivability/voice_message_gunner_mg_directional_lost",
            //    [soundsPath + "\\7 Борьба за выживание\\35 Пулемет починили"] = "07_fighting_for_survivability/voice_message_gunner_mg_ready",
            //    [soundsPath + "\\7 Борьба за выживание\\36 Механизм поворота башни сломан"] = "07_fighting_for_survivability/voice_message_gunner_rotation_drive_damaged",
            //    [soundsPath + "\\7 Борьба за выживание\\36 Починили"] = "07_fighting_for_survivability/voice_message_gunner_rotation_drive_repaired",
            //    [soundsPath + "\\7 Борьба за выживание\\37 Наводчик берет командование"] = "07_fighting_for_survivability/voice_message_gunner_taking_command",
            //    [soundsPath + "\\7 Борьба за выживание\\38 Заряжающий берет командование"] = "07_fighting_for_survivability/voice_message_loader_taking_command",

            //    [soundsPath + "\\8 Поддержка артиллерии\\1 Координаты цифры"] = "",
            //    [soundsPath + "\\8 Поддержка артиллерии\\2 Принял"] = "08_artillery_support/voice_message_artillery_acknowledged",
            //    [soundsPath + "\\8 Поддержка артиллерии\\3 Координаты буквы"] = "",
            //    [soundsPath + "\\8 Поддержка артиллерии\\4 Привязку закончил огонь"] = "08_artillery_support/voice_message_artillery_bracketed",
            //    [soundsPath + "\\8 Поддержка артиллерии\\5 Артиллерия огонь"] = "08_artillery_support/voice_message_artillery_open_fire",
            //    [soundsPath + "\\8 Поддержка артиллерии\\6 Вас понял"] = "08_artillery_support/voice_message_artillery_understood",
            //    [soundsPath + "\\8 Поддержка артиллерии\\7 Угроза арт удара по нам"] = "08_artillery_support/voice_message_chief_artillery_danger",
            //    [soundsPath + "\\8 Поддержка артиллерии\\8 Арт заградительный огонь командир"] = "08_artillery_support/voice_message_commander_art_barrage",
            //    [soundsPath + "\\8 Поддержка артиллерии\\9 Цифры командир"] = "",
            //    [soundsPath + "\\8 Поддержка артиллерии\\10 Буквы командир"] = "",
            //    [soundsPath + "\\8 Поддержка артиллерии\\11 Координаты командир вызов арт"] = "08_artillery_support/voice_message_commander_art_coordinates",
            //    [soundsPath + "\\8 Поддержка артиллерии\\12 Командир уничтожить"] = "08_artillery_support/voice_message_commander_art_destroy",
            //    [soundsPath + "\\8 Поддержка артиллерии\\13 Арта на себя"] = "08_artillery_support/voice_message_commander_art_on_me",

            //    [soundsPath + "\\9 Поддержка авиации\\1 Авиация на подлете"] = "09_aviation_support/voice_message_aviation_on_the_way",
            //    [soundsPath + "\\9 Поддержка авиации\\2 Командир запрос поддержки"] = "09_aviation_support/voice_message_commander_art_request",

            //    [soundsPath + "\\10 Противовоздушная оборона\\1 Воздух"] = "10_air_defense/voice_message_chief_air_danger",

            //    [soundsPath + "\\11 Конец битвы\\1 Поражение"] = "11_battle_end/voice_message_chief_battle_loose",
            //    [soundsPath + "\\11 Конец битвы\\2 Победа"] = "11_battle_end/voice_message_chief_battle_win",
            //};

            //public Dictionary<string, string[]> pathsFMODmany = new Dictionary<string, string[]>()
            //{
            //    [soundsPath + "\\7 Борьба за выживание\\6 Двигатель встал"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_engine_off",
            //        "07_fighting_for_survivability/voice_message_driver_engine_stalled"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\8 Пожар"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_fire",
            //        "07_fighting_for_survivability/voice_message_gunner_fire",
            //        "07_fighting_for_survivability/voice_message_loader_fire"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\9 Пожар двигателя"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_fire_engine",
            //        "07_fighting_for_survivability/voice_message_gunner_fire_engine",
            //        "07_fighting_for_survivability/voice_message_loader_fire_engine"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\10 Пожар потушен"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_fire_extinguished",
            //        "07_fighting_for_survivability/voice_message_gunner_fire_extinguished",
            //        "07_fighting_for_survivability/voice_message_loader_fire_extinguished"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\11 Пожар в боевом отделении"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_fire_fighting_compartment",
            //        "07_fighting_for_survivability/voice_message_gunner_fire_fighting_compartment",
            //        "07_fighting_for_survivability/voice_message_loader_fire_fighting_compartment"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\12 Боеприпасы горят"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_fire_munition_compartment",
            //        "07_fighting_for_survivability/voice_message_gunner_fire_munition_compartment",
            //        "07_fighting_for_survivability/voice_message_loader_fire_munition_compartment"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\13 Наводчик без сознания"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_gunner_unconscious",
            //        "07_fighting_for_survivability/voice_message_loader_gunner_unconscious"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\13 Наводчик контужен"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_gunner_stunned",
            //        "07_fighting_for_survivability/voice_message_loader_gunner_stunned"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\15 Заряжающий без сознания"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_loader_unconscious",
            //        "07_fighting_for_survivability/voice_message_gunner_loader_unconscious"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\15 Заряжающий контужен"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_loader_stunned",
            //        "07_fighting_for_survivability/voice_message_gunner_loader_stunned"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\24 Попали по танку"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_driver_weve_been_hit",
            //        "07_fighting_for_survivability/voice_message_gunner_weve_been_hit",
            //        "07_fighting_for_survivability/voice_message_loader_weve_been_hit"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\30 Водитель без сознания"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_gunner_driver_unconscious",
            //        "07_fighting_for_survivability/voice_message_loader_driver_unconscious"
            //    },
            //    [soundsPath + "\\7 Борьба за выживание\\30 Водитель контужен"] = new[]
            //    {
            //        "07_fighting_for_survivability/voice_message_gunner_driver_stunned",
            //        "07_fighting_for_survivability/voice_message_loader_gunner_stunned"
            //    }

        };
    }
}
