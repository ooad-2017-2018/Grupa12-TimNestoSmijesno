using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Admin:Osoba
    {
        public Admin(global::System.String ime, global::System.String prezime, global::System.String korisnickoIme, global::System.String sifra, Object slika, global::System.String jmbg, DateTime datumRodjenja, global::System.String email, global::System.String brojTelefona):base(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja,email, brojTelefona)
        {

        }


    }
}
