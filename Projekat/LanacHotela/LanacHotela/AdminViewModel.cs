using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class AdminViewModel
    {
        public void DodajUposlenika (global::System.String ime, global::System.String prezime, global::System.String korisnickoIme, global::System.String sifra, Object slika, global::System.String jmbg, DateTime datumRodjenja, global::System.String email, global::System.String brojTelefona, global::System.Int32 plata, DateTime datumZaposlenja, DateTime datumPrestankaRada, global::System.Int32 idHotela, global::System.String pozicija)
        {
            Uposlenik u = new Uposlenik(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona, plata, datumZaposlenja, datumPrestankaRada, idHotela, pozicija);


        }
    }
}
