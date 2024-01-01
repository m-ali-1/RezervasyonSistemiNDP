using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class RezervasyonYoneticisi : IRezervasyonYoneticisi
    {
        private List<Rezervasyon> rezervasyonlar;

        public RezervasyonYoneticisi()
        {
            rezervasyonlar = new List<Rezervasyon>();
        }

        public void RezervasyonYap(Kullanici kullanici, Otel otel, Oda oda)
        {
            Rezervasyon yeniRezervasyon = new Rezervasyon(kullanici, otel, oda);
            rezervasyonlar.Add(yeniRezervasyon);
            oda.BosMu = false;
        }

        public void RezervasyonIptal(Rezervasyon rezervasyon)
        {
            rezervasyonlar.Remove(rezervasyon);
            rezervasyon.Oda.BosMu = true;
        }

        public List<Rezervasyon> RezervasyonlariGetir(Kullanici kullanici)
        {
            return rezervasyonlar.Where(r => r.Kullanici.Equals(kullanici)).ToList();
        }

        public List<Rezervasyon> TumRezervasyonlariGetir()
        {
            return rezervasyonlar;
        }
    }


}
