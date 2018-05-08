using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanacHotela
{
    public class AdminViewModel
    {
        public void DodajUposlenika (LanacHotela lanac, global::System.String ime, global::System.String prezime, global::System.String korisnickoIme, global::System.String sifra, Object slika, global::System.String jmbg, DateTime datumRodjenja, global::System.String email, global::System.String brojTelefona, global::System.Int32 plata, DateTime datumZaposlenja, DateTime datumPrestankaRada, global::System.Int32 idHotela, global::System.String pozicija)
        {
            Uposlenik u = new Uposlenik(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona, plata, datumZaposlenja, datumPrestankaRada, idHotela, pozicija);
            foreach(Hotel h in lanac.ListaHotela) if(idHotela==h.IdHotela)
                {
                    h.ListaUposlenika.Add(u);
                }

        }

        public void BrisiUposlenika(Uposlenik u, LanacHotela lanac)
        {
            foreach(Hotel h in lanac.ListaHotela)
            {
                    foreach(Uposlenik p in h.ListaUposlenika)
                    {
                        if(p==u)
                        {
                            h.ListaUposlenika.Remove(p);
                            break;
                        }
                    }
                }
            }
        
        public void DodajUposlenika(Uposlenik u, LanacHotela l)
        {
            foreach(Hotel h in l.ListaHotela)
            {
                if (u.IdHotela == h.IdHotela)
                {
                    foreach(Uposlenik p in h.ListaUposlenika)
                    {
                        if(p==u) throw new Exception("Već postoji taj uposlenik u hotelu");

                    }
                    h.ListaUposlenika.Add(u);
                }
            }
        }

        public void BrisiUposlenika(string nazivhotela, string imeuposlenika, string prezimeuposlenika, string jmbguposlenika, LanacHotela lanac)
        {
            foreach (Hotel h in lanac.ListaHotela)
            {
                if (h.ImeHotela == nazivhotela)
                {
                    foreach (Uposlenik u in h.ListaUposlenika)
                    {
                        if (u.Ime == imeuposlenika && u.Prezime == prezimeuposlenika && u.Jmbg == jmbguposlenika)
                        {
                            h.ListaUposlenika.Remove(u);
                            break;
                        }
                    }
                }
            }
        }

        public void DodajHotel(LanacHotela l ,global::System.String i, Uposlenik menadzer, global::System.Int32 brojZvjezdica, List<Soba> listaSoba, List<RezervacijaSmjestaja> listaRezervacija, List<Uposlenik> listaUposlenika, global::System.String lokacija, global::System.String brojTelefona, global::System.String email, List<Usluge> listaUsluga)
        {
            Hotel h = new Hotel(i, menadzer, brojZvjezdica, listaSoba, listaRezervacija, listaUposlenika, lokacija, brojTelefona, email, listaUsluga);
            foreach (Hotel x in l.ListaHotela)
            {
                if (x.IdHotela == h.IdHotela) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            l.ListaHotela.Add(h);
         }

        public void DodajHotel (LanacHotela l, Hotel h)
        {
            foreach(Hotel x in l.ListaHotela)
            {
                if(x==h) throw new Exception("Već postoji ovaj hotel u lancu hotela");

            }
        }

        public void BrisiHotel(LanacHotela l, Hotel h)
        {
            bool nasao = false;
            foreach (Hotel x in l.ListaHotela)
            {
                if (x == h)
                {
                    l.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
            }
            if(!nasao) throw new Exception("Ovaj hotel ne postoji u lancu");

        }

        public void BrisiHotel (LanacHotela l, string ime)
        {
            foreach(Hotel x in l.ListaHotela)
            {
                bool nasao = false;
                if (x.ImeHotela == ime)
                {
                    l.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
                if (!nasao) throw new Exception("Ne postoji hotel pod ovim nazivom");

            }
        }
    }

}

