namespace readLog
{
    partial class CommentForm
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
            txtAdSoyad = new TextBox();
            lblAd = new Label();
            txtYorum = new TextBox();
            btnKaydet = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BackColor = SystemColors.Info;
            txtAdSoyad.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdSoyad.ForeColor = Color.FromArgb(64, 0, 0);
            txtAdSoyad.Location = new Point(207, 64);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(132, 33);
            txtAdSoyad.TabIndex = 0;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.BackColor = Color.Maroon;
            lblAd.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAd.ForeColor = SystemColors.Info;
            lblAd.Location = new Point(98, 66);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(103, 25);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad Soyad :";
            // 
            // txtYorum
            // 
            txtYorum.BackColor = Color.FromArgb(64, 0, 0);
            txtYorum.ForeColor = SystemColors.Info;
            txtYorum.Location = new Point(74, 122);
            txtYorum.Multiline = true;
            txtYorum.Name = "txtYorum";
            txtYorum.Size = new Size(609, 411);
            txtYorum.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(64, 0, 0);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKaydet.ForeColor = SystemColors.Info;
            btnKaydet.Location = new Point(207, 562);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(159, 48);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(64, 0, 0);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCikis.ForeColor = SystemColors.Info;
            btnCikis.Location = new Point(386, 562);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(159, 48);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(752, 678);
            Controls.Add(btnCikis);
            Controls.Add(btnKaydet);
            Controls.Add(txtYorum);
            Controls.Add(lblAd);
            Controls.Add(txtAdSoyad);
            Name = "CommentForm";
            Text = "CommentForm";
            Load += CommentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private Label lblAd;
        private TextBox txtYorum;
        private Button btnKaydet;
        private Button btnCikis;
    }
}