using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CSGO_Dedicated_Server.Utilities;

//using CSGO_Dedicated_Server.Properties;

namespace CSGO_Dedicated_Server
{
    public partial class Form1 : Form
    {
        private readonly Settings _settings;

        public Form1()
        {
            // Settings
            _settings = SettingsHelper.LoadFromFile();

            // Initialize
            InitializeComponent();

            // Set
            UpdatePathLabel();
            comboBox_gamemode.SelectedIndex = _settings.GameMode;
            textBox_map.Text = _settings.Map;
        }

        private void button_chooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable file (*.exe)|*.exe";
            openFileDialog1.RestoreDirectory = true;
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            _settings.Path = openFileDialog1.FileName;
            UpdatePathLabel();
            _settings.Save();
        }

        private void UpdatePathLabel()
        {
            label_path.Text = "Path: " + _settings.Path;
        }

        private void comboBox_gamemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.GameMode = comboBox_gamemode.SelectedIndex;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo {FileName = _settings.Path};
                _settings.Map = textBox_map.Text;
                switch (comboBox_gamemode.SelectedIndex)
                {
                    case 0:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 0 +game_mode 0 +mapgroup mg_active +map " + _settings.Map;
                        break;
                    case 1:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 0 +game_mode 1 +mapgroup mg_active +map de_dust2" + _settings.Map;
                        break;
                    case 2:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 1 +game_mode 0 +mapgroup mg_armsrace +map ar_shoots";
                        break;
                    case 3:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 1 +game_mode 1 +mapgroup mg_demolition +map de_lake";
                        break;
                    case 4:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 1 +game_mode 2 +mapgroup mg_active +map" + _settings.Map;
                        break;
                }
                _settings.Save();
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}