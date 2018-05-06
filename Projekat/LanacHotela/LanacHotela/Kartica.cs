namespace LanacHotela
{
    class Kartica
    {
        private string idKartice;
        private double stanjeNaKartici;

        public Kartica(global::System.String idKartice, global::System.Double stanjeNaKartici)
        {
            this.idKartice = idKartice;
            this.stanjeNaKartici = stanjeNaKartici;

        }

        public global::System.String IdKartice { get => idKartice; set => idKartice = value; }
        public global::System.Double StanjeNaKartici { get => stanjeNaKartici; set => stanjeNaKartici = value; }
    }
}