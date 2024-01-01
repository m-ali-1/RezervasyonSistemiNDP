using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public interface IOtel
    {
        string OtelAdi { get; set; }
        List<Oda> Odalar { get; set; }

        string BilgileriGetir();
    }
}
