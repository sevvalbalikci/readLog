namespace readLog
{
    partial class CommentListForm
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
            lblKitapId = new Label();
            cmbKitapId = new ComboBox();
            lstYorumlar = new ListBox();
            btnCikis = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblKitapId
            // 
            lblKitapId.AutoSize = true;
            lblKitapId.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKitapId.ForeColor = SystemColors.Info;
            lblKitapId.Location = new Point(53, 108);
            lblKitapId.Name = "lblKitapId";
            lblKitapId.Size = new Size(150, 25);
            lblKitapId.TabIndex = 0;
            lblKitapId.Text = "Kitap ID Seçin :";
            // 
            // cmbKitapId
            // 
            cmbKitapId.BackColor = SystemColors.Info;
            cmbKitapId.FlatStyle = FlatStyle.Flat;
            cmbKitapId.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbKitapId.ForeColor = Color.FromArgb(64, 0, 0);
            cmbKitapId.FormattingEnabled = true;
            cmbKitapId.Location = new Point(209, 108);
            cmbKitapId.Name = "cmbKitapId";
            cmbKitapId.Size = new Size(144, 31);
            cmbKitapId.TabIndex = 1;
            // 
            // lstYorumlar
            // 
            lstYorumlar.BackColor = Color.FromArgb(64, 0, 0);
            lstYorumlar.Font = new Font("Goudy Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstYorumlar.ForeColor = SystemColors.Info;
            lstYorumlar.FormattingEnabled = true;
            lstYorumlar.Location = new Point(51, 162);
            lstYorumlar.Name = "lstYorumlar";
            lstYorumlar.Size = new Size(634, 372);
            lstYorumlar.TabIndex = 2;
            lstYorumlar.Click += lstYorumlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(64, 0, 0);
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Goudy Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCikis.ForeColor = SystemColors.Info;
            btnCikis.Location = new Point(536, 570);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(127, 46);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(232, 43);
            label1.TabIndex = 4;
            label1.Text = "YORUMLAR";
            // 
            // CommentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(734, 639);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Controls.Add(lstYorumlar);
            Controls.Add(cmbKitapId);
            Controls.Add(lblKitapId);
            Name = "CommentListForm";
            Text = "CommentListForm";
            Load += CommentListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitapId;
        private ComboBox cmbKitapId;
        private ListBox lstYorumlar;
        private Button btnCikis;
        private Label label1;
    }
}