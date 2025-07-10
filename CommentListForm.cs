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
        private readonly int kitapId;
        public CommentListForm(int kitapId)
        {
            InitializeComponent();
            this.Text = "Yorumları Görüntüle";
            this.kitapId = kitapId;
            yorumlar = CommentService.Yukle();
            YorumlariYukle();
            btnCikis.Click += (s, e) => this.Close();
        }
        private void YorumlariYukle()
        {
            lstYorumlar.Items.Clear();

            if (yorumlar == null)
                return;

            var filtreli = yorumlar
                .Where(y => y.KitapId == this.kitapId)
                .OrderBy(y => y.YorumTarihi)
                .ToList();

            foreach (var yorum in filtreli)
            {
                var item = new ListViewItem(yorum.YorumcuAdSoyad);
                item.SubItems.Add(yorum.YorumMetni);
                lstYorumlar.Items.Add(item);
            }
        }



        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstYorumlar_Click(object sender, EventArgs e)
        {
            if (lstYorumlar.SelectedItems.Count > 0)
            {
                var secilen = lstYorumlar.SelectedItems[0];
                string yorumcu = secilen.SubItems[0].Text;
                string yorum = secilen.SubItems[1].Text;

                MessageBox.Show($"{yorumcu}:\n\n{yorum}", "Yorum Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
