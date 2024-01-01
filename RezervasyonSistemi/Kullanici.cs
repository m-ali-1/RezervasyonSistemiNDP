using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class Kullanici
    {
        public string KimlikNumarasi { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Sifre { get; set; }
        public IRezervasyonYoneticisi RezervasyonYoneticisi { get; set; }
        protected bool isAdmin;
        /*public Otel RezervasyonYapilanOtel { get; set; }
        public Oda RezervasyonYapilanOda { get; set; }*/

        public Kullanici(string kimlikNumarasi, string isim, string soyisim, string telefonNumarasi, string sifre)
        {
            if (kimlikNumarasi.Length == 5)
            {
                KimlikNumarasi = kimlikNumarasi;
                Isim = isim;
                Soyisim = soyisim;
                TelefonNumarasi = telefonNumarasi;
                Sifre = sifre;
                RezervasyonYoneticisi = new RezervasyonYoneticisi();
                isAdmin = false;
            }
            else
            {
                throw new ArgumentException("Kimlik numarası 11 haneli olmalıdır.");
            }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        /*public void RezervasyonYap(Otel otel, Oda oda)
        {
            RezervasyonYoneticisi.RezervasyonYap(this, otel, oda);
            RezervasyonYapilanOtel = otel;
            RezervasyonYapilanOda = oda;
        }

        public void RezervasyonIptal(Rezervasyon rezervasyon)
        {
            RezervasyonYoneticisi.RezervasyonIptal(rezervasyon);
        }

        public List<Rezervasyon> RezervasyonlariGetir()
        {
            return RezervasyonYoneticisi.RezervasyonlariGetir(this);
        }*/
    }
}
