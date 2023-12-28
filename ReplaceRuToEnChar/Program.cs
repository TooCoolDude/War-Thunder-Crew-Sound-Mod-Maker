namespace ReplaceRuToEnChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();
            ReplaceFilesChars(path);

        }

        public void ReplaceFilesChars(string path)
        {
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var subfiles = Directory.GetDirectories(file);
            }
        }
    }
}