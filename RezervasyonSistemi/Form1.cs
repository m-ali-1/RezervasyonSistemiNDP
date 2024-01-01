using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class Form1 : Form
    {
        private List<Kullanici> kullaniciListesi;
        private Kullanici aktifKullanici;
        private IRezervasyonYoneticisi rezervasyonYoneticisi;
        private List<Otel> OtelListesi;
        private Admin adminKullanici;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            kullaniciListesi = new List<Kullanici>();
            OtelListesi = new List<Otel>();

            // Form yüklenirken yapýlacak iþlemler
            aktifKullanici = null;
            rezervasyonYoneticisi = new RezervasyonYoneticisi();
            adminKullanici = new Admin("00000", "Admin", "Admin", "1234", "admin123");
            kullaniciListesi.Insert(0, adminKullanici);

            // Örnek otel ve odalarý oluþtur
            Otel otel1 = new Otel("Otel 1");
            Oda oda101 = new Oda(101);
            Oda oda102 = new Oda(102);
            otel1.Odalar.Add(oda101);
            otel1.Odalar.Add(oda102);

            Otel otel2 = new Otel("Otel 2");
            Oda oda201 = new Oda(201);
            Oda oda202 = new Oda(202);
            otel2.Odalar.Add(oda201);
            otel2.Odalar.Add(oda202);

            Otel otel3 = new Otel("Otel 3");
            Oda oda301 = new Oda(301);
            Oda oda302 = new Oda(302);
            otel3.Odalar.Add(oda301);
            otel3.Odalar.Add(oda302);

            OtelListesi.Add(otel1);
            OtelListesi.Add(otel2);
            OtelListesi.Add(otel3);
            foreach (Otel otel in OtelListesi)
            {
                lbOteller.Items.Add(otel.OtelAdi);
            }

            ShowGirisYapGroupBox();
        }

        private void ShowGirisYapGroupBox()
        {
            gbGirisYap.Visible = true;
            gbKayitOl.Visible = false;
            gbRezervasyon.Visible = false;
            gbRezervasyonlarim.Visible = false;
            gbAdmin.Visible = false;
        }
        private void ShowKayitOlGroupBox()
        {
            gbGirisYap.Visible = false;
            gbKayitOl.Visible = true;
            gbRezervasyon.Visible = false;
            gbRezervasyonlarim.Visible = false;
            gbAdmin.Visible = false;
        }
        private void ShowRezervasyonGroupBox()
        {
            gbGirisYap.Visible = false;
            gbKayitOl.Visible = false;
            gbRezervasyon.Visible = true;
            gbRezervasyonlarim.Visible = false;
            gbAdmin.Visible = false;
        }
        private void ShowRezervasyonlarimGroupBox()
        {
            gbGirisYap.Visible = false;
            gbKayitOl.Visible = false;
            gbRezervasyon.Visible = true;
            gbRezervasyonlarim.Visible = true;
            gbAdmin.Visible = false;
        }
        private void ShowAdminGroupBox()
        {

            gbGirisYap.Visible = false;
            gbKayitOl.Visible = false;
            gbRezervasyon.Visible = true;
            gbRezervasyonlarim.Visible = true;
            gbAdmin.Visible = true;
        }

        private void lbOteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("lbOteller_SelectedIndexChanged - Seçilen Index: " + lbOteller.SelectedIndex);

            lbOdalar.Items.Clear(); // Önceki seçimleri temizle

            if (lbOteller.SelectedIndex != -1 && lbOteller.SelectedIndex < OtelListesi.Count)
            {
                Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
                Console.WriteLine("lbOteller_SelectedIndexChanged - Seçili Otel: " + seciliOtel.OtelAdi);

                // Odalarý temizle ve seçilen otelin odalarýný ekle
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }
            }
        }

        private void lbOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("lbOdalar_SelectedIndexChanged - Seçilen Index: " + lbOdalar.SelectedIndex);

            // Bu kýsýmda gerekirse odalarýn seçilmesiyle ilgili baþka bir iþlem yapabilirsiniz.
            // Ancak þu anki sorununuzu çözmek için bu kýsma ihtiyaç yok.
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kayýt Ol butonuna týklandýðýnda
            string kimlikNumarasi = tbKimlikNumarasi.Text;
            string isim = tbIsim.Text;
            string soyisim = tbSoyisim.Text;
            string telefonNumarasi = tbTelefonNumarasi.Text;
            string sifre = tbSifre.Text;

            try
            {
                // Yeni kullanýcý oluþtur
                Kullanici yeniKullanici = new Kullanici(kimlikNumarasi, isim, soyisim, telefonNumarasi, sifre);

                // Kullanýcýyý listeye ekle
                kullaniciListesi.Add(yeniKullanici);

                MessageBox.Show("Kullanýcý kaydý yapýldý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TemizleTextBox();
                ShowGirisYapGroupBox();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TemizleTextBox()
        {
            // TextBox'larý temizle
            tbKimlikNumarasi.Clear();
            tbIsim.Clear();
            tbSoyisim.Clear();
            tbTelefonNumarasi.Clear();
            tbSifre.Clear();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanýcý giriþini kontrol et
            Kullanici girisYapanKullanici = KullaniciGirisKontrolu(tbGirisKimlikNumarasi.Text, tbGirisSifre.Text);

            if (girisYapanKullanici != null)
            {
                // Kullanýcý admin mi deðil mi kontrol et
                if (girisYapanKullanici.IsAdmin)
                {
                    // Eðer kullanýcý admin ise Admin GroupBox'ýný aktif et
                    MessageBox.Show("Admin giriþi baþarýlý!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbGirisKimlikNumarasi.Clear();
                    tbGirisSifre.Clear();
                    ShowAdminGroupBox();
                }
                else
                {
                    // Eðer kullanýcý admin deðilse diðer GroupBox'ý aktif et
                    tbGirisKimlikNumarasi.Clear();
                    tbGirisSifre.Clear();
                    ShowRezervasyonGroupBox();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz kimlik numarasý veya telefon numarasý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Kullanici KullaniciGirisKontrolu(string kimlikNumarasi, string sifre)
        {
            // Kullanýcý giriþini kontrol et
            Kullanici girisYapanKullanici = kullaniciListesi.FirstOrDefault(k => k.KimlikNumarasi == kimlikNumarasi && k.Sifre == sifre);

            if (girisYapanKullanici != null)
            {
                // Eðer giriþ yapan kullanýcý bir admin ise, Admin olarak döndür
                if (girisYapanKullanici is Admin)
                {
                    aktifKullanici = girisYapanKullanici;
                    return aktifKullanici;
                }

                // Eðer giriþ yapan kullanýcý admin deðilse, aktif kullanýcýyý güncelle
                aktifKullanici = girisYapanKullanici;
                return aktifKullanici;
            }

            return null;
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if (lbOteller.SelectedIndex >= 0 && lbOdalar.SelectedIndex >= 0)
            {
                Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
                Oda seciliOda = seciliOtel.Odalar[lbOdalar.SelectedIndex];

                Console.WriteLine("SeciliOtel: " + seciliOtel); // Debug çýktýsý
                Console.WriteLine("SeciliOda: " + seciliOda);   // Debug çýktýsý

                if (seciliOtel != null && seciliOda != null)
                {
                    // Rezervasyon yap
                    rezervasyonYoneticisi.RezervasyonYap(aktifKullanici, seciliOtel, seciliOda);
                    MessageBox.Show("Rezervasyon yapýldý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen otel ve oda seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen otel ve oda seçiniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GuncelleRezervasyonlarimListesi();
        }

        private void GuncelleRezervasyonlarimListesi()
        {
            // Önceki rezervasyonlarý temizle
            lbRezervasyonlarim.Items.Clear();

            // Yeni rezervasyonlarý ekle
            foreach (Rezervasyon rezervasyon in rezervasyonYoneticisi.RezervasyonlariGetir(aktifKullanici))
            {
                lbRezervasyonlarim.Items.Add(rezervasyon);
            }
        }


        private void btnRezervasyonlarim_Click(object sender, EventArgs e)
        {
            if (aktifKullanici is Admin)
            {
                // Eðer aktif kullanýcý admin ise tüm rezervasyonlarý görüntüle
                List<Rezervasyon> tumRezervasyonlar = rezervasyonYoneticisi.TumRezervasyonlariGetir();

                // ListBox'ý temizle ve tüm rezervasyonlarý ekle
                lbRezervasyonlarim.Items.Clear();
                foreach (Rezervasyon rezervasyon in tumRezervasyonlar)
                {
                    // Sadece gerekli bilgileri ekleyin (örneðin, Rezervasyon.ToString())
                    lbRezervasyonlarim.Items.Add(rezervasyon.ToString());
                }
                ShowRezervasyonlarimGroupBox();
                gbAdmin.Visible = true;
            }
            else
            {
                // Eðer aktif kullanýcý admin deðilse, sadece kendi rezervasyonlarýný görüntüle
                List<Rezervasyon> kullaniciRezervasyonlari = rezervasyonYoneticisi.RezervasyonlariGetir(aktifKullanici);

                // ListBox'ý temizle ve kullanýcýnýn rezervasyonlarýný ekle
                lbRezervasyonlarim.Items.Clear();
                foreach (Rezervasyon rezervasyon in kullaniciRezervasyonlari)
                {
                    // Sadece gerekli bilgileri ekleyin (örneðin, Rezervasyon.ToString())
                    lbRezervasyonlarim.Items.Add(rezervasyon.ToString());
                }
                ShowRezervasyonlarimGroupBox();
            }

        }

        private void btnRezervasyonIptalEt_Click(object sender, EventArgs e)
        {
            int seciliIndex = lbRezervasyonlarim.SelectedIndex;

            if (seciliIndex != -1)
            {
                Rezervasyon seciliRezervasyon = rezervasyonYoneticisi.TumRezervasyonlariGetir()[seciliIndex];
                rezervasyonYoneticisi.RezervasyonIptal(seciliRezervasyon);
                MessageBox.Show("Rezervasyon iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Rezervasyonlarý güncelle
                if (aktifKullanici is Admin)
                {
                    List<Rezervasyon> tumRezervasyonlar = rezervasyonYoneticisi.TumRezervasyonlariGetir();
                    GuncelRezervasyonlariListele(tumRezervasyonlar);
                }
                else
                {
                    List<Rezervasyon> kullaniciRezervasyonlari = rezervasyonYoneticisi.RezervasyonlariGetir(aktifKullanici);
                    GuncelRezervasyonlariListele(kullaniciRezervasyonlari);
                }
            }
            else
            {
                MessageBox.Show("Lütfen iptal edilecek bir rezervasyon seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GuncelRezervasyonlariListele(List<Rezervasyon> rezervasyonlarListesi)
        {
            lbRezervasyonlarim.Items.Clear();
            foreach (Rezervasyon rezervasyon in rezervasyonlarListesi)
            {
                lbRezervasyonlarim.Items.Add(rezervasyon.ToString());
            }
        }


        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            aktifKullanici = null;
            ShowGirisYapGroupBox();
        }

        private void btnGirisKismi_Click(object sender, EventArgs e)
        {
            ShowGirisYapGroupBox();
        }

        private void btnKayitKismi_Click(object sender, EventArgs e)
        {
            ShowKayitOlGroupBox();
        }

        private void btnAdminOtelEkle_Click(object sender, EventArgs e)
        {
            // Admin, otel eklesin
            string yeniOtelAdi = txtOtelAdi.Text;

            if (!string.IsNullOrWhiteSpace(yeniOtelAdi))
            {
                Otel yeniOtel = new Otel(yeniOtelAdi);
                adminKullanici.OtelEkle(yeniOtel);

                OtelListesi.Add(yeniOtel);

                // ListBox'ý temizle ve yeniden doldur
                lbOteller.DataSource = null;
                lbOteller.DataSource = OtelListesi;
                lbOteller.DisplayMember = "OtelAdi";

                MessageBox.Show("Otel eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir otel adý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminOdaEkle_Click(object sender, EventArgs e)
        {
            // Admin, oda eklesin
            Otel seciliOtel = lbOteller.SelectedItem as Otel;
            int yeniOdaNo = Convert.ToInt32(txtOdaNo.Text);

            if (seciliOtel != null)
            {
                Oda yeniOda = new Oda(yeniOdaNo);
                adminKullanici.OdaEkle(seciliOtel, yeniOda);

                // Oda ekledikten sonra Oda listesini güncelle
                lbOdalar.Items.Clear();
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }

                MessageBox.Show("Oda eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir otel seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminOtelSil_Click(object sender, EventArgs e)
        {
            Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];

            if (seciliOtel != null)
            {
                adminKullanici.OtelSil(OtelListesi, seciliOtel);

                // ListBox'ý temizle ve güncel otel listesini ekle
                lbOteller.DataSource = null;
                lbOteller.DataSource = OtelListesi;
                lbOteller.DisplayMember = "OtelAdi";


                MessageBox.Show("Otel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir otel seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdminOdaSil_Click(object sender, EventArgs e)
        {
            Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
            Oda seciliOda = seciliOtel.Odalar[lbOdalar.SelectedIndex];

            if (seciliOtel != null && seciliOda != null)
            {
                adminKullanici.OdaSil(seciliOtel, seciliOda);

                // Odalarý temizle ve güncel oda listesini ekle
                lbOdalar.Items.Clear();
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }

                MessageBox.Show("Oda silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir otel ve oda seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdminTumKullanicilariListele_Click(object sender, EventArgs e)
        {
            if (aktifKullanici is Admin)
            {
                lbTumKullanicilar.Items.Clear();
                foreach (var kullanici in kullaniciListesi)
                {
                    lbTumKullanicilar.Items.Add($"{kullanici.KimlikNumarasi} - {kullanici.Isim} {kullanici.Soyisim}");
                }
            }
        }
        private void btnBilgileriGetir_Click(object sender, EventArgs e)
        {
            Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
            if (seciliOtel != null)
            {
                string otelBilgisi = seciliOtel.BilgileriGetir();
                MessageBox.Show(otelBilgisi, "Otel Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir otel seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
