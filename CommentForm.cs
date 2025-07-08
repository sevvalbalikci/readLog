using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readLog
{
    public partial class CommentForm : Form
    {
        private readonly int kitapId;
        private List<Comment> yorumlar;
        public CommentForm(int kitapId)
        {
            InitializeComponent();
            this.kitapId = kitapId;

            this.Text = "Yorum Ekle";
            btnKaydet.Click += btnKaydet_Click;
            btnCikis.Click += (s, e) => this.Close();

            yorumlar = CommentService.Yukle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) || string.IsNullOrWhiteSpace(txtYorum.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad ve Yorum girin.",
                    "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniYorum = new Comment
            {
                Id = SonrakiId(),
                KitapId = this.kitapId,
                YorumcuAdSoyad = txtAdSoyad.Text.Trim(),
                YorumMetni = txtYorum.Text.Trim(),
                YorumTarihi = DateTime.Now
            };

            yorumlar.Add(yeniYorum);
            CommentService.Kaydet(yorumlar);

            MessageBox.Show("Yorum başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private int SonrakiId()
        {
            return yorumlar.Any() ? yorumlar.Max(y => y.Id) + 1 : 1;
        }

        private void CommentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
