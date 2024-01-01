using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public interface IRezervasyonYoneticisi
    {
        void RezervasyonYap(Kullanici kullanici, Otel otel, Oda oda);
        void RezervasyonIptal(Rezervasyon rezervasyon);
        List<Rezervasyon> RezervasyonlariGetir(Kullanici kullanici);
        List<Rezervasyon> TumRezervasyonlariGetir();
    }
}
