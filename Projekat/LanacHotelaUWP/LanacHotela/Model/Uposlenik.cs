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
        private static int idBrojac = 1000;
        
        private int plata;
        public DateTime datumZaposlenja;
        public DateTime datumPrestankaRada;
        private string idHotela; //u kojem radi uposlenik
        private string pozicija; //radno mjesto uposlenika

        public Uposlenik(string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja,
                        string email, string brojTelefona, int plata, DateTime datumZaposlenja, 
                        string idHotela, string pozicija):base(ime, prezime,korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona)
        {

            this.plata = plata;
            this.datumZaposlenja = datumZaposlenja;
            this.datumPrestankaRada = DateTime.MinValue;
            this.idHotela = idHotela;
            this.pozicija = pozicija;
            idBrojac++;
        }
       
        


        public global::System.Int32 Plata { get => plata; set => plata = value; }
        public string IdHotela { get => idHotela; set => idHotela = value; }
        public global::System.String Pozicija { get => pozicija; set => pozicija = value; }

    }
}
