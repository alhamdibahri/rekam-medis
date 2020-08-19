namespace RekamMedis
{
    partial class FormPasien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.telepon = new MetroFramework.Controls.MetroTextBox();
            this.lbljam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.alamat = new MetroFramework.Controls.MetroTextBox();
            this.tgl_daftar = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.umur = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tgl_lahir = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.namapasien = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.kodepasien = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.status = new System.Windows.Forms.TextBox();
            this.lblrecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(824, 264);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "kodepasien";
            this.Column1.HeaderText = "Kode Pasien";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "namapasien";
            this.Column2.HeaderText = "Nama Pasien";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tgl_lahir";
            this.Column3.HeaderText = "Tanggal Lahir";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "jk";
            this.Column4.HeaderText = "Jeni Kelamin";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "alamat";
            this.Column5.HeaderText = "Alamat";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "umur";
            this.Column6.HeaderText = "Umur";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tgl_daftar";
            this.Column7.HeaderText = "Tanggal Daftar";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "jam_daftar";
            this.Column8.HeaderText = "Jam Daftar";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "teleponpasien";
            this.Column9.HeaderText = "Telepon";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "status";
            this.Column10.HeaderText = "Status";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.ForeColor = System.Drawing.Color.Black;
            this.metroLabel9.Location = new System.Drawing.Point(554, 514);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(33, 19);
            this.metroLabel9.TabIndex = 80;
            this.metroLabel9.Text = "WIB";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.ForeColor = System.Drawing.Color.Black;
            this.metroLabel10.Location = new System.Drawing.Point(407, 547);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 79;
            this.metroLabel10.Text = "Telepon";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // telepon
            // 
            // 
            // 
            // 
            this.telepon.CustomButton.Image = null;
            this.telepon.CustomButton.Location = new System.Drawing.Point(232, 1);
            this.telepon.CustomButton.Name = "";
            this.telepon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.telepon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.telepon.CustomButton.TabIndex = 1;
            this.telepon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.telepon.CustomButton.UseSelectable = true;
            this.telepon.CustomButton.Visible = false;
            this.telepon.Lines = new string[0];
            this.telepon.Location = new System.Drawing.Point(517, 546);
            this.telepon.MaxLength = 32767;
            this.telepon.Name = "telepon";
            this.telepon.PasswordChar = '\0';
            this.telepon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.telepon.SelectedText = "";
            this.telepon.SelectionLength = 0;
            this.telepon.SelectionStart = 0;
            this.telepon.ShortcutsEnabled = true;
            this.telepon.Size = new System.Drawing.Size(254, 23);
            this.telepon.TabIndex = 78;
            this.telepon.UseSelectable = true;
            this.telepon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.telepon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbljam
            // 
            this.lbljam.AutoSize = true;
            this.lbljam.BackColor = System.Drawing.Color.Transparent;
            this.lbljam.ForeColor = System.Drawing.Color.Black;
            this.lbljam.Location = new System.Drawing.Point(517, 514);
            this.lbljam.Name = "lbljam";
            this.lbljam.Size = new System.Drawing.Size(15, 19);
            this.lbljam.TabIndex = 77;
            this.lbljam.Text = "-";
            this.lbljam.UseCustomBackColor = true;
            this.lbljam.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.ForeColor = System.Drawing.Color.Black;
            this.metroLabel8.Location = new System.Drawing.Point(407, 514);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(73, 19);
            this.metroLabel8.TabIndex = 76;
            this.metroLabel8.Text = "Jam Daftar";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.ForeColor = System.Drawing.Color.Black;
            this.metroLabel7.Location = new System.Drawing.Point(407, 397);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 75;
            this.metroLabel7.Text = "Alamat";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // alamat
            // 
            // 
            // 
            // 
            this.alamat.CustomButton.Image = null;
            this.alamat.CustomButton.Location = new System.Drawing.Point(194, 2);
            this.alamat.CustomButton.Name = "";
            this.alamat.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.alamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.alamat.CustomButton.TabIndex = 1;
            this.alamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.alamat.CustomButton.UseSelectable = true;
            this.alamat.CustomButton.Visible = false;
            this.alamat.Lines = new string[0];
            this.alamat.Location = new System.Drawing.Point(517, 397);
            this.alamat.MaxLength = 32767;
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.PasswordChar = '\0';
            this.alamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamat.SelectedText = "";
            this.alamat.SelectionLength = 0;
            this.alamat.SelectionStart = 0;
            this.alamat.ShortcutsEnabled = true;
            this.alamat.Size = new System.Drawing.Size(254, 62);
            this.alamat.TabIndex = 74;
            this.alamat.UseSelectable = true;
            this.alamat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.alamat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tgl_daftar
            // 
            this.tgl_daftar.Location = new System.Drawing.Point(517, 473);
            this.tgl_daftar.Name = "tgl_daftar";
            this.tgl_daftar.Size = new System.Drawing.Size(254, 20);
            this.tgl_daftar.TabIndex = 73;
            this.tgl_daftar.Value = new System.DateTime(2018, 11, 22, 0, 0, 0, 0);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.ForeColor = System.Drawing.Color.Black;
            this.metroLabel6.Location = new System.Drawing.Point(407, 473);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 72;
            this.metroLabel6.Text = "Tanggal Daftar";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // umur
            // 
            this.umur.Location = new System.Drawing.Point(160, 546);
            this.umur.Name = "umur";
            this.umur.Size = new System.Drawing.Size(175, 20);
            this.umur.TabIndex = 71;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(50, 546);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(42, 19);
            this.metroLabel5.TabIndex = 70;
            this.metroLabel5.Text = "Umur";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton2.ForeColor = System.Drawing.Color.Black;
            this.metroRadioButton2.Location = new System.Drawing.Point(251, 514);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(84, 15);
            this.metroRadioButton2.TabIndex = 69;
            this.metroRadioButton2.Text = "Perempuan";
            this.metroRadioButton2.UseCustomBackColor = true;
            this.metroRadioButton2.UseCustomForeColor = true;
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton1.ForeColor = System.Drawing.Color.Black;
            this.metroRadioButton1.Location = new System.Drawing.Point(160, 514);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(76, 15);
            this.metroRadioButton1.TabIndex = 68;
            this.metroRadioButton1.Text = "Laki - Laki";
            this.metroRadioButton1.UseCustomBackColor = true;
            this.metroRadioButton1.UseCustomForeColor = true;
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(50, 510);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 67;
            this.metroLabel4.Text = "Jenis Kelamin";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.Location = new System.Drawing.Point(160, 474);
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.Size = new System.Drawing.Size(177, 20);
            this.tgl_lahir.TabIndex = 66;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(50, 474);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 65;
            this.metroLabel3.Text = "Tanggal Lahir";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(50, 436);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 64;
            this.metroLabel2.Text = "Nama Pasien";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
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
            this.namapasien.Location = new System.Drawing.Point(160, 436);
            this.namapasien.MaxLength = 32767;
            this.namapasien.Name = "namapasien";
            this.namapasien.PasswordChar = '\0';
            this.namapasien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namapasien.SelectedText = "";
            this.namapasien.SelectionLength = 0;
            this.namapasien.SelectionStart = 0;
            this.namapasien.ShortcutsEnabled = true;
            this.namapasien.Size = new System.Drawing.Size(221, 23);
            this.namapasien.TabIndex = 63;
            this.namapasien.UseSelectable = true;
            this.namapasien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namapasien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(50, 397);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Kode Pasien";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // kodepasien
            // 
            // 
            // 
            // 
            this.kodepasien.CustomButton.Image = null;
            this.kodepasien.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.kodepasien.CustomButton.Name = "";
            this.kodepasien.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.kodepasien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.kodepasien.CustomButton.TabIndex = 1;
            this.kodepasien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.kodepasien.CustomButton.UseSelectable = true;
            this.kodepasien.CustomButton.Visible = false;
            this.kodepasien.Lines = new string[0];
            this.kodepasien.Location = new System.Drawing.Point(160, 397);
            this.kodepasien.MaxLength = 32767;
            this.kodepasien.Name = "kodepasien";
            this.kodepasien.PasswordChar = '\0';
            this.kodepasien.ReadOnly = true;
            this.kodepasien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.kodepasien.SelectedText = "";
            this.kodepasien.SelectionLength = 0;
            this.kodepasien.SelectionStart = 0;
            this.kodepasien.ShortcutsEnabled = true;
            this.kodepasien.Size = new System.Drawing.Size(177, 23);
            this.kodepasien.TabIndex = 61;
            this.kodepasien.UseSelectable = true;
            this.kodepasien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.kodepasien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RekamMedis.Properties.Resources.edit_add_2;
            this.button1.Location = new System.Drawing.Point(548, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 85;
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
            this.button5.Location = new System.Drawing.Point(669, 589);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 40);
            this.button5.TabIndex = 84;
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
            this.btnhapus.Location = new System.Drawing.Point(284, 589);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(115, 40);
            this.btnhapus.TabIndex = 83;
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
            this.btnubah.Location = new System.Drawing.Point(163, 589);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(115, 40);
            this.btnubah.TabIndex = 82;
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
            this.btnsimpan.Location = new System.Drawing.Point(42, 589);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(115, 40);
            this.btnsimpan.TabIndex = 81;
            this.btnsimpan.Text = "Insert";
            this.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(622, 514);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(43, 19);
            this.metroLabel11.TabIndex = 86;
            this.metroLabel11.Text = "Status";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(670, 514);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 20);
            this.status.TabIndex = 87;
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Location = new System.Drawing.Point(785, 91);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(10, 13);
            this.lblrecord.TabIndex = 91;
            this.lblrecord.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Jumlah Record : ";
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.DisplayIcon = true;
            this.metroTextBox6.Icon = global::RekamMedis.Properties.Resources.system_search_3;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(582, 63);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(221, 23);
            this.metroTextBox6.TabIndex = 88;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox6.TextChanged += new System.EventHandler(this.metroTextBox6_TextChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(543, 63);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(33, 19);
            this.metroLabel12.TabIndex = 89;
            this.metroLabel12.Text = "Cari";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 641);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroTextBox6);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.status);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.telepon);
            this.Controls.Add(this.lbljam);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.tgl_daftar);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.umur);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tgl_lahir);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.namapasien);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.kodepasien);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPasien";
            this.Text = "Data Pasien";
            this.Load += new System.EventHandler(this.FormPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox telepon;
        private MetroFramework.Controls.MetroLabel lbljam;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox alamat;
        private System.Windows.Forms.DateTimePicker tgl_daftar;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.NumericUpDown umur;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DateTimePicker tgl_lahir;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox namapasien;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox kodepasien;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button btnhapus;
        internal System.Windows.Forms.Button btnubah;
        internal System.Windows.Forms.Button btnsimpan;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.Timer timer1;
    }
}