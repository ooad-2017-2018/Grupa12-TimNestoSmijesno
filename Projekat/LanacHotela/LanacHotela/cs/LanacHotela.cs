using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public static class LanacHotela
    {
        private static string imeLanca;
        private static List<Hotel> listaHotela = new List<Hotel>{ Kontejnerska.hotel1, Kontejnerska.hotel2, Kontejnerska.hotel3 };
        private static List<Osoba> listaKorisnika = new List<Osoba> {Kontejnerska.nur, Kontejnerska.jelena, Kontejnerska.nedim, Kontejnerska.mustafa };

        
        public static string ImeLanca { get => imeLanca; set => imeLanca = value; }
        public static List<Hotel> ListaHotela { get => listaHotela; set => listaHotela = value; }
        public static List<Osoba> ListaKorisnika { get => listaKorisnika; set => listaKorisnika = value; }

       
        public static void BrisiHotel(Hotel h)
        {
            foreach(Hotel x in ListaHotela)
            {
                if (x == h) ListaHotela.Remove(x);
            }
        }
        public static void BrisiKorisnika(Osoba o)
        {
            foreach (Osoba x in ListaKorisnika)
            {
                if (x == o) ListaKorisnika.Remove(x);
            }

        }
        public static void DodajKorisnika(Osoba korisnik)
        {
            foreach (Osoba x in ListaKorisnika)
            {
                if (x.Jmbg== korisnik.Jmbg) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            listaKorisnika.Add(korisnik);
        }
        public static void DodajHotel(Hotel hotel)
        {
            foreach (Hotel x in listaHotela)
            {
                if (x.IdHotela == hotel.IdHotela) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            listaHotela.Add(hotel);
        }
       

    }
}
