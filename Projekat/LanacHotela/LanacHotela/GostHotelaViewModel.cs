using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class GostHotelaViewModel
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

        public List<RezervacijaSmjestaja> MojeRezervacije(GostHotela g, LanacHotela l)
        {
            List<RezervacijaSmjestaja> lista = new List<RezervacijaSmjestaja>();
            foreach(Hotel x in l.ListaHotela)
            {
                foreach(RezervacijaSmjestaja r in x.ListaRezervacija)
                {
                    if (r.Korisnik == g) lista.Add(r);
                }
            }
            return lista;
        }
    }
}
