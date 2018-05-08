using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Uposlenik : Osoba
    {
        private int idUposlenika;
        private static int idBrojac = 100;
        
        private int plata;
        public DateTime datumZaposlenja;
        public DateTime datumPrestankaRada;
        private int idHotela; //u kojem radi uposlenik
        private string pozicija; //radno mjesto uposlenika

        public Uposlenik(global::System.String ime, global::System.String prezime, global::System.String korisnickoIme, global::System.String sifra, Object slika, global::System.String jmbg, DateTime datumRodjenja, global::System.String email, global::System.String brojTelefona, global::System.Int32 plata, DateTime datumZaposlenja, DateTime datumPrestankaRada, global::System.Int32 idHotela, global::System.String pozicija):base(ime, prezime,korisnickoIme, sifra, slika, jmbg,datumRodjenja, email,brojTelefona)
        {
            this.idUposlenika = idBrojac++;
            this.plata = plata;
            this.datumZaposlenja = datumZaposlenja;
            this.datumPrestankaRada = datumPrestankaRada;
            this.idHotela = idHotela;
            this.pozicija = pozicija;
            idBrojac++;
        }

        public global::System.Int32 IdUposlenika { get => idUposlenika; set => idUposlenika = value; }
        public global::System.Int32 Plata { get => plata; set => plata = value; }
        public global::System.Int32 IdHotela { get => idHotela; set => idHotela = value; }
        public global::System.String Pozicija { get => pozicija; set => pozicija = value; }
    }
}
