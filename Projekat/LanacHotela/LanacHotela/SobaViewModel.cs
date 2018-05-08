using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class SobaViewModel
    {
        public List<Komentar> PregledKomentara(Soba s)
        {
            List<Komentar> l = s.ListaKomentara;
            return l;
        }

        public List<Object> PregledSlika(Soba s)
        {
            List<Object> l = s.ListaSlikaSobe;
            return l;
        }

        public void KalendarDostupnosti()
        {

        }

        public void Rezervisi()
        {

        }
    }
}

