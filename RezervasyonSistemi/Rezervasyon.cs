using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class Rezervasyon
    {
        public Kullanici Kullanici { get; set; }
        public Otel Otel { get; set; }
        public Oda Oda { get; set; }

        public Rezervasyon(Kullanici kullanici, Otel otel, Oda oda)
        {
            Kullanici = kullanici ?? throw new ArgumentNullException(nameof(kullanici));
            Otel = otel ?? throw new ArgumentNullException(nameof(otel));
            Oda = oda ?? throw new ArgumentNullException(nameof(oda));
        }

        // Özel ToString metodu ekleyerek ListBox'ta nasıl görüntüleneceğini belirtiyoruz
        public override string ToString()
        {
            return $"{Kullanici.Isim} {Kullanici.Soyisim} - {Otel.OtelAdi}, Oda {Oda.OdaNumarasi}";
        }


    }
}
