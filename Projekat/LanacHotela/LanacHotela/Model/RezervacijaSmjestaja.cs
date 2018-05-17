using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class RezervacijaSmjestaja
    {
        public string id { get; set; }
        private static int idBrojac = 1000;
        DateTime danDolaska;
        private int brojDanaOstanka;
        Hotel hotel;
        GostHotela korisnik;
        Soba soba;
        bool validnaRezervacija;
        string razlogOtkazivanja;
        double cijenaOstanka;

        public RezervacijaSmjestaja(global::System.Int32 idRezervacije, DateTime danDolaska, global::System.Int32 brojDanaOstanka, Hotel hotel, GostHotela korisnik, Soba soba, global::System.Boolean validnaRezervacija, global::System.String razlogOtkazivanja, global::System.Double cijenaOstanka)
        {
            this.danDolaska = danDolaska;
            this.brojDanaOstanka = brojDanaOstanka;
            this.hotel = hotel;
            this.korisnik = korisnik;
            this.soba = soba;
            this.validnaRezervacija = validnaRezervacija;
            this.razlogOtkazivanja = razlogOtkazivanja;
            this.cijenaOstanka = cijenaOstanka;
            idBrojac++;
        }

        public DateTime DanDolaska { get => danDolaska; set => danDolaska = value; }
        public global::System.Boolean ValidnaRezervacija { get => validnaRezervacija; set => validnaRezervacija = value; }
        public global::System.String RazlogOtkazivanja { get => razlogOtkazivanja; set => razlogOtkazivanja = value; }
        public global::System.Double CijenaOstanka { get => cijenaOstanka; set => cijenaOstanka = value; }
        internal Hotel Hotel { get => hotel; set => hotel = value; }
        internal GostHotela Korisnik { get => korisnik; set => korisnik = value; }
        internal Soba Soba { get => soba; set => soba = value; }
        public global::System.Int32 BrojDanaOstanka { get => brojDanaOstanka; set => brojDanaOstanka = value; }

        public void OtkazivanjeRezervacije(string razlog) //nakon što smo poslali razlog korisnik dobije pare nazad na svoju karticu, razlog je naveden i rezervacija se označava kao ne validna
        {
            RazlogOtkazivanja = razlog;
            ValidnaRezervacija = false;
            korisnik.PlatnaKartica.StanjeNaKartici += CijenaOstanka;
        }
        public double izracunajCijenu(DateTime dDolaska, int brojDana)
        {
            CijenaOstanka=brojDana * Soba.CijenaPoNoci;
            return CijenaOstanka;
        }

    }
}
