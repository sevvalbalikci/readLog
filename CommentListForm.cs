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
    public partial class CommentListForm : Form
    {
        private List<Comment> yorumlar;

        public CommentListForm()
        {
            InitializeComponent();
            this.Text = "Yorumları Görüntüle";
            yorumlar = CommentService.Yukle();


            var kitapIdler = yorumlar
                .Select(y => y.KitapId)
                .Distinct()
                .OrderBy(id => id)
                .ToList();
            cmbKitapId.DataSource = kitapIdler;

            cmbKitapId.SelectedIndexChanged += CmbKitapId_SelectedIndexChanged;
            btnCikis.Click += (s, e) => this.Close();
        }

        private void CmbKitapId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKitapId.SelectedItem is int secilenId)
            {
                lstYorumlar.Items.Clear();

                var secilenYorumlar = yorumlar
                    .Where(y => y.KitapId == secilenId)
                    .OrderBy(y => y.YorumTarihi)
                    .ToList();

                if (!secilenYorumlar.Any())
                {
                    lstYorumlar.Items.Add("Bu kitap için henüz yorum yok.");
                    return;
                }

                foreach (var yorum in secilenYorumlar)
                {
                    lstYorumlar.Items.Add($"[{yorum.YorumTarihi:G}] {yorum.YorumcuAdSoyad}: {yorum.YorumMetni}");
                }
            }
        }

        private void CommentListForm_Load(object sender, EventArgs e)
        {
            YorumlariYukle();
        }

        private void YorumlariYukle()
        {
            lstYorumlar.Items.Clear(); 

            var yorumlar = CommentService.Yukle();

            int secilenKitapId = (int)cmbKitapId.SelectedItem;

            var filtreli = yorumlar
                .Where(y => y.KitapId == secilenKitapId)
                .OrderBy(y => y.YorumTarihi)
                .ToList();

            foreach (var yorum in filtreli)
            {
                lstYorumlar.Items.Add($"{yorum.YorumcuAdSoyad}: {yorum.YorumMetni}");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstYorumlar_Click(object sender, EventArgs e)
        {
            if (lstYorumlar.SelectedItem != null)
            {
                string secilenYorum = lstYorumlar.SelectedItem.ToString();
                MessageBox.Show(secilenYorum, "Yorum Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
