using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class LanacHotela
    {
        private string imeLanca;
        private List<Hotel> listaHotela;
        private List<Osoba> listaKorisnika;

        public LanacHotela(global::System.String imeLanca, List<Hotel> listaHotela, List<Osoba> listaKorisnika)
        {
            this.imeLanca = imeLanca;
            this.listaHotela = listaHotela;
            this.listaKorisnika = listaKorisnika;
        }

        public string ImeLanca { get => imeLanca; set => imeLanca = value; }
        public List<Hotel> ListaHotela { get => listaHotela; set => listaHotela = value; }
        public List<Osoba> ListaKorisnika { get => listaKorisnika; set => listaKorisnika = value; }

        public void BrisiHotel(Hotel h)
        {
            foreach(Hotel x in ListaHotela)
            {
                if (x == h) ListaHotela.Remove(x);
            }
        }
        public void BrisiKorisnika(Osoba o)
        {
            foreach (Osoba x in ListaKorisnika)
            {
                if (x == o) ListaKorisnika.Remove(x);
            }

        }
        public void DodajKorisnika(Osoba korisnik)
        {
            foreach (Osoba x in ListaKorisnika)
            {
                if (x.Jmbg== korisnik.Jmbg) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            listaKorisnika.Add(korisnik);
        }
        public void DodajHotel(Hotel hotel)
        {
            foreach (Hotel x in listaHotela)
            {
                if (x.IdHotela == hotel.IdHotela) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            listaHotela.Add(hotel);
        }

    }
}
