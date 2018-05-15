using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class Admin : Uposlenik
    {
        public Admin(string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja, string email, string brojTelefona, int plata, DateTime datumZaposlenja,  string pozicija) : base(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona, plata, datumZaposlenja, 0, pozicija)
        {
        }
    }
}
