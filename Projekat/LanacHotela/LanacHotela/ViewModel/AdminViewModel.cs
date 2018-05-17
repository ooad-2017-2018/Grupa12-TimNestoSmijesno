using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LanacHotela
{
    public static class AdminViewModel
    {
        public static void DodajUposlenika (string ime, string prezime, string korisnickoIme, string sifra, Image slika, string jmbg, DateTime datumRodjenja,
                                     string email, string brojTelefona, int plata, DateTime datumZaposlenja,  string id, string pozicija)
        {
            Uposlenik u = new Uposlenik(ime, prezime, korisnickoIme, sifra, slika, jmbg, datumRodjenja, email, brojTelefona, plata,
                datumZaposlenja, id, pozicija);
            foreach(Hotel h in LanacHotela.ListaHotela) if(id==h.id)
                {
                    h.ListaUposlenika.Add(u);
                }
            foreach(Osoba o in LanacHotela.ListaKorisnika)
            {
                if (u.Jmbg == o.Jmbg) LanacHotela.ListaKorisnika.Remove(o);
            }
            LanacHotela.ListaKorisnika.Add(u);

        }

        public static void BrisiUposlenika(Uposlenik u)
        {
            foreach(Hotel h in LanacHotela.ListaHotela)
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
        
        public static void DodajUposlenika(Uposlenik u)
        {
            foreach(Hotel h in LanacHotela.ListaHotela)
            {
                if (u.id == h.id)
                {
                    foreach(Uposlenik p in h.ListaUposlenika)
                    {
                        if(p==u) throw new Exception("Već postoji taj uposlenik u hotelu");

                    }
                    h.ListaUposlenika.Add(u);
                }
            }
            foreach (Osoba o in LanacHotela.ListaKorisnika)
            {
                if (u.Jmbg == o.Jmbg) LanacHotela.ListaKorisnika.Remove(o);
            }
            LanacHotela.ListaKorisnika.Add(u);
        }

        public static void BrisiUposlenika(string nazivhotela, string imeuposlenika, string prezimeuposlenika, string jmbguposlenika)
        {
            foreach (Hotel h in LanacHotela.ListaHotela)
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

        public static  void DodajHotel(global::System.String i, Uposlenik menadzer, global::System.Int32 brojZvjezdica, List<Soba> listaSoba, List<RezervacijaSmjestaja> listaRezervacija, List<Uposlenik> listaUposlenika, global::System.String lokacija, global::System.String brojTelefona, global::System.String email, List<Usluge> listaUsluga)
        {
            Hotel h = new Hotel(i, menadzer, brojZvjezdica, listaSoba, listaRezervacija, listaUposlenika, lokacija, brojTelefona, email, listaUsluga);
            foreach (Hotel x in LanacHotela.ListaHotela)
            {
                if (x.id == h.id) throw new Exception("Već postoji ta rezervacija za ovog korisnika");

            }
            LanacHotela.ListaHotela.Add(h);
         }

        public static void DodajHotel ( Hotel h)
        {
            foreach(Hotel x in LanacHotela.ListaHotela)
            {
                if(x==h) throw new Exception("Već postoji ovaj hotel u lancu hotela");

            }
        }

        public  static void BrisiHotel( Hotel h)
        {
            bool nasao = false;
            foreach (Hotel x in LanacHotela.ListaHotela)
            {
                if (x == h)
                {
                    LanacHotela.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
            }
            if(!nasao) throw new Exception("Ovaj hotel ne postoji u lancu");

        }

        public static void BrisiHotel ( string ime)
        {
            foreach(Hotel x in LanacHotela.ListaHotela)
            {
                bool nasao = false;
                if (x.ImeHotela == ime)
                {
                    LanacHotela.ListaHotela.Remove(x);
                    nasao = true;
                    break;
                }
                if (!nasao) throw new Exception("Ne postoji hotel pod ovim nazivom");

            }
        }
    }

}

