using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CSGO_Dedicated_Server.Properties;

namespace CSGO_Dedicated_Server
{
    public partial class Form1 : Form
    {
        private string _path;

        public Form1()
        {
            _path = (string) Settings.Default["Last_Used_Path"];
            InitializeComponent();
            UpdateStartButton();
            UpdatePathLabel();
        }

        private void button_chooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable file (*.exe)|*.exe";
            openFileDialog1.RestoreDirectory = true;
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            _path = openFileDialog1.FileName;
            Settings.Default["Last_Used_Path"] = _path;
            Settings.Default.Save();
            UpdatePathLabel();
            UpdateStartButton();
        }

        private void UpdatePathLabel()
        {
            label_path.Text = Resources.Form1_button_chooseFile_Click_Dedicated_server_path__ + _path;
        }

        private void UpdateStartButton()
        {
            if (_path.EndsWith(".exe") && comboBox_gamemode.SelectedIndex > -1)
            {
                button_start.BackColor = Color.Green;
            }
            else
            {
                button_start.BackColor = Color.Black;
            }
        }

        private void comboBox_gamemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStartButton();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                var startInfo = new ProcessStartInfo {FileName = _path};
                switch (comboBox_gamemode.SelectedIndex)
                {
                    case 0:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 0 +game_mode 0 +mapgroup mg_active +map de_dust2";
                        break;
                    case 1:
                        startInfo.Arguments =
                            "-game csgo -console -usercon -tickrate 128 +game_type 0 +game_mode 1 +mapgroup mg_active +map de_dust2";
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
                            "-game csgo -console -usercon -tickrate 128 +game_type 1 +game_mode 2 +mapgroup mg_allclassic +map de_dust";
                        break;
                }
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