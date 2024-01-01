using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class Otel : IOtel
    {
        public string OtelAdi { get; set; }
        public List<Oda> Odalar { get; set; }
        Random random = new Random();

        public Otel(string otelAdi)
        {
            OtelAdi = otelAdi;
            Odalar = new List<Oda>();
        }
        public string BilgileriGetir()
        {
            StringBuilder bilgi = new StringBuilder();
            bilgi.AppendLine($"Otel Adı: {OtelAdi}");
            bilgi.AppendLine("Odalar:");
            foreach (Oda oda in Odalar)
            {
                int kisiSayisi = random.Next(1, 5);
                bilgi.AppendLine($"  Oda Numarası: {oda.OdaNumarasi}");
                bilgi.AppendLine($" Kalabilecek Kişi Sayısı: {kisiSayisi}");
            }
            return bilgi.ToString();
        }
    }
}
