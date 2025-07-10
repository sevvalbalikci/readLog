using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace readLog
{
    partial class CommentListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstYorumlar = new ListView();
            btnCikis = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstYorumlar
            //responsive tasarım
            // 
            lstYorumlar.BackColor = Color.FromArgb(64, 0, 0);
            lstYorumlar.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold);
            lstYorumlar.ForeColor = SystemColors.Info;
            lstYorumlar.FullRowSelect = true;
            lstYorumlar.Location = new Point(51, 162);
            lstYorumlar.Name = "lstYorumlar";
            lstYorumlar.Size = new Size(634, 372);
            lstYorumlar.TabIndex = 2;
            lstYorumlar.UseCompatibleStateImageBehavior = false;
            lstYorumlar.View = View.Details;
            lstYorumlar.Click += lstYorumlar_Click;
            lstYorumlar.Columns.Add("Yorumcu", 150);
            lstYorumlar.Columns.Add("Yorum", 450);
            lstYorumlar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
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
            btnCikis.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            label1.Anchor = AnchorStyles.Top;
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
            Name = "CommentListForm";
            Text = "Yorumları Görüntüle";
            MinimumSize = new Size(600, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKitapId;
        private ComboBox cmbKitapId;
        private ListView lstYorumlar;
        private Button btnCikis;
        private Label label1;
    }
}
