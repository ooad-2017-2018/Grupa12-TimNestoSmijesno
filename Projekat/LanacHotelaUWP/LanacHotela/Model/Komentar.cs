using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class Komentar
    {
        private static int idBrojac = 1000;
        private string tekstKomentara;
        private GostHotela korinikKomentarisao;

        public Komentar(global::System.String tekstKomentara, GostHotela korinikKomentarisao)
        {
            this.tekstKomentara = tekstKomentara;
            this.korinikKomentarisao = korinikKomentarisao;
        }

        public string id { get; set; }
        public global::System.String TekstKomentara { get => tekstKomentara; set => tekstKomentara = value; }
        internal GostHotela KorinikKomentarisao { get => korinikKomentarisao; set => korinikKomentarisao = value; }
    }
}
