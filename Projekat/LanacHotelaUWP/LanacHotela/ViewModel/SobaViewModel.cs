using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class SobaViewModel
    {
        public List<Komentar> PregledKomentara(Soba s)
        {
            List<Komentar> l = s.ListaKomentara;
            return l;
        }

        public List<Image> PregledSlika(Soba s)
        {
            List<Image> l = s.ListaSlikaSobe;
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

