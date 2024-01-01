using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonSistemi
{
    public class Oda
    {
        public int OdaNumarasi { get; set; }
        public bool BosMu { get; set; }

        public Oda(int odaNumarasi)
        {
            OdaNumarasi = odaNumarasi;
            BosMu = true;
        }
    }


}
