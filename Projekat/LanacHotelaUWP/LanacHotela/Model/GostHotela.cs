using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class GostHotela : Osoba
    {
        private static int idBrojac = 1234;
        private string brojLicnailiPasosa;
        private Kartica platnaKartica;

        public GostHotela(string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja, 
                          string email, string brojTelefona, string brojLicnailiPasosa, string platnaKartica) : base(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona)
        {
            this.brojLicnailiPasosa = brojLicnailiPasosa;
            Kartica kartica = new Kartica(platnaKartica, 1600);
            this.PlatnaKartica = kartica;
        }

        public global::System.String BrojLicnailiPasosa { get => brojLicnailiPasosa; set => brojLicnailiPasosa = value; }
        internal Kartica PlatnaKartica { get => platnaKartica; set => platnaKartica = value; }
        public string id { get => id; set => id = value; }
    }
}
