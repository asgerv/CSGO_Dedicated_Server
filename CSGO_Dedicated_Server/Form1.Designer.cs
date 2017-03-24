namespace CSGO_Dedicated_Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_path = new System.Windows.Forms.Label();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_gamemode = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_gamemode = new System.Windows.Forms.Label();
            this.label_map = new System.Windows.Forms.Label();
            this.textBox_map = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(12, 9);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(32, 13);
            this.label_path.TabIndex = 0;
            this.label_path.Text = "Path:";
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.Location = new System.Drawing.Point(12, 25);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(101, 23);
            this.button_chooseFile.TabIndex = 2;
            this.button_chooseFile.Text = "Change path...";
            this.button_chooseFile.UseVisualStyleBackColor = true;
            this.button_chooseFile.Click += new System.EventHandler(this.button_chooseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Locate \'srcds.exe\' path";
            // 
            // comboBox_gamemode
            // 
            this.comboBox_gamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gamemode.FormattingEnabled = true;
            this.comboBox_gamemode.Items.AddRange(new object[] {
            "Casual",
            "Competitive",
            "Arms Race",
            "Demolition",
            "Deathmatch"});
            this.comboBox_gamemode.Location = new System.Drawing.Point(102, 75);
            this.comboBox_gamemode.Name = "comboBox_gamemode";
            this.comboBox_gamemode.Size = new System.Drawing.Size(121, 21);
            this.comboBox_gamemode.TabIndex = 3;
            this.comboBox_gamemode.SelectedIndexChanged += new System.EventHandler(this.comboBox_gamemode_SelectedIndexChanged);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(16, 274);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(93, 39);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_gamemode
            // 
            this.label_gamemode.AutoSize = true;
            this.label_gamemode.Location = new System.Drawing.Point(12, 78);
            this.label_gamemode.Name = "label_gamemode";
            this.label_gamemode.Size = new System.Drawing.Size(67, 13);
            this.label_gamemode.TabIndex = 5;
            this.label_gamemode.Text = "Game mode:";
            // 
            // label_map
            // 
            this.label_map.AutoSize = true;
            this.label_map.Location = new System.Drawing.Point(13, 104);
            this.label_map.Name = "label_map";
            this.label_map.Size = new System.Drawing.Size(31, 13);
            this.label_map.TabIndex = 7;
            this.label_map.Text = "Map:";
            // 
            // textBox_map
            // 
            this.textBox_map.Location = new System.Drawing.Point(102, 101);
            this.textBox_map.Name = "textBox_map";
            this.textBox_map.Size = new System.Drawing.Size(188, 20);
            this.textBox_map.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 345);
            this.Controls.Add(this.textBox_map);
            this.Controls.Add(this.label_map);
            this.Controls.Add(this.label_gamemode);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.comboBox_gamemode);
            this.Controls.Add(this.button_chooseFile);
            this.Controls.Add(this.label_path);
            this.Name = "Form1";
            this.Text = "CSGO Dedicated launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Button button_chooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_gamemode;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_gamemode;
        private System.Windows.Forms.Label label_map;
        private System.Windows.Forms.TextBox textBox_map;
    }
}

