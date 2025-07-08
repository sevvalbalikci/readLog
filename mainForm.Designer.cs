namespace readLog
{
    partial class mainForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblBaslık = new Label();
            lblAd = new Label();
            lblYazar = new Label();
            lblTur = new Label();
            lblSayfaSayisi = new Label();
            lblOkunduMu = new Label();
            lblFavoriMi = new Label();
            txtAd = new TextBox();
            txtYazar = new TextBox();
            txtTur = new TextBox();
            dgvKitaplar = new DataGridView();
            btnKitapEkle = new Button();
            chkFavoriMi = new CheckBox();
            nudSayfaSayisi = new NumericUpDown();
            chkOkunduMu = new CheckBox();
            btnSil = new Button();
            btnDuzenle = new Button();
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            lblBaslangic = new Label();
            lblBitisTarihi = new Label();
            btnGuncelle = new Button();
            btnYorumEkle = new Button();
            btnYorumlariGor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).BeginInit();
            SuspendLayout();
            // 
            // lblBaslık
            // 
            lblBaslık.AutoSize = true;
            lblBaslık.Font = new Font("Goudy Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslık.Location = new Point(388, 28);
            lblBaslık.Name = "lblBaslık";
            lblBaslık.Size = new Size(443, 74);
            lblBaslık.TabIndex = 0;
            lblBaslık.Text = "KÜTÜPHANE";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAd.Location = new Point(70, 136);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(123, 28);
            lblAd.TabIndex = 1;
            lblAd.Text = "Kitap Adı :";
            lblAd.Click += lblAd_Click;
            // 
            // lblYazar
            // 
            lblYazar.AutoSize = true;
            lblYazar.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYazar.Location = new Point(47, 184);
            lblYazar.Name = "lblYazar";
            lblYazar.Size = new Size(146, 28);
            lblYazar.TabIndex = 2;
            lblYazar.Text = "Kitap Yazarı :";
            lblYazar.Click += lblYazar_Click;
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTur.Location = new Point(57, 235);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(136, 28);
            lblTur.TabIndex = 3;
            lblTur.Text = "Kitap Türü :";
            // 
            // lblSayfaSayisi
            // 
            lblSayfaSayisi.AutoSize = true;
            lblSayfaSayisi.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSayfaSayisi.Location = new Point(60, 286);
            lblSayfaSayisi.Name = "lblSayfaSayisi";
            lblSayfaSayisi.Size = new Size(133, 28);
            lblSayfaSayisi.TabIndex = 4;
            lblSayfaSayisi.Text = "Sayfa Sayısı :";
            lblSayfaSayisi.Click += label5_Click;
            // 
            // lblOkunduMu
            // 
            lblOkunduMu.AutoSize = true;
            lblOkunduMu.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOkunduMu.Location = new Point(105, 345);
            lblOkunduMu.Name = "lblOkunduMu";
            lblOkunduMu.Size = new Size(122, 25);
            lblOkunduMu.TabIndex = 5;
            lblOkunduMu.Text = "Okudun Mu";
            // 
            // lblFavoriMi
            // 
            lblFavoriMi.AutoSize = true;
            lblFavoriMi.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFavoriMi.Location = new Point(258, 345);
            lblFavoriMi.Name = "lblFavoriMi";
            lblFavoriMi.Size = new Size(96, 25);
            lblFavoriMi.TabIndex = 6;
            lblFavoriMi.Text = "Favori Mi";
            lblFavoriMi.Click += lblFavoriMi_Click;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.Info;
            txtAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(209, 137);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(155, 33);
            txtAd.TabIndex = 7;
            // 
            // txtYazar
            // 
            txtYazar.BackColor = SystemColors.Info;
            txtYazar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYazar.Location = new Point(209, 184);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(155, 33);
            txtYazar.TabIndex = 8;
            // 
            // txtTur
            // 
            txtTur.BackColor = SystemColors.Info;
            txtTur.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTur.Location = new Point(209, 235);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(155, 33);
            txtTur.TabIndex = 9;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvKitaplar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvKitaplar.BackgroundColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvKitaplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle8.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.Info;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvKitaplar.DefaultCellStyle = dataGridViewCellStyle8;
            dgvKitaplar.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvKitaplar.GridColor = SystemColors.Window;
            dgvKitaplar.Location = new Point(388, 136);
            dgvKitaplar.Name = "dgvKitaplar";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvKitaplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle10.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.Info;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(64, 0, 0);
            dgvKitaplar.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvKitaplar.Size = new Size(755, 375);
            dgvKitaplar.TabIndex = 13;
            dgvKitaplar.CellContentClick += dgvKitaplar_CellContentClick;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.FromArgb(64, 0, 0);
            btnKitapEkle.FlatStyle = FlatStyle.Flat;
            btnKitapEkle.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKitapEkle.Location = new Point(105, 491);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(187, 52);
            btnKitapEkle.TabIndex = 14;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            // 
            // chkFavoriMi
            // 
            chkFavoriMi.AutoSize = true;
            chkFavoriMi.BackColor = Color.Maroon;
            chkFavoriMi.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkFavoriMi.ForeColor = SystemColors.Info;
            chkFavoriMi.Location = new Point(237, 349);
            chkFavoriMi.Name = "chkFavoriMi";
            chkFavoriMi.Size = new Size(15, 14);
            chkFavoriMi.TabIndex = 16;
            chkFavoriMi.UseVisualStyleBackColor = false;
            // 
            // nudSayfaSayisi
            // 
            nudSayfaSayisi.BackColor = SystemColors.Info;
            nudSayfaSayisi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nudSayfaSayisi.Location = new Point(209, 286);
            nudSayfaSayisi.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSayfaSayisi.Name = "nudSayfaSayisi";
            nudSayfaSayisi.Size = new Size(155, 33);
            nudSayfaSayisi.TabIndex = 17;
            // 
            // chkOkunduMu
            // 
            chkOkunduMu.AutoSize = true;
            chkOkunduMu.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkOkunduMu.ForeColor = Color.LemonChiffon;
            chkOkunduMu.Location = new Point(84, 349);
            chkOkunduMu.Name = "chkOkunduMu";
            chkOkunduMu.Size = new Size(15, 14);
            chkOkunduMu.TabIndex = 18;
            chkOkunduMu.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.AccessibleName = "btnSil";
            btnSil.BackColor = Color.FromArgb(64, 0, 0);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.ForeColor = SystemColors.Info;
            btnSil.Location = new Point(664, 529);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 47);
            btnSil.TabIndex = 19;
            btnSil.Text = "Kitap Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.BackColor = Color.FromArgb(64, 0, 0);
            btnDuzenle.FlatStyle = FlatStyle.Flat;
            btnDuzenle.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDuzenle.Location = new Point(388, 529);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(132, 47);
            btnDuzenle.TabIndex = 20;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = false;
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.CalendarFont = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBaslangicTarihi.CalendarForeColor = SystemColors.Info;
            dtpBaslangicTarihi.CalendarMonthBackground = SystemColors.Info;
            dtpBaslangicTarihi.CalendarTitleBackColor = SystemColors.Info;
            dtpBaslangicTarihi.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBaslangicTarihi.Format = DateTimePickerFormat.Short;
            dtpBaslangicTarihi.Location = new Point(220, 392);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(129, 27);
            dtpBaslangicTarihi.TabIndex = 22;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.CalendarFont = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBitisTarihi.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpBitisTarihi.Format = DateTimePickerFormat.Short;
            dtpBitisTarihi.Location = new Point(220, 433);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(129, 27);
            dtpBitisTarihi.TabIndex = 23;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslangic.Location = new Point(41, 391);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(173, 28);
            lblBaslangic.TabIndex = 24;
            lblBaslangic.Text = "Başlama Tarihi :";
            lblBaslangic.Click += label1_Click;
            // 
            // lblBitisTarihi
            // 
            lblBitisTarihi.AutoSize = true;
            lblBitisTarihi.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBitisTarihi.Location = new Point(46, 432);
            lblBitisTarihi.Name = "lblBitisTarihi";
            lblBitisTarihi.Size = new Size(168, 28);
            lblBitisTarihi.TabIndex = 25;
            lblBitisTarihi.Text = "Bitirme Tarihi :";
            lblBitisTarihi.Click += lblBitisTarihi_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(64, 0, 0);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Goudy Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuncelle.Location = new Point(526, 529);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(132, 47);
            btnGuncelle.TabIndex = 26;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnYorumEkle
            // 
            btnYorumEkle.BackColor = Color.FromArgb(64, 0, 0);
            btnYorumEkle.FlatStyle = FlatStyle.Flat;
            btnYorumEkle.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYorumEkle.Location = new Point(802, 529);
            btnYorumEkle.Name = "btnYorumEkle";
            btnYorumEkle.Size = new Size(155, 47);
            btnYorumEkle.TabIndex = 27;
            btnYorumEkle.Text = "Yorum Ekle";
            btnYorumEkle.UseVisualStyleBackColor = false;
            btnYorumEkle.Click += btnYorumEkle_Click;
            // 
            // btnYorumlariGor
            // 
            btnYorumlariGor.BackColor = Color.FromArgb(64, 0, 0);
            btnYorumlariGor.FlatStyle = FlatStyle.Flat;
            btnYorumlariGor.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYorumlariGor.Location = new Point(963, 529);
            btnYorumlariGor.Name = "btnYorumlariGor";
            btnYorumlariGor.Size = new Size(180, 47);
            btnYorumlariGor.TabIndex = 28;
            btnYorumlariGor.Text = "Yorumları Gör";
            btnYorumlariGor.UseVisualStyleBackColor = false;
            btnYorumlariGor.Click += btnYorumlariGor_Click_1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1192, 649);
            Controls.Add(btnYorumlariGor);
            Controls.Add(btnYorumEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(lblBitisTarihi);
            Controls.Add(lblBaslangic);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(btnDuzenle);
            Controls.Add(btnSil);
            Controls.Add(chkOkunduMu);
            Controls.Add(nudSayfaSayisi);
            Controls.Add(chkFavoriMi);
            Controls.Add(btnKitapEkle);
            Controls.Add(dgvKitaplar);
            Controls.Add(txtTur);
            Controls.Add(txtYazar);
            Controls.Add(txtAd);
            Controls.Add(lblFavoriMi);
            Controls.Add(lblOkunduMu);
            Controls.Add(lblSayfaSayisi);
            Controls.Add(lblTur);
            Controls.Add(lblYazar);
            Controls.Add(lblAd);
            Controls.Add(lblBaslık);
            ForeColor = SystemColors.Info;
            Name = "mainForm";
            Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSayfaSayisi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslık;
        private Label lblAd;
        private Label lblYazar;
        private Label lblTur;
        private Label lblSayfaSayisi;
        private Label lblOkunduMu;
        private Label lblFavoriMi;
        private TextBox txtAd;
        private TextBox txtYazar;
        private TextBox txtTur;
        private TextBox textBox4;
        private DataGridView dgvKitaplar;
        private Button btnKitapEkle;
        private CheckBox chkOkunduMu;
        private CheckBox chkFavoriMi;
        private NumericUpDown nudSayfaSayisi;
        private Button btnSil;
        private Button btnDuzenle;
        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Label lblBaslangic;
        private Label lblBitisTarihi;
        private Button btnGuncelle;
        private Button btnYorumEkle;
        private Button btnYorumlariGor;
    }
}