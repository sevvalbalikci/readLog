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
        private int kitapSayaci = 1;
        private BindingList<Book> kitaplar;

        private bool editMode = false;
        private bool updateAndAddMode = false;
        private Book seciliKitap;

        public mainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btnKitapEkle.Click += btnKitapEkle_Click;
            btnSil.Click += btnSil_Click;
            btnGuncelle.Click += btnGuncelle_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            kitaplar = new BindingList<Book>(BookService.Load());

            if (kitaplar.Any())
                kitapSayaci = kitaplar.Max(k => k.Id) + 1;
            else
                kitapSayaci = 1;



            dgvKitaplar.DataSource = kitaplar;
            dgvKitaplar.AutoGenerateColumns = true;

            dgvKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKitaplar.MultiSelect = false;
            dgvKitaplar.SelectionChanged += dgvKitaplar_SelectionChanged;

            dgvKitaplar.Columns[nameof(Book.Id)].HeaderText = "Kitap ID";
            dgvKitaplar.Columns[nameof(Book.Ad)].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[nameof(Book.Yazar)].HeaderText = "Yazar";
            dgvKitaplar.Columns[nameof(Book.Tur)].HeaderText = "Tür";
            dgvKitaplar.Columns[nameof(Book.SayfaSayisi)].HeaderText = "Sayfa";
            dgvKitaplar.Columns[nameof(Book.OkunduMu)].HeaderText = "Okundu?";
            dgvKitaplar.Columns[nameof(Book.FavoriMi)].HeaderText = "Favori?";
            dgvKitaplar.Columns[nameof(Book.OkumaBaslangicTarihi)].HeaderText = "Başlama Tarihi";
            dgvKitaplar.Columns[nameof(Book.OkumaBitisTarihi)].HeaderText = "Bitirme Tarihi";

            dgvKitaplar.Columns[nameof(Book.Id)].Visible = true;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Lütfen kitap adını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Lütfen yazar adını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTur.Text))
            {
                MessageBox.Show("Lütfen kitap türünü girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudSayfaSayisi.Value <= 0)
            {
                MessageBox.Show("Lütfen sayfa sayısını 1 veya daha fazla olarak girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBitisTarihi.Value < dtpBaslangicTarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var yeniKitap = new Book
            {
                Id = kitapSayaci,
                Ad = TextHelper.ToProperCase(txtAd.Text.Trim()),
                Yazar = TextHelper.ToProperCase(txtYazar.Text.Trim()),
                Tur = TextHelper.ToProperCase(txtTur.Text.Trim()),
                SayfaSayisi = (int)nudSayfaSayisi.Value,
                OkunduMu = chkOkunduMu.Checked,
                FavoriMi = chkFavoriMi.Checked,
                OkumaBaslangicTarihi = dtpBaslangicTarihi.Value,
                OkumaBitisTarihi = dtpBitisTarihi.Value
            };

            kitaplar.Add(yeniKitap);
            kitapSayaci++;

            BookService.Save(kitaplar.ToList());

            LoadBooksIntoDataGridView();
            TemizleKutular();
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



            BookService.Save(kitaplar.ToList());

            MessageBox.Show("Kitap silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadBooksIntoDataGridView();
        }

        private void dgvKitaplar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow != null)
                seciliKitap = dgvKitaplar.CurrentRow.DataBoundItem as Book;
        }

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
                seciliKitap.Ad = TextHelper.ToProperCase(txtAd.Text.Trim());
                seciliKitap.Yazar = TextHelper.ToProperCase(txtYazar.Text.Trim());
                seciliKitap.Tur = TextHelper.ToProperCase(txtTur.Text.Trim());
                seciliKitap.SayfaSayisi = (int)nudSayfaSayisi.Value;
                seciliKitap.OkunduMu = chkOkunduMu.Checked;
                seciliKitap.FavoriMi = chkFavoriMi.Checked;
                seciliKitap.OkumaBaslangicTarihi = dtpBaslangicTarihi.Value;
                seciliKitap.OkumaBitisTarihi = dtpBitisTarihi.Value;

                dgvKitaplar.Refresh();
                BookService.Save(kitaplar.ToList());

                MessageBox.Show("Kitap bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void LoadBooksIntoDataGridView()
        {
            var siraliKitaplar = new BindingList<Book>(kitaplar.OrderBy(k => k.Ad).ToList());
            dgvKitaplar.DataSource = siraliKitaplar;

        }

        private void SetInitialButtonStates()
        {
            btnDuzenle.Text = "Düzenle";
            btnGuncelle.Text = "Güncelle";
            TemizleKutular();

            editMode = false;
            updateAndAddMode = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (editMode)
            {
                MessageBox.Show("Lütfen önce 'Düzenle' işlemini tamamlayın veya iptal edin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!updateAndAddMode)
            {
                if (seciliKitap == null)
                {
                    MessageBox.Show("Lütfen önce listeden güncelleyip yeni olarak kaydedeceğiniz kitabı seçin.",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtAd.Text = seciliKitap.Ad;
                txtYazar.Text = seciliKitap.Yazar;
                txtTur.Text = seciliKitap.Tur;
                nudSayfaSayisi.Value = seciliKitap.SayfaSayisi;
                chkOkunduMu.Checked = seciliKitap.OkunduMu;
                chkFavoriMi.Checked = chkFavoriMi.Checked;
                dtpBaslangicTarihi.Value = seciliKitap.OkumaBaslangicTarihi ?? DateTime.Today;
                dtpBitisTarihi.Value = dtpBitisTarihi.Value;

                updateAndAddMode = true;
                btnGuncelle.Text = "Yeni Kaydet";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                    string.IsNullOrWhiteSpace(txtYazar.Text))
                {
                    MessageBox.Show("Kitap adı ve yazar boş bırakılamaz.",
                                    "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var yeniKitap = new Book
                {
                    Id = kitapSayaci,
                    Ad = TextHelper.ToProperCase(txtAd.Text.Trim()),
                    Yazar = TextHelper.ToProperCase(txtYazar.Text.Trim()),
                    Tur = TextHelper.ToProperCase(txtTur.Text.Trim()),
                    SayfaSayisi = (int)nudSayfaSayisi.Value,
                    OkunduMu = chkOkunduMu.Checked,
                    FavoriMi = chkFavoriMi.Checked,
                    OkumaBaslangicTarihi = dtpBaslangicTarihi.Value,
                    OkumaBitisTarihi = dtpBitisTarihi.Value
                };

                kitaplar.Add(yeniKitap);
                kitapSayaci++;

                BookService.Save(kitaplar.ToList());

                MessageBox.Show("Kitap güncellenmiş haliyle yeni olarak kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SetInitialButtonStates();
            }
        }

        private void btnYorumEkle_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvKitaplar.CurrentRow?.DataBoundItem is Book seciliKitap)
            {
                int kitapId = seciliKitap.Id;

                if (kitapId <= 0)
                {
                    MessageBox.Show("Seçilen kitabın geçerli bir ID'si yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CommentForm yorumForm = new CommentForm(kitapId);
                yorumForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen önce bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYorumlarıGor_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e) { }
        private void lblAd_Click(object sender, EventArgs e) { }
        private void lblYazar_Click(object sender, EventArgs e) { }
        private void lblFavoriMi_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblBitisTarihi_Click(object sender, EventArgs e) { }
        private void dgvKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
    }
}