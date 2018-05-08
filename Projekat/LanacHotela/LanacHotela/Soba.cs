using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Soba
    {
        private int idSobe;
        private static int idBrojac = 1000;
        Hotel hotelSobe;
        private double cijenaPoNoci;
        private int brojKreveta;
        private bool balkon;
        private List<Object> listaSlikaSobe;
        private List<Ocjena> listaOcjena;
        private List<Komentar> listaKomentara;

        public Soba(global::System.Int32 idSobe, Hotel hotelSobe, global::System.Double cijenaPoNoci, global::System.Int32 brojKreveta, global::System.Boolean balkon)
        {
            this.idSobe = idBrojac++;
            this.hotelSobe = hotelSobe;
            this.cijenaPoNoci = cijenaPoNoci;
            this.brojKreveta = brojKreveta;
            this.balkon = balkon;
            idBrojac++;
        }

        public global::System.Int32 IdSobe { get => idSobe; set => idSobe = value; }
        public global::System.Double CijenaPoNoci { get => cijenaPoNoci; set => cijenaPoNoci = value; }
        public global::System.Int32 BrojKreveta { get => brojKreveta; set => brojKreveta = value; }
        public global::System.Boolean Balkon { get => balkon; set => balkon = value; }
        public List<Object> ListaSlikaSobe { get => listaSlikaSobe; set => listaSlikaSobe = value; }
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
        public void DodajSliku(Object slika)
        {
            ListaSlikaSobe.Add(slika);
        }
        public bool ProvjeraDostupnostiSobe(DateTime dDolaska, int brojDana)
        {
            
            foreach(RezervacijaSmjestaja x in hotelSobe.ListaRezervacija)
            {
                if (x.Soba.IdSobe == idSobe)
                {
                    if (DateTime.Compare(x.DanDolaska, dDolaska) <= 0 && DateTime.Compare(x.DanDolaska.AddDays(x.BrojDanaOstanka), dDolaska) >= 0) return false;
                    else if (DateTime.Compare(x.DanDolaska, dDolaska) >= 0 && DateTime.Compare(x.DanDolaska.AddDays(x.BrojDanaOstanka), dDolaska) <= 0) return false;
                    else continue;
                }
               
            }
            return true;
        }

    }
}
