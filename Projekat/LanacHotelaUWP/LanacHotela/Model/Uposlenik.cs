using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public class Uposlenik : Osoba
    {
        public string id { get; set; }
        public int plata { get; set; }
        public DateTime datumZaposlenja { get; set; }
        public DateTime datumPrestankaRada { get; set; }
        public string HotelId { get; set; } //u kojem radi uposlenik
        public string pozicija { get; set; } //radno mjesto uposlenika

        public Uposlenik(string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja,
                        string email, string brojTelefona, int plata, DateTime datumZaposlenja, 
                        string idHotela, string pozicija):base(ime, prezime,korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona)
        {

            this.plata = plata;
            this.datumZaposlenja = datumZaposlenja;
            this.datumPrestankaRada = DateTime.MinValue;
            this.HotelId= idHotela;
            this.pozicija = pozicija;
        }   
        public Uposlenik(): base()
        {

        }
    }
}
