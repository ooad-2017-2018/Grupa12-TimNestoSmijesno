using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class LanacHotela
    {
        public string ImeLanca { get => imeLanca; set => imeLanca = value; }
        public List<Hotel> ListaHotela { get => listaHotela; set => listaHotela = value; }
        public List<Osoba> ListaKorisnika { get => listaKorisnika; set => listaKorisnika = value; }

        public BrisiHotel(Hotel h)
        {
            foreach(Hotel x in LanacHotela)
            {
                if (x == h) ListaHotela.Remove(x);
            }
        }
        public BrisiKorisnika(Osoba o)
        {
            foreach (Osoba x in ListaKorisnika)
            {
                if (x == o) ListaKorisnika.Remove(x);
            }

        }

    }
}
