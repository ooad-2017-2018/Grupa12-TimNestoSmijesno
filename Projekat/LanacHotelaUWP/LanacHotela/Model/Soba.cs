using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class Soba
    {
        public string id { get; set; }
        private static int idBrojac = 1000;
        Hotel hotelSobe;
        private double cijenaPoNoci;
        private int brojKreveta;
        private bool balkon;
        private List<Image> listaSlikaSobe;
        private List<Ocjena> listaOcjena;
        private List<Komentar> listaKomentara;

        public Soba(Hotel hotelSobe, global::System.Double cijenaPoNoci, global::System.Int32 brojKreveta, global::System.Boolean balkon)
        {

            this.hotelSobe = hotelSobe;
            this.cijenaPoNoci = cijenaPoNoci;
            this.brojKreveta = brojKreveta;
            this.balkon = balkon;
            idBrojac++;
        }


        public global::System.Double CijenaPoNoci { get => cijenaPoNoci; set => cijenaPoNoci = value; }
        public global::System.Int32 BrojKreveta { get => brojKreveta; set => brojKreveta = value; }
        public global::System.Boolean Balkon { get => balkon; set => balkon = value; }
        public List<Image> ListaSlikaSobe { get => listaSlikaSobe; set => listaSlikaSobe = value; }
        internal List<Ocjena> ListaOcjena { get => listaOcjena; set => listaOcjena = value; }
        internal List<Komentar> ListaKomentara { get => listaKomentara; set => listaKomentara = value; }

        public void DodajKomentar(Komentar koment)
        {
            ListaKomentara.Add(koment);
            
        }
        public void DodajOcjenu(Ocjena ocj)
        {
            ListaOcjena.Add(ocj);
        }
        public void DodajSliku(Image slika)
        {
            ListaSlikaSobe.Add(slika);
        }
        /*
        public bool ProvjeraDostupnostiSobe(DateTime dDolaska, int brojDana)
        {
            
            foreach(RezervacijaSmjestaja x in hotelSobe.ListaRezervacija)
            {
                if (x.Soba.id == id)
                {
                    if (DateTime.Compare(x.DanDolaska, dDolaska) <= 0 && DateTime.Compare(x.DanDolaska.AddDays(x.BrojDanaOstanka), dDolaska) >= 0) return false;
                    else if (DateTime.Compare(x.DanDolaska, dDolaska) >= 0 && DateTime.Compare(x.DanDolaska.AddDays(x.BrojDanaOstanka), dDolaska) <= 0) return false;
                    else continue;
                }
               
            }
            return true;
            
        } */

    }
}
