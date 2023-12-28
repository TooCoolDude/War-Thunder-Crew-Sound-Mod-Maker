using System.Text;

namespace FMOD_API_crew_mod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Путь к звукам:");
            PathsFMOD.soundsPath = Console.ReadLine();
            Console.WriteLine("Путь к скриптам:");
            string scriptPath = Console.ReadLine();
            string scriptPath1 = scriptPath + "\\scriptCrewTestBanks.txt";
            string scriptPath2 = scriptPath + "\\scriptCrewTest.txt";
            string scriptPath3 = scriptPath + "\\scriptCrewTestMany.txt";
            var pathsFMODvar = new PathsFMOD();
            var dirs = SetSourceDir(PathsFMOD.soundsPath);
            File.WriteAllText(scriptPath1, dirs);
            File.WriteAllText(scriptPath2, 
                MakeScript(PathsFMOD.soundsPath, pathsFMODvar.pathsFMOD));
            File.WriteAllText(scriptPath3,
                MakeScriptMany(PathsFMOD.soundsPath, pathsFMODvar.pathsFMODmany));
            Console.WriteLine("Ok");
            Console.ReadLine();
        }

        static string MakeScript(string soundsPath, Dictionary<string, string> pathsFMOD)
        {
            var scripts = new StringBuilder();
            foreach (var pair in pathsFMOD)
            {
                if (pair.Value is null)
                    continue;
                if (pair.Value == "")
                    continue;
                
                var files = GetNames(pair.Key);
                if (files == null)
                    continue;
                
                scripts.Append(SelectEvent(PathsFMOD.eventsPathHigh + pair.Value));
                foreach (var file in files)
                {
                    var dir = Directory.GetParent(file).ToString() + "\\";
                    if (dir is null)
                        continue;
                    var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""), 
                        file.Replace("\\", "/")));
                }
                scripts.Append(SelectEvent(PathsFMOD.eventsPathMed + pair.Value));
                foreach (var file in files)
                {
                    var dir = Directory.GetParent(file).ToString() + "\\";
                    if (dir is null)
                        continue;
                    var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""), 
                        file.Replace("\\", "/")));
                }
                scripts.Append(SelectEvent(PathsFMOD.eventsPathLow + pair.Value));
                foreach (var file in files)
                {
                    var dir = Directory.GetParent(file).ToString() + "\\";
                    if (dir is null)
                        continue;
                    var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""), 
                        file.Replace("\\", "/")));
                }
            }
            return scripts.ToString();
        }

        static string MakeScriptMany(string soundsPath, Dictionary<string, string[]> pathsFMODmany)
        {
            var scripts = new StringBuilder();
            foreach (var pair in pathsFMODmany)
            {
                if (pair.Value is null)
                    continue;
                if (pair.Value.Length == 0)
                    continue;

                var files = GetNames(pair.Key);
                if (files == null)
                    continue;

                foreach (var eventPath in pair.Value)
                {
                    scripts.Append(SelectEvent(PathsFMOD.eventsPathHigh + eventPath));
                    foreach (var file in files)
                    {
                        var dir = Directory.GetParent(file).ToString() + "\\";
                        if (dir is null)
                            continue;
                        var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""),
                            file.Replace("\\", "/")));
                    }
                    scripts.Append(SelectEvent(PathsFMOD.eventsPathMed + eventPath));
                    foreach (var file in files)
                    {
                        var dir = Directory.GetParent(file).ToString() + "\\";
                        if (dir is null)
                            continue;
                        var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""),
                            file.Replace("\\", "/")));
                    }
                    scripts.Append(SelectEvent(PathsFMOD.eventsPathLow + eventPath));
                    foreach (var file in files)
                    {
                        var dir = Directory.GetParent(file).ToString() + "\\";
                        if (dir is null)
                            continue;
                        var s = scripts.Append(AddSound(file.Replace(dir, "").Replace(".wav", ""),
                            file.Replace("\\", "/")));
                    }
                }
            }
            return scripts.ToString();
        }

        static IEnumerable<string> GetNames(string path)
        {
            if (!Directory.Exists(path))
                return null;
            return Directory.GetFiles(path).Select(x => x/*.Replace($"{PathsFMOD.soundsPath}\\", "")*/);
        }

        static string SelectEvent(string eventPath)
        {
            return $"\r\n\nvar event = studio.project.workspace.masterEventFolder.getItem(\"{eventPath}\");" +
                $"var track = event.groupTracks[0];" +
                $"studio.project.deleteObject(track.modules[0]);" +
                $"var multiInstrument = track.addSound(event.timeline, 'MultiSound', 0, 0.4);" +
                $"multiInstrument.isAsync = true;";
        }

        static string AddSound(string name, string path)
        {
            return $"var singleInstrument1 = studio.project.create('SingleSound');" +
                $"singleInstrument1.owner = track.modules[0];" +
                $"singleInstrument1.name = \"{name}\";" +
                $"var asset = studio.project.importAudioFile(\"{path}\");" +
                $"singleInstrument1.audioFile = asset; ";
        }

        static string SetSourceDir(string soundsPath)
        {
            var scriptBanks = new StringBuilder();
            string[] banks = 
                {
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_cz",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_de",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_en",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_en_au",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_en_us",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_en_za",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_fi",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_fr",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_hu",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_it",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_jp",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_ko",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_pl",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_pt",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_ru",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_sp",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_sr",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_sv",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_tr",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_vi",
                    "dialogs_crew/dialogs_wt_tanks_new/_crew_dialogs_ground_new_zh"
                };

            foreach (string bank in banks)
            {

                scriptBanks.Append($"\r\nvar bank = studio.project.workspace.masterBankFolder.getItem(\"{bank}\");" +
                    $"\r\nbank.audioTable.sourceDirectory = \"{soundsPath.Replace("\\", "\\\\")}\";");
            }
            return scriptBanks.ToString();
        }
    }
}