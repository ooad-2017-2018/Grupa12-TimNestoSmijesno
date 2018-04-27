using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Hotel
    {
        public int idHotela;
        private static int idBrojac = 1000;
        public Uposlenik menadzer;
        public int brojZvjezdica;
        public List<Soba> listaSoba = new List<Soba>();
        public List<Rezervacija> listaRezervacija = new List<Rezervacija>();
        public List<Uposlenik> listaUposlenika = new List<Uposlenik>();
        public string lokacija;
        public string brojTelefona;
        public string email;
        public List<Usluga> listaUsluga = new List<Usluga>();



    }
}
