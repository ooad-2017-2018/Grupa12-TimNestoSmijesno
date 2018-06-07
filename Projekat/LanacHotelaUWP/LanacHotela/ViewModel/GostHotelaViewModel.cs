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

       /* public List<RezervacijaSmjestaja> MojeRezervacije(GostHotela g)
        {
           //prvo baza pa ovo
        }
        */

        public void RegistracijaKorisnika(string i, string p, string j, string ki, string s, DateTime dr, string em, string bt, Image sl, string bl, string pk)
        {
            foreach(GostHotela g in LanacHotela.ListaKorisnika)
            {
                if (g.jmbg == j) LanacHotela.ListaKorisnika.Remove(g);
            }
            GostHotela a = new GostHotela(i, p, ki, s, sl, j, dr, em, bt, bl, pk);
            LanacHotela.ListaKorisnika.Add(a);
        }
    }
}
