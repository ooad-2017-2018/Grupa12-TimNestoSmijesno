using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
