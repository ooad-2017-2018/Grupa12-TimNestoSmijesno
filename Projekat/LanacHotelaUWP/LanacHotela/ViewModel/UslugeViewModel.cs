using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class UslugeViewModel
    {
        
        public List<Image> PregledSlika(Usluge u)
        {
            List<Image> lista = u.ListaSlika;
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


