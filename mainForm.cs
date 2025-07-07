using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using readLog;

namespace readLog
{
    public partial class mainForm : Form
    {
        private BindingList<Book> kitaplar;
        public mainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btnKitapEkle.Click += btnKitapEkle_Click;
            btnSil.Click += btnSil_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kitaplar = new BindingList<Book>(BookService.Load());
            dgvKitaplar.DataSource = kitaplar;



            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.MultiSelect = false;
            dgvKitaplar.SelectionChanged += dgvKitaplar_SelectionChanged;

            dgvKitaplar.Columns[nameof(Book.Ad)].DataPropertyName = nameof(Book.Ad);
            dgvKitaplar.Columns[nameof(Book.Yazar)].DataPropertyName = nameof(Book.Yazar);
            dgvKitaplar.Columns[nameof(Book.Tur)].DataPropertyName = nameof(Book.Tur);
            dgvKitaplar.Columns[nameof(Book.SayfaSayisi)].DataPropertyName = nameof(Book.SayfaSayisi);
            dgvKitaplar.Columns[nameof(Book.OkunduMu)].DataPropertyName = nameof(Book.OkunduMu);
            dgvKitaplar.Columns[nameof(Book.FavoriMi)].DataPropertyName = nameof(Book.FavoriMi);
            dgvKitaplar.Columns[nameof(Book.OkumaBaslangicTarihi)].DataPropertyName = nameof(Book.OkumaBaslangicTarihi);
            dgvKitaplar.Columns[nameof(Book.OkumaBitisTarihi)].DataPropertyName = nameof(Book.OkumaBitisTarihi);


            dgvKitaplar.Columns[nameof(Book.Ad)].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[nameof(Book.Yazar)].HeaderText = "Yazar";
            dgvKitaplar.Columns[nameof(Book.Tur)].HeaderText = "Tür";
            dgvKitaplar.Columns[nameof(Book.SayfaSayisi)].HeaderText = "Sayfa";
            dgvKitaplar.Columns[nameof(Book.OkunduMu)].HeaderText = "Okundu?";
            dgvKitaplar.Columns[nameof(Book.FavoriMi)].HeaderText = "Favori?";
            dgvKitaplar.Columns[nameof(Book.OkumaBaslangicTarihi)].HeaderText = "Başlama Tarihi";
            dgvKitaplar.Columns[nameof(Book.OkumaBitisTarihi)].HeaderText = "Bitirme Tarihi";
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Lütfen kitap adı ve yazar girin.",
                                "Eksik Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var yeniKitap = new Book
            {
                Ad = txtAd.Text.Trim(),
                Yazar = txtYazar.Text.Trim(),
                Tur = txtTur.Text.Trim(),
                SayfaSayisi = (int)nudSayfaSayisi.Value,
                OkunduMu = chkOkunduMu.Checked,
                FavoriMi = chkFavoriMi.Checked,

                OkumaBaslangicTarihi = dtpBaslangicTarihi.Value,
                OkumaBitisTarihi = dtpBitisTarihi.Value
            };

            kitaplar.Add(yeniKitap);
            BookService.Save(new List<Book>(kitaplar));

            txtAd.Clear();
            txtYazar.Clear();
            txtTur.Clear();
            nudSayfaSayisi.Value = 0;
            chkOkunduMu.Checked = false;
            chkFavoriMi.Checked = false;

        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
                seciliKitap = dgvKitaplar.CurrentRow.DataBoundItem as Book;
        }

        private bool editMode = false;
        private Book seciliKitap;

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                if (seciliKitap == null)
                {
                    MessageBox.Show("Lütfen önce listeden düzenleyeceğiniz kitabı seçin.",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtAd.Text = seciliKitap.Ad;
                txtYazar.Text = seciliKitap.Yazar;
                txtTur.Text = seciliKitap.Tur;
                nudSayfaSayisi.Value = seciliKitap.SayfaSayisi;
                chkOkunduMu.Checked = seciliKitap.OkunduMu;
                chkFavoriMi.Checked = seciliKitap.FavoriMi;
                dtpBaslangicTarihi.Value = seciliKitap.OkumaBaslangicTarihi ?? DateTime.Today;
                dtpBitisTarihi.Value = seciliKitap.OkumaBitisTarihi ?? DateTime.Today;

                editMode = true;
                btnDuzenle.Text = "Kaydet";
            } 
            else
            {

                seciliKitap.Ad = txtAd.Text.Trim();
                seciliKitap.Yazar = txtYazar.Text.Trim();
                seciliKitap.Tur = txtTur.Text.Trim();
                seciliKitap.SayfaSayisi = (int)nudSayfaSayisi.Value;
                seciliKitap.OkunduMu = chkOkunduMu.Checked;
                seciliKitap.FavoriMi = chkFavoriMi.Checked;
                seciliKitap.OkumaBaslangicTarihi = dtpBaslangicTarihi.Value;
                seciliKitap.OkumaBitisTarihi = dtpBitisTarihi.Value;
                dgvKitaplar.Refresh();

                BookService.Save(new List<Book>(kitaplar));

                MessageBox.Show("Kitap bilgileri güncellendi.", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                TemizleKutular();
                btnDuzenle.Text = "Düzenle";
                editMode = false;
                seciliKitap = null;

            }
        }

        private void TemizleKutular()
        {
            txtAd.Clear();
            txtYazar.Clear();
            txtTur.Clear();
            nudSayfaSayisi.Value = 0;
            chkOkunduMu.Checked = chkFavoriMi.Checked = false;
            dtpBaslangicTarihi.Value = dtpBitisTarihi.Value = DateTime.Today;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var secilenKitap = dgvKitaplar.SelectedRows[0].DataBoundItem as Book;
            if (secilenKitap == null) return;


            var onay = MessageBox.Show($"\"{secilenKitap.Ad}\" adlı kitabı silmek istediğinize emin misiniz?",
                                       "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay != DialogResult.Yes) return;

            kitaplar.Remove(secilenKitap);


            BookService.Save(new List<Book>(kitaplar));

            MessageBox.Show("Kitap silindi.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKitaplar_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var kitap = dgvKitaplar.Rows[e.RowIndex].DataBoundItem as Book;
            if (kitap == null) return;

            txtAd.Text = kitap.Ad;
            txtYazar.Text = kitap.Yazar;
            txtTur.Text = kitap.Tur;
            nudSayfaSayisi.Value = kitap.SayfaSayisi;
            chkOkunduMu.Checked = kitap.OkunduMu;
            chkFavoriMi.Checked = kitap.FavoriMi;
            dtpBaslangicTarihi.Value = kitap.OkumaBaslangicTarihi ?? DateTime.Today;
            dtpBitisTarihi.Value = kitap.OkumaBitisTarihi ?? DateTime.Today;
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void lblYazar_Click(object sender, EventArgs e)
        {

        }

        private void lblFavoriMi_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBitisTarihi_Click(object sender, EventArgs e)
        {

        }
    }
}
