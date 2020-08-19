namespace RekamMedis
{
    partial class FormCariPasien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kodepasien = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alamat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.jk = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.umur = new System.Windows.Forms.NumericUpDown();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.namapasien = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umur)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Cari Pasien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kodepasien);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.alamat);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.jk);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.umur);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.namapasien);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(384, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 371);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // kodepasien
            // 
            this.kodepasien.Location = new System.Drawing.Point(150, 44);
            this.kodepasien.Name = "kodepasien";
            this.kodepasien.Size = new System.Drawing.Size(168, 20);
            this.kodepasien.TabIndex = 82;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RekamMedis.Properties.Resources._001_59;
            this.button1.Location = new System.Drawing.Point(255, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 82;
            this.button1.Text = "Proses";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alamat
            // 
            // 
            // 
            // 
            this.alamat.CustomButton.Image = null;
            this.alamat.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.alamat.CustomButton.Name = "";
            this.alamat.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.alamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.alamat.CustomButton.TabIndex = 1;
            this.alamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.alamat.CustomButton.UseSelectable = true;
            this.alamat.CustomButton.Visible = false;
            this.alamat.Lines = new string[0];
            this.alamat.Location = new System.Drawing.Point(150, 200);
            this.alamat.MaxLength = 32767;
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.PasswordChar = '\0';
            this.alamat.ReadOnly = true;
            this.alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamat.SelectedText = "";
            this.alamat.SelectionLength = 0;
            this.alamat.SelectionStart = 0;
            this.alamat.ShortcutsEnabled = true;
            this.alamat.Size = new System.Drawing.Size(221, 93);
            this.alamat.TabIndex = 15;
            this.alamat.UseSelectable = true;
            this.alamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.alamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(38, 200);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Alamat";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // jk
            // 
            // 
            // 
            // 
            this.jk.CustomButton.Image = null;
            this.jk.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.jk.CustomButton.Name = "";
            this.jk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jk.CustomButton.TabIndex = 1;
            this.jk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jk.CustomButton.UseSelectable = true;
            this.jk.CustomButton.Visible = false;
            this.jk.Lines = new string[0];
            this.jk.Location = new System.Drawing.Point(152, 159);
            this.jk.MaxLength = 32767;
            this.jk.Name = "jk";
            this.jk.PasswordChar = '\0';
            this.jk.ReadOnly = true;
            this.jk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jk.SelectedText = "";
            this.jk.SelectionLength = 0;
            this.jk.SelectionStart = 0;
            this.jk.ShortcutsEnabled = true;
            this.jk.Size = new System.Drawing.Size(221, 23);
            this.jk.TabIndex = 13;
            this.jk.UseSelectable = true;
            this.jk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(40, 159);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Jenis Kelamin";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // umur
            // 
            this.umur.Location = new System.Drawing.Point(152, 121);
            this.umur.Name = "umur";
            this.umur.ReadOnly = true;
            this.umur.Size = new System.Drawing.Size(120, 20);
            this.umur.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(40, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Umur";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(40, 83);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Nama Pasien";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // namapasien
            // 
            // 
            // 
            // 
            this.namapasien.CustomButton.Image = null;
            this.namapasien.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.namapasien.CustomButton.Name = "";
            this.namapasien.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namapasien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namapasien.CustomButton.TabIndex = 1;
            this.namapasien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namapasien.CustomButton.UseSelectable = true;
            this.namapasien.CustomButton.Visible = false;
            this.namapasien.Lines = new string[0];
            this.namapasien.Location = new System.Drawing.Point(150, 83);
            this.namapasien.MaxLength = 32767;
            this.namapasien.Name = "namapasien";
            this.namapasien.PasswordChar = '\0';
            this.namapasien.ReadOnly = true;
            this.namapasien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namapasien.SelectedText = "";
            this.namapasien.SelectionLength = 0;
            this.namapasien.SelectionStart = 0;
            this.namapasien.ShortcutsEnabled = true;
            this.namapasien.Size = new System.Drawing.Size(221, 23);
            this.namapasien.TabIndex = 8;
            this.namapasien.UseSelectable = true;
            this.namapasien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namapasien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(40, 44);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Kode Pasien";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(172, -6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Data Pasien";
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.BackgroundImage = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroTextBox5.CustomButton.Image = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.Icon = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(110, 90);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.PromptText = "Masukkan Nama Pasien";
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.ShowButton = true;
            this.metroTextBox5.Size = new System.Drawing.Size(257, 23);
            this.metroTextBox5.TabIndex = 80;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMark = "Masukkan Nama Pasien";
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox5.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox5_ButtonClick);
            this.metroTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox5_KeyPress);
            // 
            // FormCariPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCariPasien";
            this.Text = "Rekam Medik";
            this.Load += new System.EventHandler(this.FormCariPasien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.umur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown umur;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox namapasien;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox alamat;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox jk;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        internal System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox kodepasien;

    }
}