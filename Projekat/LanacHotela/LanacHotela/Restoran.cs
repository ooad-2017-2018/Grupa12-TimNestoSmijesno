using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Restoran:Usluge
    {
        private int kapacitet;
        private Dictionary<GostHotela, string> rezervacijeDanas = new Dictionary<GostHotela, string>();
        private Dictionary<GostHotela, string> rezervacijeSutra = new Dictionary<GostHotela, string>();

        public global::System.Int32 Kapacitet { get => kapacitet; set => kapacitet = value; }
        internal Dictionary<GostHotela, global::System.String> RezervacijeDanas { get => rezervacijeDanas; set => rezervacijeDanas = value; }
        internal Dictionary<GostHotela, global::System.String> RezervacijeSutra { get => rezervacijeSutra; set => rezervacijeSutra = value; }

        public void prebaciNoviDan()
        {

        }
    }
}
