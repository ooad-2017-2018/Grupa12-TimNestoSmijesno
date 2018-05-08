using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class UslugeViewModel
    {
        public List<Usluge> PregledUsluga(Hotel h)
        {
            return h.ListaUsluga;
        }
        public List<Object> PregledSlika(Usluge u)
        {
            List<Object> lista = u.ListaSlika;
            return lista;
        }
        public List<string> PregledKomentara(Usluge u)
        {
            List<string> lista;
            lista = u.ListaKomentara;
            return lista;
        }
        public void TerminiDostupnosti()
        {

        }
    }
}
