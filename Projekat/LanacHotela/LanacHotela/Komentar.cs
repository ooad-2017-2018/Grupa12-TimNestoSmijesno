using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    class Komentar
    {
        private int idKomentara;
        private static int idBrojac = 1000;
        private string tekstKomentara;
        private GostHotela korinikKomentarisao;

        public Komentar(global::System.String tekstKomentara, GostHotela korinikKomentarisao)
        {
            this.idKomentara = idBrojac+1;
            this.tekstKomentara = tekstKomentara;
            this.korinikKomentarisao = korinikKomentarisao;
            idBrojac++;
        }

        public global::System.Int32 IdKomentara { get => idKomentara; set => idKomentara = value; }
        public global::System.String TekstKomentara { get => tekstKomentara; set => tekstKomentara = value; }
        internal GostHotela KorinikKomentarisao { get => korinikKomentarisao; set => korinikKomentarisao = value; }
    }
}
