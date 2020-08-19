namespace RekamMedis
{
    partial class FormJadwalDokter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kodeDokter = new MetroFramework.Controls.MetroComboBox();
            this.waktu = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.namaDokter = new MetroFramework.Controls.MetroTextBox();
            this.spesialis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.kodeJadwal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblrecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 353);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "Pilih Dokter";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(397, 399);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 49;
            this.metroLabel2.Text = "Jadwal";
            // 
            // kodeDokter
            // 
            this.kodeDokter.FormattingEnabled = true;
            this.kodeDokter.ItemHeight = 23;
            this.kodeDokter.Location = new System.Drawing.Point(141, 353);
            this.kodeDokter.Name = "kodeDokter";
            this.kodeDokter.Size = new System.Drawing.Size(204, 29);
            this.kodeDokter.TabIndex = 50;
            this.kodeDokter.UseSelectable = true;
            this.kodeDokter.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // waktu
            // 
            // 
            // 
            // 
            this.waktu.CustomButton.Image = null;
            this.waktu.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.waktu.CustomButton.Name = "";
            this.waktu.CustomButton.Size = new System.Drawing.Size(65, 65);
            this.waktu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.waktu.CustomButton.TabIndex = 1;
            this.waktu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.waktu.CustomButton.UseSelectable = true;
            this.waktu.CustomButton.Visible = false;
            this.waktu.Lines = new string[0];
            this.waktu.Location = new System.Drawing.Point(491, 399);
            this.waktu.MaxLength = 32767;
            this.waktu.Multiline = true;
            this.waktu.Name = "waktu";
            this.waktu.PasswordChar = '\0';
            this.waktu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.waktu.SelectedText = "";
            this.waktu.SelectionLength = 0;
            this.waktu.SelectionStart = 0;
            this.waktu.ShortcutsEnabled = true;
            this.waktu.Size = new System.Drawing.Size(204, 70);
            this.waktu.TabIndex = 51;
            this.waktu.UseSelectable = true;
            this.waktu.WaterMark = "jadwal dokter ..";
            this.waktu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.waktu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(293, 47);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(109, 19);
            this.metroLabel6.TabIndex = 58;
            this.metroLabel6.Text = "Cari berdasarkan";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 399);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 59;
            this.metroLabel3.Text = "Nama Dokter";
            // 
            // namaDokter
            // 
            // 
            // 
            // 
            this.namaDokter.CustomButton.Image = null;
            this.namaDokter.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.namaDokter.CustomButton.Name = "";
            this.namaDokter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namaDokter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namaDokter.CustomButton.TabIndex = 1;
            this.namaDokter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namaDokter.CustomButton.UseSelectable = true;
            this.namaDokter.CustomButton.Visible = false;
            this.namaDokter.Lines = new string[0];
            this.namaDokter.Location = new System.Drawing.Point(141, 399);
            this.namaDokter.MaxLength = 32767;
            this.namaDokter.Name = "namaDokter";
            this.namaDokter.PasswordChar = '\0';
            this.namaDokter.ReadOnly = true;
            this.namaDokter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namaDokter.SelectedText = "";
            this.namaDokter.SelectionLength = 0;
            this.namaDokter.SelectionStart = 0;
            this.namaDokter.ShortcutsEnabled = true;
            this.namaDokter.Size = new System.Drawing.Size(204, 23);
            this.namaDokter.TabIndex = 60;
            this.namaDokter.UseSelectable = true;
            this.namaDokter.WaterMark = "nama dokter..";
            this.namaDokter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namaDokter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // spesialis
            // 
            // 
            // 
            // 
            this.spesialis.CustomButton.Image = null;
            this.spesialis.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.spesialis.CustomButton.Name = "";
            this.spesialis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.spesialis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.spesialis.CustomButton.TabIndex = 1;
            this.spesialis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.spesialis.CustomButton.UseSelectable = true;
            this.spesialis.CustomButton.Visible = false;
            this.spesialis.Lines = new string[0];
            this.spesialis.Location = new System.Drawing.Point(141, 446);
            this.spesialis.MaxLength = 32767;
            this.spesialis.Name = "spesialis";
            this.spesialis.PasswordChar = '\0';
            this.spesialis.ReadOnly = true;
            this.spesialis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.spesialis.SelectedText = "";
            this.spesialis.SelectionLength = 0;
            this.spesialis.SelectionStart = 0;
            this.spesialis.ShortcutsEnabled = true;
            this.spesialis.Size = new System.Drawing.Size(204, 23);
            this.spesialis.TabIndex = 62;
            this.spesialis.UseSelectable = true;
            this.spesialis.WaterMark = "spesialis...";
            this.spesialis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.spesialis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(47, 446);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 61;
            this.metroLabel4.Text = "Spesialis";
            // 
            // kodeJadwal
            // 
            // 
            // 
            // 
            this.kodeJadwal.CustomButton.Image = null;
            this.kodeJadwal.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.kodeJadwal.CustomButton.Name = "";
            this.kodeJadwal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodeJadwal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodeJadwal.CustomButton.TabIndex = 1;
            this.kodeJadwal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodeJadwal.CustomButton.UseSelectable = true;
            this.kodeJadwal.CustomButton.Visible = false;
            this.kodeJadwal.Lines = new string[0];
            this.kodeJadwal.Location = new System.Drawing.Point(491, 353);
            this.kodeJadwal.MaxLength = 32767;
            this.kodeJadwal.Name = "kodeJadwal";
            this.kodeJadwal.PasswordChar = '\0';
            this.kodeJadwal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodeJadwal.SelectedText = "";
            this.kodeJadwal.SelectionLength = 0;
            this.kodeJadwal.SelectionStart = 0;
            this.kodeJadwal.ShortcutsEnabled = true;
            this.kodeJadwal.Size = new System.Drawing.Size(192, 23);
            this.kodeJadwal.TabIndex = 71;
            this.kodeJadwal.UseSelectable = true;
            this.kodeJadwal.WaterMark = "kode jadwal...";
            this.kodeJadwal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodeJadwal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(397, 353);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.TabIndex = 70;
            this.metroLabel5.Text = "Kode Jadwal";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "waktu";
            this.Column4.HeaderText = "Waktu / Tanggal";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "spesialis";
            this.Column5.HeaderText = "Spesialis";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "namaDokter";
            this.Column3.HeaderText = "Nama Dokter";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "kodeDokter";
            this.Column2.HeaderText = "Kode Dokter";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodeJadwal";
            this.Column1.HeaderText = "Kode Jadwal";
            this.Column1.Name = "Column1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(2, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(742, 238);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kode Jadwal",
            "Nama Dokter",
            "Waktu"});
            this.comboBox1.Location = new System.Drawing.Point(410, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 76;
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Location = new System.Drawing.Point(650, 73);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(10, 13);
            this.lblrecord.TabIndex = 78;
            this.lblrecord.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Jumlah Record : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RekamMedis.Properties.Resources.edit_add_2;
            this.button1.Location = new System.Drawing.Point(483, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 67;
            this.button1.Text = "Tambah";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::RekamMedis.Properties.Resources.process_stop_41;
            this.button5.Location = new System.Drawing.Point(604, 503);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 40);
            this.button5.TabIndex = 66;
            this.button5.Text = "Cancel";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Maroon;
            this.btnhapus.FlatAppearance.BorderSize = 0;
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnhapus.ForeColor = System.Drawing.Color.White;
            this.btnhapus.Image = global::RekamMedis.Properties.Resources.trash_empty_2;
            this.btnhapus.Location = new System.Drawing.Point(262, 503);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(115, 40);
            this.btnhapus.TabIndex = 65;
            this.btnhapus.Text = "Delete";
            this.btnhapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.btnubah.FlatAppearance.BorderSize = 0;
            this.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnubah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnubah.ForeColor = System.Drawing.Color.White;
            this.btnubah.Image = global::RekamMedis.Properties.Resources.document_edit1;
            this.btnubah.Location = new System.Drawing.Point(141, 503);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(115, 40);
            this.btnubah.TabIndex = 64;
            this.btnubah.Text = "Update";
            this.btnubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.btnsimpan.FlatAppearance.BorderSize = 0;
            this.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsimpan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Image = global::RekamMedis.Properties.Resources.arrow_right_double_3;
            this.btnsimpan.Location = new System.Drawing.Point(20, 503);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(115, 40);
            this.btnsimpan.TabIndex = 63;
            this.btnsimpan.Text = "Insert";
            this.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.BackgroundImage = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroTextBox5.CustomButton.Image = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.Icon = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(538, 45);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.ShowButton = true;
            this.metroTextBox5.Size = new System.Drawing.Size(181, 23);
            this.metroTextBox5.TabIndex = 79;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMark = "cari data ...";
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox5.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox5_ButtonClick);
            // 
            // FormJadwalDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 576);
            this.Controls.Add(this.metroTextBox5);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kodeJadwal);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.spesialis);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.namaDokter);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.waktu);
            this.Controls.Add(this.kodeDokter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJadwalDokter";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Jadwal Dokter";
            this.Load += new System.EventHandler(this.FormJadwalDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox kodeDokter;
        private MetroFramework.Controls.MetroTextBox waktu;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox namaDokter;
        private MetroFramework.Controls.MetroTextBox spesialis;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button btnhapus;
        internal System.Windows.Forms.Button btnubah;
        internal System.Windows.Forms.Button btnsimpan;
        private MetroFramework.Controls.MetroTextBox kodeJadwal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;

    }
}