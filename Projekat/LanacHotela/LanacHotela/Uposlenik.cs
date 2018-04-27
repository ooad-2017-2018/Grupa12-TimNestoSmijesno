using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Uposlenik : Osoba
    {
        public int idUposlenika;
        private static int idbrojac = 1000;
        public int plata;
        public DateTime datumZaposlenja;
        public DateTime datumPrestankaRada;
        public int idHotela; //u kojem radi uposlenik
        public string pozicija; //radno mjesto uposlenika
    }
}
