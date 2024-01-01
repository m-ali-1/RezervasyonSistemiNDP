namespace RezervasyonSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKayitOl = new Button();
            btnGirisYap = new Button();
            lbOteller = new ListBox();
            gbKayitOl = new GroupBox();
            label9 = new Label();
            tbSifre = new TextBox();
            label7 = new Label();
            btnGirisKismi = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbKimlikNumarasi = new TextBox();
            tbTelefonNumarasi = new TextBox();
            tbIsim = new TextBox();
            tbSoyisim = new TextBox();
            gbRezervasyon = new GroupBox();
            btnBilgileriGetir = new Button();
            btnCikisYap = new Button();
            btnRezervasyonlarim = new Button();
            btnRezervasyonYap = new Button();
            lbOdalar = new ListBox();
            btnRezervasyonIptalEt = new Button();
            gbRezervasyonlarim = new GroupBox();
            lbRezervasyonlarim = new ListBox();
            tbGirisKimlikNumarasi = new TextBox();
            tbGirisSifre = new TextBox();
            gbGirisYap = new GroupBox();
            btnKayitKismi = new Button();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            gbAdmin = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            lbTumKullanicilar = new ListBox();
            btnAdminTumKullanicilariListele = new Button();
            txtOdaNo = new TextBox();
            txtOtelAdi = new TextBox();
            btnAdminOdaSil = new Button();
            btnAdminOdaEkle = new Button();
            btnAdminOtelSil = new Button();
            btnAdminOtelEkle = new Button();
            gbKayitOl.SuspendLayout();
            gbRezervasyon.SuspendLayout();
            gbRezervasyonlarim.SuspendLayout();
            gbGirisYap.SuspendLayout();
            gbAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(48, 214);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(125, 67);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(48, 157);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(125, 73);
            btnGirisYap.TabIndex = 3;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lbOteller
            // 
            lbOteller.FormattingEnabled = true;
            lbOteller.ItemHeight = 20;
            lbOteller.Location = new Point(6, 26);
            lbOteller.Name = "lbOteller";
            lbOteller.Size = new Size(353, 144);
            lbOteller.TabIndex = 2;
            lbOteller.SelectedIndexChanged += lbOteller_SelectedIndexChanged;
            // 
            // gbKayitOl
            // 
            gbKayitOl.Controls.Add(label9);
            gbKayitOl.Controls.Add(tbSifre);
            gbKayitOl.Controls.Add(label7);
            gbKayitOl.Controls.Add(btnGirisKismi);
            gbKayitOl.Controls.Add(label4);
            gbKayitOl.Controls.Add(label3);
            gbKayitOl.Controls.Add(label2);
            gbKayitOl.Controls.Add(label1);
            gbKayitOl.Controls.Add(btnKayitOl);
            gbKayitOl.Controls.Add(tbKimlikNumarasi);
            gbKayitOl.Controls.Add(tbTelefonNumarasi);
            gbKayitOl.Controls.Add(tbIsim);
            gbKayitOl.Controls.Add(tbSoyisim);
            gbKayitOl.Location = new Point(525, 12);
            gbKayitOl.Name = "gbKayitOl";
            gbKayitOl.Size = new Size(431, 334);
            gbKayitOl.TabIndex = 3;
            gbKayitOl.TabStop = false;
            gbKayitOl.Text = "Kayıt Ol";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 174);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 17;
            label9.Text = "Şifre:";
            // 
            // tbSifre
            // 
            tbSifre.Location = new Point(107, 171);
            tbSifre.Name = "tbSifre";
            tbSifre.Size = new Size(125, 27);
            tbSifre.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(298, 75);
            label7.MaximumSize = new Size(100, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 120);
            label7.TabIndex = 15;
            label7.Text = "Eğer kaydınız varsa giriş yapmak için aşağıdaki butona tıklayınız!";
            // 
            // btnGirisKismi
            // 
            btnGirisKismi.Location = new Point(287, 214);
            btnGirisKismi.Name = "btnGirisKismi";
            btnGirisKismi.Size = new Size(125, 67);
            btnGirisKismi.TabIndex = 7;
            btnGirisKismi.Text = "Giriş Yap";
            btnGirisKismi.UseVisualStyleBackColor = true;
            btnGirisKismi.Click += btnGirisKismi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.MaximumSize = new Size(100, 100);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefon No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.MaximumSize = new Size(100, 100);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 12;
            label3.Text = "Soyisim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.MaximumSize = new Size(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 11;
            label2.Text = "İsim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.MaximumSize = new Size(100, 100);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 10;
            label1.Text = "Kimlik No:";
            // 
            // tbKimlikNumarasi
            // 
            tbKimlikNumarasi.Location = new Point(107, 44);
            tbKimlikNumarasi.Name = "tbKimlikNumarasi";
            tbKimlikNumarasi.Size = new Size(125, 27);
            tbKimlikNumarasi.TabIndex = 1;
            // 
            // tbTelefonNumarasi
            // 
            tbTelefonNumarasi.Location = new Point(107, 138);
            tbTelefonNumarasi.Name = "tbTelefonNumarasi";
            tbTelefonNumarasi.Size = new Size(125, 27);
            tbTelefonNumarasi.TabIndex = 4;
            // 
            // tbIsim
            // 
            tbIsim.Location = new Point(107, 75);
            tbIsim.Name = "tbIsim";
            tbIsim.Size = new Size(125, 27);
            tbIsim.TabIndex = 2;
            // 
            // tbSoyisim
            // 
            tbSoyisim.Location = new Point(107, 105);
            tbSoyisim.Name = "tbSoyisim";
            tbSoyisim.Size = new Size(125, 27);
            tbSoyisim.TabIndex = 3;
            // 
            // gbRezervasyon
            // 
            gbRezervasyon.Controls.Add(btnBilgileriGetir);
            gbRezervasyon.Controls.Add(btnCikisYap);
            gbRezervasyon.Controls.Add(btnRezervasyonlarim);
            gbRezervasyon.Controls.Add(btnRezervasyonYap);
            gbRezervasyon.Controls.Add(lbOdalar);
            gbRezervasyon.Controls.Add(lbOteller);
            gbRezervasyon.Location = new Point(12, 12);
            gbRezervasyon.Name = "gbRezervasyon";
            gbRezervasyon.Size = new Size(496, 375);
            gbRezervasyon.TabIndex = 4;
            gbRezervasyon.TabStop = false;
            gbRezervasyon.Text = "Rezervasyon";
            // 
            // btnBilgileriGetir
            // 
            btnBilgileriGetir.Location = new Point(6, 314);
            btnBilgileriGetir.Name = "btnBilgileriGetir";
            btnBilgileriGetir.Size = new Size(479, 55);
            btnBilgileriGetir.TabIndex = 7;
            btnBilgileriGetir.Text = "Otel Bilgisi Al";
            btnBilgileriGetir.UseVisualStyleBackColor = true;
            btnBilgileriGetir.Click += btnBilgileriGetir_Click;
            // 
            // btnCikisYap
            // 
            btnCikisYap.Location = new Point(365, 216);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(120, 92);
            btnCikisYap.TabIndex = 6;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnRezervasyonlarim
            // 
            btnRezervasyonlarim.Location = new Point(365, 121);
            btnRezervasyonlarim.Name = "btnRezervasyonlarim";
            btnRezervasyonlarim.Size = new Size(120, 89);
            btnRezervasyonlarim.TabIndex = 5;
            btnRezervasyonlarim.Text = "Rezervasyonları Görüntüle";
            btnRezervasyonlarim.UseVisualStyleBackColor = true;
            btnRezervasyonlarim.Click += btnRezervasyonlarim_Click;
            // 
            // btnRezervasyonYap
            // 
            btnRezervasyonYap.Location = new Point(365, 26);
            btnRezervasyonYap.Name = "btnRezervasyonYap";
            btnRezervasyonYap.Size = new Size(120, 89);
            btnRezervasyonYap.TabIndex = 4;
            btnRezervasyonYap.Text = "Rezervasyon Yap";
            btnRezervasyonYap.UseVisualStyleBackColor = true;
            btnRezervasyonYap.Click += btnRezervasyonYap_Click;
            // 
            // lbOdalar
            // 
            lbOdalar.FormattingEnabled = true;
            lbOdalar.ItemHeight = 20;
            lbOdalar.Location = new Point(6, 184);
            lbOdalar.Name = "lbOdalar";
            lbOdalar.Size = new Size(353, 124);
            lbOdalar.TabIndex = 3;
            lbOdalar.SelectedIndexChanged += lbOdalar_SelectedIndexChanged;
            // 
            // btnRezervasyonIptalEt
            // 
            btnRezervasyonIptalEt.Location = new Point(365, 26);
            btnRezervasyonIptalEt.Name = "btnRezervasyonIptalEt";
            btnRezervasyonIptalEt.Size = new Size(120, 204);
            btnRezervasyonIptalEt.TabIndex = 5;
            btnRezervasyonIptalEt.Text = "Rezervasyonu İptal Et";
            btnRezervasyonIptalEt.UseVisualStyleBackColor = true;
            btnRezervasyonIptalEt.Click += btnRezervasyonIptalEt_Click;
            // 
            // gbRezervasyonlarim
            // 
            gbRezervasyonlarim.Controls.Add(lbRezervasyonlarim);
            gbRezervasyonlarim.Controls.Add(btnRezervasyonIptalEt);
            gbRezervasyonlarim.Location = new Point(12, 393);
            gbRezervasyonlarim.Name = "gbRezervasyonlarim";
            gbRezervasyonlarim.Size = new Size(496, 252);
            gbRezervasyonlarim.TabIndex = 5;
            gbRezervasyonlarim.TabStop = false;
            gbRezervasyonlarim.Text = "Rezervasyon İptali";
            // 
            // lbRezervasyonlarim
            // 
            lbRezervasyonlarim.FormattingEnabled = true;
            lbRezervasyonlarim.ItemHeight = 20;
            lbRezervasyonlarim.Location = new Point(6, 26);
            lbRezervasyonlarim.Name = "lbRezervasyonlarim";
            lbRezervasyonlarim.Size = new Size(353, 204);
            lbRezervasyonlarim.TabIndex = 6;
            // 
            // tbGirisKimlikNumarasi
            // 
            tbGirisKimlikNumarasi.Location = new Point(100, 57);
            tbGirisKimlikNumarasi.Name = "tbGirisKimlikNumarasi";
            tbGirisKimlikNumarasi.Size = new Size(125, 27);
            tbGirisKimlikNumarasi.TabIndex = 1;
            // 
            // tbGirisSifre
            // 
            tbGirisSifre.Location = new Point(100, 96);
            tbGirisSifre.Name = "tbGirisSifre";
            tbGirisSifre.Size = new Size(125, 27);
            tbGirisSifre.TabIndex = 2;
            // 
            // gbGirisYap
            // 
            gbGirisYap.Controls.Add(btnKayitKismi);
            gbGirisYap.Controls.Add(label8);
            gbGirisYap.Controls.Add(label6);
            gbGirisYap.Controls.Add(label5);
            gbGirisYap.Controls.Add(btnGirisYap);
            gbGirisYap.Controls.Add(tbGirisKimlikNumarasi);
            gbGirisYap.Controls.Add(tbGirisSifre);
            gbGirisYap.Location = new Point(525, 393);
            gbGirisYap.Name = "gbGirisYap";
            gbGirisYap.Size = new Size(431, 252);
            gbGirisYap.TabIndex = 12;
            gbGirisYap.TabStop = false;
            gbGirisYap.Text = "Giriş Yap";
            // 
            // btnKayitKismi
            // 
            btnKayitKismi.Location = new Point(287, 157);
            btnKayitKismi.Name = "btnKayitKismi";
            btnKayitKismi.Size = new Size(125, 73);
            btnKayitKismi.TabIndex = 4;
            btnKayitKismi.Text = "Kayıt Ol";
            btnKayitKismi.UseVisualStyleBackColor = true;
            btnKayitKismi.Click += btnKayitKismi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(298, 57);
            label8.MaximumSize = new Size(100, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 80);
            label8.TabIndex = 14;
            label8.Text = "Kayıt olmak için aşağıdaki butona tıklayınız!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 99);
            label6.MaximumSize = new Size(100, 100);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 13;
            label6.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 60);
            label5.MaximumSize = new Size(100, 100);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 12;
            label5.Text = "Kimlik No:";
            // 
            // gbAdmin
            // 
            gbAdmin.Controls.Add(label11);
            gbAdmin.Controls.Add(label10);
            gbAdmin.Controls.Add(lbTumKullanicilar);
            gbAdmin.Controls.Add(btnAdminTumKullanicilariListele);
            gbAdmin.Controls.Add(txtOdaNo);
            gbAdmin.Controls.Add(txtOtelAdi);
            gbAdmin.Controls.Add(btnAdminOdaSil);
            gbAdmin.Controls.Add(btnAdminOdaEkle);
            gbAdmin.Controls.Add(btnAdminOtelSil);
            gbAdmin.Controls.Add(btnAdminOtelEkle);
            gbAdmin.Location = new Point(12, 651);
            gbAdmin.Name = "gbAdmin";
            gbAdmin.Size = new Size(967, 274);
            gbAdmin.TabIndex = 13;
            gbAdmin.TabStop = false;
            gbAdmin.Text = "Admin Paneli";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(232, 57);
            label11.Name = "label11";
            label11.Size = new Size(37, 20);
            label11.TabIndex = 16;
            label11.Text = "Oda";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 57);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 15;
            label10.Text = "Otel";
            // 
            // lbTumKullanicilar
            // 
            lbTumKullanicilar.FormattingEnabled = true;
            lbTumKullanicilar.ItemHeight = 20;
            lbTumKullanicilar.Location = new Point(528, 27);
            lbTumKullanicilar.Name = "lbTumKullanicilar";
            lbTumKullanicilar.Size = new Size(298, 224);
            lbTumKullanicilar.TabIndex = 14;
            // 
            // btnAdminTumKullanicilariListele
            // 
            btnAdminTumKullanicilariListele.Location = new Point(832, 27);
            btnAdminTumKullanicilariListele.Name = "btnAdminTumKullanicilariListele";
            btnAdminTumKullanicilariListele.Size = new Size(129, 224);
            btnAdminTumKullanicilariListele.TabIndex = 7;
            btnAdminTumKullanicilariListele.Text = "Kullanıcıları Görüntüle";
            btnAdminTumKullanicilariListele.UseVisualStyleBackColor = true;
            btnAdminTumKullanicilariListele.Click += btnAdminTumKullanicilariListele_Click;
            // 
            // txtOdaNo
            // 
            txtOdaNo.Location = new Point(188, 80);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(125, 27);
            txtOdaNo.TabIndex = 6;
            // 
            // txtOtelAdi
            // 
            txtOtelAdi.Location = new Point(28, 80);
            txtOtelAdi.Name = "txtOtelAdi";
            txtOtelAdi.Size = new Size(125, 27);
            txtOtelAdi.TabIndex = 5;
            // 
            // btnAdminOdaSil
            // 
            btnAdminOdaSil.Location = new Point(188, 197);
            btnAdminOdaSil.Name = "btnAdminOdaSil";
            btnAdminOdaSil.Size = new Size(125, 68);
            btnAdminOdaSil.TabIndex = 3;
            btnAdminOdaSil.Text = "Oda Sil";
            btnAdminOdaSil.UseVisualStyleBackColor = true;
            btnAdminOdaSil.Click += btnAdminOdaSil_Click;
            // 
            // btnAdminOdaEkle
            // 
            btnAdminOdaEkle.Location = new Point(188, 123);
            btnAdminOdaEkle.Name = "btnAdminOdaEkle";
            btnAdminOdaEkle.Size = new Size(125, 68);
            btnAdminOdaEkle.TabIndex = 2;
            btnAdminOdaEkle.Text = "Oda Ekle";
            btnAdminOdaEkle.UseVisualStyleBackColor = true;
            btnAdminOdaEkle.Click += btnAdminOdaEkle_Click;
            // 
            // btnAdminOtelSil
            // 
            btnAdminOtelSil.Location = new Point(28, 197);
            btnAdminOtelSil.Name = "btnAdminOtelSil";
            btnAdminOtelSil.Size = new Size(125, 68);
            btnAdminOtelSil.TabIndex = 1;
            btnAdminOtelSil.Text = "Otel Sil";
            btnAdminOtelSil.UseVisualStyleBackColor = true;
            btnAdminOtelSil.Click += btnAdminOtelSil_Click;
            // 
            // btnAdminOtelEkle
            // 
            btnAdminOtelEkle.Location = new Point(28, 123);
            btnAdminOtelEkle.Name = "btnAdminOtelEkle";
            btnAdminOtelEkle.Size = new Size(125, 68);
            btnAdminOtelEkle.TabIndex = 0;
            btnAdminOtelEkle.Text = "Otel Ekle";
            btnAdminOtelEkle.UseVisualStyleBackColor = true;
            btnAdminOtelEkle.Click += btnAdminOtelEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 937);
            Controls.Add(gbAdmin);
            Controls.Add(gbGirisYap);
            Controls.Add(gbRezervasyonlarim);
            Controls.Add(gbRezervasyon);
            Controls.Add(gbKayitOl);
            Name = "Form1";
            Text = "Form1";
            gbKayitOl.ResumeLayout(false);
            gbKayitOl.PerformLayout();
            gbRezervasyon.ResumeLayout(false);
            gbRezervasyonlarim.ResumeLayout(false);
            gbGirisYap.ResumeLayout(false);
            gbGirisYap.PerformLayout();
            gbAdmin.ResumeLayout(false);
            gbAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKayitOl;
        private Button btnGirisYap;
        private ListBox lbOteller;
        private GroupBox gbKayitOl;
        private GroupBox gbRezervasyon;
        private Button btnRezervasyonlarim;
        private Button btnRezervasyonYap;
        private ListBox lbOdalar;
        private Button btnRezervasyonIptalEt;
        private GroupBox gbRezervasyonlarim;
        private ListBox lbRezervasyonlarim;
        private TextBox tbKimlikNumarasi;
        private TextBox tbTelefonNumarasi;
        private TextBox tbIsim;
        private TextBox tbSoyisim;
        private TextBox tbGirisKimlikNumarasi;
        private TextBox tbGirisSifre;
        private GroupBox gbGirisYap;
        private Button btnCikisYap;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button btnGirisKismi;
        private Button btnKayitKismi;
        private Label label8;
        private Label label6;
        private Label label5;
        private GroupBox gbAdmin;
        private Button btnAdminOdaSil;
        private Button btnAdminOdaEkle;
        private Button btnAdminOtelSil;
        private Button btnAdminOtelEkle;
        private TextBox txtOdaNo;
        private TextBox txtOtelAdi;
        private Button btnAdminTumKullanicilariListele;
        private ListBox lbTumKullanicilar;
        private Label label9;
        private TextBox tbSifre;
        private Label label11;
        private Label label10;
        private Button btnBilgileriGetir;
    }
}