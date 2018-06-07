using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace LanacHotela
{
    public class Usluge
    {
        public string id { get; set; }
        private static int idBrojac = 100;
        private string nazivUsluge;
        private double cijena;
        private string terminiDostupnosti;
        private List<Image> listaSlika;
        private string radnoVrijeme;
        private Ocjena ocjena;
        private Komentar komentar;
        private List<string> listaKomentara;
        private string HotelId; //u kojem hotelu se nalazi usluga

        public Usluge(global::System.String nazivUsluge, global::System.Double cijena, global::System.String terminiDostupnosti, List<Image> listaSlika, global::System.String radnoVrijeme, Ocjena ocjena, Komentar komentar)
        {

            this.nazivUsluge = nazivUsluge;
            this.cijena = cijena;
            this.terminiDostupnosti = terminiDostupnosti;
            this.listaSlika = listaSlika;
            this.radnoVrijeme = radnoVrijeme;
            this.ocjena = ocjena;
            this.komentar = komentar;
            idBrojac++;
        }


        public global::System.String NazivUsluge { get => nazivUsluge; set => nazivUsluge = value; }
        public global::System.String TerminiDostupnosti { get => terminiDostupnosti; set => terminiDostupnosti = value; }
        public global::System.Double Cijena { get => cijena; set => cijena = value; }
        public global::System.String RadnoVrijeme { get => radnoVrijeme; set => radnoVrijeme = value; }
        internal Ocjena Ocjena { get => ocjena; set => ocjena = value; }
        internal Komentar Komentar { get => komentar; set => komentar = value; }
        public List<Image> ListaSlika { get => listaSlika; set => listaSlika = value; }
        public List<string> ListaKomentara { get => listaKomentara; set => listaKomentara = value; }

        public void DodajKomentar(Komentar noviKomentar)
        {

        }

        public void DodajOCjenu(Ocjena novaOcjena)
        {

        }

    }
}
