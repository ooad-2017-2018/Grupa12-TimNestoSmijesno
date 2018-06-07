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
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string sifra { get; set; }
        public Image slika { get; set; }
        public string jmbg { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }

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
        public Osoba()
        {

        }
        
        public override string ToString()
        {
            return string.Format("{0} {1}", ime, prezime);

        }
    }
    
}
