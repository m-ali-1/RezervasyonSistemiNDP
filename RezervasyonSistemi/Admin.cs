using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class Admin : Kullanici
    {
        public List<Otel> OtelListesi { get; private set; }

        public Admin(string kimlikNumarasi, string isim, string soyisim, string telefonNumarasi, string sifre)
            : base(kimlikNumarasi, isim, soyisim, telefonNumarasi, sifre)
        {
            IsAdmin = true;
            OtelListesi = new List<Otel>();
        }

        public void OtelEkle(Otel otel)
        {
            OtelListesi.Add(otel);
        }

        public void OdaEkle(Otel otel, Oda oda)
        {
            otel.Odalar.Add(oda);
        }

        public void OtelSil(List<Otel> otelListesi, Otel silinecekOtel)
        {
            otelListesi.Remove(silinecekOtel);
        }

        public void OdaSil(Otel otel, Oda silinecekOda)
        {
            otel.Odalar.Remove(silinecekOda);
        }
    }
}
