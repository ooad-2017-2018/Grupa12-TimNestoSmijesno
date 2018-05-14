using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Ocjena
    {
        private int idOcjene;
        private int ocjenaPostavljena;
        GostHotela korisnikOcijenio;

        public Ocjena(global::System.Int32 idOcjene, global::System.Int32 ocjenaPostavljena, GostHotela korisnikOcijenio)
        {
            this.idOcjene = idOcjene;
            this.ocjenaPostavljena = ocjenaPostavljena;
            this.korisnikOcijenio = korisnikOcijenio;
        }

        public global::System.Int32 IdOcjene { get => idOcjene; set => idOcjene = value; }
        public global::System.Int32 OcjenaPostavljena { get => ocjenaPostavljena; set => ocjenaPostavljena = value; }
        internal GostHotela KorisnikOcijenio { get => korisnikOcijenio; set => korisnikOcijenio = value; }
    }
}
