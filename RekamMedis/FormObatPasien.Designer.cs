namespace RekamMedis
{
    partial class FormObatPasien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.norm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dokter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tindakan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.diagnosa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.keluhan = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 46);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(817, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(14, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(162, 25);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Form Obat Pasien";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.norm);
            this.panel2.Controls.Add(this.metroLabel8);
            this.panel2.Controls.Add(this.dokter);
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.tindakan);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.diagnosa);
            this.panel2.Controls.Add(this.metroLabel4);
            this.panel2.Controls.Add(this.keluhan);
            this.panel2.Controls.Add(this.metroLabel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 435);
            this.panel2.TabIndex = 1;
            // 
            // norm
            // 
            // 
            // 
            // 
            this.norm.CustomButton.Image = null;
            this.norm.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.norm.CustomButton.Name = "";
            this.norm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.norm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.norm.CustomButton.TabIndex = 1;
            this.norm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.norm.CustomButton.UseSelectable = true;
            this.norm.CustomButton.Visible = false;
            this.norm.Enabled = false;
            this.norm.Lines = new string[0];
            this.norm.Location = new System.Drawing.Point(14, 46);
            this.norm.MaxLength = 32767;
            this.norm.Name = "norm";
            this.norm.PasswordChar = '\0';
            this.norm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.norm.SelectedText = "";
            this.norm.SelectionLength = 0;
            this.norm.SelectionStart = 0;
            this.norm.ShortcutsEnabled = true;
            this.norm.Size = new System.Drawing.Size(172, 23);
            this.norm.TabIndex = 27;
            this.norm.UseSelectable = true;
            this.norm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.norm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(12, 21);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 26;
            this.metroLabel8.Text = "Nomor RM";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // dokter
            // 
            // 
            // 
            // 
            this.dokter.CustomButton.Image = null;
            this.dokter.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.dokter.CustomButton.Name = "";
            this.dokter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dokter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dokter.CustomButton.TabIndex = 1;
            this.dokter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dokter.CustomButton.UseSelectable = true;
            this.dokter.CustomButton.Visible = false;
            this.dokter.Enabled = false;
            this.dokter.Lines = new string[0];
            this.dokter.Location = new System.Drawing.Point(15, 347);
            this.dokter.MaxLength = 32767;
            this.dokter.Name = "dokter";
            this.dokter.PasswordChar = '\0';
            this.dokter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dokter.SelectedText = "";
            this.dokter.SelectionLength = 0;
            this.dokter.SelectionStart = 0;
            this.dokter.ShortcutsEnabled = true;
            this.dokter.Size = new System.Drawing.Size(172, 23);
            this.dokter.TabIndex = 25;
            this.dokter.UseSelectable = true;
            this.dokter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dokter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(13, 322);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Dokter";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // tindakan
            // 
            // 
            // 
            // 
            this.tindakan.CustomButton.Image = null;
            this.tindakan.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.tindakan.CustomButton.Name = "";
            this.tindakan.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.tindakan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tindakan.CustomButton.TabIndex = 1;
            this.tindakan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tindakan.CustomButton.UseSelectable = true;
            this.tindakan.CustomButton.Visible = false;
            this.tindakan.Enabled = false;
            this.tindakan.Lines = new string[0];
            this.tindakan.Location = new System.Drawing.Point(15, 256);
            this.tindakan.MaxLength = 32767;
            this.tindakan.Multiline = true;
            this.tindakan.Name = "tindakan";
            this.tindakan.PasswordChar = '\0';
            this.tindakan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tindakan.SelectedText = "";
            this.tindakan.SelectionLength = 0;
            this.tindakan.SelectionStart = 0;
            this.tindakan.ShortcutsEnabled = true;
            this.tindakan.Size = new System.Drawing.Size(172, 60);
            this.tindakan.TabIndex = 23;
            this.tindakan.UseSelectable = true;
            this.tindakan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tindakan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(13, 237);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Tindakan";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // diagnosa
            // 
            // 
            // 
            // 
            this.diagnosa.CustomButton.Image = null;
            this.diagnosa.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.diagnosa.CustomButton.Name = "";
            this.diagnosa.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.diagnosa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.diagnosa.CustomButton.TabIndex = 1;
            this.diagnosa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.diagnosa.CustomButton.UseSelectable = true;
            this.diagnosa.CustomButton.Visible = false;
            this.diagnosa.Enabled = false;
            this.diagnosa.Lines = new string[0];
            this.diagnosa.Location = new System.Drawing.Point(15, 178);
            this.diagnosa.MaxLength = 32767;
            this.diagnosa.Multiline = true;
            this.diagnosa.Name = "diagnosa";
            this.diagnosa.PasswordChar = '\0';
            this.diagnosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.diagnosa.SelectedText = "";
            this.diagnosa.SelectionLength = 0;
            this.diagnosa.SelectionStart = 0;
            this.diagnosa.ShortcutsEnabled = true;
            this.diagnosa.Size = new System.Drawing.Size(172, 53);
            this.diagnosa.TabIndex = 21;
            this.diagnosa.UseSelectable = true;
            this.diagnosa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.diagnosa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(13, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Diagnosa";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // keluhan
            // 
            // 
            // 
            // 
            this.keluhan.CustomButton.Image = null;
            this.keluhan.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.keluhan.CustomButton.Name = "";
            this.keluhan.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.keluhan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keluhan.CustomButton.TabIndex = 1;
            this.keluhan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keluhan.CustomButton.UseSelectable = true;
            this.keluhan.CustomButton.Visible = false;
            this.keluhan.Enabled = false;
            this.keluhan.Lines = new string[0];
            this.keluhan.Location = new System.Drawing.Point(15, 95);
            this.keluhan.MaxLength = 32767;
            this.keluhan.Multiline = true;
            this.keluhan.Name = "keluhan";
            this.keluhan.PasswordChar = '\0';
            this.keluhan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keluhan.SelectedText = "";
            this.keluhan.SelectionLength = 0;
            this.keluhan.SelectionStart = 0;
            this.keluhan.ShortcutsEnabled = true;
            this.keluhan.Size = new System.Drawing.Size(172, 54);
            this.keluhan.TabIndex = 19;
            this.keluhan.UseSelectable = true;
            this.keluhan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keluhan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(13, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Keluhan";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(475, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::RekamMedis.Properties.Resources.go_bottom_3;
            this.button1.Location = new System.Drawing.Point(571, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 11;
            this.button1.Text = "add";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(471, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Banyaknya";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(205, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Pilih Obat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(209, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 291);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(209, 95);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(248, 29);
            this.metroComboBox1.TabIndex = 13;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "id_temp";
            this.Column6.HeaderText = "Nomor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nomorRm";
            this.Column1.HeaderText = "Nomor RM";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nama_obat";
            this.Column2.HeaderText = "Nama Obat";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ambil";
            this.Column3.HeaderText = "Ambil";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tgl_ambil";
            this.Column4.HeaderText = "Tanggal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Action";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Hapus";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // FormObatPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObatPasien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obat Pasien";
            this.Load += new System.EventHandler(this.FormObatPasien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        public MetroFramework.Controls.MetroTextBox dokter;
        public MetroFramework.Controls.MetroTextBox tindakan;
        public MetroFramework.Controls.MetroTextBox diagnosa;
        public MetroFramework.Controls.MetroTextBox keluhan;
        public MetroFramework.Controls.MetroTextBox norm;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;

    }
}