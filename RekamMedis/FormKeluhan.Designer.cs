namespace RekamMedis
{
    partial class FormKeluhan
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.norekam = new MetroFramework.Controls.MetroTextBox();
            this.keluhan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.nodokter = new MetroFramework.Controls.MetroComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nomor Rekam Medik";
            // 
            // norekam
            // 
            // 
            // 
            // 
            this.norekam.CustomButton.Image = null;
            this.norekam.CustomButton.Location = new System.Drawing.Point(195, 1);
            this.norekam.CustomButton.Name = "";
            this.norekam.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.norekam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.norekam.CustomButton.TabIndex = 1;
            this.norekam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.norekam.CustomButton.UseSelectable = true;
            this.norekam.CustomButton.Visible = false;
            this.norekam.Lines = new string[0];
            this.norekam.Location = new System.Drawing.Point(24, 101);
            this.norekam.MaxLength = 32767;
            this.norekam.Name = "norekam";
            this.norekam.PasswordChar = '\0';
            this.norekam.ReadOnly = true;
            this.norekam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.norekam.SelectedText = "";
            this.norekam.SelectionLength = 0;
            this.norekam.SelectionStart = 0;
            this.norekam.ShortcutsEnabled = true;
            this.norekam.Size = new System.Drawing.Size(217, 23);
            this.norekam.TabIndex = 1;
            this.norekam.UseSelectable = true;
            this.norekam.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.norekam.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keluhan
            // 
            // 
            // 
            // 
            this.keluhan.CustomButton.Image = null;
            this.keluhan.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.keluhan.CustomButton.Name = "";
            this.keluhan.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.keluhan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keluhan.CustomButton.TabIndex = 1;
            this.keluhan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keluhan.CustomButton.UseSelectable = true;
            this.keluhan.CustomButton.Visible = false;
            this.keluhan.Lines = new string[0];
            this.keluhan.Location = new System.Drawing.Point(24, 163);
            this.keluhan.MaxLength = 32767;
            this.keluhan.Multiline = true;
            this.keluhan.Name = "keluhan";
            this.keluhan.PasswordChar = '\0';
            this.keluhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keluhan.SelectedText = "";
            this.keluhan.SelectionLength = 0;
            this.keluhan.SelectionStart = 0;
            this.keluhan.ShortcutsEnabled = true;
            this.keluhan.Size = new System.Drawing.Size(217, 81);
            this.keluhan.TabIndex = 3;
            this.keluhan.UseSelectable = true;
            this.keluhan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keluhan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Masukkan Keluhan";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(260, 78);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Pilih Dokter";
            // 
            // nodokter
            // 
            this.nodokter.FormattingEnabled = true;
            this.nodokter.ItemHeight = 23;
            this.nodokter.Location = new System.Drawing.Point(260, 101);
            this.nodokter.Name = "nodokter";
            this.nodokter.Size = new System.Drawing.Size(217, 29);
            this.nodokter.TabIndex = 5;
            this.nodokter.UseSelectable = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::RekamMedis.Properties.Resources.process_stop_41;
            this.button5.Location = new System.Drawing.Point(364, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 40);
            this.button5.TabIndex = 62;
            this.button5.Text = "Cancel";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.btnsimpan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnsimpan.FlatAppearance.BorderSize = 0;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Image = global::RekamMedis.Properties.Resources.arrow_right_double_3;
            this.btnsimpan.Location = new System.Drawing.Point(243, 274);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(115, 40);
            this.btnsimpan.TabIndex = 63;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.Location = new System.Drawing.Point(407, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(83, 19);
            this.metroLabel5.TabIndex = 66;
            this.metroLabel5.Text = "metroLabel5";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.Visible = false;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(260, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 67;
            this.metroLabel4.Text = "Tanggal Berobat";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(260, 164);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(217, 29);
            this.metroDateTime1.TabIndex = 68;
            // 
            // FormKeluhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 338);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.nodokter);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.keluhan);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.norekam);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKeluhan";
            this.Text = "Form Keluhan";
            this.Load += new System.EventHandler(this.FormKeluhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button btnsimpan;
        public MetroFramework.Controls.MetroTextBox norekam;
        public MetroFramework.Controls.MetroTextBox keluhan;
        public MetroFramework.Controls.MetroComboBox nodokter;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}