namespace LanacHotela
{
    public class GostHotela:Osoba 
    {
        private int idGost;
        private static int idBrojac = 1234;
        private string brojLicnailiPasosa;
        private Kartica platnaKartica;

        public GostHotela(System.String ime, System.String prezime, System.String korisnickoIme, System.String sifra, System.Object slika, System.String jmbg, System.DateTime datumRodjenja, System.String email, System.String brojTelefona, global::System.String brojLicnailiPasosa, Kartica platnaKartica) : base(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona)
        {
            this.idGost = idBrojac++;
            this.brojLicnailiPasosa = brojLicnailiPasosa;
            this.platnaKartica = platnaKartica;
            idBrojac++;
        }

        public global::System.Int32 IdGost { get => idGost; set => idGost = value; }
        public global::System.String BrojLicnailiPasosa { get => brojLicnailiPasosa; set => brojLicnailiPasosa = value; }
        internal Kartica PlatnaKartica { get => platnaKartica; set => platnaKartica = value; }

     }
}
