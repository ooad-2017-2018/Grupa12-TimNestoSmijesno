using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class GostHotelaViewModel
    {
        public void DodajRezervaciju()
        {

        }

        public void IzbrisiRezervaciju()
        {

        }

        public void DodajKomentar()
        {
            
        }

        public void DodajOcjenu()
        {

        }

        public void RezervisiUslugu()
        {

        }

        public List<RezervacijaSmjestaja> MojeRezervacije(GostHotela g)
        {
            List<RezervacijaSmjestaja> lista = new List<RezervacijaSmjestaja>();
            foreach(Hotel x in LanacHotela.ListaHotela)
            {
                foreach(RezervacijaSmjestaja r in x.ListaRezervacija)
                {
                    if (r.Korisnik == g) lista.Add(r);
                }
            }
            return lista;
        }

        public void RegistracijaKorisnika(string i, string p, string j, string ki, string s, DateTime dr, string em, string bt, Image sl, string bl, string pk)
        {
            foreach(GostHotela g in LanacHotela.ListaKorisnika)
            {
                if (g.Jmbg == j) LanacHotela.ListaKorisnika.Remove(g);
            }
            GostHotela a = new GostHotela(i, p, ki, s, sl, j, dr, em, bt, bl, pk);
            LanacHotela.ListaKorisnika.Add(a);
        }
    }
}
