using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Hotel
    {        

        public Hotel(string ime, string menadzer, int brojZvjezdica , string lokacija, string brojTelefona, string email)
        {
            this.imeHotela = ime;
            this.menadzerId = menadzer;
            this.brojZvjezdica = brojZvjezdica;
            this.lokacija = lokacija;
            this.brojTelefona = brojTelefona;
            this.email = email;
        }
        public Hotel()
        {

        }
        public string id { get; set; }
        public string imeHotela { get; set; }
        public string menadzerId { get; set; }
        public int brojZvjezdica { get; set; }
        public string lokacija { get; set; }
        public string brojTelefona { get; set; }
        public string email { get; set; }

        public void dodajRezervaciju(RezervacijaSmjestaja novaRezervacija)
        {
            //prvo povezi na bazu pa ovo
        }   

        public void dodajUposlenika(Uposlenik zUposlenik)
        {
            //prvo povezi na bazu pa ovo
        }

        public void dodajUslugu(Usluge zUsluge)
        {
            //prvo povezi na bazu pa ovo
        }

        public void dodajSobu(Soba zSoba)
        {
           //prvo povezi na bazu pa onda ovo
        }
        public void brisiRezervaciju(RezervacijaSmjestaja novaRezervacija)
        {
            //prvo povezi na bazu pa ovo
        }

        public void brisiUposlenika(Uposlenik zUposlenik)
        {
            //prvo povezi na bazu pa ovo
        }

        public void brisiUslugu(Usluge zUsluge)
        {
            //prvo povezi na bazu pa ovo
        }

        public void brisiSobu(Soba zSoba)
        {
            //prvo povezi na bazu pa onda ovo
        }
        public override string ToString()
        {

            return string.Format("{0} {1}, {2}",id,imeHotela, menadzerId );
        }

    }
}
