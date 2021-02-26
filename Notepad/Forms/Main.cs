using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FHubo.Utility;
using Notepad.Config;
using Notepad.Forms;
using System.Windows.Input;
using Notepad.Extensions;
using Timer = FHubo.Utility.Timer;

namespace Notepad
{
    public partial class Main : Form
    {
        private Timer _saveTextTimer;
        private NotepadConfig _config;
        private DateTime _textChangedTime;
        private string _lastSavedText;
        public Main()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            CheckForIllegalCrossThreadCalls = false;
            _textChangedTime = DateTime.Now;
            _textBoxMain.TextChanged += _textBoxMain_TextChanged;
            Directory.CreateDirectory(NotepadConfig.ConfigPath);

            var serializer = new Serializer(NotepadConfig.ConfigPath);
            if (File.Exists(NotepadConfig.ConfigFullPath))
            {
                _config = serializer.RestoreObject<NotepadConfig>(NotepadConfig.ConfigName);
            }
            else
            {
                _config = NotepadConfig.Empty;
                serializer.StoreObject(_config, NotepadConfig.ConfigName);
            }

            _textBoxMain.WordWrap = _config.WordWrap;
            _textBoxMain.Font = _config.Font;

            if (File.Exists(_config.FileLocation))
            {
                LoadTextFromFile();
                _lastSavedText = _textBoxMain.Text;
            }
            else
            {
                _lastSavedText = "";
            }

            _saveTextTimer = new Timer(_config.SaveThreshold);
            _saveTextTimer.Tick += SaveTextTimerTick;
            _saveTextTimer.Start();
        }

        private void SaveTextTimerTick(object sender, int tickCount)
        {
            var diff = DateTime.Now - _textChangedTime;
            if (diff.Seconds > _config.SaveThreshold)
            {
                SaveTextToFile();
            }
        }

        private void SaveTextToFile()
        {
            if (_lastSavedText == _textBoxMain.Text)
                return;

            File.WriteAllText(_config.FileLocation, _textBoxMain.Text);
            _lastSavedText = _textBoxMain.Text;
        }

        private void LoadTextFromFile()
        {
            _textBoxMain.Text = File.ReadAllText(_config.FileLocation);
            _textBoxMain.Select(_textBoxMain.TextLength, 0);
            _textBoxMain.ScrollToCaret();
        }

        private void _textBoxMain_TextChanged(object sender, EventArgs e)
        {
            _textChangedTime = DateTime.Now;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _saveTextTimer.Stop();
            SaveTextToFile();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var configForm = new ConfigEditor(_config))
            {
                var dialogResult = configForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                    return;

                _config = configForm.Config;
                _textBoxMain.WordWrap = _config.WordWrap;
                _textBoxMain.Font = _config.Font;

                var serializer = new Serializer(NotepadConfig.ConfigPath);
                serializer.StoreObject(_config, NotepadConfig.ConfigName);
            }
        }
    }
}
