using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class Restoran:Usluge
    {
        private int kapacitet;
        private Dictionary<GostHotela, string> rezervacijeDanas = new Dictionary<GostHotela, string>();
        private Dictionary<GostHotela, string> rezervacijeSutra = new Dictionary<GostHotela, string>();

        public global::System.Int32 Kapacitet { get => kapacitet; set => kapacitet = value; }
        internal Dictionary<GostHotela, global::System.String> RezervacijeDanas { get => rezervacijeDanas; set => rezervacijeDanas = value; }
        internal Dictionary<GostHotela, global::System.String> RezervacijeSutra { get => rezervacijeSutra; set => rezervacijeSutra = value; }
        public Restoran(global::System.String nazivUsluge, global::System.Double cijena, global::System.String terminiDostupnosti, List<Image> listaSlika, global::System.String radnoVrijeme, Ocjena ocjena, Komentar komentar, global::System.Int32 c) : base(nazivUsluge, cijena, terminiDostupnosti, listaSlika, radnoVrijeme, ocjena, komentar)
        {
            kapacitet = c;

        }
        public void prebaciNoviDan()
        {

        }
        public string id { get; set; }
    }
}
