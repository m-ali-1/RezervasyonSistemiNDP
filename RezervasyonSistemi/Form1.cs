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

            // Form y�klenirken yap�lacak i�lemler
            aktifKullanici = null;
            rezervasyonYoneticisi = new RezervasyonYoneticisi();
            adminKullanici = new Admin("00000", "Admin", "Admin", "1234", "admin123");
            kullaniciListesi.Insert(0, adminKullanici);

            // �rnek otel ve odalar� olu�tur
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
            Console.WriteLine("lbOteller_SelectedIndexChanged - Se�ilen Index: " + lbOteller.SelectedIndex);

            lbOdalar.Items.Clear(); // �nceki se�imleri temizle

            if (lbOteller.SelectedIndex != -1 && lbOteller.SelectedIndex < OtelListesi.Count)
            {
                Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
                Console.WriteLine("lbOteller_SelectedIndexChanged - Se�ili Otel: " + seciliOtel.OtelAdi);

                // Odalar� temizle ve se�ilen otelin odalar�n� ekle
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }
            }
        }

        private void lbOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("lbOdalar_SelectedIndexChanged - Se�ilen Index: " + lbOdalar.SelectedIndex);

            // Bu k�s�mda gerekirse odalar�n se�ilmesiyle ilgili ba�ka bir i�lem yapabilirsiniz.
            // Ancak �u anki sorununuzu ��zmek i�in bu k�sma ihtiya� yok.
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kay�t Ol butonuna t�kland���nda
            string kimlikNumarasi = tbKimlikNumarasi.Text;
            string isim = tbIsim.Text;
            string soyisim = tbSoyisim.Text;
            string telefonNumarasi = tbTelefonNumarasi.Text;
            string sifre = tbSifre.Text;

            try
            {
                // Yeni kullan�c� olu�tur
                Kullanici yeniKullanici = new Kullanici(kimlikNumarasi, isim, soyisim, telefonNumarasi, sifre);

                // Kullan�c�y� listeye ekle
                kullaniciListesi.Add(yeniKullanici);

                MessageBox.Show("Kullan�c� kayd� yap�ld�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // TextBox'lar� temizle
            tbKimlikNumarasi.Clear();
            tbIsim.Clear();
            tbSoyisim.Clear();
            tbTelefonNumarasi.Clear();
            tbSifre.Clear();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullan�c� giri�ini kontrol et
            Kullanici girisYapanKullanici = KullaniciGirisKontrolu(tbGirisKimlikNumarasi.Text, tbGirisSifre.Text);

            if (girisYapanKullanici != null)
            {
                // Kullan�c� admin mi de�il mi kontrol et
                if (girisYapanKullanici.IsAdmin)
                {
                    // E�er kullan�c� admin ise Admin GroupBox'�n� aktif et
                    MessageBox.Show("Admin giri�i ba�ar�l�!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbGirisKimlikNumarasi.Clear();
                    tbGirisSifre.Clear();
                    ShowAdminGroupBox();
                }
                else
                {
                    // E�er kullan�c� admin de�ilse di�er GroupBox'� aktif et
                    tbGirisKimlikNumarasi.Clear();
                    tbGirisSifre.Clear();
                    ShowRezervasyonGroupBox();
                }
            }
            else
            {
                MessageBox.Show("Ge�ersiz kimlik numaras� veya telefon numaras�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Kullanici KullaniciGirisKontrolu(string kimlikNumarasi, string sifre)
        {
            // Kullan�c� giri�ini kontrol et
            Kullanici girisYapanKullanici = kullaniciListesi.FirstOrDefault(k => k.KimlikNumarasi == kimlikNumarasi && k.Sifre == sifre);

            if (girisYapanKullanici != null)
            {
                // E�er giri� yapan kullan�c� bir admin ise, Admin olarak d�nd�r
                if (girisYapanKullanici is Admin)
                {
                    aktifKullanici = girisYapanKullanici;
                    return aktifKullanici;
                }

                // E�er giri� yapan kullan�c� admin de�ilse, aktif kullan�c�y� g�ncelle
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

                Console.WriteLine("SeciliOtel: " + seciliOtel); // Debug ��kt�s�
                Console.WriteLine("SeciliOda: " + seciliOda);   // Debug ��kt�s�

                if (seciliOtel != null && seciliOda != null)
                {
                    // Rezervasyon yap
                    rezervasyonYoneticisi.RezervasyonYap(aktifKullanici, seciliOtel, seciliOda);
                    MessageBox.Show("Rezervasyon yap�ld�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("L�tfen otel ve oda se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("L�tfen otel ve oda se�iniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GuncelleRezervasyonlarimListesi();
        }

        private void GuncelleRezervasyonlarimListesi()
        {
            // �nceki rezervasyonlar� temizle
            lbRezervasyonlarim.Items.Clear();

            // Yeni rezervasyonlar� ekle
            foreach (Rezervasyon rezervasyon in rezervasyonYoneticisi.RezervasyonlariGetir(aktifKullanici))
            {
                lbRezervasyonlarim.Items.Add(rezervasyon);
            }
        }


        private void btnRezervasyonlarim_Click(object sender, EventArgs e)
        {
            if (aktifKullanici is Admin)
            {
                // E�er aktif kullan�c� admin ise t�m rezervasyonlar� g�r�nt�le
                List<Rezervasyon> tumRezervasyonlar = rezervasyonYoneticisi.TumRezervasyonlariGetir();

                // ListBox'� temizle ve t�m rezervasyonlar� ekle
                lbRezervasyonlarim.Items.Clear();
                foreach (Rezervasyon rezervasyon in tumRezervasyonlar)
                {
                    // Sadece gerekli bilgileri ekleyin (�rne�in, Rezervasyon.ToString())
                    lbRezervasyonlarim.Items.Add(rezervasyon.ToString());
                }
                ShowRezervasyonlarimGroupBox();
                gbAdmin.Visible = true;
            }
            else
            {
                // E�er aktif kullan�c� admin de�ilse, sadece kendi rezervasyonlar�n� g�r�nt�le
                List<Rezervasyon> kullaniciRezervasyonlari = rezervasyonYoneticisi.RezervasyonlariGetir(aktifKullanici);

                // ListBox'� temizle ve kullan�c�n�n rezervasyonlar�n� ekle
                lbRezervasyonlarim.Items.Clear();
                foreach (Rezervasyon rezervasyon in kullaniciRezervasyonlari)
                {
                    // Sadece gerekli bilgileri ekleyin (�rne�in, Rezervasyon.ToString())
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

                // Rezervasyonlar� g�ncelle
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
                MessageBox.Show("L�tfen iptal edilecek bir rezervasyon se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // ListBox'� temizle ve yeniden doldur
                lbOteller.DataSource = null;
                lbOteller.DataSource = OtelListesi;
                lbOteller.DisplayMember = "OtelAdi";

                MessageBox.Show("Otel eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen ge�erli bir otel ad� girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // Oda ekledikten sonra Oda listesini g�ncelle
                lbOdalar.Items.Clear();
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }

                MessageBox.Show("Oda eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen bir otel se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminOtelSil_Click(object sender, EventArgs e)
        {
            Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];

            if (seciliOtel != null)
            {
                adminKullanici.OtelSil(OtelListesi, seciliOtel);

                // ListBox'� temizle ve g�ncel otel listesini ekle
                lbOteller.DataSource = null;
                lbOteller.DataSource = OtelListesi;
                lbOteller.DisplayMember = "OtelAdi";


                MessageBox.Show("Otel silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen bir otel se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdminOdaSil_Click(object sender, EventArgs e)
        {
            Otel seciliOtel = OtelListesi[lbOteller.SelectedIndex];
            Oda seciliOda = seciliOtel.Odalar[lbOdalar.SelectedIndex];

            if (seciliOtel != null && seciliOda != null)
            {
                adminKullanici.OdaSil(seciliOtel, seciliOda);

                // Odalar� temizle ve g�ncel oda listesini ekle
                lbOdalar.Items.Clear();
                foreach (Oda oda in seciliOtel.Odalar)
                {
                    lbOdalar.Items.Add("Oda " + oda.OdaNumarasi);
                }

                MessageBox.Show("Oda silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen bir otel ve oda se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("L�tfen bir otel se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
