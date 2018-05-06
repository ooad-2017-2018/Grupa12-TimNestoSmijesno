using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Osoba
    {
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string sifra;
        public Object slika;
        private string jmbg;
        public DateTime datumRodjenja;
        private string email;
        private string brojTelefona;

        public Osoba(global::System.String ime, global::System.String prezime, global::System.String korisnickoIme, global::System.String sifra, Object slika, global::System.String jmbg, DateTime datumRodjenja, global::System.String email, global::System.String brojTelefona)
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

        public global::System.String Ime { get => ime; set => ime = value; }
        public global::System.String Prezime { get => prezime; set => prezime = value; }
        public global::System.String KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public global::System.String Sifra { get => sifra; set => sifra = value; }
        public global::System.String Jmbg { get => jmbg; set => jmbg = value; }
        public global::System.String Email { get => email; set => email = value; }
        public global::System.String BrojTelefona { get => brojTelefona; set => brojTelefona = value; }
    }
}
