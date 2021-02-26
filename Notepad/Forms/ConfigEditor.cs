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
using Notepad.Config;

namespace Notepad.Forms
{
    public partial class ConfigEditor : Form
    {
        public NotepadConfig Config { get; }
        private string AutoSaveText => $"Auto save after {Config.SaveThreshold} seconds";
        public ConfigEditor(NotepadConfig config)
        {
            InitializeComponent();
            Config = config;

            _txtFont.Text = Config.Font.Name;
            _txtFile.Text = Config.FileLocation;
            _lblAutoSave.Text = AutoSaveText;
            _nrthreshold.Value = Config.SaveThreshold;
            _cbWordWrap.Checked = Config.WordWrap;
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            Config.FileLocation = _txtFile.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnChangeFont_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog
            {
                Font = Config.Font
            };

            var dialogResult = dialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            Config.Font = dialog.Font;
            _txtFont.Text = Config.Font.Name;
            
            dialog.Dispose();
        }

        private void _btnFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = Path.GetDirectoryName(Config.FileLocation);
                dialog.FileName = Path.GetFileName(Config.FileLocation);
                var result = dialog.ShowDialog();

                if (result != DialogResult.OK)
                    return;

                Config.FileLocation = dialog.FileName;
                _txtFile.Text = Config.FileLocation;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Config.SaveThreshold = _nrthreshold.Value;
            _lblAutoSave.Text = AutoSaveText;
        }

        private void _cbWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            Config.WordWrap = ((CheckBox) sender).Checked;
        }
    }
}
