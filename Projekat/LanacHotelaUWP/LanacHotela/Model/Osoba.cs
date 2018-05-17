using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class Osoba
    {
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string sifra;
        public Image slika;
        private string jmbg;
        public DateTime datumRodjenja;
        private string email;
        private string brojTelefona;

        public Osoba(string ime, string prezime, string korisnickoIme,string sifra, Image slika, string jmbg, DateTime datumRodjenja, 
                     string email, string brojTelefona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.korisnickoIme = korisnickoIme;
            this.sifra = sifra;
            this.slika = slika;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.email = email;
            this.brojTelefona = brojTelefona;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Email { get => email; set => email = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
        public string id { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", Ime, Prezime);

        }
    }
    
}
