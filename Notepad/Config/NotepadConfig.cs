using System;
using System.Drawing;
using System.IO;

namespace Notepad.Config
{
    [Serializable]
    public class NotepadConfig
    {
        public Font Font { get; set; }
        public string FileLocation { get; set; }
        public int SaveThreshold { get; set; }
        public bool WordWrap { get; set; }

        public static string ConfigPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "notepad");
        public static string ConfigName => "notepad.config";
        public static string ConfigFullPath => Path.Combine(ConfigPath, ConfigName);
        public static string DefaultFileLocation => Path.Combine(ConfigPath, "default.txt");
        public static NotepadConfig Empty => new NotepadConfig
        {
            Font = new Font(FontFamily.GenericSansSerif, 8f),
            FileLocation = DefaultFileLocation,
            SaveThreshold = 10,
            WordWrap = true
        };
    }
}