using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Hotel
    {
        private static int idBrojac = 1001;
        private string imeHotela;
        private Uposlenik menadzer;
        private int brojZvjezdica;
        private List<Soba> listaSoba = new List<Soba>();
        private List<RezervacijaSmjestaja> listaRezervacija = new List<RezervacijaSmjestaja>();
        private List<Uposlenik> listaUposlenika = new List<Uposlenik>();
        private string lokacija;
        private string brojTelefona;
        private string email;
        private List<Usluge> listaUsluga = new List<Usluge>();

        public Hotel(string ime, Uposlenik menadzer, int brojZvjezdica, List<Soba> listaSoba, List<RezervacijaSmjestaja> listaRezervacija, List<Uposlenik> listaUposlenika, string lokacija, string brojTelefona, string email, List<Usluge> listaUsluga)
        {

            this.imeHotela = ime;
            this.menadzer = menadzer;
            this.brojZvjezdica = brojZvjezdica;
            this.listaSoba = listaSoba;
            this.listaRezervacija = listaRezervacija;
            this.listaUposlenika = listaUposlenika;
            this.lokacija = lokacija;
            this.brojTelefona = brojTelefona;
            this.email = email;
            this.listaUsluga = listaUsluga;
            idBrojac++;
        }

        

        public string id { get; set; }
        internal Uposlenik Menadzer { get => menadzer; set => menadzer = value; }
        public global::System.Int32 BrojZvjezdica { get => brojZvjezdica; set => brojZvjezdica = value; }
        internal List<Soba> ListaSoba { get => listaSoba; set => listaSoba = value; }
        internal List<RezervacijaSmjestaja> ListaRezervacija { get => listaRezervacija; set => listaRezervacija = value; }
        internal List<Uposlenik> ListaUposlenika { get => listaUposlenika; set => listaUposlenika = value; }
        public global::System.String Lokacija { get => lokacija; set => lokacija = value; }
        public global::System.String BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public global::System.String Email { get => email; set => email = value; }
        public List<Usluge> ListaUsluga { get => listaUsluga; set => listaUsluga = value; }
        public static global::System.Int32 IdBrojac { get => idBrojac; set => idBrojac = value; }
        public string ImeHotela { get => imeHotela; set => imeHotela = value; }

        public void dodajRezervaciju(RezervacijaSmjestaja novaRezervacija)
        {
            foreach (RezervacijaSmjestaja x in listaRezervacija)
            {
                if (x.id== novaRezervacija.id) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }

            listaRezervacija.Add(novaRezervacija);
        }
        

        public void dodajUposlenika(Uposlenik zUposlenik)
        {
            foreach (Uposlenik x in listaUposlenika)
            {
                if (x.id == zUposlenik.id) throw new Exception("Već postoji ovaj uposlenik");

            }
            listaUposlenika.Add(zUposlenik);
        }

        public void dodajUslugu(Usluge zUsluge)
        {
            foreach (Usluge x in listaUsluga)
            {
                if (x.id== zUsluge.id) throw new Exception("Već postoji ta usluga za ovaj hotel");

            }
            listaUsluga.Add(zUsluge);
        }

        public void dodajSobu(Soba zSoba)
        {
            foreach (Soba x in listaSoba)
            {
                if (x.id == zSoba.id) throw new Exception("Već postoji ta soba za ovaj hotel");

            }
            listaSoba.Add(zSoba);
        }
        public void brisiRezervaciju(RezervacijaSmjestaja novaRezervacija)
        {
            foreach (RezervacijaSmjestaja x in listaRezervacija)
            {
                if (x.id == novaRezervacija.id) listaRezervacija.Remove(x);

            }
        }

        public void brisiUposlenika(Uposlenik zUposlenik)
        {
            foreach (Uposlenik x in listaUposlenika)
            {
                if (x.id == zUposlenik.id) listaUposlenika.Remove(x);

            }
        }

        public void brisiUslugu(Usluge zUsluge)
        {
            foreach (Usluge x in listaUsluga)
            {
                if (x.id == zUsluge.id) listaUsluga.Remove(x);
            }
        }

        public void brisiSobu(Soba zSoba)
        {
            foreach (Soba x in listaSoba)
            {
                if (x.id == zSoba.id) listaSoba.Remove(x);

            }
            
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, {2}",id,ImeHotela, Menadzer );
        }

    }
}
